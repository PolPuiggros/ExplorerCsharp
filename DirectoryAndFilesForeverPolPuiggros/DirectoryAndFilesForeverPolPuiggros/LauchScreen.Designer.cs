namespace DirectoryAndFilesForeverPolPuiggros
{
    partial class LauchScreen
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
            this.pictureBoxLogoSplash = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoSplash)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxLogoSplash
            // 
            this.pictureBoxLogoSplash.Image = global::DirectoryAndFilesForeverPolPuiggros.Properties.Resources._829_removebg_preview;
            this.pictureBoxLogoSplash.Location = new System.Drawing.Point(51, 54);
            this.pictureBoxLogoSplash.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxLogoSplash.Name = "pictureBoxLogoSplash";
            this.pictureBoxLogoSplash.Size = new System.Drawing.Size(580, 430);
            this.pictureBoxLogoSplash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogoSplash.TabIndex = 0;
            this.pictureBoxLogoSplash.TabStop = false;
            // 
            // LauchScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(693, 551);
            this.Controls.Add(this.pictureBoxLogoSplash);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LauchScreen";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Shown += new System.EventHandler(this.LauchScreen_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoSplash)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogoSplash;
    }
}

