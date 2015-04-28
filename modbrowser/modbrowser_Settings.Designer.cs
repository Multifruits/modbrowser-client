namespace modbrowser
{
    partial class modbrowser_Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mbSettings = new System.Windows.Forms.Label();
            this.mbTitle = new System.Windows.Forms.Label();
            this.langLabel = new System.Windows.Forms.Label();
            this.minecraftPathLabel = new System.Windows.Forms.Label();
            this.settingsBox = new System.Windows.Forms.GroupBox();
            this.reloadModList = new System.Windows.Forms.Button();
            this.folderBrowserBtn = new System.Windows.Forms.Button();
            this.minecraftPathBox = new System.Windows.Forms.TextBox();
            this.languageBox = new System.Windows.Forms.ComboBox();
            this.saveSettings = new System.Windows.Forms.Button();
            this.minecraftFolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.settingsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // mbSettings
            // 
            this.mbSettings.AutoSize = true;
            this.mbSettings.Font = new System.Drawing.Font("Roboto Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mbSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.mbSettings.Location = new System.Drawing.Point(183, 30);
            this.mbSettings.Name = "mbSettings";
            this.mbSettings.Size = new System.Drawing.Size(62, 16);
            this.mbSettings.TabIndex = 3;
            this.mbSettings.Text = "paramètres";
            // 
            // mbTitle
            // 
            this.mbTitle.AutoSize = true;
            this.mbTitle.Font = new System.Drawing.Font("Roboto Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.mbTitle.Location = new System.Drawing.Point(12, 9);
            this.mbTitle.Name = "mbTitle";
            this.mbTitle.Size = new System.Drawing.Size(176, 43);
            this.mbTitle.TabIndex = 2;
            this.mbTitle.Text = "modbrowser";
            // 
            // langLabel
            // 
            this.langLabel.AutoSize = true;
            this.langLabel.Font = new System.Drawing.Font("Roboto Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.langLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.langLabel.Location = new System.Drawing.Point(18, 56);
            this.langLabel.Name = "langLabel";
            this.langLabel.Size = new System.Drawing.Size(86, 16);
            this.langLabel.TabIndex = 4;
            this.langLabel.Text = "Langue (à venir)";
            // 
            // minecraftPathLabel
            // 
            this.minecraftPathLabel.AutoSize = true;
            this.minecraftPathLabel.Font = new System.Drawing.Font("Roboto Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minecraftPathLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.minecraftPathLabel.Location = new System.Drawing.Point(18, 31);
            this.minecraftPathLabel.Name = "minecraftPathLabel";
            this.minecraftPathLabel.Size = new System.Drawing.Size(106, 16);
            this.minecraftPathLabel.TabIndex = 5;
            this.minecraftPathLabel.Text = "Chemin de Minecraft";
            // 
            // settingsBox
            // 
            this.settingsBox.Controls.Add(this.reloadModList);
            this.settingsBox.Controls.Add(this.folderBrowserBtn);
            this.settingsBox.Controls.Add(this.minecraftPathBox);
            this.settingsBox.Controls.Add(this.languageBox);
            this.settingsBox.Controls.Add(this.saveSettings);
            this.settingsBox.Controls.Add(this.minecraftPathLabel);
            this.settingsBox.Controls.Add(this.langLabel);
            this.settingsBox.Location = new System.Drawing.Point(34, 64);
            this.settingsBox.Name = "settingsBox";
            this.settingsBox.Size = new System.Drawing.Size(362, 134);
            this.settingsBox.TabIndex = 6;
            this.settingsBox.TabStop = false;
            this.settingsBox.Text = "Paramètres";
            // 
            // reloadModList
            // 
            this.reloadModList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.reloadModList.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(0)))));
            this.reloadModList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reloadModList.Font = new System.Drawing.Font("Roboto Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reloadModList.Location = new System.Drawing.Point(108, 99);
            this.reloadModList.Name = "reloadModList";
            this.reloadModList.Size = new System.Drawing.Size(117, 29);
            this.reloadModList.TabIndex = 11;
            this.reloadModList.Text = "VIDER LE CACHE";
            this.reloadModList.UseVisualStyleBackColor = false;
            this.reloadModList.Click += new System.EventHandler(this.eraseCache);
            // 
            // folderBrowserBtn
            // 
            this.folderBrowserBtn.Location = new System.Drawing.Point(317, 30);
            this.folderBrowserBtn.Name = "folderBrowserBtn";
            this.folderBrowserBtn.Size = new System.Drawing.Size(31, 20);
            this.folderBrowserBtn.TabIndex = 10;
            this.folderBrowserBtn.Text = "...";
            this.folderBrowserBtn.UseVisualStyleBackColor = true;
            this.folderBrowserBtn.Click += new System.EventHandler(this.selectFolder);
            // 
            // minecraftPathBox
            // 
            this.minecraftPathBox.Location = new System.Drawing.Point(152, 30);
            this.minecraftPathBox.Name = "minecraftPathBox";
            this.minecraftPathBox.Size = new System.Drawing.Size(159, 20);
            this.minecraftPathBox.TabIndex = 9;
            this.minecraftPathBox.TextChanged += new System.EventHandler(this.buttonOnOff);
            // 
            // languageBox
            // 
            this.languageBox.Enabled = false;
            this.languageBox.FormattingEnabled = true;
            this.languageBox.Items.AddRange(new object[] {
            "Français"});
            this.languageBox.Location = new System.Drawing.Point(152, 56);
            this.languageBox.Name = "languageBox";
            this.languageBox.Size = new System.Drawing.Size(196, 21);
            this.languageBox.TabIndex = 8;
            this.languageBox.Text = "Français";
            // 
            // saveSettings
            // 
            this.saveSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(195)))), ((int)(((byte)(74)))));
            this.saveSettings.Enabled = false;
            this.saveSettings.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(159)))), ((int)(((byte)(56)))));
            this.saveSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveSettings.Font = new System.Drawing.Font("Roboto Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveSettings.Location = new System.Drawing.Point(231, 99);
            this.saveSettings.Name = "saveSettings";
            this.saveSettings.Size = new System.Drawing.Size(117, 29);
            this.saveSettings.TabIndex = 7;
            this.saveSettings.Text = "SAUVEGARDER";
            this.saveSettings.UseVisualStyleBackColor = false;
            this.saveSettings.Click += new System.EventHandler(this.saveSettingsAction);
            // 
            // modbrowser_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 210);
            this.Controls.Add(this.settingsBox);
            this.Controls.Add(this.mbSettings);
            this.Controls.Add(this.mbTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "modbrowser_Settings";
            this.Text = "Paramètres de modbrowser";
            this.settingsBox.ResumeLayout(false);
            this.settingsBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mbSettings;
        private System.Windows.Forms.Label mbTitle;
        private System.Windows.Forms.Label langLabel;
        private System.Windows.Forms.Label minecraftPathLabel;
        private System.Windows.Forms.GroupBox settingsBox;
        private System.Windows.Forms.Button folderBrowserBtn;
        private System.Windows.Forms.TextBox minecraftPathBox;
        private System.Windows.Forms.ComboBox languageBox;
        private System.Windows.Forms.Button saveSettings;
        private System.Windows.Forms.FolderBrowserDialog minecraftFolderBrowser;
        private System.Windows.Forms.Button reloadModList;
    }
}