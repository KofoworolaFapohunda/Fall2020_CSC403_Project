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
    public partial class FrmSelectCharacter : Form
    {
        public static FrmSelectCharacter instance = null;
        private FrmLevel frmlevel;
        private Player yuji;
        private Player megumi;
        private Player nobara;

        
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
            yuji = new Player(CreatePosition(picYuji), CreateCollider(picYuji, 7));
            yuji.Img = picYuji.Image;
            frmlevel = FrmLevel.GetInstance(yuji);
            frmlevel.Show();

        }


        private void picMegumi_Click(object sender, EventArgs e)
        {
            megumi = new Player(CreatePosition(picMegumi), CreateCollider(picMegumi, 7));
            megumi.Img = picMegumi.Image;
            frmlevel = FrmLevel.GetInstance(megumi);
            frmlevel.Show();
        }

        private void picNobara_Click(object sender, EventArgs e)
        {
            nobara = new Player(CreatePosition(picNobara), CreateCollider(picNobara, 7));
            nobara.Img = picNobara.Image;
            frmlevel = FrmLevel.GetInstance(nobara);
            frmlevel.Show();
        }
        private Vector2 CreatePosition(PictureBox pic)
        {
            return new Vector2(pic.Location.X, pic.Location.Y);
        }

        private Collider CreateCollider(PictureBox pic, int padding)
        {
            Rectangle rect = new Rectangle(pic.Location, new Size(pic.Size.Width - padding, pic.Size.Height - padding));
            return new Collider(rect);
        }
    }
}
