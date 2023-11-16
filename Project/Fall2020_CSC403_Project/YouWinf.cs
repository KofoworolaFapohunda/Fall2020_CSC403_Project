using Fall2020_CSC403_Project.code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    public partial class YouWinf : Form
    {
        public static YouWinf instance = null;
        private FrmLevel2 frmlevel2;
        public YouWinf()
        {
            InitializeComponent();
        }

        public static YouWinf GetInstance()
        {
            if (instance == null)
            {
                instance = new YouWinf();
            }
            return instance;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

