namespace DirectoryAndFilesForeverPolPuiggros
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.groupBoxSort = new System.Windows.Forms.GroupBox();
            this.radioButtonSortDescending = new System.Windows.Forms.RadioButton();
            this.radioButtonSortAscending = new System.Windows.Forms.RadioButton();
            this.comboBoxSort = new System.Windows.Forms.ComboBox();
            this.groupBoxFilter = new System.Windows.Forms.GroupBox();
            this.buttonClearFilters = new System.Windows.Forms.Button();
            this.buttonApplyFilters = new System.Windows.Forms.Button();
            this.groupBoxDate = new System.Windows.Forms.GroupBox();
            this.buttonResetDate = new System.Windows.Forms.Button();
            this.radioButtonBeforeDate = new System.Windows.Forms.RadioButton();
            this.radioButtonAfterDate = new System.Windows.Forms.RadioButton();
            this.dateTimePickerFilterDate = new System.Windows.Forms.DateTimePicker();
            this.groupBoxFilterExtension = new System.Windows.Forms.GroupBox();
            this.comboBoxFileExtension = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxFilterShow = new System.Windows.Forms.GroupBox();
            this.radioButtonFilterShowFiles = new System.Windows.Forms.RadioButton();
            this.radioButtonFilterShowDirectories = new System.Windows.Forms.RadioButton();
            this.radioButtonFilterShowAll = new System.Windows.Forms.RadioButton();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonCreateDirectory = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonWriteJSON = new System.Windows.Forms.Button();
            this.buttonReadJSON = new System.Windows.Forms.Button();
            this.buttonCreateFile = new System.Windows.Forms.Button();
            this.textBoxDirectoriActual = new System.Windows.Forms.TextBox();
            this.IconList = new System.Windows.Forms.ImageList(this.components);
            this.listViewSubdirectoriesAndFiles = new System.Windows.Forms.ListView();
            this.buttonGoBack = new System.Windows.Forms.Button();
            this.buttonRename = new System.Windows.Forms.Button();
            this.groupBoxSort.SuspendLayout();
            this.groupBoxFilter.SuspendLayout();
            this.groupBoxDate.SuspendLayout();
            this.groupBoxFilterExtension.SuspendLayout();
            this.groupBoxFilterShow.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxSort
            // 
            this.groupBoxSort.Controls.Add(this.radioButtonSortDescending);
            this.groupBoxSort.Controls.Add(this.radioButtonSortAscending);
            this.groupBoxSort.Controls.Add(this.comboBoxSort);
            this.groupBoxSort.Font = new System.Drawing.Font("Miriam Libre", 22.2F);
            this.groupBoxSort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(228)))), ((int)(((byte)(140)))));
            this.groupBoxSort.Location = new System.Drawing.Point(25, 69);
            this.groupBoxSort.Name = "groupBoxSort";
            this.groupBoxSort.Size = new System.Drawing.Size(369, 139);
            this.groupBoxSort.TabIndex = 2;
            this.groupBoxSort.TabStop = false;
            this.groupBoxSort.Text = "Sort";
            // 
            // radioButtonSortDescending
            // 
            this.radioButtonSortDescending.AutoSize = true;
            this.radioButtonSortDescending.Checked = true;
            this.radioButtonSortDescending.Font = new System.Drawing.Font("Miriam Libre", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonSortDescending.Location = new System.Drawing.Point(40, 99);
            this.radioButtonSortDescending.Name = "radioButtonSortDescending";
            this.radioButtonSortDescending.Size = new System.Drawing.Size(143, 30);
            this.radioButtonSortDescending.TabIndex = 5;
            this.radioButtonSortDescending.TabStop = true;
            this.radioButtonSortDescending.Text = "Descending";
            this.radioButtonSortDescending.UseVisualStyleBackColor = true;
            this.radioButtonSortDescending.CheckedChanged += new System.EventHandler(this.radioButtonSortDescending_CheckedChanged);
            // 
            // radioButtonSortAscending
            // 
            this.radioButtonSortAscending.AutoSize = true;
            this.radioButtonSortAscending.Font = new System.Drawing.Font("Miriam Libre", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonSortAscending.Location = new System.Drawing.Point(208, 99);
            this.radioButtonSortAscending.Name = "radioButtonSortAscending";
            this.radioButtonSortAscending.Size = new System.Drawing.Size(131, 30);
            this.radioButtonSortAscending.TabIndex = 4;
            this.radioButtonSortAscending.Text = "Ascending";
            this.radioButtonSortAscending.UseVisualStyleBackColor = true;
            this.radioButtonSortAscending.CheckedChanged += new System.EventHandler(this.radioButtonSortAscending_CheckedChanged);
            // 
            // comboBoxSort
            // 
            this.comboBoxSort.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBoxSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSort.FormattingEnabled = true;
            this.comboBoxSort.Location = new System.Drawing.Point(38, 55);
            this.comboBoxSort.Name = "comboBoxSort";
            this.comboBoxSort.Size = new System.Drawing.Size(177, 33);
            this.comboBoxSort.TabIndex = 3;
            this.comboBoxSort.SelectedIndexChanged += new System.EventHandler(this.comboBoxSort_SelectedIndexChanged);
            // 
            // groupBoxFilter
            // 
            this.groupBoxFilter.Controls.Add(this.buttonClearFilters);
            this.groupBoxFilter.Controls.Add(this.buttonApplyFilters);
            this.groupBoxFilter.Controls.Add(this.groupBoxDate);
            this.groupBoxFilter.Controls.Add(this.groupBoxFilterExtension);
            this.groupBoxFilter.Controls.Add(this.groupBoxFilterShow);
            this.groupBoxFilter.Font = new System.Drawing.Font("Miriam Libre", 22.2F);
            this.groupBoxFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(228)))), ((int)(((byte)(140)))));
            this.groupBoxFilter.Location = new System.Drawing.Point(25, 214);
            this.groupBoxFilter.Name = "groupBoxFilter";
            this.groupBoxFilter.Size = new System.Drawing.Size(369, 492);
            this.groupBoxFilter.TabIndex = 3;
            this.groupBoxFilter.TabStop = false;
            this.groupBoxFilter.Text = "Filter";
            // 
            // buttonClearFilters
            // 
            this.buttonClearFilters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(228)))), ((int)(((byte)(140)))));
            this.buttonClearFilters.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClearFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearFilters.Font = new System.Drawing.Font("Miriam Libre", 16.2F);
            this.buttonClearFilters.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(106)))), ((int)(((byte)(79)))));
            this.buttonClearFilters.Location = new System.Drawing.Point(22, 432);
            this.buttonClearFilters.Name = "buttonClearFilters";
            this.buttonClearFilters.Size = new System.Drawing.Size(145, 44);
            this.buttonClearFilters.TabIndex = 5;
            this.buttonClearFilters.Text = "Clear";
            this.buttonClearFilters.UseVisualStyleBackColor = false;
            this.buttonClearFilters.Click += new System.EventHandler(this.buttonClearFilters_Click);
            // 
            // buttonApplyFilters
            // 
            this.buttonApplyFilters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(106)))), ((int)(((byte)(79)))));
            this.buttonApplyFilters.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonApplyFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonApplyFilters.Font = new System.Drawing.Font("Miriam Libre", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonApplyFilters.Location = new System.Drawing.Point(173, 432);
            this.buttonApplyFilters.Name = "buttonApplyFilters";
            this.buttonApplyFilters.Size = new System.Drawing.Size(166, 44);
            this.buttonApplyFilters.TabIndex = 4;
            this.buttonApplyFilters.Text = "Apply";
            this.buttonApplyFilters.UseVisualStyleBackColor = false;
            this.buttonApplyFilters.Click += new System.EventHandler(this.buttonApplyFilters_Click);
            // 
            // groupBoxDate
            // 
            this.groupBoxDate.Controls.Add(this.buttonResetDate);
            this.groupBoxDate.Controls.Add(this.radioButtonBeforeDate);
            this.groupBoxDate.Controls.Add(this.radioButtonAfterDate);
            this.groupBoxDate.Controls.Add(this.dateTimePickerFilterDate);
            this.groupBoxDate.Font = new System.Drawing.Font("Miriam Libre", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDate.ForeColor = System.Drawing.Color.White;
            this.groupBoxDate.Location = new System.Drawing.Point(22, 151);
            this.groupBoxDate.Name = "groupBoxDate";
            this.groupBoxDate.Size = new System.Drawing.Size(317, 169);
            this.groupBoxDate.TabIndex = 3;
            this.groupBoxDate.TabStop = false;
            this.groupBoxDate.Text = "Date";
            // 
            // buttonResetDate
            // 
            this.buttonResetDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(106)))), ((int)(((byte)(79)))));
            this.buttonResetDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonResetDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonResetDate.Font = new System.Drawing.Font("Miriam Libre", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonResetDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(228)))), ((int)(((byte)(140)))));
            this.buttonResetDate.Location = new System.Drawing.Point(206, 30);
            this.buttonResetDate.Name = "buttonResetDate";
            this.buttonResetDate.Size = new System.Drawing.Size(100, 54);
            this.buttonResetDate.TabIndex = 3;
            this.buttonResetDate.Text = "Clear Date";
            this.buttonResetDate.UseVisualStyleBackColor = false;
            this.buttonResetDate.Click += new System.EventHandler(this.buttonResetDate_Click);
            // 
            // radioButtonBeforeDate
            // 
            this.radioButtonBeforeDate.AutoSize = true;
            this.radioButtonBeforeDate.Font = new System.Drawing.Font("Miriam Libre", 10.8F);
            this.radioButtonBeforeDate.Location = new System.Drawing.Point(13, 121);
            this.radioButtonBeforeDate.Name = "radioButtonBeforeDate";
            this.radioButtonBeforeDate.Size = new System.Drawing.Size(209, 28);
            this.radioButtonBeforeDate.TabIndex = 2;
            this.radioButtonBeforeDate.Text = "Before Selected Date";
            this.radioButtonBeforeDate.UseVisualStyleBackColor = true;
            // 
            // radioButtonAfterDate
            // 
            this.radioButtonAfterDate.AutoSize = true;
            this.radioButtonAfterDate.Font = new System.Drawing.Font("Miriam Libre", 10.8F);
            this.radioButtonAfterDate.Location = new System.Drawing.Point(13, 87);
            this.radioButtonAfterDate.Name = "radioButtonAfterDate";
            this.radioButtonAfterDate.Size = new System.Drawing.Size(198, 28);
            this.radioButtonAfterDate.TabIndex = 1;
            this.radioButtonAfterDate.Text = "After Selected Date";
            this.radioButtonAfterDate.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerFilterDate
            // 
            this.dateTimePickerFilterDate.CalendarFont = new System.Drawing.Font("Miriam Libre", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFilterDate.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke;
            this.dateTimePickerFilterDate.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dateTimePickerFilterDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFilterDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFilterDate.Location = new System.Drawing.Point(13, 43);
            this.dateTimePickerFilterDate.Name = "dateTimePickerFilterDate";
            this.dateTimePickerFilterDate.Size = new System.Drawing.Size(177, 30);
            this.dateTimePickerFilterDate.TabIndex = 0;
            this.dateTimePickerFilterDate.Value = new System.DateTime(2022, 10, 26, 9, 41, 38, 0);
            this.dateTimePickerFilterDate.Enter += new System.EventHandler(this.dateTimePickerFilterDate_Enter);
            // 
            // groupBoxFilterExtension
            // 
            this.groupBoxFilterExtension.Controls.Add(this.comboBoxFileExtension);
            this.groupBoxFilterExtension.Controls.Add(this.label1);
            this.groupBoxFilterExtension.Font = new System.Drawing.Font("Miriam Libre", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFilterExtension.ForeColor = System.Drawing.Color.White;
            this.groupBoxFilterExtension.Location = new System.Drawing.Point(22, 326);
            this.groupBoxFilterExtension.Name = "groupBoxFilterExtension";
            this.groupBoxFilterExtension.Size = new System.Drawing.Size(317, 100);
            this.groupBoxFilterExtension.TabIndex = 2;
            this.groupBoxFilterExtension.TabStop = false;
            this.groupBoxFilterExtension.Text = "Extension";
            // 
            // comboBoxFileExtension
            // 
            this.comboBoxFileExtension.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBoxFileExtension.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFileExtension.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.comboBoxFileExtension.FormattingEnabled = true;
            this.comboBoxFileExtension.Location = new System.Drawing.Point(182, 42);
            this.comboBoxFileExtension.Name = "comboBoxFileExtension";
            this.comboBoxFileExtension.Size = new System.Drawing.Size(114, 34);
            this.comboBoxFileExtension.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "File Extension:";
            // 
            // groupBoxFilterShow
            // 
            this.groupBoxFilterShow.Controls.Add(this.radioButtonFilterShowFiles);
            this.groupBoxFilterShow.Controls.Add(this.radioButtonFilterShowDirectories);
            this.groupBoxFilterShow.Controls.Add(this.radioButtonFilterShowAll);
            this.groupBoxFilterShow.Font = new System.Drawing.Font("Miriam Libre", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFilterShow.ForeColor = System.Drawing.Color.White;
            this.groupBoxFilterShow.Location = new System.Drawing.Point(22, 45);
            this.groupBoxFilterShow.Name = "groupBoxFilterShow";
            this.groupBoxFilterShow.Size = new System.Drawing.Size(317, 100);
            this.groupBoxFilterShow.TabIndex = 1;
            this.groupBoxFilterShow.TabStop = false;
            this.groupBoxFilterShow.Text = "Show";
            // 
            // radioButtonFilterShowFiles
            // 
            this.radioButtonFilterShowFiles.AutoSize = true;
            this.radioButtonFilterShowFiles.Font = new System.Drawing.Font("Miriam Libre", 12F);
            this.radioButtonFilterShowFiles.Location = new System.Drawing.Point(228, 42);
            this.radioButtonFilterShowFiles.Name = "radioButtonFilterShowFiles";
            this.radioButtonFilterShowFiles.Size = new System.Drawing.Size(78, 30);
            this.radioButtonFilterShowFiles.TabIndex = 2;
            this.radioButtonFilterShowFiles.Text = "Files";
            this.radioButtonFilterShowFiles.UseVisualStyleBackColor = true;
            // 
            // radioButtonFilterShowDirectories
            // 
            this.radioButtonFilterShowDirectories.AutoSize = true;
            this.radioButtonFilterShowDirectories.Font = new System.Drawing.Font("Miriam Libre", 12F);
            this.radioButtonFilterShowDirectories.Location = new System.Drawing.Point(81, 42);
            this.radioButtonFilterShowDirectories.Name = "radioButtonFilterShowDirectories";
            this.radioButtonFilterShowDirectories.Size = new System.Drawing.Size(141, 30);
            this.radioButtonFilterShowDirectories.TabIndex = 1;
            this.radioButtonFilterShowDirectories.Text = "Directories";
            this.radioButtonFilterShowDirectories.UseVisualStyleBackColor = true;
            // 
            // radioButtonFilterShowAll
            // 
            this.radioButtonFilterShowAll.AutoSize = true;
            this.radioButtonFilterShowAll.Checked = true;
            this.radioButtonFilterShowAll.Font = new System.Drawing.Font("Miriam Libre", 12F);
            this.radioButtonFilterShowAll.Location = new System.Drawing.Point(16, 42);
            this.radioButtonFilterShowAll.Name = "radioButtonFilterShowAll";
            this.radioButtonFilterShowAll.Size = new System.Drawing.Size(59, 30);
            this.radioButtonFilterShowAll.TabIndex = 0;
            this.radioButtonFilterShowAll.TabStop = true;
            this.radioButtonFilterShowAll.Text = "All";
            this.radioButtonFilterShowAll.UseVisualStyleBackColor = true;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Miriam Libre", 22.2F);
            this.labelName.ForeColor = System.Drawing.Color.White;
            this.labelName.Location = new System.Drawing.Point(409, 641);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(123, 49);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Name";
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(531, 651);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(259, 34);
            this.textBoxName.TabIndex = 5;
            // 
            // buttonCreateDirectory
            // 
            this.buttonCreateDirectory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(106)))), ((int)(((byte)(79)))));
            this.buttonCreateDirectory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCreateDirectory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateDirectory.Font = new System.Drawing.Font("Miriam Libre", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateDirectory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(228)))), ((int)(((byte)(140)))));
            this.buttonCreateDirectory.Location = new System.Drawing.Point(1046, 633);
            this.buttonCreateDirectory.Name = "buttonCreateDirectory";
            this.buttonCreateDirectory.Size = new System.Drawing.Size(125, 59);
            this.buttonCreateDirectory.TabIndex = 6;
            this.buttonCreateDirectory.Text = "Create Directory";
            this.buttonCreateDirectory.UseVisualStyleBackColor = false;
            this.buttonCreateDirectory.Click += new System.EventHandler(this.buttonCreateDirectory_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(49)))));
            this.buttonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Miriam Libre", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(228)))), ((int)(((byte)(140)))));
            this.buttonDelete.Location = new System.Drawing.Point(1177, 633);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(125, 59);
            this.buttonDelete.TabIndex = 7;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonWriteJSON
            // 
            this.buttonWriteJSON.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(106)))), ((int)(((byte)(79)))));
            this.buttonWriteJSON.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonWriteJSON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWriteJSON.Font = new System.Drawing.Font("Miriam Libre", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWriteJSON.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(228)))), ((int)(((byte)(140)))));
            this.buttonWriteJSON.Location = new System.Drawing.Point(1222, 92);
            this.buttonWriteJSON.Name = "buttonWriteJSON";
            this.buttonWriteJSON.Size = new System.Drawing.Size(139, 65);
            this.buttonWriteJSON.TabIndex = 8;
            this.buttonWriteJSON.Text = "Write D.Info";
            this.buttonWriteJSON.UseVisualStyleBackColor = false;
            this.buttonWriteJSON.Click += new System.EventHandler(this.buttonWriteJSON_Click);
            // 
            // buttonReadJSON
            // 
            this.buttonReadJSON.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(106)))), ((int)(((byte)(79)))));
            this.buttonReadJSON.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReadJSON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReadJSON.Font = new System.Drawing.Font("Miriam Libre", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReadJSON.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(228)))), ((int)(((byte)(140)))));
            this.buttonReadJSON.Location = new System.Drawing.Point(1222, 173);
            this.buttonReadJSON.Name = "buttonReadJSON";
            this.buttonReadJSON.Size = new System.Drawing.Size(139, 65);
            this.buttonReadJSON.TabIndex = 9;
            this.buttonReadJSON.Text = "Read D.Info";
            this.buttonReadJSON.UseVisualStyleBackColor = false;
            this.buttonReadJSON.Click += new System.EventHandler(this.buttonReadJSON_Click);
            // 
            // buttonCreateFile
            // 
            this.buttonCreateFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(106)))), ((int)(((byte)(79)))));
            this.buttonCreateFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCreateFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateFile.Font = new System.Drawing.Font("Miriam Libre", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(228)))), ((int)(((byte)(140)))));
            this.buttonCreateFile.Location = new System.Drawing.Point(915, 633);
            this.buttonCreateFile.Name = "buttonCreateFile";
            this.buttonCreateFile.Size = new System.Drawing.Size(125, 59);
            this.buttonCreateFile.TabIndex = 11;
            this.buttonCreateFile.Text = "Create File";
            this.buttonCreateFile.UseVisualStyleBackColor = false;
            this.buttonCreateFile.Click += new System.EventHandler(this.buttonCreateFile_Click);
            // 
            // textBoxDirectoriActual
            // 
            this.textBoxDirectoriActual.BackColor = System.Drawing.Color.MintCream;
            this.textBoxDirectoriActual.Enabled = false;
            this.textBoxDirectoriActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDirectoriActual.Location = new System.Drawing.Point(418, 92);
            this.textBoxDirectoriActual.Name = "textBoxDirectoriActual";
            this.textBoxDirectoriActual.ReadOnly = true;
            this.textBoxDirectoriActual.Size = new System.Drawing.Size(786, 36);
            this.textBoxDirectoriActual.TabIndex = 12;
            // 
            // IconList
            // 
            this.IconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("IconList.ImageStream")));
            this.IconList.TransparentColor = System.Drawing.Color.Transparent;
            this.IconList.Images.SetKeyName(0, "folder.png");
            this.IconList.Images.SetKeyName(1, "uknown.png");
            this.IconList.Images.SetKeyName(2, "txt.png");
            this.IconList.Images.SetKeyName(3, "pdf.png");
            this.IconList.Images.SetKeyName(4, "mp3.png");
            this.IconList.Images.SetKeyName(5, "mp4.png");
            this.IconList.Images.SetKeyName(6, "exe.png");
            this.IconList.Images.SetKeyName(7, "png.png");
            this.IconList.Images.SetKeyName(8, "jpg.png");
            this.IconList.Images.SetKeyName(9, "doc.png");
            this.IconList.Images.SetKeyName(10, "iso.png");
            // 
            // listViewSubdirectoriesAndFiles
            // 
            this.listViewSubdirectoriesAndFiles.BackColor = System.Drawing.Color.MintCream;
            this.listViewSubdirectoriesAndFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewSubdirectoriesAndFiles.HideSelection = false;
            this.listViewSubdirectoriesAndFiles.LargeImageList = this.IconList;
            this.listViewSubdirectoriesAndFiles.Location = new System.Drawing.Point(418, 134);
            this.listViewSubdirectoriesAndFiles.MultiSelect = false;
            this.listViewSubdirectoriesAndFiles.Name = "listViewSubdirectoriesAndFiles";
            this.listViewSubdirectoriesAndFiles.Size = new System.Drawing.Size(786, 482);
            this.listViewSubdirectoriesAndFiles.SmallImageList = this.IconList;
            this.listViewSubdirectoriesAndFiles.TabIndex = 13;
            this.listViewSubdirectoriesAndFiles.UseCompatibleStateImageBehavior = false;
            this.listViewSubdirectoriesAndFiles.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listViewSubdirectoriesAndFiles_ItemSelectionChanged);
            // 
            // buttonGoBack
            // 
            this.buttonGoBack.BackgroundImage = global::DirectoryAndFilesForeverPolPuiggros.Properties.Resources.back__1_;
            this.buttonGoBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonGoBack.FlatAppearance.BorderSize = 0;
            this.buttonGoBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGoBack.Location = new System.Drawing.Point(25, 12);
            this.buttonGoBack.Name = "buttonGoBack";
            this.buttonGoBack.Size = new System.Drawing.Size(49, 51);
            this.buttonGoBack.TabIndex = 14;
            this.buttonGoBack.UseVisualStyleBackColor = true;
            this.buttonGoBack.Click += new System.EventHandler(this.buttonGoBack_Click);
            // 
            // buttonRename
            // 
            this.buttonRename.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(106)))), ((int)(((byte)(79)))));
            this.buttonRename.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRename.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRename.Font = new System.Drawing.Font("Miriam Libre", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRename.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(228)))), ((int)(((byte)(140)))));
            this.buttonRename.Location = new System.Drawing.Point(803, 651);
            this.buttonRename.Name = "buttonRename";
            this.buttonRename.Size = new System.Drawing.Size(76, 34);
            this.buttonRename.TabIndex = 15;
            this.buttonRename.Text = "Rename";
            this.buttonRename.UseVisualStyleBackColor = false;
            this.buttonRename.Click += new System.EventHandler(this.buttonRename_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1394, 721);
            this.Controls.Add(this.buttonRename);
            this.Controls.Add(this.buttonGoBack);
            this.Controls.Add(this.listViewSubdirectoriesAndFiles);
            this.Controls.Add(this.textBoxDirectoriActual);
            this.Controls.Add(this.buttonCreateFile);
            this.Controls.Add(this.buttonReadJSON);
            this.Controls.Add(this.buttonWriteJSON);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonCreateDirectory);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.groupBoxFilter);
            this.Controls.Add(this.groupBoxSort);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1412, 768);
            this.MinimumSize = new System.Drawing.Size(1412, 768);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Directory&File";
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBoxSort.ResumeLayout(false);
            this.groupBoxSort.PerformLayout();
            this.groupBoxFilter.ResumeLayout(false);
            this.groupBoxDate.ResumeLayout(false);
            this.groupBoxDate.PerformLayout();
            this.groupBoxFilterExtension.ResumeLayout(false);
            this.groupBoxFilterExtension.PerformLayout();
            this.groupBoxFilterShow.ResumeLayout(false);
            this.groupBoxFilterShow.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxSort;
        private System.Windows.Forms.RadioButton radioButtonSortDescending;
        private System.Windows.Forms.RadioButton radioButtonSortAscending;
        private System.Windows.Forms.ComboBox comboBoxSort;
        private System.Windows.Forms.GroupBox groupBoxFilter;
        private System.Windows.Forms.GroupBox groupBoxFilterShow;
        private System.Windows.Forms.RadioButton radioButtonFilterShowFiles;
        private System.Windows.Forms.RadioButton radioButtonFilterShowDirectories;
        private System.Windows.Forms.RadioButton radioButtonFilterShowAll;
        private System.Windows.Forms.GroupBox groupBoxFilterExtension;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxDate;
        private System.Windows.Forms.RadioButton radioButtonBeforeDate;
        private System.Windows.Forms.RadioButton radioButtonAfterDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerFilterDate;
        private System.Windows.Forms.ComboBox comboBoxFileExtension;
        private System.Windows.Forms.Button buttonApplyFilters;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonCreateDirectory;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonResetDate;
        private System.Windows.Forms.Button buttonWriteJSON;
        private System.Windows.Forms.Button buttonReadJSON;
        private System.Windows.Forms.Button buttonCreateFile;
        private System.Windows.Forms.TextBox textBoxDirectoriActual;
        private System.Windows.Forms.ImageList IconList;
        private System.Windows.Forms.ListView listViewSubdirectoriesAndFiles;
        private System.Windows.Forms.Button buttonGoBack;
        private System.Windows.Forms.Button buttonClearFilters;
        private System.Windows.Forms.Button buttonRename;
    }
}