namespace modbrowser
{
    partial class InstallMod
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstallMod));
            this.hashBox = new System.Windows.Forms.GroupBox();
            this.modInfo = new System.Windows.Forms.Panel();
            this.modAuthor = new System.Windows.Forms.Label();
            this.modTitle = new System.Windows.Forms.Label();
            this.modDescription = new System.Windows.Forms.RichTextBox();
            this.modIcon = new System.Windows.Forms.PictureBox();
            this.installButton = new System.Windows.Forms.Button();
            this.correspondingVersionsLabel = new System.Windows.Forms.Label();
            this.installModLabel = new System.Windows.Forms.Label();
            this.installVersionList = new System.Windows.Forms.ListView();
            this.installModList = new System.Windows.Forms.ListView();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.cancelSearchButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.installStatus = new System.Windows.Forms.StatusStrip();
            this.installStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusBar = new System.Windows.Forms.ToolStripProgressBar();
            this.hashBox.SuspendLayout();
            this.modInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modIcon)).BeginInit();
            this.searchPanel.SuspendLayout();
            this.installStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // hashBox
            // 
            this.hashBox.Controls.Add(this.modInfo);
            this.hashBox.Controls.Add(this.installButton);
            this.hashBox.Controls.Add(this.correspondingVersionsLabel);
            this.hashBox.Controls.Add(this.installModLabel);
            this.hashBox.Controls.Add(this.installVersionList);
            this.hashBox.Controls.Add(this.installModList);
            this.hashBox.Controls.Add(this.searchPanel);
            this.hashBox.Font = new System.Drawing.Font("Roboto Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hashBox.Location = new System.Drawing.Point(15, 12);
            this.hashBox.Name = "hashBox";
            this.hashBox.Size = new System.Drawing.Size(412, 319);
            this.hashBox.TabIndex = 2;
            this.hashBox.TabStop = false;
            this.hashBox.Text = "Installation de mods";
            // 
            // modInfo
            // 
            this.modInfo.Controls.Add(this.modAuthor);
            this.modInfo.Controls.Add(this.modTitle);
            this.modInfo.Controls.Add(this.modDescription);
            this.modInfo.Controls.Add(this.modIcon);
            this.modInfo.Location = new System.Drawing.Point(6, 22);
            this.modInfo.Name = "modInfo";
            this.modInfo.Size = new System.Drawing.Size(400, 297);
            this.modInfo.TabIndex = 10;
            this.modInfo.Visible = false;
            // 
            // modAuthor
            // 
            this.modAuthor.AutoSize = true;
            this.modAuthor.Font = new System.Drawing.Font("Roboto Condensed Light", 8.25F);
            this.modAuthor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.modAuthor.Location = new System.Drawing.Point(85, 53);
            this.modAuthor.Name = "modAuthor";
            this.modAuthor.Size = new System.Drawing.Size(34, 15);
            this.modAuthor.TabIndex = 9;
            this.modAuthor.Text = "Auteur";
            // 
            // modTitle
            // 
            this.modTitle.AutoSize = true;
            this.modTitle.Font = new System.Drawing.Font("Roboto Condensed", 18F);
            this.modTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.modTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.modTitle.Location = new System.Drawing.Point(82, 21);
            this.modTitle.Name = "modTitle";
            this.modTitle.Size = new System.Drawing.Size(57, 32);
            this.modTitle.TabIndex = 8;
            this.modTitle.Text = "Titre";
            // 
            // modDescription
            // 
            this.modDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.modDescription.BackColor = System.Drawing.SystemColors.Control;
            this.modDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.modDescription.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.modDescription.Location = new System.Drawing.Point(15, 84);
            this.modDescription.Name = "modDescription";
            this.modDescription.ReadOnly = true;
            this.modDescription.Size = new System.Drawing.Size(372, 197);
            this.modDescription.TabIndex = 11;
            this.modDescription.Text = "";
            // 
            // modIcon
            // 
            this.modIcon.BackColor = System.Drawing.SystemColors.Control;
            this.modIcon.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.modIcon.Location = new System.Drawing.Point(15, 14);
            this.modIcon.Name = "modIcon";
            this.modIcon.Size = new System.Drawing.Size(64, 64);
            this.modIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.modIcon.TabIndex = 10;
            this.modIcon.TabStop = false;
            // 
            // installButton
            // 
            this.installButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(195)))), ((int)(((byte)(74)))));
            this.installButton.Enabled = false;
            this.installButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(159)))), ((int)(((byte)(56)))));
            this.installButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.installButton.Font = new System.Drawing.Font("Roboto Condensed", 9F);
            this.installButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.installButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.installButton.Location = new System.Drawing.Point(245, 255);
            this.installButton.Name = "installButton";
            this.installButton.Size = new System.Drawing.Size(148, 29);
            this.installButton.TabIndex = 17;
            this.installButton.Text = "INSTALLER";
            this.installButton.UseVisualStyleBackColor = false;
            this.installButton.Click += new System.EventHandler(this.modInstall);
            // 
            // correspondingVersionsLabel
            // 
            this.correspondingVersionsLabel.AutoSize = true;
            this.correspondingVersionsLabel.Font = new System.Drawing.Font("Roboto Condensed", 9F);
            this.correspondingVersionsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.correspondingVersionsLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.correspondingVersionsLabel.Location = new System.Drawing.Point(232, 21);
            this.correspondingVersionsLabel.Name = "correspondingVersionsLabel";
            this.correspondingVersionsLabel.Size = new System.Drawing.Size(129, 16);
            this.correspondingVersionsLabel.TabIndex = 22;
            this.correspondingVersionsLabel.Text = "versions correspondantes";
            // 
            // installModLabel
            // 
            this.installModLabel.AutoSize = true;
            this.installModLabel.Font = new System.Drawing.Font("Roboto Condensed", 9F);
            this.installModLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.installModLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.installModLabel.Location = new System.Drawing.Point(17, 21);
            this.installModLabel.Name = "installModLabel";
            this.installModLabel.Size = new System.Drawing.Size(60, 16);
            this.installModLabel.TabIndex = 21;
            this.installModLabel.Text = "mod désiré";
            // 
            // installVersionList
            // 
            this.installVersionList.BackColor = System.Drawing.SystemColors.Control;
            this.installVersionList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.installVersionList.Font = new System.Drawing.Font("Roboto Condensed Light", 11F);
            this.installVersionList.ForeColor = System.Drawing.Color.Black;
            this.installVersionList.Location = new System.Drawing.Point(245, 40);
            this.installVersionList.MultiSelect = false;
            this.installVersionList.Name = "installVersionList";
            this.installVersionList.Size = new System.Drawing.Size(161, 209);
            this.installVersionList.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.installVersionList.TabIndex = 20;
            this.installVersionList.UseCompatibleStateImageBehavior = false;
            this.installVersionList.View = System.Windows.Forms.View.SmallIcon;
            this.installVersionList.SelectedIndexChanged += new System.EventHandler(this.installVersionList_SelectedIndexChanged);
            // 
            // installModList
            // 
            this.installModList.BackColor = System.Drawing.SystemColors.Control;
            this.installModList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.installModList.Font = new System.Drawing.Font("Roboto Condensed Light", 11F);
            this.installModList.ForeColor = System.Drawing.Color.Black;
            this.installModList.Location = new System.Drawing.Point(20, 40);
            this.installModList.MultiSelect = false;
            this.installModList.Name = "installModList";
            this.installModList.Size = new System.Drawing.Size(187, 210);
            this.installModList.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.installModList.TabIndex = 19;
            this.installModList.UseCompatibleStateImageBehavior = false;
            this.installModList.View = System.Windows.Forms.View.SmallIcon;
            this.installModList.SelectedIndexChanged += new System.EventHandler(this.installModList_SelectedIndexChanged);
            // 
            // searchPanel
            // 
            this.searchPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.searchPanel.Controls.Add(this.cancelSearchButton);
            this.searchPanel.Controls.Add(this.searchButton);
            this.searchPanel.Controls.Add(this.searchBox);
            this.searchPanel.Controls.Add(this.searchLabel);
            this.searchPanel.Location = new System.Drawing.Point(20, 255);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(203, 58);
            this.searchPanel.TabIndex = 18;
            // 
            // cancelSearchButton
            // 
            this.cancelSearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.cancelSearchButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.cancelSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelSearchButton.Font = new System.Drawing.Font("Roboto Condensed", 8.25F);
            this.cancelSearchButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cancelSearchButton.Location = new System.Drawing.Point(111, 1);
            this.cancelSearchButton.Name = "cancelSearchButton";
            this.cancelSearchButton.Size = new System.Drawing.Size(76, 24);
            this.cancelSearchButton.TabIndex = 14;
            this.cancelSearchButton.Text = "Annuler";
            this.cancelSearchButton.UseVisualStyleBackColor = false;
            this.cancelSearchButton.Click += new System.EventHandler(this.cancelSearchButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(195)))), ((int)(((byte)(74)))));
            this.searchButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(159)))), ((int)(((byte)(56)))));
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Roboto Condensed", 8.25F);
            this.searchButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.searchButton.Location = new System.Drawing.Point(73, 1);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(32, 24);
            this.searchButton.TabIndex = 11;
            this.searchButton.Text = "GO";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(16, 31);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(171, 23);
            this.searchBox.TabIndex = 13;
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Roboto Condensed", 9F);
            this.searchLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.searchLabel.Location = new System.Drawing.Point(13, 5);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(56, 16);
            this.searchLabel.TabIndex = 10;
            this.searchLabel.Text = "Recherche";
            // 
            // installStatus
            // 
            this.installStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.installStatusLabel,
            this.statusBar});
            this.installStatus.Location = new System.Drawing.Point(0, 334);
            this.installStatus.Name = "installStatus";
            this.installStatus.Size = new System.Drawing.Size(440, 22);
            this.installStatus.TabIndex = 9;
            this.installStatus.Text = "statusStrip1";
            // 
            // installStatusLabel
            // 
            this.installStatusLabel.Font = new System.Drawing.Font("Roboto Condensed", 9F);
            this.installStatusLabel.Name = "installStatusLabel";
            this.installStatusLabel.Size = new System.Drawing.Size(57, 17);
            this.installStatusLabel.Text = "En attente";
            // 
            // statusBar
            // 
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(100, 16);
            this.statusBar.Visible = false;
            // 
            // InstallMod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 356);
            this.Controls.Add(this.installStatus);
            this.Controls.Add(this.hashBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InstallMod";
            this.Text = "Installation de mods";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InstallMod_FormClosing);
            this.hashBox.ResumeLayout(false);
            this.hashBox.PerformLayout();
            this.modInfo.ResumeLayout(false);
            this.modInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modIcon)).EndInit();
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            this.installStatus.ResumeLayout(false);
            this.installStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox hashBox;
        private System.Windows.Forms.StatusStrip installStatus;
        private System.Windows.Forms.ToolStripStatusLabel installStatusLabel;
        private System.Windows.Forms.ToolStripProgressBar statusBar;
        private System.Windows.Forms.Panel modInfo;
        private System.Windows.Forms.Label modAuthor;
        private System.Windows.Forms.Label modTitle;
        private System.Windows.Forms.RichTextBox modDescription;
        private System.Windows.Forms.PictureBox modIcon;
        private System.Windows.Forms.Button installButton;
        private System.Windows.Forms.Label correspondingVersionsLabel;
        private System.Windows.Forms.Label installModLabel;
        private System.Windows.Forms.ListView installVersionList;
        private System.Windows.Forms.ListView installModList;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.Button cancelSearchButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label searchLabel;
    }
}