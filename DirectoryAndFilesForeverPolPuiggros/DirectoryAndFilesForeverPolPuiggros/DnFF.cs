using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace DirectoryAndFilesForeverPolPuiggros
{
    public partial class DnFF : Form
    {
        private const string MESSAGE_DEFAULT = "Introduce the path of the directory";
        DirectoryInfo actualDirectory;

        public DnFF()
        {
            InitializeComponent();
        }

        private void textBoxPathDirectory_Enter(object sender, EventArgs e)
        {
            if (textBoxPathDirectory.Text == MESSAGE_DEFAULT)
            {
                textBoxPathDirectory.Text = "";
                textBoxPathDirectory.Font = new Font(textBoxPathDirectory.Font, FontStyle.Regular);
            }
        }

        private void textBoxPathDirectory_Leave(object sender, EventArgs e)
        {
            if (textBoxPathDirectory.Text == "")
            {
                textBoxPathDirectory.Font = new Font(textBoxPathDirectory.Font, FontStyle.Italic);
                textBoxPathDirectory.Text = MESSAGE_DEFAULT;

            }
        }
        private void buttonNavigate_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fdialog = new FolderBrowserDialog();
            DialogResult result = fdialog.ShowDialog();

            if (result.Equals(DialogResult.OK))
            {
                textBoxPathDirectory.Text = fdialog.SelectedPath;
                actualDirectory = new DirectoryInfo(textBoxPathDirectory.Text);
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            switch (Comprobations(textBoxPathDirectory))
            {
                case 0:
                    MessageBox.Show("Directory Path cannot be empty", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 1:
                    MessageBox.Show("Directory doesn't exists", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case -1:
                    Main form = new Main(actualDirectory);
                    form.Show();
                    this.Hide();
                    break;
            }

        }

        private int Comprobations(TextBox textBox)
        {
            if (textBox.Text.Equals("") || textBox.Text.Equals(MESSAGE_DEFAULT)) return 0; //Is Null
            if (!Directory.Exists(textBox.Text)) return 1; //Directory doesnt exists
            return -1;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
