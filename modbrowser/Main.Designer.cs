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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.installMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modInstallItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.misesÀJourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modlist = new System.Windows.Forms.ListBox();
            this.modInfo = new System.Windows.Forms.Panel();
            this.modAuthor = new System.Windows.Forms.Label();
            this.modTitle = new System.Windows.Forms.Label();
            this.plusone = new System.Windows.Forms.Button();
            this.modDescription = new System.Windows.Forms.RichTextBox();
            this.updateMod = new System.Windows.Forms.Button();
            this.uninstallMod = new System.Windows.Forms.Button();
            this.modIcon = new System.Windows.Forms.PictureBox();
            this.statsPanel = new System.Windows.Forms.Panel();
            this.githubLabel_2 = new System.Windows.Forms.Label();
            this.githubLabel_1 = new System.Windows.Forms.Label();
            this.githubIcon = new System.Windows.Forms.PictureBox();
            this.statsBox = new System.Windows.Forms.GroupBox();
            this.modNumberPanel = new System.Windows.Forms.Panel();
            this.verifyModNumber = new System.Windows.Forms.Button();
            this.modNumberLabel = new System.Windows.Forms.Label();
            this.platformStatus = new System.Windows.Forms.Label();
            this.platformStatusPanel = new System.Windows.Forms.Panel();
            this.verifyPlatformStatus = new System.Windows.Forms.Button();
            this.platformStatusLabel = new System.Windows.Forms.Label();
            this.modNumber = new System.Windows.Forms.Label();
            this.mbVersion = new System.Windows.Forms.Label();
            this.mbTitle = new System.Windows.Forms.Label();
            this.statsButton = new System.Windows.Forms.Button();
            this.nomod = new System.Windows.Forms.Label();
            this.reloadModList = new System.Windows.Forms.Button();
            this.menu.SuspendLayout();
            this.modInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modIcon)).BeginInit();
            this.statsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.githubIcon)).BeginInit();
            this.statsBox.SuspendLayout();
            this.modNumberPanel.SuspendLayout();
            this.platformStatusPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Font = new System.Drawing.Font("Roboto Condensed", 9F);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.installMenuItem,
            this.settingsMenuButton,
            this.toolStripMenuItem1});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(784, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // installMenuItem
            // 
            this.installMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modInstallItem});
            this.installMenuItem.Name = "installMenuItem";
            this.installMenuItem.Size = new System.Drawing.Size(75, 20);
            this.installMenuItem.Text = "Installation";
            // 
            // modInstallItem
            // 
            this.modInstallItem.Name = "modInstallItem";
            this.modInstallItem.ShortcutKeyDisplayString = "";
            this.modInstallItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.M)));
            this.modInstallItem.Size = new System.Drawing.Size(134, 22);
            this.modInstallItem.Text = "Mod";
            this.modInstallItem.Click += new System.EventHandler(this.installMod);
            // 
            // settingsMenuButton
            // 
            this.settingsMenuButton.Name = "settingsMenuButton";
            this.settingsMenuButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.settingsMenuButton.Size = new System.Drawing.Size(75, 20);
            this.settingsMenuButton.Text = "Paramètres";
            this.settingsMenuButton.Click += new System.EventHandler(this.installModMenuButton);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aProposToolStripMenuItem,
            this.misesÀJourToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(25, 20);
            this.toolStripMenuItem1.Text = "?";
            // 
            // aProposToolStripMenuItem
            // 
            this.aProposToolStripMenuItem.Name = "aProposToolStripMenuItem";
            this.aProposToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.aProposToolStripMenuItem.Text = "A propos";
            this.aProposToolStripMenuItem.Click += new System.EventHandler(this.aboutFormStart);
            // 
            // misesÀJourToolStripMenuItem
            // 
            this.misesÀJourToolStripMenuItem.Name = "misesÀJourToolStripMenuItem";
            this.misesÀJourToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.misesÀJourToolStripMenuItem.Text = "Mises à jour";
            this.misesÀJourToolStripMenuItem.Click += new System.EventHandler(this.updatesButton);
            // 
            // modlist
            // 
            this.modlist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.modlist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.modlist.Font = new System.Drawing.Font("Roboto Condensed", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modlist.ForeColor = System.Drawing.Color.White;
            this.modlist.FormattingEnabled = true;
            this.modlist.ItemHeight = 23;
            this.modlist.Location = new System.Drawing.Point(12, 43);
            this.modlist.Name = "modlist";
            this.modlist.Size = new System.Drawing.Size(150, 322);
            this.modlist.TabIndex = 1;
            this.modlist.SelectedIndexChanged += new System.EventHandler(this.modSelected);
            // 
            // modInfo
            // 
            this.modInfo.BackColor = System.Drawing.SystemColors.Control;
            this.modInfo.Controls.Add(this.modAuthor);
            this.modInfo.Controls.Add(this.modTitle);
            this.modInfo.Controls.Add(this.plusone);
            this.modInfo.Controls.Add(this.modDescription);
            this.modInfo.Controls.Add(this.updateMod);
            this.modInfo.Controls.Add(this.uninstallMod);
            this.modInfo.Controls.Add(this.modIcon);
            this.modInfo.Font = new System.Drawing.Font("Roboto Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modInfo.Location = new System.Drawing.Point(175, 12);
            this.modInfo.Name = "modInfo";
            this.modInfo.Size = new System.Drawing.Size(559, 537);
            this.modInfo.TabIndex = 2;
            this.modInfo.Visible = false;
            // 
            // modAuthor
            // 
            this.modAuthor.AutoSize = true;
            this.modAuthor.Font = new System.Drawing.Font("Roboto Condensed Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modAuthor.Location = new System.Drawing.Point(89, 70);
            this.modAuthor.Name = "modAuthor";
            this.modAuthor.Size = new System.Drawing.Size(34, 15);
            this.modAuthor.TabIndex = 1;
            this.modAuthor.Text = "Auteur";
            // 
            // modTitle
            // 
            this.modTitle.AutoSize = true;
            this.modTitle.Font = new System.Drawing.Font("Roboto Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modTitle.Location = new System.Drawing.Point(86, 38);
            this.modTitle.Name = "modTitle";
            this.modTitle.Size = new System.Drawing.Size(57, 32);
            this.modTitle.TabIndex = 0;
            this.modTitle.Text = "Titre";
            // 
            // plusone
            // 
            this.plusone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(195)))), ((int)(((byte)(74)))));
            this.plusone.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(159)))), ((int)(((byte)(56)))));
            this.plusone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plusone.Location = new System.Drawing.Point(505, 413);
            this.plusone.Name = "plusone";
            this.plusone.Size = new System.Drawing.Size(38, 28);
            this.plusone.TabIndex = 8;
            this.plusone.Text = "+1";
            this.plusone.UseVisualStyleBackColor = false;
            this.plusone.Click += new System.EventHandler(this.plusoneButton);
            // 
            // modDescription
            // 
            this.modDescription.BackColor = System.Drawing.SystemColors.Control;
            this.modDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.modDescription.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.modDescription.Location = new System.Drawing.Point(19, 104);
            this.modDescription.Name = "modDescription";
            this.modDescription.ReadOnly = true;
            this.modDescription.Size = new System.Drawing.Size(524, 303);
            this.modDescription.TabIndex = 7;
            this.modDescription.Text = "";
            // 
            // updateMod
            // 
            this.updateMod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.updateMod.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(0)))));
            this.updateMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateMod.Font = new System.Drawing.Font("Roboto Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateMod.Location = new System.Drawing.Point(426, 63);
            this.updateMod.Name = "updateMod";
            this.updateMod.Size = new System.Drawing.Size(117, 29);
            this.updateMod.TabIndex = 6;
            this.updateMod.Text = "METTRE À JOUR";
            this.updateMod.UseVisualStyleBackColor = false;
            this.updateMod.Click += new System.EventHandler(this.updateButton);
            // 
            // uninstallMod
            // 
            this.uninstallMod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.uninstallMod.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.uninstallMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uninstallMod.Font = new System.Drawing.Font("Roboto Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uninstallMod.Location = new System.Drawing.Point(426, 31);
            this.uninstallMod.Name = "uninstallMod";
            this.uninstallMod.Size = new System.Drawing.Size(117, 29);
            this.uninstallMod.TabIndex = 5;
            this.uninstallMod.Text = "DÉSINSTALLER";
            this.uninstallMod.UseVisualStyleBackColor = false;
            this.uninstallMod.Click += new System.EventHandler(this.uninstall);
            // 
            // modIcon
            // 
            this.modIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.modIcon.Location = new System.Drawing.Point(19, 34);
            this.modIcon.Name = "modIcon";
            this.modIcon.Size = new System.Drawing.Size(64, 64);
            this.modIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.modIcon.TabIndex = 4;
            this.modIcon.TabStop = false;
            // 
            // statsPanel
            // 
            this.statsPanel.BackColor = System.Drawing.SystemColors.Control;
            this.statsPanel.Controls.Add(this.githubLabel_2);
            this.statsPanel.Controls.Add(this.githubLabel_1);
            this.statsPanel.Controls.Add(this.githubIcon);
            this.statsPanel.Controls.Add(this.statsBox);
            this.statsPanel.Controls.Add(this.mbVersion);
            this.statsPanel.Controls.Add(this.mbTitle);
            this.statsPanel.Location = new System.Drawing.Point(175, 12);
            this.statsPanel.Name = "statsPanel";
            this.statsPanel.Size = new System.Drawing.Size(559, 467);
            this.statsPanel.TabIndex = 9;
            // 
            // githubLabel_2
            // 
            this.githubLabel_2.AutoSize = true;
            this.githubLabel_2.Font = new System.Drawing.Font("Roboto Condensed", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.githubLabel_2.Location = new System.Drawing.Point(377, 406);
            this.githubLabel_2.Name = "githubLabel_2";
            this.githubLabel_2.Size = new System.Drawing.Size(96, 26);
            this.githubLabel_2.TabIndex = 9;
            this.githubLabel_2.Text = "sur GitHub";
            // 
            // githubLabel_1
            // 
            this.githubLabel_1.AutoSize = true;
            this.githubLabel_1.Font = new System.Drawing.Font("Roboto Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.githubLabel_1.Location = new System.Drawing.Point(394, 391);
            this.githubLabel_1.Name = "githubLabel_1";
            this.githubLabel_1.Size = new System.Drawing.Size(78, 16);
            this.githubLabel_1.TabIndex = 8;
            this.githubLabel_1.Text = "retrouvez nous";
            // 
            // githubIcon
            // 
            this.githubIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.githubIcon.Image = ((System.Drawing.Image)(resources.GetObject("githubIcon.Image")));
            this.githubIcon.Location = new System.Drawing.Point(479, 377);
            this.githubIcon.Name = "githubIcon";
            this.githubIcon.Size = new System.Drawing.Size(64, 64);
            this.githubIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.githubIcon.TabIndex = 7;
            this.githubIcon.TabStop = false;
            this.githubIcon.Click += new System.EventHandler(this.GitHubLink);
            // 
            // statsBox
            // 
            this.statsBox.Controls.Add(this.modNumberPanel);
            this.statsBox.Controls.Add(this.platformStatus);
            this.statsBox.Controls.Add(this.platformStatusPanel);
            this.statsBox.Controls.Add(this.modNumber);
            this.statsBox.Location = new System.Drawing.Point(24, 88);
            this.statsBox.Name = "statsBox";
            this.statsBox.Size = new System.Drawing.Size(519, 147);
            this.statsBox.TabIndex = 6;
            this.statsBox.TabStop = false;
            this.statsBox.Text = "Statistiques";
            // 
            // modNumberPanel
            // 
            this.modNumberPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.modNumberPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.modNumberPanel.Controls.Add(this.verifyModNumber);
            this.modNumberPanel.Controls.Add(this.modNumberLabel);
            this.modNumberPanel.Location = new System.Drawing.Point(26, 31);
            this.modNumberPanel.Name = "modNumberPanel";
            this.modNumberPanel.Size = new System.Drawing.Size(75, 75);
            this.modNumberPanel.TabIndex = 2;
            // 
            // verifyModNumber
            // 
            this.verifyModNumber.BackColor = System.Drawing.SystemColors.Control;
            this.verifyModNumber.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.verifyModNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.verifyModNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.verifyModNumber.Location = new System.Drawing.Point(-1, 51);
            this.verifyModNumber.Name = "verifyModNumber";
            this.verifyModNumber.Size = new System.Drawing.Size(76, 24);
            this.verifyModNumber.TabIndex = 6;
            this.verifyModNumber.Text = "VÉRIFIER";
            this.verifyModNumber.UseVisualStyleBackColor = false;
            this.verifyModNumber.Click += new System.EventHandler(this.modNumberButton);
            // 
            // modNumberLabel
            // 
            this.modNumberLabel.Font = new System.Drawing.Font("Roboto Condensed", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modNumberLabel.ForeColor = System.Drawing.Color.White;
            this.modNumberLabel.Location = new System.Drawing.Point(3, 0);
            this.modNumberLabel.Name = "modNumberLabel";
            this.modNumberLabel.Size = new System.Drawing.Size(69, 50);
            this.modNumberLabel.TabIndex = 4;
            this.modNumberLabel.Text = "0";
            this.modNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // platformStatus
            // 
            this.platformStatus.AutoSize = true;
            this.platformStatus.Font = new System.Drawing.Font("Roboto Condensed", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.platformStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.platformStatus.Location = new System.Drawing.Point(106, 109);
            this.platformStatus.Name = "platformStatus";
            this.platformStatus.Size = new System.Drawing.Size(52, 15);
            this.platformStatus.TabIndex = 5;
            this.platformStatus.Text = "Plateforme";
            // 
            // platformStatusPanel
            // 
            this.platformStatusPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.platformStatusPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.platformStatusPanel.Controls.Add(this.verifyPlatformStatus);
            this.platformStatusPanel.Controls.Add(this.platformStatusLabel);
            this.platformStatusPanel.Location = new System.Drawing.Point(108, 31);
            this.platformStatusPanel.Name = "platformStatusPanel";
            this.platformStatusPanel.Size = new System.Drawing.Size(75, 75);
            this.platformStatusPanel.TabIndex = 3;
            // 
            // verifyPlatformStatus
            // 
            this.verifyPlatformStatus.BackColor = System.Drawing.SystemColors.Control;
            this.verifyPlatformStatus.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.verifyPlatformStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.verifyPlatformStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.verifyPlatformStatus.Location = new System.Drawing.Point(-1, 51);
            this.verifyPlatformStatus.Name = "verifyPlatformStatus";
            this.verifyPlatformStatus.Size = new System.Drawing.Size(76, 24);
            this.verifyPlatformStatus.TabIndex = 5;
            this.verifyPlatformStatus.Text = "VÉRIFIER";
            this.verifyPlatformStatus.UseVisualStyleBackColor = false;
            this.verifyPlatformStatus.Click += new System.EventHandler(this.platformStatusButton);
            // 
            // platformStatusLabel
            // 
            this.platformStatusLabel.Font = new System.Drawing.Font("Roboto Condensed", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.platformStatusLabel.ForeColor = System.Drawing.Color.White;
            this.platformStatusLabel.Location = new System.Drawing.Point(3, 0);
            this.platformStatusLabel.Name = "platformStatusLabel";
            this.platformStatusLabel.Size = new System.Drawing.Size(69, 50);
            this.platformStatusLabel.TabIndex = 5;
            this.platformStatusLabel.Text = "inconnu";
            this.platformStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // modNumber
            // 
            this.modNumber.AutoSize = true;
            this.modNumber.Font = new System.Drawing.Font("Roboto Condensed", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.modNumber.Location = new System.Drawing.Point(24, 109);
            this.modNumber.Name = "modNumber";
            this.modNumber.Size = new System.Drawing.Size(77, 15);
            this.modNumber.TabIndex = 4;
            this.modNumber.Text = "Nombre de mods";
            // 
            // mbVersion
            // 
            this.mbVersion.AutoSize = true;
            this.mbVersion.Font = new System.Drawing.Font("Roboto Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mbVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.mbVersion.Location = new System.Drawing.Point(187, 44);
            this.mbVersion.Name = "mbVersion";
            this.mbVersion.Size = new System.Drawing.Size(92, 16);
            this.mbVersion.TabIndex = 1;
            this.mbVersion.Text = "undefined version";
            // 
            // mbTitle
            // 
            this.mbTitle.AutoSize = true;
            this.mbTitle.Font = new System.Drawing.Font("Roboto Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.mbTitle.Location = new System.Drawing.Point(16, 23);
            this.mbTitle.Name = "mbTitle";
            this.mbTitle.Size = new System.Drawing.Size(176, 43);
            this.mbTitle.TabIndex = 0;
            this.mbTitle.Text = "modbrowser";
            // 
            // statsButton
            // 
            this.statsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(195)))), ((int)(((byte)(74)))));
            this.statsButton.Enabled = false;
            this.statsButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(159)))), ((int)(((byte)(56)))));
            this.statsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statsButton.Font = new System.Drawing.Font("Roboto Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.statsButton.Location = new System.Drawing.Point(12, 420);
            this.statsButton.Name = "statsButton";
            this.statsButton.Size = new System.Drawing.Size(150, 29);
            this.statsButton.TabIndex = 7;
            this.statsButton.Text = "STATISTIQUES";
            this.statsButton.UseVisualStyleBackColor = false;
            this.statsButton.Click += new System.EventHandler(this.openStats);
            // 
            // nomod
            // 
            this.nomod.AutoSize = true;
            this.nomod.Font = new System.Drawing.Font("Roboto Condensed", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.nomod.Location = new System.Drawing.Point(12, 43);
            this.nomod.Name = "nomod";
            this.nomod.Size = new System.Drawing.Size(88, 24);
            this.nomod.TabIndex = 10;
            this.nomod.Text = "aucun mod";
            // 
            // reloadModList
            // 
            this.reloadModList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.reloadModList.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(0)))));
            this.reloadModList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reloadModList.Font = new System.Drawing.Font("Roboto Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reloadModList.Location = new System.Drawing.Point(12, 385);
            this.reloadModList.Name = "reloadModList";
            this.reloadModList.Size = new System.Drawing.Size(150, 29);
            this.reloadModList.TabIndex = 9;
            this.reloadModList.Text = "RECHARGER LA LISTE";
            this.reloadModList.UseVisualStyleBackColor = false;
            this.reloadModList.Click += new System.EventHandler(this.reloadModsList);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.reloadModList);
            this.Controls.Add(this.nomod);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.statsPanel);
            this.Controls.Add(this.statsButton);
            this.Controls.Add(this.modlist);
            this.Controls.Add(this.modInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "modbrowser";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.modInfo.ResumeLayout(false);
            this.modInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modIcon)).EndInit();
            this.statsPanel.ResumeLayout(false);
            this.statsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.githubIcon)).EndInit();
            this.statsBox.ResumeLayout(false);
            this.statsBox.PerformLayout();
            this.modNumberPanel.ResumeLayout(false);
            this.platformStatusPanel.ResumeLayout(false);
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
        private System.Windows.Forms.Panel statsPanel;
        private System.Windows.Forms.Label mbTitle;
        private System.Windows.Forms.Label mbVersion;
        private System.Windows.Forms.Button statsButton;
        private System.Windows.Forms.Label modNumber;
        private System.Windows.Forms.Panel platformStatusPanel;
        private System.Windows.Forms.Panel modNumberPanel;
        private System.Windows.Forms.Label modNumberLabel;
        private System.Windows.Forms.Label platformStatusLabel;
        private System.Windows.Forms.Button verifyPlatformStatus;
        private System.Windows.Forms.Label platformStatus;
        private System.Windows.Forms.Button verifyModNumber;
        private System.Windows.Forms.GroupBox statsBox;
        private System.Windows.Forms.Label githubLabel_2;
        private System.Windows.Forms.Label githubLabel_1;
        private System.Windows.Forms.PictureBox githubIcon;
        private System.Windows.Forms.Label nomod;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aProposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem misesÀJourToolStripMenuItem;
        private System.Windows.Forms.Button reloadModList;
        public System.Windows.Forms.ListBox modlist;
    }
}

