using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace global820 {
    public partial class Settings : Form {
        public Settings() {
            InitializeComponent();
        }

        private void Settings_FormClosing(object sender, FormClosingEventArgs e) {
            Properties.Settings.Default.Save();
        }

        private void fileSearch_Click(object sender, EventArgs e) {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                path.Text = openFileDialog1.FileName;
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            if (MessageBox.Show("You sure about that?", "Reset to default", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes) {
                Properties.Settings.Default.Reset();
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
