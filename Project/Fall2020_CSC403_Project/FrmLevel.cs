using Fall2020_CSC403_Project.code;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project {
  public partial class FrmLevel : Form {
    private Player player;

    private Enemy enemyPoisonPacket;
    private Enemy bossKoolaid;
    private Enemy enemyCheeto;
    private Character[] walls;
    public Weapon weapon;
    private HealingItem[] potions;
    public static int KillEnemy = 0;
    public static int NumOfEnemy = 3;
    private DateTime timeBegin;
    private FrmBattle frmBattle;
    public static FrmLevel frmlevel = null; 
    public static FrmLevel instance = null;
    
    public FrmLevel() {
      InitializeComponent();
      frmlevel = this;
    }
    public static FrmLevel GetInstance(Player player) {
      if (instance == null) {
        instance = new FrmLevel();
        instance.player = player;
        instance.Setup();
      }
      return instance;
    }
    public void Setup() {
        picPlayer.BackgroundImage = player.Img;
        picPlayer.Refresh();

    }
    private void FrmLevel_Load(object sender, EventArgs e) {
      const int PADDING = 7;
      const int NUM_WALLS = 13;
      const int NUM_POTIONS = 1;

      player = new Player(CreatePosition(picPlayer), CreateCollider(picPlayer, PADDING));
      bossKoolaid = new Enemy(CreatePosition(picBossKoolAid), CreateCollider(picBossKoolAid, PADDING));
      enemyPoisonPacket = new Enemy(CreatePosition(picEnemyPoisonPacket), CreateCollider(picEnemyPoisonPacket, PADDING));
      enemyCheeto = new Enemy(CreatePosition(picEnemyCheeto), CreateCollider(picEnemyCheeto, PADDING));
      weapon = new Weapon(CreatePosition(knife), CreateCollider(knife, PADDING));
      potions = new HealingItem[NUM_POTIONS];
      for (int w = 0; w < NUM_POTIONS; w++) {
        PictureBox pic = Controls.Find("heal" + w.ToString(), true)[0] as PictureBox;
        potions[w] = new HealingItem(CreatePosition(pic), CreateCollider(pic, PADDING));
      }
      

      bossKoolaid.Img = picBossKoolAid.BackgroundImage;
      enemyPoisonPacket.Img = picEnemyPoisonPacket.BackgroundImage;
      enemyCheeto.Img = picEnemyCheeto.BackgroundImage;

      bossKoolaid.Color = Color.Red;
      enemyPoisonPacket.Color = Color.Green;
      enemyCheeto.Color = Color.FromArgb(255, 245, 161);

      walls = new Character[NUM_WALLS];
      for (int w = 0; w < NUM_WALLS; w++) {
        PictureBox pic = Controls.Find("picWall" + w.ToString(), true)[0] as PictureBox;
        walls[w] = new Character(CreatePosition(pic), CreateCollider(pic, PADDING));
      }

      Game.player = player;
      timeBegin = DateTime.Now;
      UpdatePlayerStatus(30, 30, 0, 20, 0);
      BgdTrack.PlayBackgroundTrack(); //Calling the background music
    }

    private Vector2 CreatePosition(PictureBox pic) {
      return new Vector2(pic.Location.X, pic.Location.Y);
    }

    private Collider CreateCollider(PictureBox pic, int padding) {
      Rectangle rect = new Rectangle(pic.Location, new Size(pic.Size.Width - padding, pic.Size.Height - padding));
      return new Collider(rect);
    }

    private void FrmLevel_KeyUp(object sender, KeyEventArgs e) {
      player.ResetMoveSpeed();
    }

    private void tmrUpdateInGameTime_Tick(object sender, EventArgs e) {
      TimeSpan span = DateTime.Now - timeBegin;
      string time = span.ToString(@"hh\:mm\:ss");
      lblInGameTime.Text = "Time: " + time.ToString();
    }

    private void tmrPlayerMove_Tick(object sender, EventArgs e) {
      // move player
      player.Move();

      // check collision with walls
      if (HitAWall(player)) {
        player.MoveBack();
      }

      // check collision with enemies
      if (HitAChar(player, enemyPoisonPacket)) {
        Fight(enemyPoisonPacket);
      }
      else if (HitAChar(player, enemyCheeto)) {
        Fight(enemyCheeto);
      }
      if (HitAChar(player, bossKoolaid)) {
        Fight(bossKoolaid);
      }
      //check weapon
      if (HitAWeapon(player)){
        Controls.Remove(knife);
        weapon = new Weapon(CreatePosition(vanish), CreateCollider(vanish, 0));
        Weapon.haveAWeapon = true;
      }
      //check potion
      for (int w = 0; w < potions.Length; w++) {
        if (HitAPotion(player, potions[w])){
          Controls.Remove(Controls.Find("heal" + w.ToString(), true)[0] as PictureBox);
          potions[w] = new HealingItem(CreatePosition(vanish), CreateCollider(vanish, 0));
          HealingItem.havePotion ++;
        }
      }
      
      // update player's picture box
      picPlayer.Location = new Point((int)player.Position.x, (int)player.Position.y);
            
        }

    private bool HitAWall(Character c) {
      bool hitAWall = false;
      for (int w = 0; w < walls.Length; w++) {
        if (c.Collider.Intersects(walls[w].Collider)) {
          hitAWall = true;
          break;
        }
      }
      return hitAWall;
    }

    private bool HitAChar(Character you, Character other) {
      
      return you.Collider.Intersects(other.Collider);
    }

    private bool HitAWeapon(Character c) {
        bool hitAWeapon = false;
        if (c.Collider.Intersects(weapon.Collider)) {
            hitAWeapon = true;
        }
        return hitAWeapon;
    }
    private bool HitAPotion(Character you, Character other){
       for (int w = 0; w < potions.Length; w++) {
         if (you.Collider.Intersects(potions[w].Collider)) {
           break;
         }     
       }
       return you.Collider.Intersects(other.Collider);
    }
    private void Fight(Enemy enemy) {
        player.ResetMoveSpeed();
        player.MoveBack();
        frmBattle = FrmBattle.GetInstance(enemy);
        frmBattle.Show();

        if (enemy == bossKoolaid) {
            frmBattle.SetupForBossBattle();
        }
    }
    public void CheckResult(Enemy enemy){
        if (FrmBattle.Death){
            Enemy_vanishing(enemy);
            FrmBattle.Death = false;
        }
    }
    private void Enemy_vanishing(Enemy enemy) {
        if (enemy == enemyPoisonPacket) {
            Controls.Remove(picEnemyPoisonPacket);
            enemyPoisonPacket = new Enemy(CreatePosition(vanish), CreateCollider(vanish, 0));
        }
        else if (enemy == bossKoolaid) {
            picBossKoolAid.Dispose();
            bossKoolaid = new Enemy(CreatePosition(vanish), CreateCollider(vanish, 0));
        }
        else if (enemy == enemyCheeto) {
            picEnemyCheeto.Dispose();
            enemyCheeto = new Enemy(CreatePosition(vanish), CreateCollider(vanish, 0));
        }
    }
    public void UpdatePlayerStatus(int Health, int MaxHealth, int Experience, int maxExp, int level) {
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
    private void FrmLevel_KeyDown(object sender, KeyEventArgs e) {
        switch (e.KeyCode) {
          case Keys.Left:
            player.GoLeft();
          break;

        case Keys.Right:
            player.GoRight();
          break;

        case Keys.Up:
            player.GoUp();
          break;

        case Keys.Down:
            player.GoDown();
          break;

        default:
            player.ResetMoveSpeed();
          break;
        }
    }

    private void lblInGameTime_Click(object sender, EventArgs e) {

    }
  }
}
