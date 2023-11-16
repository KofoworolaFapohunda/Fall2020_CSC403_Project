﻿namespace Fall2020_CSC403_Project
{
    partial class FrmBattle2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBattle2));
            this.btnAttack = new System.Windows.Forms.Button();
            this.btnEscape = new System.Windows.Forms.Button();
            this.btnHeal = new System.Windows.Forms.Button();
            this.lblPlayerHealthFull = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEnemyHealthFull = new System.Windows.Forms.Label();
            this.btnHelp = new System.Windows.Forms.Button();
            this.lblPlayerExpFull = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelpotion = new System.Windows.Forms.Label();
            this.labellv = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.advert = new System.Windows.Forms.Panel();
            this.AdExit = new System.Windows.Forms.TextBox();
            this.picEnemy = new System.Windows.Forms.PictureBox();
            this.picPlayer = new System.Windows.Forms.PictureBox();
            this.potion = new System.Windows.Forms.PictureBox();
            this.picBossBattle = new System.Windows.Forms.PictureBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.advert.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.potion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBossBattle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAttack
            // 
            this.btnAttack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttack.Location = new System.Drawing.Point(180, 550);
            this.btnAttack.Margin = new System.Windows.Forms.Padding(4);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(192, 60);
            this.btnAttack.TabIndex = 2;
            this.btnAttack.Text = "Attack";
            this.btnAttack.UseVisualStyleBackColor = true;
            this.btnAttack.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // btnEscape
            // 
            this.btnEscape.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEscape.Location = new System.Drawing.Point(180, 640);
            this.btnEscape.Margin = new System.Windows.Forms.Padding(4);
            this.btnEscape.Name = "btnEscape";
            this.btnEscape.Size = new System.Drawing.Size(192, 60);
            this.btnEscape.TabIndex = 9;
            this.btnEscape.Text = "Escape";
            this.btnEscape.UseVisualStyleBackColor = true;
            this.btnEscape.Click += new System.EventHandler(this.btnEscape_Click);
            // 
            // btnHeal
            // 
            this.btnHeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHeal.Location = new System.Drawing.Point(180, 730);
            this.btnHeal.Margin = new System.Windows.Forms.Padding(4);
            this.btnHeal.Name = "btnHeal";
            this.btnHeal.Size = new System.Drawing.Size(192, 60);
            this.btnHeal.TabIndex = 10;
            this.btnHeal.Text = "Heal";
            this.btnHeal.UseVisualStyleBackColor = true;
            this.btnHeal.Click += new System.EventHandler(this.btnHeal_Click);
            // 
            // lblPlayerHealthFull
            // 
            this.lblPlayerHealthFull.BackColor = System.Drawing.Color.Blue;
            this.lblPlayerHealthFull.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerHealthFull.ForeColor = System.Drawing.Color.White;
            this.lblPlayerHealthFull.Location = new System.Drawing.Point(107, 88);
            this.lblPlayerHealthFull.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayerHealthFull.Name = "lblPlayerHealthFull";
            this.lblPlayerHealthFull.Size = new System.Drawing.Size(340, 28);
            this.lblPlayerHealthFull.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(105, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 32);
            this.label1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(772, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(344, 32);
            this.label2.TabIndex = 5;
            // 
            // lblEnemyHealthFull
            // 
            this.lblEnemyHealthFull.BackColor = System.Drawing.Color.Blue;
            this.lblEnemyHealthFull.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnemyHealthFull.ForeColor = System.Drawing.Color.White;
            this.lblEnemyHealthFull.Location = new System.Drawing.Point(774, 88);
            this.lblEnemyHealthFull.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnemyHealthFull.Name = "lblEnemyHealthFull";
            this.lblEnemyHealthFull.Size = new System.Drawing.Size(340, 28);
            this.lblEnemyHealthFull.TabIndex = 6;
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(1124, 32);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(85, 27);
            this.btnHelp.TabIndex = 8;
            this.btnHelp.Text = "FAQ";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // lblPlayerExpFull
            // 
            this.lblPlayerExpFull.BackColor = System.Drawing.Color.Red;
            this.lblPlayerExpFull.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerExpFull.ForeColor = System.Drawing.Color.White;
            this.lblPlayerExpFull.Location = new System.Drawing.Point(107, 44);
            this.lblPlayerExpFull.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayerExpFull.Name = "lblPlayerExpFull";
            this.lblPlayerExpFull.Size = new System.Drawing.Size(340, 28);
            this.lblPlayerExpFull.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(105, 42);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(344, 32);
            this.label3.TabIndex = 22;
            // 
            // labelpotion
            // 
            this.labelpotion.BackColor = System.Drawing.Color.DarkGray;
            this.labelpotion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelpotion.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpotion.Location = new System.Drawing.Point(456, 730);
            this.labelpotion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelpotion.Name = "labelpotion";
            this.labelpotion.Size = new System.Drawing.Size(120, 60);
            this.labelpotion.TabIndex = 23;
            // 
            // labellv
            // 
            this.labellv.BackColor = System.Drawing.Color.DarkGray;
            this.labellv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labellv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labellv.Location = new System.Drawing.Point(456, 40);
            this.labellv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labellv.Name = "labellv";
            this.labellv.Size = new System.Drawing.Size(80, 32);
            this.labellv.TabIndex = 24;
            // 
            // timer1
            // 
            this.timer1.Interval = 800;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // advert
            // 
            this.advert.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.Advert;
            this.advert.Controls.Add(this.axWindowsMediaPlayer1);
            this.advert.Controls.Add(this.AdExit);
            this.advert.Location = new System.Drawing.Point(12, 12);
            this.advert.Name = "advert";
            this.advert.Size = new System.Drawing.Size(1209, 778);
            this.advert.TabIndex = 9;
            this.advert.Click += new System.EventHandler(this.advert_Click);
            // 
            // AdExit
            // 
            this.AdExit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdExit.Location = new System.Drawing.Point(1146, 0);
            this.AdExit.Name = "AdExit";
            this.AdExit.Size = new System.Drawing.Size(63, 35);
            this.AdExit.TabIndex = 10;
            this.AdExit.Text = "EXIT";
            this.AdExit.Click += new System.EventHandler(this.AdExit_Click);
            // 
            // picEnemy
            // 
            this.picEnemy.BackColor = System.Drawing.Color.WhiteSmoke;
            this.picEnemy.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.enemy_v3;
            this.picEnemy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picEnemy.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picEnemy.Location = new System.Drawing.Point(772, 136);
            this.picEnemy.Margin = new System.Windows.Forms.Padding(4);
            this.picEnemy.Name = "picEnemy";
            this.picEnemy.Size = new System.Drawing.Size(342, 368);
            this.picEnemy.TabIndex = 1;
            this.picEnemy.TabStop = false;
            // 
            // picPlayer
            // 
            this.picPlayer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.picPlayer.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.player2;
            this.picPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPlayer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picPlayer.Location = new System.Drawing.Point(105, 136);
            this.picPlayer.Margin = new System.Windows.Forms.Padding(4);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(342, 368);
            this.picPlayer.TabIndex = 0;
            this.picPlayer.TabStop = false;
            // 
            // potion
            // 
            this.potion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.potion.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.Potion;
            this.potion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.potion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.potion.Location = new System.Drawing.Point(403, 730);
            this.potion.Margin = new System.Windows.Forms.Padding(4);
            this.potion.Name = "potion";
            this.potion.Size = new System.Drawing.Size(46, 60);
            this.potion.TabIndex = 11;
            this.potion.TabStop = false;
            this.potion.Click += new System.EventHandler(this.potion_Click);
            // 
            // picBossBattle
            // 
            this.picBossBattle.Location = new System.Drawing.Point(0, 0);
            this.picBossBattle.Name = "picBossBattle";
            this.picBossBattle.Size = new System.Drawing.Size(100, 50);
            this.picBossBattle.TabIndex = 0;
            this.picBossBattle.TabStop = false;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(803, 752);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(75, 23);
            this.axWindowsMediaPlayer1.TabIndex = 11;
            this.axWindowsMediaPlayer1.Visible = false;
            // 
            // FrmBattle2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1233, 835);
            this.Controls.Add(this.advert);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.lblEnemyHealthFull);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPlayerHealthFull);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAttack);
            this.Controls.Add(this.btnEscape);
            this.Controls.Add(this.btnHeal);
            this.Controls.Add(this.picEnemy);
            this.Controls.Add(this.picPlayer);
            this.Controls.Add(this.potion);
            this.Controls.Add(this.lblPlayerExpFull);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelpotion);
            this.Controls.Add(this.labellv);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmBattle2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Fight!";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmBattle2_FormClosing);
            this.advert.ResumeLayout(false);
            this.advert.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.potion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBossBattle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picPlayer;
        private System.Windows.Forms.PictureBox picEnemy;
        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.Label lblPlayerHealthFull;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEnemyHealthFull;
        private System.Windows.Forms.PictureBox picBossBattle;

        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnEscape;
        private System.Windows.Forms.Button btnHeal;
        private System.Windows.Forms.PictureBox potion;
        private System.Windows.Forms.Label lblPlayerExpFull;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelpotion;
        private System.Windows.Forms.Label labellv;
        private System.Windows.Forms.Panel advert;
        private System.Windows.Forms.TextBox AdExit;
        private System.Windows.Forms.Timer timer1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}