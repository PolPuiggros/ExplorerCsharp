namespace DirectoryAndFilesForeverPolPuiggros
{
    partial class DnFF
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
            this.textBoxPathDirectory = new System.Windows.Forms.TextBox();
            this.buttonNavigate = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxPathDirectory
            // 
            this.textBoxPathDirectory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(76)))), ((int)(((byte)(66)))));
            this.textBoxPathDirectory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPathDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPathDirectory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxPathDirectory.Location = new System.Drawing.Point(60, 352);
            this.textBoxPathDirectory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPathDirectory.MaximumSize = new System.Drawing.Size(621, 38);
            this.textBoxPathDirectory.MinimumSize = new System.Drawing.Size(621, 38);
            this.textBoxPathDirectory.Name = "textBoxPathDirectory";
            this.textBoxPathDirectory.Size = new System.Drawing.Size(621, 41);
            this.textBoxPathDirectory.TabIndex = 1;
            this.textBoxPathDirectory.Text = "Introduce the path of the directory";
            this.textBoxPathDirectory.Enter += new System.EventHandler(this.textBoxPathDirectory_Enter);
            this.textBoxPathDirectory.Leave += new System.EventHandler(this.textBoxPathDirectory_Leave);
            // 
            // buttonNavigate
            // 
            this.buttonNavigate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(101)))));
            this.buttonNavigate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNavigate.FlatAppearance.BorderSize = 0;
            this.buttonNavigate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonNavigate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNavigate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonNavigate.Location = new System.Drawing.Point(687, 352);
            this.buttonNavigate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonNavigate.MaximumSize = new System.Drawing.Size(123, 47);
            this.buttonNavigate.MinimumSize = new System.Drawing.Size(123, 42);
            this.buttonNavigate.Name = "buttonNavigate";
            this.buttonNavigate.Size = new System.Drawing.Size(123, 44);
            this.buttonNavigate.TabIndex = 0;
            this.buttonNavigate.Text = "Navigate";
            this.buttonNavigate.UseVisualStyleBackColor = false;
            this.buttonNavigate.Click += new System.EventHandler(this.buttonNavigate_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.buttonStart.BackgroundImage = global::DirectoryAndFilesForeverPolPuiggros.Properties.Resources.rightdef;
            this.buttonStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStart.FlatAppearance.BorderSize = 0;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.Location = new System.Drawing.Point(436, 528);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(100, 100);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.buttonClose.BackgroundImage = global::DirectoryAndFilesForeverPolPuiggros.Properties.Resources.close__4_;
            this.buttonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Location = new System.Drawing.Point(945, 12);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(38, 38);
            this.buttonClose.TabIndex = 3;
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // DnFF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(153)))), ((int)(((byte)(200)))));
            this.BackgroundImage = global::DirectoryAndFilesForeverPolPuiggros.Properties.Resources.Directory_FilesForever__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1005, 721);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonNavigate);
            this.Controls.Add(this.textBoxPathDirectory);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DnFF";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Directory&Files";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPathDirectory;
        private System.Windows.Forms.Button buttonNavigate;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonClose;
    }
}