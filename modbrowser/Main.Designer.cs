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
            this.githubIcon = new System.Windows.Forms.PictureBox();
            this.githubLabel_2 = new System.Windows.Forms.Label();
            this.modInfo = new System.Windows.Forms.Panel();
            this.modCategory = new System.Windows.Forms.Label();
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
            this.modbrowserIconColorPanel = new System.Windows.Forms.Panel();
            this.modbrowserIcon = new System.Windows.Forms.PictureBox();
            this.platformBrowser = new Awesomium.Windows.Forms.WebControl(this.components);
            this.menu.SuspendLayout();
            this.modActions.SuspendLayout();
            this.listButtonsPanel.SuspendLayout();
            this.modlistPanel.SuspendLayout();
            this.githubPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.githubIcon)).BeginInit();
            this.modInfo.SuspendLayout();
            this.plusonePanel.SuspendLayout();
            this.modActionsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modIcon)).BeginInit();
            this.mainPagePanel.SuspendLayout();
            this.modbrowserIconColorPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modbrowserIcon)).BeginInit();
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
            resources.ApplyResources(this.installMenuItem, "installMenuItem");
            this.installMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modInstallItem});
            this.installMenuItem.Name = "installMenuItem";
            // 
            // modInstallItem
            // 
            resources.ApplyResources(this.modInstallItem, "modInstallItem");
            this.modInstallItem.Name = "modInstallItem";
            this.modInstallItem.Click += new System.EventHandler(this.installMod);
            // 
            // settingsMenuButton
            // 
            resources.ApplyResources(this.settingsMenuButton, "settingsMenuButton");
            this.settingsMenuButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modbrowserToolStripMenuItem,
            this.gestionnaireDePluginsToolStripMenuItem});
            this.settingsMenuButton.Name = "settingsMenuButton";
            // 
            // modbrowserToolStripMenuItem
            // 
            resources.ApplyResources(this.modbrowserToolStripMenuItem, "modbrowserToolStripMenuItem");
            this.modbrowserToolStripMenuItem.Name = "modbrowserToolStripMenuItem";
            this.modbrowserToolStripMenuItem.Click += new System.EventHandler(this.modbrowserToolStripMenuItem_Click);
            // 
            // gestionnaireDePluginsToolStripMenuItem
            // 
            resources.ApplyResources(this.gestionnaireDePluginsToolStripMenuItem, "gestionnaireDePluginsToolStripMenuItem");
            this.gestionnaireDePluginsToolStripMenuItem.Name = "gestionnaireDePluginsToolStripMenuItem";
            this.gestionnaireDePluginsToolStripMenuItem.Click += new System.EventHandler(this.gestionnaireDePluginsToolStripMenuItem_Click);
            // 
            // helpMenuItem
            // 
            resources.ApplyResources(this.helpMenuItem, "helpMenuItem");
            this.helpMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutMenuItem,
            this.updateMenuItem});
            this.helpMenuItem.Name = "helpMenuItem";
            // 
            // aboutMenuItem
            // 
            resources.ApplyResources(this.aboutMenuItem, "aboutMenuItem");
            this.aboutMenuItem.Name = "aboutMenuItem";
            this.aboutMenuItem.Click += new System.EventHandler(this.aboutFormStart);
            // 
            // updateMenuItem
            // 
            resources.ApplyResources(this.updateMenuItem, "updateMenuItem");
            this.updateMenuItem.Name = "updateMenuItem";
            this.updateMenuItem.Click += new System.EventHandler(this.updatesButton);
            // 
            // pluginsList
            // 
            resources.ApplyResources(this.pluginsList, "pluginsList");
            this.pluginsList.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.pluginsList.Name = "pluginsList";
            this.pluginsList.SelectedIndexChanged += new System.EventHandler(this.pluginsList_Click);
            // 
            // modActions
            // 
            resources.ApplyResources(this.modActions, "modActions");
            this.modActions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uninstallStripMenuItem,
            this.updateStripMenuItem});
            this.modActions.Name = "modActionsContextMenuStrip";
            // 
            // uninstallStripMenuItem
            // 
            resources.ApplyResources(this.uninstallStripMenuItem, "uninstallStripMenuItem");
            this.uninstallStripMenuItem.Name = "uninstallStripMenuItem";
            this.uninstallStripMenuItem.Click += new System.EventHandler(this.uninstallModStripMenuItem);
            // 
            // updateStripMenuItem
            // 
            resources.ApplyResources(this.updateStripMenuItem, "updateStripMenuItem");
            this.updateStripMenuItem.Name = "updateStripMenuItem";
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
            resources.ApplyResources(this.mainPageButton, "mainPageButton");
            this.mainPageButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(195)))), ((int)(((byte)(74)))));
            this.mainPageButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(159)))), ((int)(((byte)(56)))));
            this.mainPageButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.mainPageButton.Name = "mainPageButton";
            this.mainPageButton.UseVisualStyleBackColor = false;
            this.mainPageButton.Click += new System.EventHandler(this.menuButton);
            // 
            // reloadModList
            // 
            resources.ApplyResources(this.reloadModList, "reloadModList");
            this.reloadModList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.reloadModList.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(0)))));
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
            resources.ApplyResources(this.modlistPanel, "modlistPanel");
            this.modlistPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.modlistPanel.Controls.Add(this.modlist);
            this.modlistPanel.Controls.Add(this.nomod);
            this.modlistPanel.Controls.Add(this.listButtonsPanel);
            this.modlistPanel.Name = "modlistPanel";
            // 
            // modlist
            // 
            resources.ApplyResources(this.modlist, "modlist");
            this.modlist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.modlist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.modlist.ContextMenuStrip = this.modActions;
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
            // githubIcon
            // 
            resources.ApplyResources(this.githubIcon, "githubIcon");
            this.githubIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.githubIcon.Name = "githubIcon";
            this.githubIcon.TabStop = false;
            this.githubIcon.Click += new System.EventHandler(this.GitHubLink);
            // 
            // githubLabel_2
            // 
            resources.ApplyResources(this.githubLabel_2, "githubLabel_2");
            this.githubLabel_2.Name = "githubLabel_2";
            // 
            // modInfo
            // 
            resources.ApplyResources(this.modInfo, "modInfo");
            this.modInfo.BackColor = System.Drawing.SystemColors.Control;
            this.modInfo.Controls.Add(this.modCategory);
            this.modInfo.Controls.Add(this.plusonePanel);
            this.modInfo.Controls.Add(this.modActionsPanel);
            this.modInfo.Controls.Add(this.modAuthor);
            this.modInfo.Controls.Add(this.modTitle);
            this.modInfo.Controls.Add(this.modDescription);
            this.modInfo.Controls.Add(this.modIcon);
            this.modInfo.Name = "modInfo";
            // 
            // modCategory
            // 
            resources.ApplyResources(this.modCategory, "modCategory");
            this.modCategory.Name = "modCategory";
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
            resources.ApplyResources(this.plusone, "plusone");
            this.plusone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(195)))), ((int)(((byte)(74)))));
            this.plusone.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(159)))), ((int)(((byte)(56)))));
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
            resources.ApplyResources(this.uninstallMod, "uninstallMod");
            this.uninstallMod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.uninstallMod.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.uninstallMod.Name = "uninstallMod";
            this.uninstallMod.UseVisualStyleBackColor = false;
            this.uninstallMod.Click += new System.EventHandler(this.uninstall);
            // 
            // updateMod
            // 
            resources.ApplyResources(this.updateMod, "updateMod");
            this.updateMod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.updateMod.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(0)))));
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
            // modIcon
            // 
            resources.ApplyResources(this.modIcon, "modIcon");
            this.modIcon.BackColor = System.Drawing.SystemColors.Control;
            this.modIcon.Name = "modIcon";
            this.modIcon.TabStop = false;
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
            resources.ApplyResources(this.modbrowserIconColorPanel, "modbrowserIconColorPanel");
            this.modbrowserIconColorPanel.Controls.Add(this.modbrowserIcon);
            this.modbrowserIconColorPanel.Name = "modbrowserIconColorPanel";
            // 
            // modbrowserIcon
            // 
            resources.ApplyResources(this.modbrowserIcon, "modbrowserIcon");
            this.modbrowserIcon.BackColor = System.Drawing.Color.Transparent;
            this.modbrowserIcon.Image = global::modbrowser.Properties.Resources.modbrowser_dark;
            this.modbrowserIcon.Name = "modbrowserIcon";
            this.modbrowserIcon.TabStop = false;
            // 
            // platformBrowser
            // 
            resources.ApplyResources(this.platformBrowser, "platformBrowser");
            this.platformBrowser.Source = new System.Uri("http://modbrowser.shost.ca/blog/", System.UriKind.Absolute);
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
            this.Load += new System.EventHandler(this.Main_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.githubIcon)).EndInit();
            this.modInfo.ResumeLayout(false);
            this.modInfo.PerformLayout();
            this.plusonePanel.ResumeLayout(false);
            this.modActionsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.modIcon)).EndInit();
            this.mainPagePanel.ResumeLayout(false);
            this.mainPagePanel.PerformLayout();
            this.modbrowserIconColorPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.modbrowserIcon)).EndInit();
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
        private System.Windows.Forms.Label modCategory;
    }
}

