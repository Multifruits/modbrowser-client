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
            this.modInstallItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.modbrowserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionnaireDePluginsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pluginsList = new System.Windows.Forms.ToolStripComboBox();
            this.modActions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.uninstallStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nomod = new System.Windows.Forms.Label();
            this.mainPageButton = new System.Windows.Forms.Button();
            this.reloadModList = new System.Windows.Forms.Button();
            this.listButtonsPanel = new System.Windows.Forms.Panel();
            this.modlistPanel = new System.Windows.Forms.Panel();
            this.modlist = new System.Windows.Forms.ListView();
            this.modIconsList = new System.Windows.Forms.ImageList(this.components);
            this.mbTitle = new System.Windows.Forms.Label();
            this.mbVersion = new System.Windows.Forms.Label();
            this.githubPanel = new System.Windows.Forms.Panel();
            this.githubLabel_1 = new System.Windows.Forms.Label();
            this.githubLabel_2 = new System.Windows.Forms.Label();
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
            this.mainPagePanel = new System.Windows.Forms.Panel();
            this.modbrowserIconColorPanel = new System.Windows.Forms.Panel();
            this.platformBrowser = new Awesomium.Windows.Forms.WebControl(this.components);
            this.modIcon = new System.Windows.Forms.PictureBox();
            this.modbrowserIcon = new System.Windows.Forms.PictureBox();
            this.githubIcon = new System.Windows.Forms.PictureBox();
            this.menu.SuspendLayout();
            this.modActions.SuspendLayout();
            this.listButtonsPanel.SuspendLayout();
            this.modlistPanel.SuspendLayout();
            this.githubPanel.SuspendLayout();
            this.modInfo.SuspendLayout();
            this.plusonePanel.SuspendLayout();
            this.modActionsPanel.SuspendLayout();
            this.mainPagePanel.SuspendLayout();
            this.modbrowserIconColorPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modbrowserIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.githubIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            resources.ApplyResources(this.menu, "menu");
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.installMenuItem,
            this.settingsMenuButton,
            this.helpMenuItem,
            this.pluginsList});
            this.menu.Name = "menu";
            // 
            // installMenuItem
            // 
            this.installMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modInstallItem});
            resources.ApplyResources(this.installMenuItem, "installMenuItem");
            this.installMenuItem.Name = "installMenuItem";
            // 
            // modInstallItem
            // 
            this.modInstallItem.Name = "modInstallItem";
            resources.ApplyResources(this.modInstallItem, "modInstallItem");
            this.modInstallItem.Click += new System.EventHandler(this.installMod);
            // 
            // settingsMenuButton
            // 
            this.settingsMenuButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modbrowserToolStripMenuItem,
            this.gestionnaireDePluginsToolStripMenuItem});
            this.settingsMenuButton.Name = "settingsMenuButton";
            resources.ApplyResources(this.settingsMenuButton, "settingsMenuButton");
            // 
            // modbrowserToolStripMenuItem
            // 
            this.modbrowserToolStripMenuItem.Name = "modbrowserToolStripMenuItem";
            resources.ApplyResources(this.modbrowserToolStripMenuItem, "modbrowserToolStripMenuItem");
            this.modbrowserToolStripMenuItem.Click += new System.EventHandler(this.modbrowserToolStripMenuItem_Click);
            // 
            // gestionnaireDePluginsToolStripMenuItem
            // 
            this.gestionnaireDePluginsToolStripMenuItem.Name = "gestionnaireDePluginsToolStripMenuItem";
            resources.ApplyResources(this.gestionnaireDePluginsToolStripMenuItem, "gestionnaireDePluginsToolStripMenuItem");
            this.gestionnaireDePluginsToolStripMenuItem.Click += new System.EventHandler(this.gestionnaireDePluginsToolStripMenuItem_Click);
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
            // pluginsList
            // 
            this.pluginsList.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            resources.ApplyResources(this.pluginsList, "pluginsList");
            this.pluginsList.Name = "pluginsList";
            this.pluginsList.SelectedIndexChanged += new System.EventHandler(this.pluginsList_Click);
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
            this.modlistPanel.Controls.Add(this.modlist);
            this.modlistPanel.Controls.Add(this.nomod);
            this.modlistPanel.Controls.Add(this.listButtonsPanel);
            resources.ApplyResources(this.modlistPanel, "modlistPanel");
            this.modlistPanel.Name = "modlistPanel";
            // 
            // modlist
            // 
            this.modlist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.modlist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.modlist.ContextMenuStrip = this.modActions;
            resources.ApplyResources(this.modlist, "modlist");
            this.modlist.ForeColor = System.Drawing.Color.White;
            this.modlist.MultiSelect = false;
            this.modlist.Name = "modlist";
            this.modlist.SmallImageList = this.modIconsList;
            this.modlist.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.modlist.UseCompatibleStateImageBehavior = false;
            this.modlist.View = System.Windows.Forms.View.SmallIcon;
            this.modlist.SelectedIndexChanged += new System.EventHandler(this.modSelected);
            // 
            // modIconsList
            // 
            this.modIconsList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("modIconsList.ImageStream")));
            this.modIconsList.TransparentColor = System.Drawing.Color.Transparent;
            this.modIconsList.Images.SetKeyName(0, "d");
            // 
            // mbTitle
            // 
            resources.ApplyResources(this.mbTitle, "mbTitle");
            this.mbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.mbTitle.Name = "mbTitle";
            // 
            // mbVersion
            // 
            resources.ApplyResources(this.mbVersion, "mbVersion");
            this.mbVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.mbVersion.Name = "mbVersion";
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
            // githubLabel_2
            // 
            resources.ApplyResources(this.githubLabel_2, "githubLabel_2");
            this.githubLabel_2.Name = "githubLabel_2";
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
            this.modActionsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.modActionsPanel_Paint);
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
            // 
            // mainPagePanel
            // 
            resources.ApplyResources(this.mainPagePanel, "mainPagePanel");
            this.mainPagePanel.BackColor = System.Drawing.SystemColors.Control;
            this.mainPagePanel.Controls.Add(this.modbrowserIconColorPanel);
            this.mainPagePanel.Controls.Add(this.platformBrowser);
            this.mainPagePanel.Controls.Add(this.githubPanel);
            this.mainPagePanel.Controls.Add(this.mbVersion);
            this.mainPagePanel.Controls.Add(this.mbTitle);
            this.mainPagePanel.Name = "mainPagePanel";
            // 
            // modbrowserIconColorPanel
            // 
            this.modbrowserIconColorPanel.Controls.Add(this.modbrowserIcon);
            resources.ApplyResources(this.modbrowserIconColorPanel, "modbrowserIconColorPanel");
            this.modbrowserIconColorPanel.Name = "modbrowserIconColorPanel";
            // 
            // platformBrowser
            // 
            resources.ApplyResources(this.platformBrowser, "platformBrowser");
            this.platformBrowser.Source = new System.Uri("http://modbrowser.shost.ca/blog/", System.UriKind.Absolute);
            // 
            // modIcon
            // 
            this.modIcon.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.modIcon, "modIcon");
            this.modIcon.Name = "modIcon";
            this.modIcon.TabStop = false;
            // 
            // modbrowserIcon
            // 
            this.modbrowserIcon.BackColor = System.Drawing.Color.Transparent;
            this.modbrowserIcon.Image = global::modbrowser.Properties.Resources.modbrowser_dark;
            resources.ApplyResources(this.modbrowserIcon, "modbrowserIcon");
            this.modbrowserIcon.Name = "modbrowserIcon";
            this.modbrowserIcon.TabStop = false;
            // 
            // githubIcon
            // 
            this.githubIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.githubIcon, "githubIcon");
            this.githubIcon.Name = "githubIcon";
            this.githubIcon.TabStop = false;
            this.githubIcon.Click += new System.EventHandler(this.GitHubLink);
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
            this.Resize += new System.EventHandler(this.resizeModList);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.modActions.ResumeLayout(false);
            this.listButtonsPanel.ResumeLayout(false);
            this.modlistPanel.ResumeLayout(false);
            this.modlistPanel.PerformLayout();
            this.githubPanel.ResumeLayout(false);
            this.githubPanel.PerformLayout();
            this.modInfo.ResumeLayout(false);
            this.modInfo.PerformLayout();
            this.plusonePanel.ResumeLayout(false);
            this.modActionsPanel.ResumeLayout(false);
            this.mainPagePanel.ResumeLayout(false);
            this.mainPagePanel.PerformLayout();
            this.modbrowserIconColorPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.modIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modbrowserIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.githubIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem installMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modInstallItem;
        private System.Windows.Forms.ToolStripMenuItem settingsMenuButton;
        private System.Windows.Forms.Label nomod;
        private System.Windows.Forms.ToolStripMenuItem helpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateMenuItem;
        private System.Windows.Forms.Button mainPageButton;
        private System.Windows.Forms.Button reloadModList;
        private System.Windows.Forms.Panel listButtonsPanel;
        private System.Windows.Forms.Panel modlistPanel;
        private System.Windows.Forms.ContextMenuStrip modActions;
        private System.Windows.Forms.ToolStripMenuItem uninstallStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateStripMenuItem;
        private System.Windows.Forms.ListView modlist;
        private System.Windows.Forms.ImageList modIconsList;
        private System.Windows.Forms.Label mbTitle;
        private System.Windows.Forms.Label mbVersion;
        private System.Windows.Forms.Panel githubPanel;
        private System.Windows.Forms.Label githubLabel_1;
        private System.Windows.Forms.PictureBox githubIcon;
        private System.Windows.Forms.Label githubLabel_2;
        private System.Windows.Forms.Panel modInfo;
        private System.Windows.Forms.Panel plusonePanel;
        private System.Windows.Forms.Button plusone;
        private System.Windows.Forms.Label plusoneNumber;
        private System.Windows.Forms.Panel modActionsPanel;
        private System.Windows.Forms.Button uninstallMod;
        private System.Windows.Forms.Button updateMod;
        private System.Windows.Forms.Label modAuthor;
        private System.Windows.Forms.Label modTitle;
        private System.Windows.Forms.RichTextBox modDescription;
        private System.Windows.Forms.PictureBox modIcon;
        private System.Windows.Forms.Panel mainPagePanel;
        private System.Windows.Forms.ToolStripMenuItem modbrowserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionnaireDePluginsToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox pluginsList;
        private System.Windows.Forms.PictureBox modbrowserIcon;
        public Awesomium.Windows.Forms.WebControl platformBrowser;
        private System.Windows.Forms.Panel modbrowserIconColorPanel;
    }
}

