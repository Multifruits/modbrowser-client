namespace modbrowser
{
    partial class Main
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.installMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forgeInstallItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_18 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_1710 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_164 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_other = new System.Windows.Forms.ToolStripMenuItem();
            this.modInstallItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modlist = new System.Windows.Forms.ListBox();
            this.modActions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.uninstallStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modInfo = new System.Windows.Forms.Panel();
            this.plusonePanel = new System.Windows.Forms.Panel();
            this.plusone = new System.Windows.Forms.Button();
            this.plusoneNumber = new System.Windows.Forms.Label();
            this.modActionsPanel = new System.Windows.Forms.Panel();
            this.uninstallMod = new System.Windows.Forms.Button();
            this.updateMod = new System.Windows.Forms.Button();
            this.modAuthor = new System.Windows.Forms.Label();
            this.modTitle = new System.Windows.Forms.Label();
            this.modDescription = new System.Windows.Forms.RichTextBox();
            this.modIcon = new System.Windows.Forms.PictureBox();
            this.mainPagePanel = new System.Windows.Forms.Panel();
            this.statsPanel = new System.Windows.Forms.Panel();
            this.modNumberPanel = new System.Windows.Forms.Panel();
            this.verifyModNumber = new System.Windows.Forms.Button();
            this.modNumberLabel = new System.Windows.Forms.Label();
            this.modNumber = new System.Windows.Forms.Label();
            this.platformStatusPanel = new System.Windows.Forms.Panel();
            this.verifyPlatformStatus = new System.Windows.Forms.Button();
            this.platformStatusLabel = new System.Windows.Forms.Label();
            this.platformStatus = new System.Windows.Forms.Label();
            this.githubPanel = new System.Windows.Forms.Panel();
            this.githubLabel_1 = new System.Windows.Forms.Label();
            this.githubIcon = new System.Windows.Forms.PictureBox();
            this.githubLabel_2 = new System.Windows.Forms.Label();
            this.platformBrowser = new System.Windows.Forms.WebBrowser();
            this.mbVersion = new System.Windows.Forms.Label();
            this.mbTitle = new System.Windows.Forms.Label();
            this.nomod = new System.Windows.Forms.Label();
            this.mainPageButton = new System.Windows.Forms.Button();
            this.reloadModList = new System.Windows.Forms.Button();
            this.listButtonsPanel = new System.Windows.Forms.Panel();
            this.modlistPanel = new System.Windows.Forms.Panel();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.cancelSearchButton = new System.Windows.Forms.Button();
            this.menu.SuspendLayout();
            this.modActions.SuspendLayout();
            this.modInfo.SuspendLayout();
            this.plusonePanel.SuspendLayout();
            this.modActionsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modIcon)).BeginInit();
            this.mainPagePanel.SuspendLayout();
            this.statsPanel.SuspendLayout();
            this.modNumberPanel.SuspendLayout();
            this.platformStatusPanel.SuspendLayout();
            this.githubPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.githubIcon)).BeginInit();
            this.listButtonsPanel.SuspendLayout();
            this.modlistPanel.SuspendLayout();
            this.searchPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            resources.ApplyResources(this.menu, "menu");
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.installMenuItem,
            this.settingsMenuButton,
            this.helpMenuItem});
            this.menu.Name = "menu";
            // 
            // installMenuItem
            // 
            this.installMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.forgeInstallItem,
            this.modInstallItem});
            this.installMenuItem.Name = "installMenuItem";
            resources.ApplyResources(this.installMenuItem, "installMenuItem");
            // 
            // forgeInstallItem
            // 
            this.forgeInstallItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem_18,
            this.menuItem_1710,
            this.menuItem_164,
            this.menuItem_other});
            this.forgeInstallItem.Name = "forgeInstallItem";
            resources.ApplyResources(this.forgeInstallItem, "forgeInstallItem");
            // 
            // menuItem_18
            // 
            this.menuItem_18.Name = "menuItem_18";
            resources.ApplyResources(this.menuItem_18, "menuItem_18");
            this.menuItem_18.Click += new System.EventHandler(this.menuItem_18_Click);
            // 
            // menuItem_1710
            // 
            this.menuItem_1710.Name = "menuItem_1710";
            resources.ApplyResources(this.menuItem_1710, "menuItem_1710");
            this.menuItem_1710.Click += new System.EventHandler(this.menuItem_1710_Click);
            // 
            // menuItem_164
            // 
            this.menuItem_164.Name = "menuItem_164";
            resources.ApplyResources(this.menuItem_164, "menuItem_164");
            this.menuItem_164.Click += new System.EventHandler(this.menuItem_164_Click);
            // 
            // menuItem_other
            // 
            this.menuItem_other.Name = "menuItem_other";
            resources.ApplyResources(this.menuItem_other, "menuItem_other");
            this.menuItem_other.Click += new System.EventHandler(this.menuItem_other_Click);
            // 
            // modInstallItem
            // 
            this.modInstallItem.Name = "modInstallItem";
            resources.ApplyResources(this.modInstallItem, "modInstallItem");
            this.modInstallItem.Click += new System.EventHandler(this.installMod);
            // 
            // settingsMenuButton
            // 
            this.settingsMenuButton.Name = "settingsMenuButton";
            resources.ApplyResources(this.settingsMenuButton, "settingsMenuButton");
            this.settingsMenuButton.Click += new System.EventHandler(this.installModMenuButton);
            // 
            // helpMenuItem
            // 
            this.helpMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutMenuItem,
            this.updateMenuItem});
            this.helpMenuItem.Name = "helpMenuItem";
            resources.ApplyResources(this.helpMenuItem, "helpMenuItem");
            // 
            // aboutMenuItem
            // 
            this.aboutMenuItem.Name = "aboutMenuItem";
            resources.ApplyResources(this.aboutMenuItem, "aboutMenuItem");
            this.aboutMenuItem.Click += new System.EventHandler(this.aboutFormStart);
            // 
            // updateMenuItem
            // 
            this.updateMenuItem.Name = "updateMenuItem";
            resources.ApplyResources(this.updateMenuItem, "updateMenuItem");
            this.updateMenuItem.Click += new System.EventHandler(this.updatesButton);
            // 
            // modlist
            // 
            this.modlist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.modlist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.modlist.ContextMenuStrip = this.modActions;
            resources.ApplyResources(this.modlist, "modlist");
            this.modlist.ForeColor = System.Drawing.Color.White;
            this.modlist.FormattingEnabled = true;
            this.modlist.Name = "modlist";
            this.modlist.Sorted = true;
            this.modlist.SelectedIndexChanged += new System.EventHandler(this.modSelected);
            // 
            // modActions
            // 
            this.modActions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uninstallStripMenuItem,
            this.updateStripMenuItem});
            this.modActions.Name = "modActionsContextMenuStrip";
            resources.ApplyResources(this.modActions, "modActions");
            // 
            // uninstallStripMenuItem
            // 
            this.uninstallStripMenuItem.Name = "uninstallStripMenuItem";
            resources.ApplyResources(this.uninstallStripMenuItem, "uninstallStripMenuItem");
            this.uninstallStripMenuItem.Click += new System.EventHandler(this.uninstallModStripMenuItem);
            // 
            // updateStripMenuItem
            // 
            this.updateStripMenuItem.Name = "updateStripMenuItem";
            resources.ApplyResources(this.updateStripMenuItem, "updateStripMenuItem");
            this.updateStripMenuItem.Click += new System.EventHandler(this.updateByStripMenuItem);
            // 
            // modInfo
            // 
            this.modInfo.BackColor = System.Drawing.SystemColors.Control;
            this.modInfo.Controls.Add(this.plusonePanel);
            this.modInfo.Controls.Add(this.modActionsPanel);
            this.modInfo.Controls.Add(this.modAuthor);
            this.modInfo.Controls.Add(this.modTitle);
            this.modInfo.Controls.Add(this.modDescription);
            this.modInfo.Controls.Add(this.modIcon);
            resources.ApplyResources(this.modInfo, "modInfo");
            this.modInfo.Name = "modInfo";
            // 
            // plusonePanel
            // 
            resources.ApplyResources(this.plusonePanel, "plusonePanel");
            this.plusonePanel.Controls.Add(this.plusone);
            this.plusonePanel.Controls.Add(this.plusoneNumber);
            this.plusonePanel.Name = "plusonePanel";
            // 
            // plusone
            // 
            this.plusone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(195)))), ((int)(((byte)(74)))));
            this.plusone.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(159)))), ((int)(((byte)(56)))));
            resources.ApplyResources(this.plusone, "plusone");
            this.plusone.Name = "plusone";
            this.plusone.UseVisualStyleBackColor = false;
            this.plusone.Click += new System.EventHandler(this.plusoneButton);
            // 
            // plusoneNumber
            // 
            resources.ApplyResources(this.plusoneNumber, "plusoneNumber");
            this.plusoneNumber.Name = "plusoneNumber";
            // 
            // modActionsPanel
            // 
            resources.ApplyResources(this.modActionsPanel, "modActionsPanel");
            this.modActionsPanel.Controls.Add(this.uninstallMod);
            this.modActionsPanel.Controls.Add(this.updateMod);
            this.modActionsPanel.Name = "modActionsPanel";
            // 
            // uninstallMod
            // 
            this.uninstallMod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.uninstallMod.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            resources.ApplyResources(this.uninstallMod, "uninstallMod");
            this.uninstallMod.Name = "uninstallMod";
            this.uninstallMod.UseVisualStyleBackColor = false;
            this.uninstallMod.Click += new System.EventHandler(this.uninstall);
            // 
            // updateMod
            // 
            this.updateMod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.updateMod.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.updateMod, "updateMod");
            this.updateMod.Name = "updateMod";
            this.updateMod.UseVisualStyleBackColor = false;
            this.updateMod.Click += new System.EventHandler(this.updateButton);
            // 
            // modAuthor
            // 
            resources.ApplyResources(this.modAuthor, "modAuthor");
            this.modAuthor.Name = "modAuthor";
            // 
            // modTitle
            // 
            resources.ApplyResources(this.modTitle, "modTitle");
            this.modTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.modTitle.Name = "modTitle";
            // 
            // modDescription
            // 
            resources.ApplyResources(this.modDescription, "modDescription");
            this.modDescription.BackColor = System.Drawing.SystemColors.Control;
            this.modDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.modDescription.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.modDescription.Name = "modDescription";
            this.modDescription.ReadOnly = true;
            this.modDescription.TextChanged += new System.EventHandler(this.modDescription_TextChanged);
            // 
            // modIcon
            // 
            this.modIcon.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.modIcon, "modIcon");
            this.modIcon.Name = "modIcon";
            this.modIcon.TabStop = false;
            // 
            // mainPagePanel
            // 
            resources.ApplyResources(this.mainPagePanel, "mainPagePanel");
            this.mainPagePanel.BackColor = System.Drawing.SystemColors.Control;
            this.mainPagePanel.Controls.Add(this.searchPanel);
            this.mainPagePanel.Controls.Add(this.platformBrowser);
            this.mainPagePanel.Controls.Add(this.statsPanel);
            this.mainPagePanel.Controls.Add(this.githubPanel);
            this.mainPagePanel.Controls.Add(this.mbVersion);
            this.mainPagePanel.Controls.Add(this.mbTitle);
            this.mainPagePanel.Name = "mainPagePanel";
            // 
            // statsPanel
            // 
            resources.ApplyResources(this.statsPanel, "statsPanel");
            this.statsPanel.Controls.Add(this.modNumberPanel);
            this.statsPanel.Controls.Add(this.modNumber);
            this.statsPanel.Controls.Add(this.platformStatusPanel);
            this.statsPanel.Controls.Add(this.platformStatus);
            this.statsPanel.Name = "statsPanel";
            // 
            // modNumberPanel
            // 
            this.modNumberPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.modNumberPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.modNumberPanel.Controls.Add(this.verifyModNumber);
            this.modNumberPanel.Controls.Add(this.modNumberLabel);
            resources.ApplyResources(this.modNumberPanel, "modNumberPanel");
            this.modNumberPanel.Name = "modNumberPanel";
            // 
            // verifyModNumber
            // 
            this.verifyModNumber.BackColor = System.Drawing.SystemColors.Control;
            this.verifyModNumber.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            resources.ApplyResources(this.verifyModNumber, "verifyModNumber");
            this.verifyModNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.verifyModNumber.Name = "verifyModNumber";
            this.verifyModNumber.UseVisualStyleBackColor = false;
            this.verifyModNumber.Click += new System.EventHandler(this.modNumberButton);
            // 
            // modNumberLabel
            // 
            resources.ApplyResources(this.modNumberLabel, "modNumberLabel");
            this.modNumberLabel.ForeColor = System.Drawing.Color.White;
            this.modNumberLabel.Name = "modNumberLabel";
            // 
            // modNumber
            // 
            resources.ApplyResources(this.modNumber, "modNumber");
            this.modNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.modNumber.Name = "modNumber";
            // 
            // platformStatusPanel
            // 
            this.platformStatusPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.platformStatusPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.platformStatusPanel.Controls.Add(this.verifyPlatformStatus);
            this.platformStatusPanel.Controls.Add(this.platformStatusLabel);
            resources.ApplyResources(this.platformStatusPanel, "platformStatusPanel");
            this.platformStatusPanel.Name = "platformStatusPanel";
            // 
            // verifyPlatformStatus
            // 
            this.verifyPlatformStatus.BackColor = System.Drawing.SystemColors.Control;
            this.verifyPlatformStatus.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            resources.ApplyResources(this.verifyPlatformStatus, "verifyPlatformStatus");
            this.verifyPlatformStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.verifyPlatformStatus.Name = "verifyPlatformStatus";
            this.verifyPlatformStatus.UseVisualStyleBackColor = false;
            this.verifyPlatformStatus.Click += new System.EventHandler(this.platformStatusButton);
            // 
            // platformStatusLabel
            // 
            resources.ApplyResources(this.platformStatusLabel, "platformStatusLabel");
            this.platformStatusLabel.ForeColor = System.Drawing.Color.White;
            this.platformStatusLabel.Name = "platformStatusLabel";
            // 
            // platformStatus
            // 
            resources.ApplyResources(this.platformStatus, "platformStatus");
            this.platformStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.platformStatus.Name = "platformStatus";
            // 
            // githubPanel
            // 
            resources.ApplyResources(this.githubPanel, "githubPanel");
            this.githubPanel.Controls.Add(this.githubLabel_1);
            this.githubPanel.Controls.Add(this.githubIcon);
            this.githubPanel.Controls.Add(this.githubLabel_2);
            this.githubPanel.Name = "githubPanel";
            // 
            // githubLabel_1
            // 
            resources.ApplyResources(this.githubLabel_1, "githubLabel_1");
            this.githubLabel_1.Name = "githubLabel_1";
            // 
            // githubIcon
            // 
            this.githubIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.githubIcon, "githubIcon");
            this.githubIcon.Name = "githubIcon";
            this.githubIcon.TabStop = false;
            this.githubIcon.Click += new System.EventHandler(this.GitHubLink);
            // 
            // githubLabel_2
            // 
            resources.ApplyResources(this.githubLabel_2, "githubLabel_2");
            this.githubLabel_2.Name = "githubLabel_2";
            // 
            // platformBrowser
            // 
            resources.ApplyResources(this.platformBrowser, "platformBrowser");
            this.platformBrowser.Name = "platformBrowser";
            this.platformBrowser.ScriptErrorsSuppressed = true;
            this.platformBrowser.Url = new System.Uri("http://modbrowser.shost.ca/plateforme/minecraft/mods_clientview/", System.UriKind.Absolute);
            // 
            // mbVersion
            // 
            resources.ApplyResources(this.mbVersion, "mbVersion");
            this.mbVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.mbVersion.Name = "mbVersion";
            // 
            // mbTitle
            // 
            resources.ApplyResources(this.mbTitle, "mbTitle");
            this.mbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.mbTitle.Name = "mbTitle";
            // 
            // nomod
            // 
            resources.ApplyResources(this.nomod, "nomod");
            this.nomod.ForeColor = System.Drawing.Color.White;
            this.nomod.Name = "nomod";
            // 
            // mainPageButton
            // 
            this.mainPageButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(195)))), ((int)(((byte)(74)))));
            resources.ApplyResources(this.mainPageButton, "mainPageButton");
            this.mainPageButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(159)))), ((int)(((byte)(56)))));
            this.mainPageButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.mainPageButton.Name = "mainPageButton";
            this.mainPageButton.UseVisualStyleBackColor = false;
            this.mainPageButton.Click += new System.EventHandler(this.menuButton);
            // 
            // reloadModList
            // 
            this.reloadModList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.reloadModList.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.reloadModList, "reloadModList");
            this.reloadModList.Name = "reloadModList";
            this.reloadModList.UseVisualStyleBackColor = false;
            this.reloadModList.Click += new System.EventHandler(this.reloadModsList);
            // 
            // listButtonsPanel
            // 
            resources.ApplyResources(this.listButtonsPanel, "listButtonsPanel");
            this.listButtonsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.listButtonsPanel.Controls.Add(this.reloadModList);
            this.listButtonsPanel.Controls.Add(this.mainPageButton);
            this.listButtonsPanel.Name = "listButtonsPanel";
            // 
            // modlistPanel
            // 
            this.modlistPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.modlistPanel.Controls.Add(this.nomod);
            this.modlistPanel.Controls.Add(this.modlist);
            this.modlistPanel.Controls.Add(this.listButtonsPanel);
            resources.ApplyResources(this.modlistPanel, "modlistPanel");
            this.modlistPanel.Name = "modlistPanel";
            // 
            // searchBox
            // 
            resources.ApplyResources(this.searchBox, "searchBox");
            this.searchBox.Name = "searchBox";
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
            // searchLabel
            // 
            resources.ApplyResources(this.searchLabel, "searchLabel");
            this.searchLabel.Name = "searchLabel";
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(195)))), ((int)(((byte)(74)))));
            this.searchButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(159)))), ((int)(((byte)(56)))));
            resources.ApplyResources(this.searchButton, "searchButton");
            this.searchButton.Name = "searchButton";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // cancelSearchButton
            // 
            this.cancelSearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.cancelSearchButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            resources.ApplyResources(this.cancelSearchButton, "cancelSearchButton");
            this.cancelSearchButton.Name = "cancelSearchButton";
            this.cancelSearchButton.UseVisualStyleBackColor = false;
            this.cancelSearchButton.Click += new System.EventHandler(this.cancelSearchButton_Click);
            // 
            // Main
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.modInfo);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.mainPagePanel);
            this.Controls.Add(this.modlistPanel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.MainMenuStrip = this.menu;
            this.Name = "Main";
            this.ResizeEnd += new System.EventHandler(this.resizeModList);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.modActions.ResumeLayout(false);
            this.modInfo.ResumeLayout(false);
            this.modInfo.PerformLayout();
            this.plusonePanel.ResumeLayout(false);
            this.modActionsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.modIcon)).EndInit();
            this.mainPagePanel.ResumeLayout(false);
            this.mainPagePanel.PerformLayout();
            this.statsPanel.ResumeLayout(false);
            this.statsPanel.PerformLayout();
            this.modNumberPanel.ResumeLayout(false);
            this.platformStatusPanel.ResumeLayout(false);
            this.githubPanel.ResumeLayout(false);
            this.githubPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.githubIcon)).EndInit();
            this.listButtonsPanel.ResumeLayout(false);
            this.modlistPanel.ResumeLayout(false);
            this.modlistPanel.PerformLayout();
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem installMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modInstallItem;
        private System.Windows.Forms.ToolStripMenuItem settingsMenuButton;
        private System.Windows.Forms.Panel modInfo;
        private System.Windows.Forms.Label modAuthor;
        private System.Windows.Forms.Label modTitle;
        private System.Windows.Forms.PictureBox modIcon;
        private System.Windows.Forms.Button updateMod;
        private System.Windows.Forms.Button uninstallMod;
        private System.Windows.Forms.RichTextBox modDescription;
        private System.Windows.Forms.Button plusone;
        private System.Windows.Forms.Panel mainPagePanel;
        private System.Windows.Forms.Label mbTitle;
        private System.Windows.Forms.Label mbVersion;
        private System.Windows.Forms.Label modNumber;
        private System.Windows.Forms.Panel platformStatusPanel;
        private System.Windows.Forms.Panel modNumberPanel;
        private System.Windows.Forms.Label modNumberLabel;
        private System.Windows.Forms.Label platformStatusLabel;
        private System.Windows.Forms.Button verifyPlatformStatus;
        private System.Windows.Forms.Label platformStatus;
        private System.Windows.Forms.Button verifyModNumber;
        private System.Windows.Forms.Label githubLabel_2;
        private System.Windows.Forms.Label githubLabel_1;
        private System.Windows.Forms.PictureBox githubIcon;
        private System.Windows.Forms.Label nomod;
        private System.Windows.Forms.ToolStripMenuItem helpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateMenuItem;
        public System.Windows.Forms.ListBox modlist;
        private System.Windows.Forms.Button mainPageButton;
        private System.Windows.Forms.Button reloadModList;
        private System.Windows.Forms.Panel listButtonsPanel;
        private System.Windows.Forms.Panel modlistPanel;
        private System.Windows.Forms.WebBrowser platformBrowser;
        private System.Windows.Forms.Panel githubPanel;
        private System.Windows.Forms.Panel statsPanel;
        private System.Windows.Forms.Panel modActionsPanel;
        private System.Windows.Forms.Panel plusonePanel;
        private System.Windows.Forms.Label plusoneNumber;
        private System.Windows.Forms.ContextMenuStrip modActions;
        private System.Windows.Forms.ToolStripMenuItem uninstallStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forgeInstallItem;
        private System.Windows.Forms.ToolStripMenuItem menuItem_18;
        private System.Windows.Forms.ToolStripMenuItem menuItem_1710;
        private System.Windows.Forms.ToolStripMenuItem menuItem_164;
        private System.Windows.Forms.ToolStripMenuItem menuItem_other;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button cancelSearchButton;
    }
}

