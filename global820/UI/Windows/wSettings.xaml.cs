using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace global820.UI.Windows
{
    /// <summary>
    /// Interaction logic for Settings.xaml
    /// </summary>
    public partial class wSettings : Window
    {
        public wSettings()
        {
            InitializeComponent();
        }

        private void btn_pathBrowse_Click(object sender, RoutedEventArgs e)
        {
            //FileDialog openFileDialog1;
            Microsoft.Win32.OpenFileDialog openFileDialog1 = new Microsoft.Win32.OpenFileDialog();
            if (!string.IsNullOrWhiteSpace(Properties.Settings.Default.LogPath) &&
                System.IO.Directory.Exists(Properties.Settings.Default.LogPath))
            {
                openFileDialog1.InitialDirectory = Properties.Settings.Default.LogPath;
            }

            if (openFileDialog1.ShowDialog() == true)//System.Windows.Forms.DialogResult.OK)
            {
                Properties.Settings.Default.LogPath= openFileDialog1.FileName;
                //txt_path.Text = openFileDialog1.FileName;
            }
        }

        private void btn_ok_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
            this.Close();
        }

        private void btn_reset_Click(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.Reset();
            this.DialogResult = false;
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Properties.Settings.Default.Save();
        }
    }
}
