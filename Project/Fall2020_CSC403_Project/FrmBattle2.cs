using Fall2020_CSC403_Project.code;
using Fall2020_CSC403_Project.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    public partial class FrmBattle2 : Form
    {
        public static FrmBattle2 instance = null;
        private Enemy enemy;
        private Player player2;
        private GameOver gameover;
        private YouWin youwin;
        public static bool Death = false;
        //Initializing advert Panel and declaring variables
        private static int characterbattle;
        private List<string> texts = new List<string> { "5", "4", "3", "2", "EXIT" };
        private int currentIndex = 0;
        private bool ad3start = false;// sets it to false
        string urlToOpen = "";



        private FrmBattle2()
        {
            InitializeComponent();
            player2 = Game.player;           
        }

        public void Setup()
        {
            // update for this enemy
            picEnemy.BackgroundImage = enemy.Img;
            picEnemy.Refresh();
            BackColor = enemy.Color;
            picBossBattle.Visible = false;

            // Observer pattern
            enemy.AttackEvent += PlayerDamage;
            player2.AttackEvent += EnemyDamage;
            player2.HealEvent += PlayerHealing;

            // show health
            UpdateHealthBars();

            // show experience
            UpdateExpBars();
            labelpotion.Text = "X " + HealingItem.havePotion.ToString();
            advert.Visible = false;
            player2.UpdateExp(FrmBattle.getexperience);
            enemy.OnAttack(FrmBattle.getattack);
            player2.OnHeal(FrmBattle.getheal);
            FrmBattle.getattack = 0;
            FrmBattle.getexperience = 0;
            FrmBattle.getheal = 0;
        }

        public void SetupForBossBattle()
        {
            string val = BackColor.Name.ToString();
            if (val == "Red")//Check if the boss has been defeated
            {
                //Show possible games to download
                AdVisible(val);
            }
        }

        public static FrmBattle2 GetInstance(Enemy enemy)
        {
            if (instance == null)
            {
                instance = new FrmBattle2();
                instance.enemy = enemy;
                instance.Setup();
            }
            return instance;
        }

        private void UpdateHealthBars()
        {
            float playerHealthPer = player2.Health / (float)player2.MaxHealth;
            float enemyHealthPer = enemy.Health / (float)enemy.MaxHealth;

            const int MAX_HEALTHBAR_WIDTH = 226;
            lblPlayerHealthFull.Width = (int)(MAX_HEALTHBAR_WIDTH * playerHealthPer);
            lblEnemyHealthFull.Width = (int)(MAX_HEALTHBAR_WIDTH * enemyHealthPer);

            lblPlayerHealthFull.Text = "HP: " + player2.Health.ToString();
            lblEnemyHealthFull.Text = "HP: " + enemy.Health.ToString();
        }
        private void UpdateExpBars()
        {
            float playerExpPer = player2.Experience / (float)player2.maxExp;
            const int MAX_EXPBAR_WIDTH = 226;
            lblPlayerExpFull.Width = (int)(MAX_EXPBAR_WIDTH * playerExpPer);
            lblPlayerExpFull.Text = "EXP: " + player2.Experience.ToString();
            labellv.Text = "Lv." + player2.Level.ToString();
        }



        private void btnAttack_Click(object sender, EventArgs e)
        {
            //SoundPlayer attack_audio = new SoundPlayer(Resources.boom);
            axWindowsMediaPlayer1.URL = Application.StartupPath.Replace("\\bin\\Debug", "\\data\\boom.wav");
            bool checkweapon = Weapon.haveAWeapon;
            if (checkweapon)
            {
                player2.OnAttack(-8);
                player2.UpdateExp(1);
                UpdateExpBars();
            }
            else
            {
                player2.OnAttack(-4);
                player2.UpdateExp(1);
                UpdateExpBars();
            }
            if (enemy.Health > 0)
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
                enemy.OnAttack(-2);
            }

            UpdateHealthBars();
            Death = false;
            if (enemy.Health <= 0)
            {
                instance = null;
                FrmLevel2.KillEnemy++;
                player2.UpdateExp(10);
                UpdateExpBars();
                Death = true;
                Close();
                if (FrmLevel2.KillEnemy == FrmLevel2.NumOfEnemy)
                {
                    gameover = GameOver.GetInstance();
                gameover.Show();
                }
            }
            if (player2.Health <= 0)
            {
                instance = null;
                Close();
                gameover = GameOver.GetInstance();
                gameover.Show();
            }
        }
        private void btnEscape_Click(object sender, EventArgs e)
        {
            instance = null;
            Close();
        }
        private void btnHeal_Click(object sender, EventArgs e)
        {
            if (HealingItem.havePotion > 0)
            {
                player2.OnHeal(5);
                UpdateHealthBars();
                HealingItem.havePotion--;
                labelpotion.Text = "X " + HealingItem.havePotion.ToString();
            }

        }

        private void EnemyDamage(int amount)
        {
            enemy.AlterHealth(amount);
        }

        private void PlayerDamage(int amount)
        {
            player2.AlterHealth(amount);
        }
        private void PlayerHealing(int amount)
        {
            player2.AlterHealth(amount);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (currentIndex < texts.Count)
            {
                AdExit.Text = texts[currentIndex];
                currentIndex++;
            }
            else
            {
                // When you reach the end of the list, reset the index to start over.
                currentIndex = 0;
            }
            if (AdExit.Text == "EXIT")
            {
                timer1.Stop();
            }
        }

        private void AdVisible(string color)
        {
            timer1.Start();

            if (color == "Red")
            {
                urlToOpen = "https://www.microsoft.com/en-us/store/top-free/games/pc"; //  URL to take you to the next game to download
                advert.BackgroundImage = Resources.Advert;

                advert.Visible = true;
                advert.Enabled = true;
            }

            advert.Visible = true;
            advert.Enabled = true;
        }

        private void AdExit_Click(object sender, EventArgs e)
        {
            if (AdExit.Text == "EXIT")
            {
                advert.Visible = false;
                advert.Enabled = false;
                ad3start = false;
                timer1.Stop();
            }
        }
        private void advert_Click(object sender, EventArgs e)
        {
            // Specify the URL you want to open in the default web browser
            try
            {
                // Open the default web browser with the specified URL
                System.Diagnostics.Process.Start(urlToOpen);
            }
            catch (Exception ex)
            {
                // Handle any exceptions that might occur when opening the web browser
                MessageBox.Show("An error occurred while opening the web browser: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }   ///////////////////////////////////////////////stop			

        /// advert ends
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHelp_Click(object sender, EventArgs e)
        {
            string documentationUrl = "https://docs.google.com/document/d/158qKBqjiTSbWiRfbgNZ-8zu_gsyhuzam8IXES70mpeU/edit"; // link to google docs FAQ
            System.Diagnostics.Process.Start(documentationUrl);
        }

        private void FrmBattle2_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmLevel2.frmlevel2.CheckResult(enemy);
            FrmLevel2.frmlevel2.UpdatePlayerStatus(player2.Health, player2.MaxHealth, player2.Experience, player2.maxExp, player2.Level);
            FrmBattle.inherithealth = player2.Health;
            FrmBattle.inheritmaxhealth = player2.MaxHealth;
            FrmBattle.inheritexperience = player2.Experience;
            FrmBattle.inheritmaxexperience = player2.maxExp;
            FrmBattle.inheritlevel = player2.Level;
        }
    }
}
