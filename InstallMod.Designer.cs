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
            this.hashInfo = new System.Windows.Forms.Label();
            this.hashTextBox = new System.Windows.Forms.TextBox();
            this.hashBox = new System.Windows.Forms.GroupBox();
            this.invalidHash = new System.Windows.Forms.Label();
            this.installButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.hashBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // hashInfo
            // 
            this.hashInfo.Font = new System.Drawing.Font("Roboto Condensed Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hashInfo.Location = new System.Drawing.Point(71, 9);
            this.hashInfo.Name = "hashInfo";
            this.hashInfo.Size = new System.Drawing.Size(357, 50);
            this.hashInfo.TabIndex = 0;
            this.hashInfo.Text = resources.GetString("hashInfo.Text");
            this.hashInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // hashTextBox
            // 
            this.hashTextBox.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hashTextBox.Location = new System.Drawing.Point(43, 32);
            this.hashTextBox.MaxLength = 40;
            this.hashTextBox.Name = "hashTextBox";
            this.hashTextBox.Size = new System.Drawing.Size(338, 29);
            this.hashTextBox.TabIndex = 1;
            this.hashTextBox.Text = "entrez le HASH ici";
            this.hashTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.hashTextBox.Click += new System.EventHandler(this.hashBoxClicked);
            this.hashTextBox.TextChanged += new System.EventHandler(this.hashBoxChanged);
            // 
            // hashBox
            // 
            this.hashBox.Controls.Add(this.invalidHash);
            this.hashBox.Controls.Add(this.installButton);
            this.hashBox.Controls.Add(this.hashTextBox);
            this.hashBox.Font = new System.Drawing.Font("Roboto Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hashBox.Location = new System.Drawing.Point(15, 73);
            this.hashBox.Name = "hashBox";
            this.hashBox.Size = new System.Drawing.Size(412, 111);
            this.hashBox.TabIndex = 2;
            this.hashBox.TabStop = false;
            this.hashBox.Text = "Entrer le HASH";
            // 
            // invalidHash
            // 
            this.invalidHash.AutoSize = true;
            this.invalidHash.Font = new System.Drawing.Font("Roboto Condensed Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invalidHash.Location = new System.Drawing.Point(49, 73);
            this.invalidHash.Name = "invalidHash";
            this.invalidHash.Size = new System.Drawing.Size(74, 16);
            this.invalidHash.TabIndex = 3;
            this.invalidHash.Text = "HASH invalide.";
            // 
            // installButton
            // 
            this.installButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(195)))), ((int)(((byte)(74)))));
            this.installButton.Enabled = false;
            this.installButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(159)))), ((int)(((byte)(56)))));
            this.installButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.installButton.Font = new System.Drawing.Font("Roboto Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.installButton.Location = new System.Drawing.Point(264, 67);
            this.installButton.Name = "installButton";
            this.installButton.Size = new System.Drawing.Size(117, 29);
            this.installButton.TabIndex = 6;
            this.installButton.Text = "INSTALLER";
            this.installButton.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // InstallMod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 201);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.hashBox);
            this.Controls.Add(this.hashInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "InstallMod";
            this.Text = "Installation de mods";
            this.hashBox.ResumeLayout(false);
            this.hashBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label hashInfo;
        private System.Windows.Forms.TextBox hashTextBox;
        private System.Windows.Forms.GroupBox hashBox;
        private System.Windows.Forms.Button installButton;
        private System.Windows.Forms.Label invalidHash;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}