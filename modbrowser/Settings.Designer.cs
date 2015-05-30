﻿namespace modbrowser
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
            this.label1 = new System.Windows.Forms.Label();
            this.colorComboBox = new System.Windows.Forms.ComboBox();
            this.cacheSize = new System.Windows.Forms.Label();
            this.reloadModList = new System.Windows.Forms.Button();
            this.folderBrowserBtn = new System.Windows.Forms.Button();
            this.minecraftPathBox = new System.Windows.Forms.TextBox();
            this.saveSettings = new System.Windows.Forms.Button();
            this.minecraftFolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.settingsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // mbSettings
            // 
            this.mbSettings.AutoSize = true;
            this.mbSettings.Font = new System.Drawing.Font("Roboto Condensed", 9F);
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
            this.mbTitle.Font = new System.Drawing.Font("Roboto Condensed", 24F);
            this.mbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.mbTitle.Location = new System.Drawing.Point(12, 9);
            this.mbTitle.Name = "mbTitle";
            this.mbTitle.Size = new System.Drawing.Size(176, 43);
            this.mbTitle.TabIndex = 2;
            this.mbTitle.Text = "modbrowser";
            // 
            // minecraftPathLabel
            // 
            this.minecraftPathLabel.AutoSize = true;
            this.minecraftPathLabel.Font = new System.Drawing.Font("Roboto Condensed", 9F);
            this.minecraftPathLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.minecraftPathLabel.Location = new System.Drawing.Point(18, 31);
            this.minecraftPathLabel.Name = "minecraftPathLabel";
            this.minecraftPathLabel.Size = new System.Drawing.Size(106, 16);
            this.minecraftPathLabel.TabIndex = 5;
            this.minecraftPathLabel.Text = "Chemin de Minecraft";
            // 
            // settingsBox
            // 
            this.settingsBox.Controls.Add(this.label1);
            this.settingsBox.Controls.Add(this.colorComboBox);
            this.settingsBox.Controls.Add(this.cacheSize);
            this.settingsBox.Controls.Add(this.reloadModList);
            this.settingsBox.Controls.Add(this.folderBrowserBtn);
            this.settingsBox.Controls.Add(this.minecraftPathBox);
            this.settingsBox.Controls.Add(this.saveSettings);
            this.settingsBox.Controls.Add(this.minecraftPathLabel);
            this.settingsBox.Location = new System.Drawing.Point(34, 64);
            this.settingsBox.Name = "settingsBox";
            this.settingsBox.Size = new System.Drawing.Size(362, 154);
            this.settingsBox.TabIndex = 6;
            this.settingsBox.TabStop = false;
            this.settingsBox.Text = "Paramètres";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Condensed", 9F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label1.Location = new System.Drawing.Point(18, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Couleur de l\'interface";
            // 
            // colorComboBox
            // 
            this.colorComboBox.FormattingEnabled = true;
            this.colorComboBox.Items.AddRange(new object[] {
            "Ambre",
            "Bleu",
            "Bleu clair",
            "Citron vert",
            "Cyan",
            "Gris",
            "Gris-bleu",
            "Indigo",
            "Jaune",
            "Marron",
            "Orange",
            "Orange foncé",
            "Rose",
            "Rouge",
            "Vert",
            "Vert clair",
            "Violet",
            "Violet foncé"});
            this.colorComboBox.Location = new System.Drawing.Point(152, 56);
            this.colorComboBox.Name = "colorComboBox";
            this.colorComboBox.Size = new System.Drawing.Size(196, 21);
            this.colorComboBox.Sorted = true;
            this.colorComboBox.TabIndex = 12;
            this.colorComboBox.Text = "Couleur";
            this.colorComboBox.SelectedIndexChanged += new System.EventHandler(this.colorComboBox_SelectedIndexChanged);
            // 
            // cacheSize
            // 
            this.cacheSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.75F);
            this.cacheSize.Location = new System.Drawing.Point(111, 128);
            this.cacheSize.Name = "cacheSize";
            this.cacheSize.Size = new System.Drawing.Size(117, 16);
            this.cacheSize.TabIndex = 7;
            this.cacheSize.Text = "indéterminé";
            this.cacheSize.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // reloadModList
            // 
            this.reloadModList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.reloadModList.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(0)))));
            this.reloadModList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reloadModList.Font = new System.Drawing.Font("Roboto Condensed", 9F);
            this.reloadModList.Location = new System.Drawing.Point(108, 96);
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
            this.minecraftPathBox.TextChanged += new System.EventHandler(this.pathChanged);
            // 
            // saveSettings
            // 
            this.saveSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(195)))), ((int)(((byte)(74)))));
            this.saveSettings.Enabled = false;
            this.saveSettings.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(159)))), ((int)(((byte)(56)))));
            this.saveSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveSettings.Font = new System.Drawing.Font("Roboto Condensed", 9F);
            this.saveSettings.Location = new System.Drawing.Point(231, 96);
            this.saveSettings.Name = "saveSettings";
            this.saveSettings.Size = new System.Drawing.Size(117, 29);
            this.saveSettings.TabIndex = 7;
            this.saveSettings.Text = "SAUVEGARDER";
            this.saveSettings.UseVisualStyleBackColor = false;
            this.saveSettings.Click += new System.EventHandler(this.saveSettingsAction);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 234);
            this.Controls.Add(this.settingsBox);
            this.Controls.Add(this.mbSettings);
            this.Controls.Add(this.mbTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Settings";
            this.Text = "Paramètres de modbrowser";
            this.settingsBox.ResumeLayout(false);
            this.settingsBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mbSettings;
        private System.Windows.Forms.Label mbTitle;
        private System.Windows.Forms.Label minecraftPathLabel;
        private System.Windows.Forms.GroupBox settingsBox;
        private System.Windows.Forms.Button folderBrowserBtn;
        private System.Windows.Forms.TextBox minecraftPathBox;
        private System.Windows.Forms.Button saveSettings;
        private System.Windows.Forms.FolderBrowserDialog minecraftFolderBrowser;
        private System.Windows.Forms.Button reloadModList;
        private System.Windows.Forms.Label cacheSize;
        private System.Windows.Forms.ComboBox colorComboBox;
        private System.Windows.Forms.Label label1;
    }
}