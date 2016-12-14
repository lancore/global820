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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.partyReq = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.whisper = new System.Windows.Forms.TextBox();
            this.showTime = new System.Windows.Forms.CheckBox();
            this.showParty = new System.Windows.Forms.CheckBox();
            this.showGuild = new System.Windows.Forms.CheckBox();
            this.showWhisper = new System.Windows.Forms.CheckBox();
            this.showTrade = new System.Windows.Forms.CheckBox();
            this.showGlobal = new System.Windows.Forms.CheckBox();
            this.polling = new System.Windows.Forms.TrackBar();
            this.path = new System.Windows.Forms.TextBox();
            this.notify = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.whitelist = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.polling)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "whisper message";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "polling interval";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "path";
            // 
            // fileSearch
            // 
            this.fileSearch.Location = new System.Drawing.Point(314, 19);
            this.fileSearch.Name = "fileSearch";
            this.fileSearch.Size = new System.Drawing.Size(28, 20);
            this.fileSearch.TabIndex = 2;
            this.fileSearch.Text = "...";
            this.fileSearch.UseVisualStyleBackColor = true;
            this.fileSearch.Click += new System.EventHandler(this.fileSearch_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "logfile|*.txt";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(394, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(313, 312);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Filter";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(241, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Notifylist";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.polling);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.path);
            this.groupBox1.Controls.Add(this.fileSearch);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 105);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "client log";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.showTime);
            this.groupBox2.Controls.Add(this.showParty);
            this.groupBox2.Controls.Add(this.showGuild);
            this.groupBox2.Controls.Add(this.showWhisper);
            this.groupBox2.Controls.Add(this.showTrade);
            this.groupBox2.Controls.Add(this.showGlobal);
            this.groupBox2.Location = new System.Drawing.Point(366, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(103, 192);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "chat options";
            // 
            // partyReq
            // 
            this.partyReq.DataBindings.Add(new System.Windows.Forms.Binding("SelectedIndex", global::global820.Properties.Settings.Default, "PartyReq", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.partyReq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.partyReq.FormattingEnabled = true;
            this.partyReq.Items.AddRange(new object[] {
            "on click",
            "on notify",
            "on click and notify",
            "never"});
            this.partyReq.Location = new System.Drawing.Point(100, 45);
            this.partyReq.Name = "partyReq";
            this.partyReq.Size = new System.Drawing.Size(242, 21);
            this.partyReq.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.partyReq);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.whisper);
            this.groupBox3.Location = new System.Drawing.Point(12, 123);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(348, 81);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "party invite request";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "copy to clipboard";
            // 
            // whisper
            // 
            this.whisper.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::global820.Properties.Settings.Default, "WhisperMsg", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.whisper.Location = new System.Drawing.Point(100, 19);
            this.whisper.Name = "whisper";
            this.whisper.Size = new System.Drawing.Size(242, 20);
            this.whisper.TabIndex = 1;
            this.whisper.Text = global::global820.Properties.Settings.Default.WhisperMsg;
            // 
            // showTime
            // 
            this.showTime.AutoSize = true;
            this.showTime.Checked = global::global820.Properties.Settings.Default.ShowTime;
            this.showTime.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::global820.Properties.Settings.Default, "ShowTime", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.showTime.Location = new System.Drawing.Point(6, 169);
            this.showTime.Name = "showTime";
            this.showTime.Size = new System.Drawing.Size(73, 17);
            this.showTime.TabIndex = 5;
            this.showTime.Text = "timestamp";
            this.showTime.UseVisualStyleBackColor = true;
            // 
            // showParty
            // 
            this.showParty.AutoSize = true;
            this.showParty.Checked = global::global820.Properties.Settings.Default.ShowParty;
            this.showParty.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::global820.Properties.Settings.Default, "ShowParty", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.showParty.Location = new System.Drawing.Point(6, 91);
            this.showParty.Name = "showParty";
            this.showParty.Size = new System.Drawing.Size(49, 17);
            this.showParty.TabIndex = 3;
            this.showParty.Text = "party";
            this.showParty.UseVisualStyleBackColor = true;
            // 
            // showGuild
            // 
            this.showGuild.AutoSize = true;
            this.showGuild.Checked = global::global820.Properties.Settings.Default.ShowGuild;
            this.showGuild.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::global820.Properties.Settings.Default, "ShowGuild", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.showGuild.Location = new System.Drawing.Point(6, 114);
            this.showGuild.Name = "showGuild";
            this.showGuild.Size = new System.Drawing.Size(48, 17);
            this.showGuild.TabIndex = 4;
            this.showGuild.Text = "guild";
            this.showGuild.UseVisualStyleBackColor = true;
            // 
            // showWhisper
            // 
            this.showWhisper.AutoSize = true;
            this.showWhisper.Checked = global::global820.Properties.Settings.Default.ShowWhisper;
            this.showWhisper.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::global820.Properties.Settings.Default, "ShowWhisper", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.showWhisper.Location = new System.Drawing.Point(6, 68);
            this.showWhisper.Name = "showWhisper";
            this.showWhisper.Size = new System.Drawing.Size(62, 17);
            this.showWhisper.TabIndex = 2;
            this.showWhisper.Text = "whisper";
            this.showWhisper.UseVisualStyleBackColor = true;
            // 
            // showTrade
            // 
            this.showTrade.AutoSize = true;
            this.showTrade.Checked = global::global820.Properties.Settings.Default.ShowTrade;
            this.showTrade.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::global820.Properties.Settings.Default, "ShowTrade", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.showTrade.Location = new System.Drawing.Point(6, 45);
            this.showTrade.Name = "showTrade";
            this.showTrade.Size = new System.Drawing.Size(50, 17);
            this.showTrade.TabIndex = 1;
            this.showTrade.Text = "trade";
            this.showTrade.UseVisualStyleBackColor = true;
            // 
            // showGlobal
            // 
            this.showGlobal.AutoSize = true;
            this.showGlobal.Checked = global::global820.Properties.Settings.Default.ShowGlobal;
            this.showGlobal.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showGlobal.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::global820.Properties.Settings.Default, "ShowGlobal", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.showGlobal.Location = new System.Drawing.Point(6, 22);
            this.showGlobal.Name = "showGlobal";
            this.showGlobal.Size = new System.Drawing.Size(54, 17);
            this.showGlobal.TabIndex = 0;
            this.showGlobal.Text = "global";
            this.showGlobal.UseVisualStyleBackColor = true;
            // 
            // polling
            // 
            this.polling.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::global820.Properties.Settings.Default, "Polling", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.polling.LargeChange = 150;
            this.polling.Location = new System.Drawing.Point(86, 45);
            this.polling.Maximum = 3000;
            this.polling.Minimum = 50;
            this.polling.Name = "polling";
            this.polling.Size = new System.Drawing.Size(256, 45);
            this.polling.SmallChange = 50;
            this.polling.TabIndex = 4;
            this.polling.TickFrequency = 150;
            this.polling.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.polling.Value = global::global820.Properties.Settings.Default.Polling;
            // 
            // path
            // 
            this.path.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::global820.Properties.Settings.Default, "LogPath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.path.Location = new System.Drawing.Point(40, 19);
            this.path.Name = "path";
            this.path.ReadOnly = true;
            this.path.Size = new System.Drawing.Size(268, 20);
            this.path.TabIndex = 1;
            this.path.Text = global::global820.Properties.Settings.Default.LogPath;
            // 
            // notify
            // 
            this.notify.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::global820.Properties.Settings.Default, "NotifyList", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.notify.Location = new System.Drawing.Point(244, 230);
            this.notify.Multiline = true;
            this.notify.Name = "notify";
            this.notify.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.notify.Size = new System.Drawing.Size(225, 74);
            this.notify.TabIndex = 7;
            this.notify.Text = global::global820.Properties.Settings.Default.NotifyList;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::global820.Properties.Settings.Default, "Filter", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox1.Location = new System.Drawing.Point(12, 230);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(226, 74);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = global::global820.Properties.Settings.Default.Filter;
            // 
            // whitelist
            // 
            this.whitelist.AutoSize = true;
            this.whitelist.Checked = global::global820.Properties.Settings.Default.Whitelist;
            this.whitelist.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::global820.Properties.Settings.Default, "Whitelist", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.whitelist.Location = new System.Drawing.Point(175, 214);
            this.whitelist.Name = "whitelist";
            this.whitelist.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.whitelist.Size = new System.Drawing.Size(63, 17);
            this.whitelist.TabIndex = 5;
            this.whitelist.Text = "whitelist";
            this.whitelist.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 345);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.notify);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.whitelist);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Settings_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox showGuild;
        private System.Windows.Forms.CheckBox showWhisper;
        private System.Windows.Forms.CheckBox showTrade;
        private System.Windows.Forms.CheckBox showGlobal;
        private System.Windows.Forms.CheckBox showParty;
        private System.Windows.Forms.CheckBox showTime;
        private System.Windows.Forms.ComboBox partyReq;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
    }
}