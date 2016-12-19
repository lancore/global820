using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using global820;

namespace global820.UI
{
    /// <summary>
    /// Interaction logic for ChatLine.xaml
    /// </summary>
    public partial class ChatLine : UserControl
    {

        public ChatLine()
        {
            InitializeComponent();
        }

        private void UserControl_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Debugger.Break();
        }

        private void UserControl_MouseDown(object sender, MouseButtonEventArgs e)
        {
            string name = "";
            if (sender is ChatLine)
            {
                ChatLine obj = (ChatLine)sender;
                name = obj.Sender;
            }
            else
            {
                Debugger.Break();
                //name = ((Panel)((Control)sender).Parent).Controls.Find("name", false)[0].Text;
            }
            Clipboard.SetText("@" + Regex.Replace(name, "^<.*> ", "") + " Hi, still got room for me?");
        }


        #region "Bindable Properties"
        #region "ChannelBackground"
        public static readonly DependencyProperty ChannelBackgroundProperty = DependencyProperty.Register(
            "ChannelBackground",
            typeof(Brush),
            typeof(ChatLine),
            new PropertyMetadata(OnChannelBackgroundChanged));


        private static void OnChannelBackgroundChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ChatLine o = (ChatLine)d;
            o.ChannelBackgroundChanged((Brush)e.NewValue);
        }
        public Brush ChannelBackground
        {
            get { return (Brush)GetValue(ChannelBackgroundProperty); }
            set { SetValue(ChannelBackgroundProperty, value); }
        }

        private void ChannelBackgroundChanged(Brush source)
        {
            ChannelBackground = source;
            lbl_sender.Background = source;
            lbl_channel.Background = source;
            lbl_timestamp.Background = source;
        }
        #endregion
        #region "ChannelForeground"
        public static readonly DependencyProperty ChannelForegroundProperty = DependencyProperty.Register(
            "ChannelForeground",
            typeof(Brush),
            typeof(ChatLine),
            new PropertyMetadata(OnChannelForegroundChanged));


        private static void OnChannelForegroundChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ChatLine o = (ChatLine)d;
            o.ChannelForegroundChanged((Brush)e.NewValue);
        }
        public Brush ChannelForeground
        {
            get { return (Brush)GetValue(ChannelForegroundProperty); }
            set { SetValue(ChannelForegroundProperty, value); }
        }

        private void ChannelForegroundChanged(Brush source)
        {
            ChannelForeground = source;
            lbl_sender.Foreground = source;
            lbl_channel.Foreground = source;
            lbl_timestamp.Foreground = source;
        }
        #endregion
        #region "Message"


        public static readonly DependencyProperty MessageProperty = DependencyProperty.Register(
            "Message",
            typeof(ChatMessage),
            typeof(ChatLine),
            new PropertyMetadata(OnMessageChanged));


        private static void OnMessageChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ChatLine o = (ChatLine)d;
            o.MessageChanged((ChatMessage)e.NewValue);
        }
        public ChatMessage Message
        {
            get { return (ChatMessage)GetValue(MessageProperty); }
            set { SetValue(MessageProperty, value); }
        }

        private void MessageChanged(ChatMessage source)
        {
            Message = source;
        }
        #endregion
        #region "MessageText"
        public static readonly DependencyProperty MessageTextProperty = DependencyProperty.Register(
            "MessageText",
            typeof(string),
            typeof(ChatLine),
            new PropertyMetadata(OnMessageTextChanged));


        private static void OnMessageTextChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ChatLine o = (ChatLine)d;
            o.MessageTextChanged((string)e.NewValue);
        }
        public string MessageText
        {
            get { return (string)GetValue(MessageTextProperty); }
            set { SetValue(MessageTextProperty, value); }
        }

        private void MessageTextChanged(string source)
        {
            MessageText = source;
            txt_message.Text = source;
        }
        #endregion

        #region "Sender"
        public static readonly DependencyProperty SenderProperty = DependencyProperty.Register(
            "Sender",
            typeof(string),
            typeof(ChatLine),
            new PropertyMetadata(OnSenderChanged));


        private static void OnSenderChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ChatLine o = (ChatLine)d;
            o.SenderChanged((string)e.NewValue);
        }
        public string Sender
        {
            get { return (string)GetValue(SenderProperty); }
            set { SetValue(SenderProperty, value); }
        }

        private void SenderChanged(string source)
        {
            Sender = source;
            lbl_sender.Content = $"{source}:";
        }
        #endregion

        #region "TimeStamp"
        public static readonly DependencyProperty TimeStampProperty = DependencyProperty.Register(
            "TimeStamp",
            typeof(DateTime),
            typeof(ChatLine),
            new PropertyMetadata(OnTimeStampChanged));


        private static void OnTimeStampChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ChatLine o = (ChatLine)d;
            o.TimeStampChanged((DateTime)e.NewValue);
        }
        public DateTime TimeStamp
        {
            get { return (DateTime)GetValue(TimeStampProperty); }
            set { SetValue(TimeStampProperty, value); }
        }

        private void TimeStampChanged(DateTime source)
        {
            TimeStamp = source;

            lbl_timestamp.Content = $"[{source:H:mm}]";//string.Format("[{0:H:mm}]", source);
        }
        #endregion
        #region "Channel"
        public static readonly DependencyProperty ChannelProperty = DependencyProperty.Register(
            "Channel",
            typeof(eChatChannel),
            typeof(ChatLine),
            new PropertyMetadata(OnChannelChanged));


        private static void OnChannelChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ChatLine o = (ChatLine)d;
            o.ChannelChanged((eChatChannel)e.NewValue);
        }
        public eChatChannel Channel
        {
            get { return (eChatChannel)GetValue(ChannelProperty); }
            set { SetValue(ChannelProperty, value); }
        }

        private void ChannelChanged(eChatChannel source)
        {
            Channel = source;
            lbl_channel.Content = ChatChannelHelper.EnumToChar(source);

        }
        #endregion
        #region "NotificationMatch"
        public static readonly DependencyProperty NotificationMatchProperty = DependencyProperty.Register(
            "NotificationMatch",
            typeof(bool),
            typeof(ChatLine),
            new PropertyMetadata(OnNotificationMatchChanged));


        private static void OnNotificationMatchChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ChatLine o = (ChatLine)d;
            o.NotificationMatchChanged((bool)e.NewValue);
        }
        public bool NotificationMatch
        {
            get { return (bool)GetValue(NotificationMatchProperty); }
            set { SetValue(NotificationMatchProperty, value); }
        }

        private void NotificationMatchChanged(bool source)
        {
            NotificationMatch = source;
            //this.NotificationMatchBackground =source
        }
        #endregion
        #region "NotificationMatchBackground"
        public static readonly DependencyProperty NotificationMatchBackgroundProperty = DependencyProperty.Register(
            "NotificationMatchBackground",
            typeof(Brush),
            typeof(ChatLine),
            new PropertyMetadata(OnNotificationMatchBackgroundChanged));


        private static void OnNotificationMatchBackgroundChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ChatLine o = (ChatLine)d;
            o.NotificationMatchBackgroundChanged((Brush)e.NewValue);
        }
        public Brush NotificationMatchBackground
        {
            get { return (Brush)GetValue(NotificationMatchBackgroundProperty); }
            set { SetValue(NotificationMatchBackgroundProperty, value); }
        }

        private void NotificationMatchBackgroundChanged(Brush source)
        {
            NotificationMatchBackground = source;
            this.Background = source;
        }
        #endregion
        #endregion
    }
}
