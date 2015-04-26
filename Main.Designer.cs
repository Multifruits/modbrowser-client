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
            this.menu = new System.Windows.Forms.MenuStrip();
            this.nouveauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modBrowserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minecraftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modlist = new System.Windows.Forms.ListBox();
            this.modInfo = new System.Windows.Forms.Panel();
            this.statsPanel = new System.Windows.Forms.Panel();
            this.mbVersion = new System.Windows.Forms.Label();
            this.mbTitle = new System.Windows.Forms.Label();
            this.modAuthor = new System.Windows.Forms.Label();
            this.modTitle = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.modDescription = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.modIcon = new System.Windows.Forms.PictureBox();
            this.statsButton = new System.Windows.Forms.Button();
            this.menu.SuspendLayout();
            this.modInfo.SuspendLayout();
            this.statsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Font = new System.Drawing.Font("Roboto Condensed", 9F);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouveauToolStripMenuItem,
            this.aProposToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(784, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // nouveauToolStripMenuItem
            // 
            this.nouveauToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modToolStripMenuItem});
            this.nouveauToolStripMenuItem.Name = "nouveauToolStripMenuItem";
            this.nouveauToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.nouveauToolStripMenuItem.Text = "Installation";
            // 
            // modToolStripMenuItem
            // 
            this.modToolStripMenuItem.Name = "modToolStripMenuItem";
            this.modToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.modToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.M)));
            this.modToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.modToolStripMenuItem.Text = "Mod";
            this.modToolStripMenuItem.Click += new System.EventHandler(this.installMod);
            // 
            // aProposToolStripMenuItem
            // 
            this.aProposToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modBrowserToolStripMenuItem,
            this.minecraftToolStripMenuItem});
            this.aProposToolStripMenuItem.Name = "aProposToolStripMenuItem";
            this.aProposToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.aProposToolStripMenuItem.Text = "Paramètres";
            // 
            // modBrowserToolStripMenuItem
            // 
            this.modBrowserToolStripMenuItem.Name = "modBrowserToolStripMenuItem";
            this.modBrowserToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.modBrowserToolStripMenuItem.Text = "ModBrowser";
            // 
            // minecraftToolStripMenuItem
            // 
            this.minecraftToolStripMenuItem.Name = "minecraftToolStripMenuItem";
            this.minecraftToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.minecraftToolStripMenuItem.Text = "Minecraft";
            // 
            // modlist
            // 
            this.modlist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(85)))), ((int)(((byte)(72)))));
            this.modlist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.modlist.Font = new System.Drawing.Font("Roboto Condensed", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modlist.ForeColor = System.Drawing.Color.White;
            this.modlist.FormattingEnabled = true;
            this.modlist.ItemHeight = 23;
            this.modlist.Location = new System.Drawing.Point(12, 43);
            this.modlist.Name = "modlist";
            this.modlist.Size = new System.Drawing.Size(157, 368);
            this.modlist.TabIndex = 1;
            this.modlist.SelectedIndexChanged += new System.EventHandler(this.modSelected);
            // 
            // modInfo
            // 
            this.modInfo.BackColor = System.Drawing.SystemColors.Control;
            this.modInfo.Controls.Add(this.modAuthor);
            this.modInfo.Controls.Add(this.modTitle);
            this.modInfo.Controls.Add(this.button3);
            this.modInfo.Controls.Add(this.modDescription);
            this.modInfo.Controls.Add(this.button2);
            this.modInfo.Controls.Add(this.button1);
            this.modInfo.Controls.Add(this.modIcon);
            this.modInfo.Font = new System.Drawing.Font("Roboto Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modInfo.Location = new System.Drawing.Point(175, 12);
            this.modInfo.Name = "modInfo";
            this.modInfo.Size = new System.Drawing.Size(559, 537);
            this.modInfo.TabIndex = 2;
            this.modInfo.Visible = false;
            // 
            // statsPanel
            // 
            this.statsPanel.BackColor = System.Drawing.SystemColors.Control;
            this.statsPanel.Controls.Add(this.mbVersion);
            this.statsPanel.Controls.Add(this.mbTitle);
            this.statsPanel.Location = new System.Drawing.Point(175, 12);
            this.statsPanel.Name = "statsPanel";
            this.statsPanel.Size = new System.Drawing.Size(559, 467);
            this.statsPanel.TabIndex = 9;
            // 
            // mbVersion
            // 
            this.mbVersion.AutoSize = true;
            this.mbVersion.Location = new System.Drawing.Point(187, 44);
            this.mbVersion.Name = "mbVersion";
            this.mbVersion.Size = new System.Drawing.Size(91, 13);
            this.mbVersion.TabIndex = 1;
            this.mbVersion.Text = "undefined version";
            // 
            // mbTitle
            // 
            this.mbTitle.AutoSize = true;
            this.mbTitle.Font = new System.Drawing.Font("Roboto Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mbTitle.Location = new System.Drawing.Point(16, 23);
            this.mbTitle.Name = "mbTitle";
            this.mbTitle.Size = new System.Drawing.Size(176, 43);
            this.mbTitle.TabIndex = 0;
            this.mbTitle.Text = "modbrowser";
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
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(195)))), ((int)(((byte)(74)))));
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(159)))), ((int)(((byte)(56)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(505, 413);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(38, 28);
            this.button3.TabIndex = 8;
            this.button3.Text = "+1";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.plusoneButton);
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
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(0)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Roboto Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(426, 63);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 29);
            this.button2.TabIndex = 6;
            this.button2.Text = "METTRE À JOUR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.updateButton);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Roboto Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(426, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 29);
            this.button1.TabIndex = 5;
            this.button1.Text = "DÉSINSTALLER";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.uninstall);
            // 
            // modIcon
            // 
            this.modIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(85)))), ((int)(((byte)(72)))));
            this.modIcon.Location = new System.Drawing.Point(19, 34);
            this.modIcon.Name = "modIcon";
            this.modIcon.Size = new System.Drawing.Size(64, 64);
            this.modIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.modIcon.TabIndex = 4;
            this.modIcon.TabStop = false;
            // 
            // statsButton
            // 
            this.statsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(195)))), ((int)(((byte)(74)))));
            this.statsButton.Enabled = false;
            this.statsButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(159)))), ((int)(((byte)(56)))));
            this.statsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statsButton.Font = new System.Drawing.Font("Roboto Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statsButton.Location = new System.Drawing.Point(12, 420);
            this.statsButton.Name = "statsButton";
            this.statsButton.Size = new System.Drawing.Size(150, 29);
            this.statsButton.TabIndex = 7;
            this.statsButton.Text = "STATISTIQUES";
            this.statsButton.UseVisualStyleBackColor = false;
            this.statsButton.Click += new System.EventHandler(this.installButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(85)))), ((int)(((byte)(72)))));
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.statsPanel);
            this.Controls.Add(this.statsButton);
            this.Controls.Add(this.modlist);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.modInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menu;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "modbrowser";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.modInfo.ResumeLayout(false);
            this.modInfo.PerformLayout();
            this.statsPanel.ResumeLayout(false);
            this.statsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem nouveauToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aProposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modBrowserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minecraftToolStripMenuItem;
        private System.Windows.Forms.ListBox modlist;
        private System.Windows.Forms.Panel modInfo;
        private System.Windows.Forms.Label modAuthor;
        private System.Windows.Forms.Label modTitle;
        private System.Windows.Forms.PictureBox modIcon;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox modDescription;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel statsPanel;
        private System.Windows.Forms.Label mbTitle;
        private System.Windows.Forms.Label mbVersion;
        private System.Windows.Forms.Button statsButton;
    }
}

