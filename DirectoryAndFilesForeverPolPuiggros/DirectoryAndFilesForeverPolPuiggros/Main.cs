using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using Newtonsoft.Json.Linq;
using WinFormAnimation;
using static System.Net.Mime.MediaTypeNames;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using File = System.IO.File;
using Path = System.IO.Path;

namespace DirectoryAndFilesForeverPolPuiggros
{
    public partial class Main : Form
    {
        private const String all = "ALL";
        private const String dir = "DIR";
        private const String file = "FILE";

        private string[] typesOfSort = new string[]
        {"Name", "Date", "Type"};

        private string[] fileExtensions = new string[]
        { ".*", ".txt", ".zip", ".pdf", ".mp4", ".mp3",
        ".jpg", ".jpeg", ".doc", ".docx", ".gif", ".png"};

        private DirectoryInfo actualDirectory;
        List<DirFile> currentList = new List<DirFile>();
        List<DirFile> subDirectoriesAndFiles = new List<DirFile>();
        List<DirFile> tempList = new List<DirFile>();
        DirFile selectedItem = new DirFile();
        String jsonFile;

        public Main(DirectoryInfo selectedDirectory)
        {
            InitializeComponent();
            actualDirectory = selectedDirectory;

        }
        private void Main_Load(object sender, EventArgs e)
        {
            //FILL COMBOBOXES AND FIELDS
            fillTypesOfSort();
            fillExtensions();
            defaultValuesFields();
            defaultValuesFieldsFilters();


            // -------------------------
            defaultDisplay();
        }

        private void defaultDisplay()
        {
            listViewSubdirectoriesAndFiles.Items.Clear();
            subDirectoriesAndFiles.Clear();
            getSubdirectoriesAndFiles(all, subDirectoriesAndFiles);
            currentList = subDirectoriesAndFiles;
            currentList = sortElements("Name", "DESC", currentList);
            displaySubdirectoriesAndFiles(currentList);
        }

        //------------------------------------------------------- GET FILES AND SUB --------------------------------------------------------- //

        /** OBTENIR SUBDIRECTORIS I FITXERS I POSAR-LOS A LA LLISTA QUE ES PASSI PER PARÀMETRE **/
        private void getSubdirectoriesAndFiles(String request, List<DirFile> list)
        {
            subDirectoriesAndFiles.Clear();
            switch (request)
            {
                case all:
                    getDirs(list);
                    getFiles(list);
                    break;
                case dir:
                    getDirs(list);
                    break;
                case file:
                    getFiles(list);
                    break;
            }
        }
        private void getDirs(List<DirFile> list)
        {
            foreach (DirectoryInfo subD in actualDirectory.GetDirectories())
            {
                DirFile dirFile = new DirFile();
                dirFile.name = subD.Name;
                dirFile.fullName = subD.FullName;
                dirFile.creationDateTime = subD.CreationTime;
                dirFile.extension = subD.Extension;
                list.Add(dirFile);
            }
        }
        private void getFiles(List<DirFile> list)
        {
            foreach (FileInfo file in actualDirectory.GetFiles())
            {
                DirFile dirFile = new DirFile();
                dirFile.name = file.Name;
                dirFile.fullName = file.FullName;
                dirFile.creationDateTime = file.CreationTime;
                dirFile.extension = file.Extension;
                list.Add(dirFile);
            }
        }

        /**MOSTRAR A LA LISTVIEW TOTS ELS SUBELEMENTS DEL DIRECTORI**/
        private void displaySubdirectoriesAndFiles(List<DirFile> list)
        {
            string ext;
            listViewSubdirectoriesAndFiles.Clear();
            foreach (DirFile item in list)
            {
                if (isAFile(item))
                {
                    ext = Path.GetExtension(item.fullName);
                    DisplayIcons(ext, item);
                }
                else
                {
                    listViewSubdirectoriesAndFiles.Items.Add(item.name, 0);
                }

            }
        }

