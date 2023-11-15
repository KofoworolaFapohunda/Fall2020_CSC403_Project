﻿using Fall2020_CSC403_Project.code;
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
    public partial class YouWin : Form
    {
        private Player player;
        public static YouWin instance = null;
        private FrmLevel2 frmlevel2;
        public YouWin()
        {
            InitializeComponent();
        }

        public static YouWin GetInstance()
        {
            if (instance == null)
            {
                instance = new YouWin();
            }
            return instance;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmlevel2 = FrmLevel2.GetInstance();
            frmlevel2.Show();
            Close();

        }

    private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

