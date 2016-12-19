using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
//using System.Windows.Forms;
using System.Windows.Media;
using global820.Properties;
using global820.UI.Windows;

namespace global820
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region "Members"

        public ObservableCollection<ChatMessage> ChatMessages { get; set; } 
        private int currentLine = 0;
        //private System.Timers.Timer tmr;
        private System.Windows.Threading.DispatcherTimer tmr;// = new System.Windows.Threading.DispatcherTimer();
        private bool filterBroken = false;
        private long startPos = 0;
        private bool initialized = false;
        private Regex regexChat= new Regex(".{20}[^]]*] (.*)",RegexOptions.Compiled);
        private Regex regexTime = new Regex("^\\d{4}\\/\\d{1,2}\\/\\d{1,2} (\\d{1,2}:\\d{2}:\\d{2})", RegexOptions.Compiled);//new Regex("\\d{4}\\/\\d{1,2}\\/\\d{1,2} (\\d{1,2}:\\d{2}:\\d{2})", RegexOptions.Compiled);
        private HashSet<eChatChannel> channelFilter = new HashSet<eChatChannel>()
        {
            eChatChannel.Global,
            //eChatChannel.Guild,
            //eChatChannel.Trade
        };
        CultureInfo enUS = new CultureInfo("en-US");
        System.Media.SoundPlayer notify;
        #endregion

        private void Initialize()
        {
            lv_chat.ItemsSource = ChatMessages;
            initialized = true;
        }

        private void ReloadSettings()
        {
            channelFilter = new HashSet<eChatChannel>();
            //LI: how i did ChampSelect:Role Filter, to enumerate off this and not manually hard code
            if (!global820.Properties.Settings.Default.ChannelFilter_Global)
            {
                channelFilter.Add(eChatChannel.Global);
            }
            if (!global820.Properties.Settings.Default.ChannelFilter_Guild)
            {
                channelFilter.Add(eChatChannel.Guild);
            }
            if (!global820.Properties.Settings.Default.ChannelFilter_Local)
            {
                channelFilter.Add(eChatChannel.Local);
            }
            if (!global820.Properties.Settings.Default.ChannelFilter_Party)
            {
                channelFilter.Add(eChatChannel.Party);
            }
            if (!global820.Properties.Settings.Default.ChannelFilter_Trade)
            {
                channelFilter.Add(eChatChannel.Trade);
            }
            if (!global820.Properties.Settings.Default.ChannelFilter_Whisper)
            {
                channelFilter.Add(eChatChannel.Whispers);
            }
        }
        public MainWindow()
        {
            InitializeComponent();
            ChatMessages= new ObservableCollection<ChatMessage>();
            System.Reflection.Assembly a = System.Reflection.Assembly.GetExecutingAssembly();
            System.IO.Stream s = a.GetManifestResourceStream("global820.notify.wav");
            notify = new System.Media.SoundPlayer(s);
        }
        #region "handlers"

        private void tmr_Elapsed(object sender, EventArgs e)//(object source, System.Timers.ElapsedEventArgs e)
        {
            if (!File.Exists(Properties.Settings.Default.LogPath))
            {
                tmr.Stop();
                return;
            }
            
            using (Stream s = new FileStream(System.IO.Path.GetFullPath(Properties.Settings.Default.LogPath), FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                if (startPos <= 0)
                {
                    startPos = s.Length - 1024;
                }
                s.Position = startPos;
                StreamReader rdr = new StreamReader(s);
                for (int i = 0; i < currentLine; i++)
                {
                    if (rdr.EndOfStream) break;
                    rdr.ReadLine();
                }

                while (!rdr.EndOfStream && !filterBroken)
                {
                    //Control lbl = processLine(rdr.ReadLine());
                    ChatMessage message = processLine(rdr.ReadLine());
                    if (message != null)
                    {
                        ChatMessages.Add(message);
                        //lb_chat.Invoke(new ThreadStart(delegate
                        //{
                        //    lbl.Width = chat.Width - 25;
                        //    lbl.Top = chat.Controls.Count * (lbl.Height + 1) - chat.VerticalScroll.Value;
                        //    lbl.Left = 0;
                        //    lb_chat.Controls.Add(lbl);
                        //    chat.ScrollControlIntoView(lbl);
                        //}));
                    }

                    currentLine++;
                }
            }
        }

        private void btn_settings_Click(object sender, RoutedEventArgs e)
        {
            wSettings settings = new wSettings();
            if (tmr != null && tmr.IsEnabled)
            {
                tmr.Stop();
            }
            
            settings.ShowDialog();
            ReloadSettings();
            start();
        }

        private void chk_keepOnTop_Checked(object sender, RoutedEventArgs e)
        {
            //this.Topmost = chk_keepOnTop.IsChecked != null && chk_keepOnTop.IsChecked.Value;
        }



        #endregion

        
        private ChatMessage processLine(string line)
        {
            ChatMessage ret = null;
            Match match = regexChat.Match(line);
            Match timeMatch = regexTime.Match(line);
            if (match.Success)
            {
                //we only want the global chat
                eChatChannel channel = ChatChannelHelper.CharToEnum(match.Groups[1].Value[0]);
                if (!channelFilter.Contains(channel)) return null;// != eChatChannel.Global) return ret;
                ret = new ChatMessage();
                ret.Channel = channel;

                string[] data = match.Groups[1].Value.Split(new string[] { ": " }, 2, StringSplitOptions.None);
                ret.Sender = data[0].Trim(match.Groups[1].Value[0]);
                ret.Message = data[1];
                if (timeMatch.Success)
                {
                    string timeRaw = timeMatch.Captures[0].Value;
                    DateTime parseOut;
                    //PFP: if the date logs use month as 01-->12 use /MM/ instead of /Mm
                    //https://msdn.microsoft.com/en-us/library/8kb3ddd4(v=vs.110).aspx
                    if (DateTime.TryParseExact(timeRaw, "yyyy/M/dd HH:mm:ss", enUS, DateTimeStyles.None, out parseOut))
                    {
                        ret.TimeStamp = parseOut;
                    }

                }
                    
                //TODO: don't do this every single time, have this cached.
                //use the filters
                string[] filters = Properties.Settings.Default.Filter.Split(new string[] { System.Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string filter in filters)
                {
                    try
                    {
                        bool m = Regex.Match(data[1], filter, RegexOptions.IgnoreCase).Success;
                        if (Properties.Settings.Default.Whitelist)
                        {
                            m = !m;
                        }
                        if (m)
                        {
                            return null;
                        }
                    }
                    catch (Exception e)
                    {
                        System.Windows.MessageBox.Show(e.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                        filterBroken = true;
                        tmr.Stop();
                    }
                }
                    

                //check for notifications
                string[] notifyList = Properties.Settings.Default.NotifyList.Split(new string[] { System.Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string item in notifyList)
                {
                    if (Regex.Match(data[1], item, RegexOptions.IgnoreCase).Success)
                    {
                        notify.Play();
                        ret.NotificationMatch = true;
                    }
                }
            }

            return ret;
        }


        private void start()
        {
            if (Properties.Settings.Default.LogPath != "" && File.Exists(Properties.Settings.Default.LogPath))
            {
                tmr = new System.Windows.Threading.DispatcherTimer();//System.Timers.Timer(Properties.Settings.Default.Polling);
                tmr.Interval = TimeSpan.FromMilliseconds(Properties.Settings.Default.Polling);
                tmr.Tick += new EventHandler(tmr_Elapsed);//tmr_Elapsed;
                filterBroken = false;
                currentLine = 0;
                startPos = 0;
                tmr_Elapsed(null, null);
                tmr.Start();
            }
            else
            {
                MessageBox.Show("Select your client logfile in the settings");
            }
        }

        private void w_Chat_Loaded(object sender, RoutedEventArgs e)
        {
            //prevent the app from starting while we are in designer view
            if (!System.ComponentModel.DesignerProperties.GetIsInDesignMode(this) && !initialized)
            {
                Initialize();
                start();
            }
        }
    }
}