        //------------------------------------------------------- SORT --------------------------------------------------------- //
        private void comboBoxSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentList = sortElements(comboBoxSort.Text, rbSort(), currentList);
        }
        private void radioButtonSortDescending_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonSortAscending.Checked)
            {
                currentList = sortElements(comboBoxSort.Text, rbSort(), currentList);
            }
        }

        private void radioButtonSortAscending_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonSortDescending.Checked)
            {
                currentList = sortElements(comboBoxSort.Text, rbSort(), currentList);
            }
        }
        private List<DirFile> sortElements(string typeOfSort, string order, List<DirFile> currentList)
        {
            List<DirFile> sorted = new List<DirFile>();
            switch (typeOfSort)
            {
                case "Name":
                    if (order == "ASC")
                    {
                        sorted = currentList.OrderByDescending(f => f.name).ToList();
                    }
                    else if (order == "DESC")
                    {
                        sorted = currentList.OrderBy(f => f.name).ToList();
                    }
                    break;

                case "Date":
                    if (order == "ASC")
                    {
                        sorted = currentList.OrderBy(f => f.creationDateTime).ToList();
                    }
                    else if (order == "DESC")
                    {
                        sorted = currentList.OrderByDescending(f => f.creationDateTime).ToList();
                    }
                    break;

                case "Type":
                    if (order == "ASC")
                    {
                        sorted = currentList.OrderByDescending(f => f.extension).ToList();
                    }
                    else if (order == "DESC")
                    {
                        sorted = currentList.OrderBy(f => f.extension).ToList();
                    }
                    break;
            }
            displaySubdirectoriesAndFiles(sorted);
            return sorted;
        }

        //------------------------------------------------------- FILTERS --------------------------------------------------------- //
        // APLICAR ELS FILTRES
        private void buttonApplyFilters_Click(object sender, EventArgs e)
        {
            applyFilters();
        }
        private void applyFilters()
        {
            if (checkFiltersActives()) // SI HI HA ALGUN FILTRE APLICAT
            {
                listViewSubdirectoriesAndFiles.Items.Clear();
                tempList.Clear();
                typeOfFile();
                tempList = dateFilter();
                tempList = filterByExtension();
                currentList = tempList;
                currentList = sortElements(comboBoxSort.Text, rbSort(), currentList);
                displaySubdirectoriesAndFiles(currentList);
            }
            else
            {
                defaultDisplay();
            }
        }
        private string rbSort()
        {
            if (radioButtonSortAscending.Checked) return "ASC";
            else if (radioButtonSortDescending.Checked) return "DESC";
            return "";
        }

        // COMPROVAR QUE HI HA FILTRES ACTIUS
        private bool checkFiltersActives()
        {
            if (radioButtonFilterShowDirectories.Checked || radioButtonFilterShowFiles.Checked || radioButtonFilterShowAll.Checked) return true;
            else if (!dateTimePickerFilterDate.Text.Equals(" ") && (radioButtonBeforeDate.Checked || radioButtonAfterDate.Checked)) return true;
            else if (!comboBoxFileExtension.Text.Equals(".*")) return true;
            return false;
        }

        //FILTRAR PER DIRECTORIS, FITXERS O TOT
        private void typeOfFile()
        {
            if (radioButtonFilterShowDirectories.Checked) getSubdirectoriesAndFiles(dir, tempList);
            else if (radioButtonFilterShowFiles.Checked) getSubdirectoriesAndFiles(file, tempList);
            else { getSubdirectoriesAndFiles(all, tempList); }
        }

        //FILTRE DE LA DATA
        private List<DirFile> dateFilter()
        {
            List<DirFile> filteredData = new List<DirFile>();
            if (!dateTimePickerFilterDate.Text.Equals(" "))
            {
                for (int i = 0; i < tempList.Count; i++)
                {
                    int date = DateTime.Compare(tempList[i].creationDateTime, dateTimePickerFilterDate.Value);
                    if (date <= 0 && radioButtonBeforeDate.Checked)
                    {
                        filteredData.Add(tempList[i]);
                    }
                    else if (date > 0 && radioButtonAfterDate.Checked)
                    {
                        filteredData.Add(tempList[i]);
                    }
                }
                return filteredData;
            }
            return tempList;

        }
        // REINICIAR EL VALOR DE LA DATA A NULL
        private void buttonResetDate_Click(object sender, EventArgs e)
        {
            resetDate();
        }
        private void resetDate()
        {
            dateTimePickerFilterDate.Format = DateTimePickerFormat.Custom;
            dateTimePickerFilterDate.CustomFormat = " ";
            radioButtonAfterDate.Checked = false;
            radioButtonBeforeDate.Checked = false;
        }

        // DATA FORMAT
        private void dateTimePickerFilterDate_Enter(object sender, EventArgs e)
        {
            if (dateTimePickerFilterDate.CustomFormat == " ")
            {
                dateTimePickerFilterDate.Format = DateTimePickerFormat.Custom;
                dateTimePickerFilterDate.CustomFormat = "MM/dd/yyyy";
                dateTimePickerFilterDate.Value = DateTime.Now;
            }
        }

        // FILTRAR PER EXTENSIÓ
        private List<DirFile> filterByExtension()
        {
            List<DirFile> listFilesExtension = new List<DirFile>();
            string extToFilter = comboBoxFileExtension.Text.ToLower();

            for (int i = 0; i < tempList.Count; i++)
            {
                if (tempList[i].extension.Equals(extToFilter))
                {
                    listFilesExtension.Add(tempList[i]);
                }
                else if (extToFilter.Equals(".*"))
                {
                    listFilesExtension.Add(tempList[i]);
                }
            }
            return listFilesExtension;
        }
        //CLEANS ALL THE FILTERS
        private void buttonClearFilters_Click(object sender, EventArgs e)
        {
            defaultValuesFieldsFilters();
        }

        //------------------------------ DEFAULT VALUES & FILL COMBOBOXES ---------------------------------------//
        private void defaultValuesFields()
        {
            textBoxDirectoriActual.Text = actualDirectory.FullName;
            comboBoxSort.Text = "Name";
            comboBoxFileExtension.Text = ".*";
            radioButtonSortDescending.Checked = true;
        }

        private void defaultValuesFieldsFilters()
        {
            dateTimePickerFilterDate.Format = DateTimePickerFormat.Custom;
            dateTimePickerFilterDate.CustomFormat = " ";
            radioButtonFilterShowAll.Checked = true;
            comboBoxFileExtension.Text = ".*";
            resetDate();
        }
        private void fillTypesOfSort()
        {
            foreach (string sortType in typesOfSort)
            {
                comboBoxSort.Items.Add(sortType);
            }
        }

        private void fillExtensions()
        {
            foreach (string extension in fileExtensions)
            {
                comboBoxFileExtension.Items.Add(extension);
            }
        }


        //--------------------------------------------- CREATE, RENAME, DELETE ------------------------------------------ //

        //RENAME THE SELECTED ITEM
        private void buttonRename_Click(object sender, EventArgs e)
        {
            if (someItemSelected())
            {
                if (!textBoxName.Text.Equals(""))
                {
                    currentList.Clear();
                    if (isAFile(selectedItem))
                    {
                        File.Move(selectedItem.fullName, actualDirectory.FullName + "\\" + textBoxName.Text);
                        getSubdirectoriesAndFiles(all, currentList);
                        textBoxName.Text = "";
                    }
                    else
                    {
                        Directory.Move(selectedItem.fullName, actualDirectory.FullName + "\\" + textBoxName.Text);
                        getSubdirectoriesAndFiles(all, currentList);
                        textBoxName.Text = "";
                    }
                    currentList = sortElements(comboBoxSort.Text, rbSort(), currentList);
                    displaySubdirectoriesAndFiles(currentList);
                }
                else
                {
                    MessageBox.Show("Name cannot be empty");
                }
            }
            else
            {
                MessageBox.Show("Select a item to rename", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //CREATES A FILE WITH THE NAME OF THE COMBOBOX
        private void buttonCreateFile_Click(object sender, EventArgs e)
        {
            if (!textBoxName.Text.Equals(""))
            {
                string newFilePath = actualDirectory.FullName + "\\" + textBoxName.Text;
                string ext = Path.GetExtension(newFilePath);
                if (ext.Equals(""))
                {
                    FileStream fs = File.Create(newFilePath + ".txt");
                    fs.Close();
                }
                else
                {
                    FileStream fs = File.Create(newFilePath);
                    fs.Close();
                }
                currentList.Clear();
                textBoxName.Text = "";
                getSubdirectoriesAndFiles(all, currentList);
                currentList = sortElements(comboBoxSort.Text, rbSort(), currentList);
                applyFilters();
                displaySubdirectoriesAndFiles(currentList);
            }
        }

        //CREATES A DIRECTORY WITH THE NAME OF THE COMBOBOX
        private void buttonCreateDirectory_Click(object sender, EventArgs e)
        {
            if (!textBoxName.Text.Equals(""))
            {
                Directory.CreateDirectory(actualDirectory.FullName + "\\" + textBoxName.Text);
                currentList.Clear();
                textBoxName.Text = "";
                getSubdirectoriesAndFiles(all, currentList);
                currentList = sortElements(comboBoxSort.Text, rbSort(), currentList);
                applyFilters();
                displaySubdirectoriesAndFiles(currentList);
            }

        }

        //DELETES THE SELECTED ITEM
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (someItemSelected())
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete the selected item?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    currentList.Clear();
                    if (isAFile(selectedItem))
                    {
                        File.Delete(selectedItem.fullName);
                        textBoxName.Text = "";
                    }
                    else
                    {
                        Directory.Delete(selectedItem.fullName, true);
                        textBoxName.Text = "";
                    }
                    getSubdirectoriesAndFiles(all, currentList);
                    currentList = sortElements(comboBoxSort.Text, rbSort(), currentList);
                    displaySubdirectoriesAndFiles(currentList);
                }
            }
            else
            {
                MessageBox.Show("Select a item to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //------------------------------------------------------- UTILITIES --------------------------------------------------------- //

        //RETURNS TRUE IF THERE IS SOME ITEM SELECTED ON THE LISTVIEW
        private bool someItemSelected()
        {
            if (listViewSubdirectoriesAndFiles.SelectedItems.Count >= 1) return true;
            return false;
        }

        //RETURNS TRUE IF THE PARAMETER IS A FILE
        private bool isAFile(DirFile item)
        {
            if (Directory.Exists(item.fullName)) return false;
            return true;
        }

        //GO TO SECOND ACTIVITY
        private void buttonReadJSON_Click(object sender, EventArgs e)
        {
            ReadDir rDir = new ReadDir(actualDirectory);
            this.Hide();
            rDir.Show();
        }

        //SELECTED ITEM OF THE LISTVIEW
        private void listViewSubdirectoriesAndFiles_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            string selectedItemFullPath = actualDirectory.FullName + @"\" + e.Item.Text;
            string selectedItemName = e.Item.Text;

            textBoxDirectoriActual.Text = selectedItemFullPath;
            textBoxName.Text = selectedItemName;
            selectedItem.fullName = selectedItemFullPath;
            selectedItem.name = selectedItemName;

        }

        //ASSIGNS AN ICON DEPENDING ON THE EXTENSION
        private void DisplayIcons(String ext, DirFile item)
        {
            ext = ext.ToLower();
            switch (ext)
            {
                case ".txt":
                    listViewSubdirectoriesAndFiles.Items.Add(item.name, 2);
                    break;
                case ".pdf":
                    listViewSubdirectoriesAndFiles.Items.Add(item.name, 3);
                    break;
                case ".docx":
                    listViewSubdirectoriesAndFiles.Items.Add(item.name, 9);
                    break;
                case ".doc":
                    listViewSubdirectoriesAndFiles.Items.Add(item.name, 9);
                    break;
                case ".jpg":
                    listViewSubdirectoriesAndFiles.Items.Add(item.name, 8);
                    break;
                case ".jpeg":
                    listViewSubdirectoriesAndFiles.Items.Add(item.name, 8);
                    break;
                case ".png":
                    listViewSubdirectoriesAndFiles.Items.Add(item.name, 7);
                    break;
                case ".exe":
                    listViewSubdirectoriesAndFiles.Items.Add(item.name, 6);
                    break;
                case ".mp3":
                    listViewSubdirectoriesAndFiles.Items.Add(item.name, 4);
                    break;
                case ".mp4":
                    listViewSubdirectoriesAndFiles.Items.Add(item.name, 5);
                    break;
                case ".iso":
                    listViewSubdirectoriesAndFiles.Items.Add(item.name, 10);
                    break;
                default:
                    listViewSubdirectoriesAndFiles.Items.Add(item.name, 1);
                    break;
            }
        }

        //PREVIOUS FORM
        private void buttonGoBack_Click(object sender, EventArgs e)
        {
            DnFF dnFF = new DnFF();
            this.Close();
            dnFF.Show();
        }

        private void buttonWriteJSON_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            try
            {
                saveFile.FileName = "Directory_Info";
                saveFile.Title = "Write the actual directory information";
                saveFile.Filter = "JSON files (*.json)|*.json";
                saveFile.DefaultExt = "json";
                saveFile.AddExtension = true;
                saveFile.FilterIndex = 2;
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    jsonFile = saveFile.FileName;
                    getSubdirectoriesAndFiles(all, subDirectoriesAndFiles);
                    JArray jArraySubdSubf = (JArray) JToken.FromObject(subDirectoriesAndFiles);
                    File.WriteAllText(jsonFile, jArraySubdSubf.ToString());
                }
                
            }
            catch
            {
                MessageBox.Show("Something went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
         
            
            //sfd.InitialDirectory = @"C:\";

        }
    }
}
