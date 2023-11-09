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
    public partial class Level_2 : Form
    {
        public static Level_2 instance = null;
        public Level_2()
        {
            InitializeComponent();
        }
        public static Level_2 GetInstance()
        {
            if (instance == null)
            {
                instance = new Level_2();
            }
            return instance;
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
