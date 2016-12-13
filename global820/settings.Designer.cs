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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.whitelist = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.path = new System.Windows.Forms.TextBox();
            this.whisper = new System.Windows.Forms.TextBox();
            this.polling = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.fileSearch = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.polling)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 213);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // whitelist
            // 
            this.whitelist.AutoSize = true;
            this.whitelist.Checked = global::global820.Properties.Settings.Default.Whitelist;
            this.whitelist.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::global820.Properties.Settings.Default, "Whitelist", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.whitelist.Location = new System.Drawing.Point(18, 339);
            this.whitelist.Name = "whitelist";
            this.whitelist.Size = new System.Drawing.Size(63, 17);
            this.whitelist.TabIndex = 3;
            this.whitelist.Text = "whitelist";
            this.whitelist.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::global820.Properties.Settings.Default, "Filter", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox1.Location = new System.Drawing.Point(6, 19);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(377, 188);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = global::global820.Properties.Settings.Default.Filter;
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
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 370);
            this.Controls.Add(this.whitelist);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fileSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.path);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.whisper);
            this.Controls.Add(this.polling);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Settings_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.polling)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar polling;
        private System.Windows.Forms.TextBox whisper;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox whitelist;
        private System.Windows.Forms.TextBox path;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button fileSearch;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}