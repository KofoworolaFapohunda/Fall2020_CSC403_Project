using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fall2020_CSC403_Project.code;

namespace Fall2020_CSC403_Project
{
    public partial class Welcome : Form
    {
        private FrmSelectCharacter frmSC;
        public Welcome() {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            frmSC = new FrmSelectCharacter();
            frmSC.Show();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnVideo_Click(object sender, EventArgs e)
        {
            string VideoUrl = "https://drive.google.com/file/d/1_yF6qXJe4-PUNgO3SH0ceXLCAYoKqOj7/view"; // link to video
            System.Diagnostics.Process.Start(VideoUrl);
        }
    }
}
