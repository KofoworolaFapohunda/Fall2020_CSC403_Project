using Fall2020_CSC403_Project.code;
using Fall2020_CSC403_Project.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project {
  public partial class FrmBattle : Form {
    public static FrmBattle instance = null;
    private Enemy enemy;
    private Player player;
    private GameOver gameover;
    private YouWin youwin;
    public static bool Death = false;
    //Initializing advert Panel and declaring variables
    private List<string> texts = new List<string> { "5", "4", "3", "2", "EXIT" };
    private int currentIndex = 0;
    private bool ad3start = false;// sets it to false
    string urlToOpen = "";



        private FrmBattle() {
      InitializeComponent();
      player = Game.player;
    }

    public void Setup() {
      // update for this enemy
      picEnemy.BackgroundImage = enemy.Img;
      picEnemy.Refresh();
      BackColor = enemy.Color;
      picBossBattle.Visible = false;

      // Observer pattern
      enemy.AttackEvent += PlayerDamage;
      player.AttackEvent += EnemyDamage;
      player.HealEvent += PlayerHealing;

      // show health
      UpdateHealthBars();

      // show experience
      UpdateExpBars();
      labelpotion.Text = "X " + HealingItem.havePotion.ToString();
    }

    public void SetupForBossBattle() {
      picBossBattle.Location = Point.Empty;
      picBossBattle.Size = ClientSize;
      picBossBattle.Visible = true;

      SoundPlayer simpleSound = new SoundPlayer(Resources.final_battle);
      simpleSound.Play();

      tmrFinalBattle.Enabled = true;
    }

    public static FrmBattle GetInstance(Enemy enemy) {
      if (instance == null) {
        instance = new FrmBattle();
        instance.enemy = enemy;
        instance.Setup();
      }
      return instance;
    }

    private void UpdateHealthBars() {
      float playerHealthPer = player.Health / (float)player.MaxHealth;
      float enemyHealthPer = enemy.Health / (float)enemy.MaxHealth;

      const int MAX_HEALTHBAR_WIDTH = 226;
      lblPlayerHealthFull.Width = (int)(MAX_HEALTHBAR_WIDTH * playerHealthPer);
      lblEnemyHealthFull.Width = (int)(MAX_HEALTHBAR_WIDTH * enemyHealthPer);

      lblPlayerHealthFull.Text = "HP: " + player.Health.ToString();
      lblEnemyHealthFull.Text = "HP: " + enemy.Health.ToString();
    }
    private void UpdateExpBars() {
      float playerExpPer = player.Experience / (float)player.maxExp;
      const int MAX_EXPBAR_WIDTH = 226;
      lblPlayerExpFull.Width = (int)(MAX_EXPBAR_WIDTH * playerExpPer);
      lblPlayerExpFull.Text = "EXP: " + player.Experience.ToString();
      labellv.Text = "Lv." + player.Level.ToString();
        }



        private void btnAttack_Click(object sender, EventArgs e) {
            SoundPlayer attack_audio = new SoundPlayer(Resources.boom);
            bool checkweapon = Weapon.haveAWeapon;
            if (checkweapon)
            {
                player.OnAttack(-8);
                player.UpdateExp(1);
                UpdateExpBars();
            }
            else
            {
                player.OnAttack(-4);
                player.UpdateExp(1);
                UpdateExpBars();
            }
            if (enemy.Health > 0) {
                attack_audio.Play();
                enemy.OnAttack(-2);
            }

            UpdateHealthBars();
            Death = false;
            if (enemy.Health <= 0){
                instance = null;
                FrmLevel.KillEnemy++;
                player.UpdateExp(10);
                UpdateExpBars();
                Death = true;
                Close();
                if (FrmLevel.KillEnemy == FrmLevel.NumOfEnemy)
                {
                    youwin = YouWin.GetInstance();
                    youwin.Show();
                }
            }
            if (player.Health <= 0){
                instance = null;
                Close();
                gameover = GameOver.GetInstance();
                gameover.Show();
            }
        }
        private void btnEscape_Click(object sender, EventArgs e) {
            instance = null;
            Close();
        }
        private void btnHeal_Click(object sender, EventArgs e) {
            if (HealingItem.havePotion > 0) { 
                player.OnHeal(5);
                UpdateHealthBars();
                HealingItem.havePotion --;
                labelpotion.Text = "X " + HealingItem.havePotion.ToString();
            }
            
        }

        private void EnemyDamage(int amount) {
            enemy.AlterHealth(amount);
        }

        private void PlayerDamage(int amount) {
             player.AlterHealth(amount);
        }
        private void PlayerHealing(int amount) {
            player.AlterHealth(amount);
        }

        private void tmrFinalBattle_Tick(object sender, EventArgs e) {
            picBossBattle.Visible = false;
            tmrFinalBattle.Enabled = false;
            BgdTrack.PlayBackgroundTrack();//Calling the background music to start again
            /// advert functionality
            ///////////////////////////////start			
            string val = BackColor.Name.ToString();
            if (val == "Red") {
                //Show possible games to download
                //Check if tthe boss has been defeated 
                AdVisible(val);
            }
        }
        private void timer1_Tick(object sender, EventArgs e) {
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

            if (color == "Red") {
                urlToOpen = "https://www.microsoft.com/en-us/store/top-free/games/pc"; //  URL to take you to the next game to download
                advert.BackgroundImage = Resources.Advert;

                advert.Visible = true;
                advert.Enabled = true;
            }

            advert.Visible = true;
            advert.Enabled = true;
        }

        private void AdExit_Click(object sender, EventArgs e) {
            if (AdExit.Text == "EXIT")
            {
                advert.Visible = false;
                advert.Enabled = false;
                ad3start = false;
                timer1.Stop();
            }
        }
        private void advert_Click(object sender, EventArgs e) {
            // Specify the URL you want to open in the default web browser
            try {
                // Open the default web browser with the specified URL
                System.Diagnostics.Process.Start(urlToOpen);
            }
            catch (Exception ex) {
                // Handle any exceptions that might occur when opening the web browser
                MessageBox.Show("An error occurred while opening the web browser: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }   ///////////////////////////////////////////////stop			

        /// advert ends
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHelp_Click(object sender, EventArgs e) {
            string documentationUrl = "https://docs.google.com/document/d/158qKBqjiTSbWiRfbgNZ-8zu_gsyhuzam8IXES70mpeU/edit"; // link to google docs FAQ
            System.Diagnostics.Process.Start(documentationUrl);
        }

        private void FrmBattle_FormClosing(object sender, FormClosingEventArgs e) {
            FrmLevel.frmlevel.CheckResult(enemy);
            FrmLevel.frmlevel.UpdatePlayerStatus(player.Health, player.MaxHealth, player.Experience, player.maxExp, player.Level);
        }

        private void potion_Click(object sender, EventArgs e){

        }
  }
}
