namespace modbrowser
{
    partial class Plugins
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
            this.pluginsList = new System.Windows.Forms.ListBox();
            this.name = new System.Windows.Forms.Panel();
            this.game = new System.Windows.Forms.GroupBox();
            this.resourcePath = new System.Windows.Forms.Label();
            this.gameName = new System.Windows.Forms.Label();
            this.api = new System.Windows.Forms.GroupBox();
            this.APIurl = new System.Windows.Forms.LinkLabel();
            this.APIversion = new System.Windows.Forms.Label();
            this.Plugin = new System.Windows.Forms.GroupBox();
            this.pluginName = new System.Windows.Forms.Label();
            this.pluginAuthor = new System.Windows.Forms.Label();
            this.pluginVersion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.mainPageButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.gamePath = new System.Windows.Forms.TextBox();
            this.name.SuspendLayout();
            this.game.SuspendLayout();
            this.api.SuspendLayout();
            this.Plugin.SuspendLayout();
            this.SuspendLayout();
            // 
            // pluginsList
            // 
            this.pluginsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pluginsList.Dock = System.Windows.Forms.DockStyle.Left;
            this.pluginsList.Font = new System.Drawing.Font("Roboto Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pluginsList.FormattingEnabled = true;
            this.pluginsList.ItemHeight = 16;
            this.pluginsList.Location = new System.Drawing.Point(0, 0);
            this.pluginsList.Name = "pluginsList";
            this.pluginsList.Size = new System.Drawing.Size(157, 267);
            this.pluginsList.TabIndex = 0;
            this.pluginsList.SelectedIndexChanged += new System.EventHandler(this.pluginsList_SelectedIndexChanged);
            // 
            // name
            // 
            this.name.Controls.Add(this.button1);
            this.name.Controls.Add(this.mainPageButton);
            this.name.Controls.Add(this.game);
            this.name.Controls.Add(this.api);
            this.name.Controls.Add(this.Plugin);
            this.name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.name.Font = new System.Drawing.Font("Roboto Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(157, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(379, 267);
            this.name.TabIndex = 1;
            this.name.Visible = false;
            // 
            // game
            // 
            this.game.Controls.Add(this.gamePath);
            this.game.Controls.Add(this.label6);
            this.game.Controls.Add(this.resourcePath);
            this.game.Controls.Add(this.label7);
            this.game.Controls.Add(this.label8);
            this.game.Controls.Add(this.gameName);
            this.game.Font = new System.Drawing.Font("Roboto Condensed", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.game.Location = new System.Drawing.Point(6, 82);
            this.game.Name = "game";
            this.game.Size = new System.Drawing.Size(370, 93);
            this.game.TabIndex = 6;
            this.game.TabStop = false;
            this.game.Text = "Jeu";
            // 
            // resourcePath
            // 
            this.resourcePath.AutoSize = true;
            this.resourcePath.Font = new System.Drawing.Font("Roboto Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resourcePath.Location = new System.Drawing.Point(128, 61);
            this.resourcePath.Name = "resourcePath";
            this.resourcePath.Size = new System.Drawing.Size(76, 16);
            this.resourcePath.TabIndex = 9;
            this.resourcePath.Text = "resourcesPath";
            // 
            // gameName
            // 
            this.gameName.AutoSize = true;
            this.gameName.Font = new System.Drawing.Font("Roboto Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameName.Location = new System.Drawing.Point(56, 19);
            this.gameName.Name = "gameName";
            this.gameName.Size = new System.Drawing.Size(34, 16);
            this.gameName.TabIndex = 0;
            this.gameName.Text = "name";
            // 
            // api
            // 
            this.api.Controls.Add(this.label4);
            this.api.Controls.Add(this.label5);
            this.api.Controls.Add(this.APIurl);
            this.api.Controls.Add(this.APIversion);
            this.api.Font = new System.Drawing.Font("Roboto Condensed", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.api.Location = new System.Drawing.Point(194, 3);
            this.api.Name = "api";
            this.api.Size = new System.Drawing.Size(182, 73);
            this.api.TabIndex = 6;
            this.api.TabStop = false;
            this.api.Text = "API";
            // 
            // APIurl
            // 
            this.APIurl.AutoSize = true;
            this.APIurl.Font = new System.Drawing.Font("Roboto Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.APIurl.Location = new System.Drawing.Point(65, 19);
            this.APIurl.Name = "APIurl";
            this.APIurl.Size = new System.Drawing.Size(21, 16);
            this.APIurl.TabIndex = 2;
            this.APIurl.TabStop = true;
            this.APIurl.Text = "url";
            this.APIurl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.APIurl_LinkClicked);
            // 
            // APIversion
            // 
            this.APIversion.AutoSize = true;
            this.APIversion.Font = new System.Drawing.Font("Roboto Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.APIversion.Location = new System.Drawing.Point(63, 32);
            this.APIversion.Name = "APIversion";
            this.APIversion.Size = new System.Drawing.Size(42, 16);
            this.APIversion.TabIndex = 0;
            this.APIversion.Text = "version";
            // 
            // Plugin
            // 
            this.Plugin.Controls.Add(this.label1);
            this.Plugin.Controls.Add(this.label2);
            this.Plugin.Controls.Add(this.label3);
            this.Plugin.Controls.Add(this.pluginName);
            this.Plugin.Controls.Add(this.pluginAuthor);
            this.Plugin.Controls.Add(this.pluginVersion);
            this.Plugin.Font = new System.Drawing.Font("Roboto Condensed", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Plugin.Location = new System.Drawing.Point(6, 3);
            this.Plugin.Name = "Plugin";
            this.Plugin.Size = new System.Drawing.Size(182, 73);
            this.Plugin.TabIndex = 5;
            this.Plugin.TabStop = false;
            this.Plugin.Text = "Plugin";
            // 
            // pluginName
            // 
            this.pluginName.AutoSize = true;
            this.pluginName.Font = new System.Drawing.Font("Roboto Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pluginName.Location = new System.Drawing.Point(53, 32);
            this.pluginName.Name = "pluginName";
            this.pluginName.Size = new System.Drawing.Size(34, 16);
            this.pluginName.TabIndex = 0;
            this.pluginName.Text = "name";
            // 
            // pluginAuthor
            // 
            this.pluginAuthor.AutoSize = true;
            this.pluginAuthor.Font = new System.Drawing.Font("Roboto Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pluginAuthor.Location = new System.Drawing.Point(65, 19);
            this.pluginAuthor.Name = "pluginAuthor";
            this.pluginAuthor.Size = new System.Drawing.Size(40, 16);
            this.pluginAuthor.TabIndex = 1;
            this.pluginAuthor.Text = "author";
            // 
            // pluginVersion
            // 
            this.pluginVersion.AutoSize = true;
            this.pluginVersion.Font = new System.Drawing.Font("Roboto Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pluginVersion.Location = new System.Drawing.Point(71, 45);
            this.pluginVersion.Name = "pluginVersion";
            this.pluginVersion.Size = new System.Drawing.Size(42, 16);
            this.pluginVersion.TabIndex = 2;
            this.pluginVersion.Text = "version";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Condensed", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nom :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Condensed", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Auteur :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Condensed", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Version :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto Condensed", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Version :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto Condensed", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Adresse :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto Condensed", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Nom :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto Condensed", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Chemin :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Roboto Condensed", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "Chemin du contenu :";
            // 
            // mainPageButton
            // 
            this.mainPageButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(195)))), ((int)(((byte)(74)))));
            this.mainPageButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(159)))), ((int)(((byte)(56)))));
            this.mainPageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainPageButton.Font = new System.Drawing.Font("Roboto Condensed", 9F);
            this.mainPageButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.mainPageButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.mainPageButton.Location = new System.Drawing.Point(217, 181);
            this.mainPageButton.Name = "mainPageButton";
            this.mainPageButton.Size = new System.Drawing.Size(150, 29);
            this.mainPageButton.TabIndex = 8;
            this.mainPageButton.Text = "ENREGISTRER";
            this.mainPageButton.UseVisualStyleBackColor = false;
            this.mainPageButton.Click += new System.EventHandler(this.mainPageButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Roboto Condensed", 9F);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(217, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 29);
            this.button1.TabIndex = 9;
            this.button1.Text = "SUPPRIMER";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gamePath
            // 
            this.gamePath.Font = new System.Drawing.Font("Roboto Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gamePath.Location = new System.Drawing.Point(68, 35);
            this.gamePath.Name = "gamePath";
            this.gamePath.Size = new System.Drawing.Size(293, 23);
            this.gamePath.TabIndex = 10;
            // 
            // Plugins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 267);
            this.Controls.Add(this.name);
            this.Controls.Add(this.pluginsList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(552, 306);
            this.MinimumSize = new System.Drawing.Size(552, 306);
            this.Name = "Plugins";
            this.Text = "Plugins";
            this.Load += new System.EventHandler(this.Plugins_Load);
            this.name.ResumeLayout(false);
            this.game.ResumeLayout(false);
            this.game.PerformLayout();
            this.api.ResumeLayout(false);
            this.api.PerformLayout();
            this.Plugin.ResumeLayout(false);
            this.Plugin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox pluginsList;
        private System.Windows.Forms.Panel name;
        private System.Windows.Forms.GroupBox game;
        private System.Windows.Forms.Label gameName;
        private System.Windows.Forms.GroupBox api;
        private System.Windows.Forms.Label APIversion;
        private System.Windows.Forms.GroupBox Plugin;
        private System.Windows.Forms.Label pluginName;
        private System.Windows.Forms.Label pluginAuthor;
        private System.Windows.Forms.Label pluginVersion;
        private System.Windows.Forms.Label resourcePath;
        private System.Windows.Forms.LinkLabel APIurl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button mainPageButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox gamePath;

    }
}