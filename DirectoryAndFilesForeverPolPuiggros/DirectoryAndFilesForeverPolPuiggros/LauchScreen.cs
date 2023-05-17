using System;
using System.Windows.Forms;

namespace DirectoryAndFilesForeverPolPuiggros
{
    public partial class LauchScreen : Form
    {

        Timer tmr;
        public LauchScreen()
        {
            InitializeComponent();
        }

        private void LauchScreen_Shown(object sender, EventArgs e)
        {
            tmr = new Timer();
            tmr.Interval = 3000;
            tmr.Start();
            tmr.Tick += tmr_Tick;
        }
        void tmr_Tick(object sender, EventArgs e)
        {
            tmr.Stop();
            DnFF form = new DnFF();
            form.Show();
            this.Hide();
        }
    }
}
