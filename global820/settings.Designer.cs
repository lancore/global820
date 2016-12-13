namespace global820 {
    partial class Settings {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fileSearch = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.notify = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.whitelist = new System.Windows.Forms.CheckBox();
            this.path = new System.Windows.Forms.TextBox();
            this.whisper = new System.Windows.Forms.TextBox();
            this.polling = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.polling)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "whisper message";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "polling interval";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "client log";
            // 
            // fileSearch
            // 
            this.fileSearch.Location = new System.Drawing.Point(373, 10);
            this.fileSearch.Name = "fileSearch";
            this.fileSearch.Size = new System.Drawing.Size(28, 23);
            this.fileSearch.TabIndex = 8;
            this.fileSearch.Text = "...";
            this.fileSearch.UseVisualStyleBackColor = true;
            this.fileSearch.Click += new System.EventHandler(this.fileSearch_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "logfile|*.txt";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(326, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(245, 335);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Filter";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Notifylist";
            // 
            // notify
            // 
            this.notify.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::global820.Properties.Settings.Default, "NotifyList", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.notify.Location = new System.Drawing.Point(12, 243);
            this.notify.Multiline = true;
            this.notify.Name = "notify";
            this.notify.Size = new System.Drawing.Size(389, 86);
            this.notify.TabIndex = 12;
            this.notify.Text = global::global820.Properties.Settings.Default.NotifyList;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::global820.Properties.Settings.Default, "Filter", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox1.Location = new System.Drawing.Point(12, 139);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(389, 74);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = global::global820.Properties.Settings.Default.Filter;
            // 
            // whitelist
            // 
            this.whitelist.AutoSize = true;
            this.whitelist.Checked = global::global820.Properties.Settings.Default.Whitelist;
            this.whitelist.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::global820.Properties.Settings.Default, "Whitelist", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.whitelist.Location = new System.Drawing.Point(338, 122);
            this.whitelist.Name = "whitelist";
            this.whitelist.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.whitelist.Size = new System.Drawing.Size(63, 17);
            this.whitelist.TabIndex = 3;
            this.whitelist.Text = "whitelist";
            this.whitelist.UseVisualStyleBackColor = true;
            // 
            // path
            // 
            this.path.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::global820.Properties.Settings.Default, "LogPath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.path.Location = new System.Drawing.Point(106, 12);
            this.path.Name = "path";
            this.path.ReadOnly = true;
            this.path.Size = new System.Drawing.Size(261, 20);
            this.path.TabIndex = 6;
            this.path.Text = global::global820.Properties.Settings.Default.LogPath;
            // 
            // whisper
            // 
            this.whisper.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::global820.Properties.Settings.Default, "WhisperMsg", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.whisper.Location = new System.Drawing.Point(106, 90);
            this.whisper.Name = "whisper";
            this.whisper.Size = new System.Drawing.Size(295, 20);
            this.whisper.TabIndex = 1;
            this.whisper.Text = global::global820.Properties.Settings.Default.WhisperMsg;
            // 
            // polling
            // 
            this.polling.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::global820.Properties.Settings.Default, "Polling", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.polling.LargeChange = 150;
            this.polling.Location = new System.Drawing.Point(106, 39);
            this.polling.Maximum = 3000;
            this.polling.Minimum = 50;
            this.polling.Name = "polling";
            this.polling.Size = new System.Drawing.Size(295, 45);
            this.polling.SmallChange = 50;
            this.polling.TabIndex = 0;
            this.polling.TickFrequency = 150;
            this.polling.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.polling.Value = global::global820.Properties.Settings.Default.Polling;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 370);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.notify);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.whitelist);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fileSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.path);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.whisper);
            this.Controls.Add(this.polling);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.Text = "/hideout";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Settings_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.polling)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar polling;
        private System.Windows.Forms.TextBox whisper;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox whitelist;
        private System.Windows.Forms.TextBox path;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button fileSearch;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox notify;
    }
}