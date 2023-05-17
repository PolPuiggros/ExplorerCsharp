using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace DirectoryAndFilesForeverPolPuiggros
{
    public partial class ReadDir : Form
    {
        private const string MESSAGE_DEFAULT = "Select a JSON file";
        string filePath;
        DirectoryInfo actualDirectory;
        List<DirFile> subDandFiles;
        const int WIDTH_COLUMN_NAME = 100;
        const int WIDTH_COLUMN_CREATION = 150;
        const int WIDTH_COLUMN_EXT = 60;

        public ReadDir(DirectoryInfo selectedDirectory)
        {
            InitializeComponent();
            actualDirectory = selectedDirectory;
            textBoxJSONFile.Text = MESSAGE_DEFAULT;
        }


        private void buttonNavigate_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdialog = new OpenFileDialog();
            fdialog.Filter = "json files (*.json)|*.json";
            DialogResult result = fdialog.ShowDialog();

            if (result.Equals(DialogResult.OK))
            {
                filePath = fdialog.FileName;
                textBoxJSONFile.Text = filePath;
                JArray jarraySubdSubf = JArray.Parse(File.ReadAllText(filePath, Encoding.Default));
                subDandFiles =  jarraySubdSubf.ToObject<List<DirFile>>();

                showDatagrid(subDandFiles);
                
            }

        }

        private void showDatagrid(List <DirFile> s)
        {
            //foreach (DataGridViewColumn column in dataGridViewDirecDetail.Columns)
            //{
            //    column.SortMode = DataGridViewColumnSortMode.NotSortable;
            //}
            dataGridViewDirecDetail.RowHeadersVisible = false;
            dataGridViewDirecDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewDirecDetail.DataSource = null;
            dataGridViewDirecDetail.DataSource = s;
            dataGridViewDirecDetail.Columns[0].Width = WIDTH_COLUMN_NAME;
            dataGridViewDirecDetail.Columns[2].Width = WIDTH_COLUMN_CREATION;
            dataGridViewDirecDetail.Columns[3].Width = WIDTH_COLUMN_EXT;
        }

        private void textBoxPathDirectory_Enter(object sender, EventArgs e)
        {
            if (textBoxJSONFile.Text == MESSAGE_DEFAULT)
            {
                textBoxJSONFile.Text = "";
                textBoxJSONFile.Font = new Font(textBoxJSONFile.Font, FontStyle.Regular);
            }
        }

        private void textBoxPathDirectory_Leave(object sender, EventArgs e)
        {
            if (textBoxJSONFile.Text == "")
            {
                textBoxJSONFile.Font = new Font(textBoxJSONFile.Font, FontStyle.Italic);
                textBoxJSONFile.Text = MESSAGE_DEFAULT;

            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Main main = new Main(actualDirectory);
            this.Close();
            main.Show();
        }
    }
}
