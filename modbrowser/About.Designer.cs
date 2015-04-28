namespace modbrowser
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.aboutText = new System.Windows.Forms.RichTextBox();
            this.mbVersion = new System.Windows.Forms.Label();
            this.mbTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // aboutText
            // 
            this.aboutText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.aboutText.Location = new System.Drawing.Point(33, 77);
            this.aboutText.Name = "aboutText";
            this.aboutText.ReadOnly = true;
            this.aboutText.Size = new System.Drawing.Size(352, 114);
            this.aboutText.TabIndex = 0;
            this.aboutText.Text = resources.GetString("aboutText.Text");
            // 
            // mbVersion
            // 
            this.mbVersion.AutoSize = true;
            this.mbVersion.Font = new System.Drawing.Font("Roboto Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mbVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.mbVersion.Location = new System.Drawing.Point(196, 39);
            this.mbVersion.Name = "mbVersion";
            this.mbVersion.Size = new System.Drawing.Size(50, 16);
            this.mbVersion.TabIndex = 3;
            this.mbVersion.Text = "à propos";
            // 
            // mbTitle
            // 
            this.mbTitle.AutoSize = true;
            this.mbTitle.Font = new System.Drawing.Font("Roboto Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.mbTitle.Location = new System.Drawing.Point(25, 18);
            this.mbTitle.Name = "mbTitle";
            this.mbTitle.Size = new System.Drawing.Size(176, 43);
            this.mbTitle.TabIndex = 2;
            this.mbTitle.Text = "modbrowser";
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 212);
            this.Controls.Add(this.mbVersion);
            this.Controls.Add(this.mbTitle);
            this.Controls.Add(this.aboutText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "About";
            this.Text = "A propos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox aboutText;
        private System.Windows.Forms.Label mbVersion;
        private System.Windows.Forms.Label mbTitle;
    }
}