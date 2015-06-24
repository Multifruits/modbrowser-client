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
            this.installBox = new System.Windows.Forms.GroupBox();
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
            this.installBox.SuspendLayout();
            this.modInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modIcon)).BeginInit();
            this.searchPanel.SuspendLayout();
            this.installStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // installBox
            // 
            resources.ApplyResources(this.installBox, "installBox");
            this.installBox.BackColor = System.Drawing.Color.Transparent;
            this.installBox.Controls.Add(this.modInfo);
            this.installBox.Controls.Add(this.installButton);
            this.installBox.Controls.Add(this.correspondingVersionsLabel);
            this.installBox.Controls.Add(this.installModLabel);
            this.installBox.Controls.Add(this.installVersionList);
            this.installBox.Controls.Add(this.installModList);
            this.installBox.Controls.Add(this.searchPanel);
            this.installBox.ForeColor = System.Drawing.Color.White;
            this.installBox.Name = "installBox";
            this.installBox.TabStop = false;
            // 
            // modInfo
            // 
            resources.ApplyResources(this.modInfo, "modInfo");
            this.modInfo.Controls.Add(this.modAuthor);
            this.modInfo.Controls.Add(this.modTitle);
            this.modInfo.Controls.Add(this.modDescription);
            this.modInfo.Controls.Add(this.modIcon);
            this.modInfo.Name = "modInfo";
            // 
            // modAuthor
            // 
            resources.ApplyResources(this.modAuthor, "modAuthor");
            this.modAuthor.Name = "modAuthor";
            // 
            // modTitle
            // 
            resources.ApplyResources(this.modTitle, "modTitle");
            this.modTitle.ForeColor = System.Drawing.Color.White;
            this.modTitle.Name = "modTitle";
            // 
            // modDescription
            // 
            resources.ApplyResources(this.modDescription, "modDescription");
            this.modDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.modDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.modDescription.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.modDescription.Name = "modDescription";
            this.modDescription.ReadOnly = true;
            // 
            // modIcon
            // 
            resources.ApplyResources(this.modIcon, "modIcon");
            this.modIcon.BackColor = System.Drawing.Color.Transparent;
            this.modIcon.Name = "modIcon";
            this.modIcon.TabStop = false;
            // 
            // installButton
            // 
            resources.ApplyResources(this.installButton, "installButton");
            this.installButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(195)))), ((int)(((byte)(74)))));
            this.installButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(159)))), ((int)(((byte)(56)))));
            this.installButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.installButton.Name = "installButton";
            this.installButton.UseVisualStyleBackColor = false;
            this.installButton.Click += new System.EventHandler(this.installButton_Clicked);
            // 
            // correspondingVersionsLabel
            // 
            resources.ApplyResources(this.correspondingVersionsLabel, "correspondingVersionsLabel");
            this.correspondingVersionsLabel.ForeColor = System.Drawing.Color.White;
            this.correspondingVersionsLabel.Name = "correspondingVersionsLabel";
            // 
            // installModLabel
            // 
            resources.ApplyResources(this.installModLabel, "installModLabel");
            this.installModLabel.ForeColor = System.Drawing.Color.White;
            this.installModLabel.Name = "installModLabel";
            // 
            // installVersionList
            // 
            resources.ApplyResources(this.installVersionList, "installVersionList");
            this.installVersionList.BackColor = System.Drawing.SystemColors.Control;
            this.installVersionList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.installVersionList.ForeColor = System.Drawing.Color.Black;
            this.installVersionList.MultiSelect = false;
            this.installVersionList.Name = "installVersionList";
            this.installVersionList.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.installVersionList.UseCompatibleStateImageBehavior = false;
            this.installVersionList.View = System.Windows.Forms.View.SmallIcon;
            this.installVersionList.SelectedIndexChanged += new System.EventHandler(this.installVersionList_SelectedIndexChanged);
            // 
            // installModList
            // 
            resources.ApplyResources(this.installModList, "installModList");
            this.installModList.BackColor = System.Drawing.SystemColors.Control;
            this.installModList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.installModList.ForeColor = System.Drawing.Color.Black;
            this.installModList.MultiSelect = false;
            this.installModList.Name = "installModList";
            this.installModList.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.installModList.UseCompatibleStateImageBehavior = false;
            this.installModList.View = System.Windows.Forms.View.SmallIcon;
            this.installModList.SelectedIndexChanged += new System.EventHandler(this.installModList_SelectedIndexChanged);
            // 
            // searchPanel
            // 
            resources.ApplyResources(this.searchPanel, "searchPanel");
            this.searchPanel.Controls.Add(this.cancelSearchButton);
            this.searchPanel.Controls.Add(this.searchButton);
            this.searchPanel.Controls.Add(this.searchBox);
            this.searchPanel.Controls.Add(this.searchLabel);
            this.searchPanel.Name = "searchPanel";
            // 
            // cancelSearchButton
            // 
            resources.ApplyResources(this.cancelSearchButton, "cancelSearchButton");
            this.cancelSearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.cancelSearchButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.cancelSearchButton.Name = "cancelSearchButton";
            this.cancelSearchButton.UseVisualStyleBackColor = false;
            this.cancelSearchButton.Click += new System.EventHandler(this.cancelSearchButton_Click);
            // 
            // searchButton
            // 
            resources.ApplyResources(this.searchButton, "searchButton");
            this.searchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(195)))), ((int)(((byte)(74)))));
            this.searchButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(159)))), ((int)(((byte)(56)))));
            this.searchButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.searchButton.Name = "searchButton";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchBox
            // 
            resources.ApplyResources(this.searchBox, "searchBox");
            this.searchBox.Name = "searchBox";
            // 
            // searchLabel
            // 
            resources.ApplyResources(this.searchLabel, "searchLabel");
            this.searchLabel.Name = "searchLabel";
            // 
            // installStatus
            // 
            resources.ApplyResources(this.installStatus, "installStatus");
            this.installStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.installStatusLabel,
            this.statusBar});
            this.installStatus.Name = "installStatus";
            this.installStatus.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            // 
            // installStatusLabel
            // 
            resources.ApplyResources(this.installStatusLabel, "installStatusLabel");
            this.installStatusLabel.BackColor = System.Drawing.SystemColors.Control;
            this.installStatusLabel.Name = "installStatusLabel";
            // 
            // statusBar
            // 
            resources.ApplyResources(this.statusBar, "statusBar");
            this.statusBar.Name = "statusBar";
            // 
            // InstallMod
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.Controls.Add(this.installStatus);
            this.Controls.Add(this.installBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "InstallMod";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.installationClosing);
            this.installBox.ResumeLayout(false);
            this.installBox.PerformLayout();
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

        private System.Windows.Forms.GroupBox installBox;
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