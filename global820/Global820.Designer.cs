namespace global820
{
    partial class Global820
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Global820));
            this.chat = new System.Windows.Forms.Panel();
            this.settings = new System.Windows.Forms.Button();
            this.onTop = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // chat
            // 
            this.chat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chat.AutoScroll = true;
            this.chat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chat.Location = new System.Drawing.Point(12, 12);
            this.chat.Name = "chat";
            this.chat.Size = new System.Drawing.Size(664, 393);
            this.chat.TabIndex = 0;
            this.chat.MouseEnter += new System.EventHandler(this.chat_MouseEnter);
            this.chat.Resize += new System.EventHandler(this.chat_Resize);
            // 
            // settings
            // 
            this.settings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.settings.Location = new System.Drawing.Point(601, 411);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(75, 23);
            this.settings.TabIndex = 2;
            this.settings.Text = "settings";
            this.settings.UseVisualStyleBackColor = true;
            this.settings.Click += new System.EventHandler(this.settings_Click);
            // 
            // onTop
            // 
            this.onTop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.onTop.AutoSize = true;
            this.onTop.Location = new System.Drawing.Point(12, 415);
            this.onTop.Name = "onTop";
            this.onTop.Size = new System.Drawing.Size(83, 17);
            this.onTop.TabIndex = 1;
            this.onTop.Text = "keep on top";
            this.onTop.UseVisualStyleBackColor = true;
            this.onTop.CheckedChanged += new System.EventHandler(this.onTop_CheckedChanged);
            // 
            // Global820
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 446);
            this.Controls.Add(this.onTop);
            this.Controls.Add(this.settings);
            this.Controls.Add(this.chat);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Global820";
            this.Text = "Global 820";
            this.Shown += new System.EventHandler(this.Global820_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel chat;
        private System.Windows.Forms.Button settings;
        private System.Windows.Forms.CheckBox onTop;
    }
}

