using Fall2020_CSC403_Project.code;
using System;
using System.Drawing;
using System.Windows.Forms;
namespace Fall2020_CSC403_Project
{
    public partial class FrmLevel2 : Form
    {
        private Player player2;
        private Enemy enemyv1;
        private Enemy enemyv3;
        private Enemy enemyv2;
        private Character[] wall2;
        public Weapon weapon;
        private HealingItem[] potions;
        public static int KillEnemy = 0;
        public static int NumOfEnemy = 3;
        private DateTime timeBegin;
        private FrmBattle2 frmBattle2;
        public static FrmLevel2 frmlevel2 = null;
        public static FrmLevel2 instance = null;

        public FrmLevel2()
        {
            InitializeComponent();
            frmlevel2 = this;
        }

        public static FrmLevel2 GetInstance()
        {
            if (instance == null)
            {
                instance = new FrmLevel2();
            }
            return instance;
        }
        private void FrmLevel_Load(object sender, EventArgs e)
        {
            const int PADDING = 7;
            const int NUM_WALLS = 13;
            const int NUM_POTIONS = 1;
            player2 = new Player(CreatePosition(picPlayer), CreateCollider(picPlayer, PADDING));
            enemyv3 = new Enemy(CreatePosition(picenemyv3), CreateCollider(picenemyv3, PADDING));
            enemyv1 = new Enemy(CreatePosition(picenemyv1), CreateCollider(picenemyv1, PADDING));
            enemyv2 = new Enemy(CreatePosition(picenemyv2), CreateCollider(picenemyv2, PADDING));
            weapon = new Weapon(CreatePosition(knife), CreateCollider(knife, PADDING));
            potions = new HealingItem[NUM_POTIONS];
            for (int w = 0; w < NUM_POTIONS; w++)
            {
                PictureBox pic = Controls.Find("heal" + w.ToString(), true)[0] as PictureBox;
                potions[w] = new HealingItem(CreatePosition(pic), CreateCollider(pic, PADDING));
            }

            enemyv3.Img = picenemyv3.BackgroundImage;
            enemyv1.Img = picenemyv1.BackgroundImage;
            enemyv2.Img = picenemyv2.BackgroundImage;
            enemyv3.Color = Color.Red;
            enemyv1.Color = Color.Green;
            enemyv2.Color = Color.FromArgb(255, 245, 161);
            wall2 = new Character[NUM_WALLS];
            for (int w = 0; w < NUM_WALLS; w++)
            {
                PictureBox pic = Controls.Find("picWall" + w.ToString(), true)[0] as PictureBox;
                wall2[w] = new Character(CreatePosition(pic), CreateCollider(pic, PADDING));
            }

            Game.player = player2;
            timeBegin = DateTime.Now;
            UpdatePlayerStatus(FrmBattle.inherithealth, FrmBattle.inheritmaxhealth, FrmBattle.inheritexperience, FrmBattle.inheritmaxexperience, FrmBattle.inheritlevel);
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
        private void FrmLevel_KeyUp(object sender, KeyEventArgs e)
        {
            player2.ResetMoveSpeed();
        }
        private void tmrUpdateInGameTime_Tick(object sender, EventArgs e)
        {
            TimeSpan span = DateTime.Now - timeBegin;
            string time = span.ToString(@"hh\:mm\:ss");
            lblInGameTime.Text = "Time: " + time.ToString();
        }
        private void tmrPlayerMove_Tick(object sender, EventArgs e)
        {
            // move player
            player2.Move();
            // check collision with walls
            if (HitAWall(player2))
            {
                player2.MoveBack();
            }
            // check collision with enemies
            if (HitAChar(player2, enemyv1))
            {
                Fight(enemyv1);
            }
            else if (HitAChar(player2, enemyv2))
            {
                Fight(enemyv2);
            }
            if (HitAChar(player2, enemyv3))
            {
                Fight(enemyv3);
            }
            //check weapon
            if (HitAWeapon(player2))
            {
                Controls.Remove(knife);
                weapon = new Weapon(CreatePosition(vanish), CreateCollider(vanish, 0));
                Weapon.haveAWeapon = true;
            }
            //check potion
            for (int w = 0; w < potions.Length; w++)
            {
                if (HitAPotion(player2, potions[w]))
                {
                    Controls.Remove(Controls.Find("heal" + w.ToString(), true)[0] as PictureBox);
                    potions[w] = new HealingItem(CreatePosition(vanish), CreateCollider(vanish, 0));
                    HealingItem.havePotion++;
                }
            }

            // update player's picture box
            picPlayer.Location = new Point((int)player2.Position.x, (int)player2.Position.y);

        }
        private bool HitAWall(Character c)
        {
            bool hitAWall = false;
            for (int w = 0; w < wall2.Length; w++)
            {
                if (c.Collider.Intersects(wall2[w].Collider))
                {
                    hitAWall = true;
                    break;
                }
            }
            return hitAWall;
        }
        private bool HitAChar(Character you, Character other)
        {

            return you.Collider.Intersects(other.Collider);
        }
        private bool HitAWeapon(Character c)
        {
            bool hitAWeapon = false;
            if (c.Collider.Intersects(weapon.Collider))
            {
                hitAWeapon = true;
            }
            return hitAWeapon;
        }
        private bool HitAPotion(Character you, Character other)
        {
            for (int w = 0; w < potions.Length; w++)
            {
                if (you.Collider.Intersects(potions[w].Collider))
                {
                    break;
                }
            }
            return you.Collider.Intersects(other.Collider);
        }
        private void Fight(Enemy enemy)
        {
            player2.ResetMoveSpeed();
            player2.MoveBack();
            frmBattle2 = FrmBattle2.GetInstance(enemy);
            frmBattle2.Show();
            if (enemy == enemyv3)
            {
                frmBattle2.SetupForBossBattle();
            }
        }
        public void CheckResult(Enemy enemy)
        {
            if (FrmBattle2.Death)
            {
                Enemy_vanishing(enemy);
                FrmBattle2.Death = false;
            }
        }
        private void Enemy_vanishing(Enemy enemy)
        {
            if (enemy == enemyv1)
            {
                Controls.Remove(picenemyv1);
                enemyv1 = new Enemy(CreatePosition(vanish), CreateCollider(vanish, 0));
            }
            else if (enemy == enemyv3)
            {
                picenemyv3.Dispose();
                enemyv3 = new Enemy(CreatePosition(vanish), CreateCollider(vanish, 0));
            }
            else if (enemy == enemyv2)
            {
                picenemyv2.Dispose();
                enemyv2 = new Enemy(CreatePosition(vanish), CreateCollider(vanish, 0));
            }
        }
        public void UpdatePlayerStatus(int Health, int MaxHealth, int Experience, int maxExp, int level)
        {
            float playerHealthPer = Health / (float)MaxHealth;
            const int MAX_HEALTHBAR_WIDTH = 151;
            lblPlayerHealthFull.Width = (int)(MAX_HEALTHBAR_WIDTH * playerHealthPer);
            lblPlayerHealthFull.Text = "HP: " + Health.ToString();
            float playerExpPer = Experience / (float)maxExp;
            const int MAX_EXPBAR_WIDTH = 151;
            lblPlayerExpFull.Width = (int)(MAX_EXPBAR_WIDTH * playerExpPer);
            lblPlayerExpFull.Text = "EXP: " + Experience.ToString();
            labellv.Text = "Lv." + level.ToString();
        }
        private void FrmLevel_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    player2.GoLeft();
                    break;
                case Keys.Right:
                    player2.GoRight();
                    break;
                case Keys.Up:
                    player2.GoUp();
                    break;
                case Keys.Down:
                    player2.GoDown();
                    break;
                default:
                    player2.ResetMoveSpeed();
                    break;
            }
        }
        private void lblInGameTime_Click(object sender, EventArgs e)
        {
        }
    }
}