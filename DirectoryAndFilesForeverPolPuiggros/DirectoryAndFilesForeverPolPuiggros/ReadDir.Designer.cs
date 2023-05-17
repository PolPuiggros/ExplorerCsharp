namespace DirectoryAndFilesForeverPolPuiggros
{
    partial class ReadDir
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.textBoxJSONFile = new System.Windows.Forms.TextBox();
            this.dataGridViewDirecDetail = new System.Windows.Forms.DataGridView();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonNavigate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDirecDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Miriam Libre", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(74, 19);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(465, 62);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Read Directory Info";
            // 
            // textBoxJSONFile
            // 
            this.textBoxJSONFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(76)))), ((int)(((byte)(66)))));
            this.textBoxJSONFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxJSONFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxJSONFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxJSONFile.Location = new System.Drawing.Point(46, 113);
            this.textBoxJSONFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxJSONFile.Name = "textBoxJSONFile";
            this.textBoxJSONFile.ReadOnly = true;
            this.textBoxJSONFile.Size = new System.Drawing.Size(700, 38);
            this.textBoxJSONFile.TabIndex = 1;
            this.textBoxJSONFile.Text = " Select a JSON file";
            this.textBoxJSONFile.Enter += new System.EventHandler(this.textBoxPathDirectory_Enter);
            this.textBoxJSONFile.Leave += new System.EventHandler(this.textBoxPathDirectory_Leave);
            // 
            // dataGridViewDirecDetail
            // 
            this.dataGridViewDirecDetail.BackgroundColor = System.Drawing.Color.MintCream;
            this.dataGridViewDirecDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDirecDetail.Location = new System.Drawing.Point(46, 191);
            this.dataGridViewDirecDetail.Name = "dataGridViewDirecDetail";
            this.dataGridViewDirecDetail.RowHeadersVisible = false;
            this.dataGridViewDirecDetail.RowHeadersWidth = 51;
            this.dataGridViewDirecDetail.RowTemplate.Height = 24;
            this.dataGridViewDirecDetail.Size = new System.Drawing.Size(991, 493);
            this.dataGridViewDirecDetail.TabIndex = 4;
            // 
            // buttonBack
            // 
            this.buttonBack.BackgroundImage = global::DirectoryAndFilesForeverPolPuiggros.Properties.Resources.back__1_;
            this.buttonBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonBack.FlatAppearance.BorderSize = 0;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Location = new System.Drawing.Point(12, 19);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(49, 51);
            this.buttonBack.TabIndex = 15;
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonNavigate
            // 
            this.buttonNavigate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(101)))));
            this.buttonNavigate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNavigate.FlatAppearance.BorderSize = 0;
            this.buttonNavigate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonNavigate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNavigate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonNavigate.Location = new System.Drawing.Point(762, 113);
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
            // ReadDir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1082, 725);
            this.Controls.Add(this.buttonNavigate);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.dataGridViewDirecDetail);
            this.Controls.Add(this.textBoxJSONFile);
            this.Controls.Add(this.labelTitle);
            this.Name = "ReadDir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Read Directory Info";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDirecDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxJSONFile;
        private System.Windows.Forms.DataGridView dataGridViewDirecDetail;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonNavigate;
    }
}