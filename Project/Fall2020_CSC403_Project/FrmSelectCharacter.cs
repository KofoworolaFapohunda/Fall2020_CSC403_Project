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
    public partial class FrmSelectCharacter : Form
    {
        public static FrmSelectCharacter instance = null;
        private FrmBattle frm_battle;
        public FrmSelectCharacter()
        {
            InitializeComponent();
        }
        public static FrmSelectCharacter GetInstance()
        {
            if (instance == null)
            {
                instance = new FrmSelectCharacter();
            }
            return instance;
        }
        private void picYuji_Click(object sender, EventArgs e)
        {


        }


        private void picMegumi_Click(object sender, EventArgs e)
        {

        }

        private void picNobara_Click(object sender, EventArgs e)
        {

        }
    }
}
