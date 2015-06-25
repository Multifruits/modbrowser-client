namespace modbrowser
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.mbSettings = new System.Windows.Forms.Label();
            this.mbTitle = new System.Windows.Forms.Label();
            this.minecraftPathLabel = new System.Windows.Forms.Label();
            this.settingsBox = new System.Windows.Forms.GroupBox();
            this.language_comboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.color_comboBox = new System.Windows.Forms.ComboBox();
            this.cacheSize = new System.Windows.Forms.Label();
            this.reloadModList = new System.Windows.Forms.Button();
            this.saveSettings = new System.Windows.Forms.Button();
            this.minecraftFolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.settingsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // mbSettings
            // 
            resources.ApplyResources(this.mbSettings, "mbSettings");
            this.mbSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.mbSettings.Name = "mbSettings";
            // 
            // mbTitle
            // 
            resources.ApplyResources(this.mbTitle, "mbTitle");
            this.mbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.mbTitle.Name = "mbTitle";
            // 
            // minecraftPathLabel
            // 
            resources.ApplyResources(this.minecraftPathLabel, "minecraftPathLabel");
            this.minecraftPathLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.minecraftPathLabel.Name = "minecraftPathLabel";
            // 
            // settingsBox
            // 
            this.settingsBox.Controls.Add(this.language_comboBox);
            this.settingsBox.Controls.Add(this.label1);
            this.settingsBox.Controls.Add(this.color_comboBox);
            this.settingsBox.Controls.Add(this.cacheSize);
            this.settingsBox.Controls.Add(this.reloadModList);
            this.settingsBox.Controls.Add(this.saveSettings);
            this.settingsBox.Controls.Add(this.minecraftPathLabel);
            resources.ApplyResources(this.settingsBox, "settingsBox");
            this.settingsBox.Name = "settingsBox";
            this.settingsBox.TabStop = false;
            // 
            // language_comboBox
            // 
            this.language_comboBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.language_comboBox.FormattingEnabled = true;
            this.language_comboBox.Items.AddRange(new object[] {
            resources.GetString("language_comboBox.Items"),
            resources.GetString("language_comboBox.Items1"),
            resources.GetString("language_comboBox.Items2"),
            resources.GetString("language_comboBox.Items3")});
            resources.ApplyResources(this.language_comboBox, "language_comboBox");
            this.language_comboBox.Name = "language_comboBox";
            this.language_comboBox.Sorted = true;
            this.language_comboBox.SelectedIndexChanged += new System.EventHandler(this.buttonOnOff);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label1.Name = "label1";
            // 
            // color_comboBox
            // 
            this.color_comboBox.FormattingEnabled = true;
            this.color_comboBox.Items.AddRange(new object[] {
            resources.GetString("color_comboBox.Items"),
            resources.GetString("color_comboBox.Items1"),
            resources.GetString("color_comboBox.Items2"),
            resources.GetString("color_comboBox.Items3"),
            resources.GetString("color_comboBox.Items4"),
            resources.GetString("color_comboBox.Items5"),
            resources.GetString("color_comboBox.Items6"),
            resources.GetString("color_comboBox.Items7"),
            resources.GetString("color_comboBox.Items8"),
            resources.GetString("color_comboBox.Items9"),
            resources.GetString("color_comboBox.Items10"),
            resources.GetString("color_comboBox.Items11"),
            resources.GetString("color_comboBox.Items12"),
            resources.GetString("color_comboBox.Items13"),
            resources.GetString("color_comboBox.Items14"),
            resources.GetString("color_comboBox.Items15"),
            resources.GetString("color_comboBox.Items16"),
            resources.GetString("color_comboBox.Items17")});
            resources.ApplyResources(this.color_comboBox, "color_comboBox");
            this.color_comboBox.Name = "color_comboBox";
            this.color_comboBox.SelectedIndexChanged += new System.EventHandler(this.buttonOnOff);
            // 
            // cacheSize
            // 
            resources.ApplyResources(this.cacheSize, "cacheSize");
            this.cacheSize.Name = "cacheSize";
            // 
            // reloadModList
            // 
            this.reloadModList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.reloadModList.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.reloadModList, "reloadModList");
            this.reloadModList.Name = "reloadModList";
            this.reloadModList.UseVisualStyleBackColor = false;
            this.reloadModList.Click += new System.EventHandler(this.eraseCache);
            // 
            // saveSettings
            // 
            this.saveSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(195)))), ((int)(((byte)(74)))));
            resources.ApplyResources(this.saveSettings, "saveSettings");
            this.saveSettings.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(159)))), ((int)(((byte)(56)))));
            this.saveSettings.Name = "saveSettings";
            this.saveSettings.UseVisualStyleBackColor = false;
            this.saveSettings.Click += new System.EventHandler(this.saveSettingsAction);
            // 
            // Settings
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.settingsBox);
            this.Controls.Add(this.mbSettings);
            this.Controls.Add(this.mbTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Settings";
            this.settingsBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mbSettings;
        private System.Windows.Forms.Label mbTitle;
        private System.Windows.Forms.Label minecraftPathLabel;
        private System.Windows.Forms.GroupBox settingsBox;
        private System.Windows.Forms.Button saveSettings;
        private System.Windows.Forms.FolderBrowserDialog minecraftFolderBrowser;
        private System.Windows.Forms.Button reloadModList;
        private System.Windows.Forms.Label cacheSize;
        private System.Windows.Forms.ComboBox color_comboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox language_comboBox;
    }
}