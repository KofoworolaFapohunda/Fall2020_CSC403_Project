namespace Fall2020_CSC403_Project
{
    partial class FrmSelectCharacter
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
            this.select_charatecter_text = new System.Windows.Forms.Label();
            this.picYuji = new System.Windows.Forms.PictureBox();
            this.picMegumi = new System.Windows.Forms.PictureBox();
            this.picNobara = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picYuji)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMegumi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNobara)).BeginInit();
            this.SuspendLayout();
            // 
            // select_charatecter_text
            // 
            this.select_charatecter_text.AutoSize = true;
            this.select_charatecter_text.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.select_charatecter_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.select_charatecter_text.ForeColor = System.Drawing.Color.Brown;
            this.select_charatecter_text.Location = new System.Drawing.Point(300, 35);
            this.select_charatecter_text.Name = "select_charatecter_text";
            this.select_charatecter_text.Size = new System.Drawing.Size(806, 91);
            this.select_charatecter_text.TabIndex = 0;
            this.select_charatecter_text.Text = "Select your Character";
            // 
            // picYuji
            // 
            this.picYuji.BackColor = System.Drawing.Color.Transparent;
            this.picYuji.Image = global::Fall2020_CSC403_Project.Properties.Resources.mc1;
            this.picYuji.Location = new System.Drawing.Point(115, 165);
            this.picYuji.Name = "picYuji";
            this.picYuji.Size = new System.Drawing.Size(334, 486);
            this.picYuji.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picYuji.TabIndex = 1;
            this.picYuji.TabStop = false;
            this.picYuji.Click += new System.EventHandler(this.picYuji_Click);
            // 
            // picMegumi
            // 
            this.picMegumi.BackColor = System.Drawing.Color.Transparent;
            this.picMegumi.Image = global::Fall2020_CSC403_Project.Properties.Resources.mc2;
            this.picMegumi.Location = new System.Drawing.Point(548, 165);
            this.picMegumi.Name = "picMegumi";
            this.picMegumi.Size = new System.Drawing.Size(334, 486);
            this.picMegumi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMegumi.TabIndex = 2;
            this.picMegumi.TabStop = false;
            this.picMegumi.Click += new System.EventHandler(this.picMegumi_Click);
            // 
            // picNobara
            // 
            this.picNobara.BackColor = System.Drawing.Color.Transparent;
            this.picNobara.Image = global::Fall2020_CSC403_Project.Properties.Resources.mc3;
            this.picNobara.Location = new System.Drawing.Point(961, 165);
            this.picNobara.Name = "picNobara";
            this.picNobara.Size = new System.Drawing.Size(334, 486);
            this.picNobara.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNobara.TabIndex = 3;
            this.picNobara.TabStop = false;
            this.picNobara.Click += new System.EventHandler(this.picNobara_Click);
            // 
            // FrmSelectCharacter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1390, 695);
            this.Controls.Add(this.picNobara);
            this.Controls.Add(this.picMegumi);
            this.Controls.Add(this.picYuji);
            this.Controls.Add(this.select_charatecter_text);
            this.DoubleBuffered = true;
            this.Name = "FrmSelectCharacter";
            this.Text = "FrmSelectCharacter";
            ((System.ComponentModel.ISupportInitialize)(this.picYuji)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMegumi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNobara)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label select_charatecter_text;
        private System.Windows.Forms.PictureBox picYuji;
        private System.Windows.Forms.PictureBox picMegumi;
        private System.Windows.Forms.PictureBox picNobara;
    }
}