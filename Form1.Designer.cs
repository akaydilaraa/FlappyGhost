namespace FlappyGhost
{
    partial class FlappyGhost
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ağ = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.pipeBottom = new System.Windows.Forms.PictureBox();
            this.pipeTop = new System.Windows.Forms.PictureBox();
            this.Bird = new System.Windows.Forms.PictureBox();
            this.scoreText = new System.Windows.Forms.Label();
            this.newgametext = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ağ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bird)).BeginInit();
            this.SuspendLayout();
            // 
            // ağ
            // 
            this.ağ.Image = global::FlappyGhost.Properties.Resources.pngwing_com__13_;
            this.ağ.Location = new System.Drawing.Point(1, 0);
            this.ağ.Name = "ağ";
            this.ağ.Size = new System.Drawing.Size(313, 349);
            this.ağ.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ağ.TabIndex = 4;
            this.ağ.TabStop = false;
            // 
            // ground
            // 
            this.ground.BackColor = System.Drawing.Color.Black;
            this.ground.Location = new System.Drawing.Point(1, 508);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(1050, 176);
            this.ground.TabIndex = 2;
            this.ground.TabStop = false;
            // 
            // pipeBottom
            // 
            this.pipeBottom.Image = global::FlappyGhost.Properties.Resources.pngwing_com;
            this.pipeBottom.Location = new System.Drawing.Point(514, 326);
            this.pipeBottom.Name = "pipeBottom";
            this.pipeBottom.Size = new System.Drawing.Size(83, 185);
            this.pipeBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeBottom.TabIndex = 3;
            this.pipeBottom.TabStop = false;
            // 
            // pipeTop
            // 
            this.pipeTop.Image = global::FlappyGhost.Properties.Resources.pngwing_com;
            this.pipeTop.Location = new System.Drawing.Point(699, 0);
            this.pipeTop.Name = "pipeTop";
            this.pipeTop.Size = new System.Drawing.Size(79, 172);
            this.pipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeTop.TabIndex = 1;
            this.pipeTop.TabStop = false;
            // 
            // Bird
            // 
            this.Bird.Image = global::FlappyGhost.Properties.Resources.pngeg;
            this.Bird.Location = new System.Drawing.Point(275, 183);
            this.Bird.Name = "Bird";
            this.Bird.Size = new System.Drawing.Size(85, 74);
            this.Bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Bird.TabIndex = 0;
            this.Bird.TabStop = false;
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.scoreText.ForeColor = System.Drawing.Color.White;
            this.scoreText.Location = new System.Drawing.Point(784, 0);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(119, 37);
            this.scoreText.TabIndex = 5;
            this.scoreText.Text = "Score:0";
            // 
            // newgametext
            // 
            this.newgametext.AutoSize = true;
            this.newgametext.BackColor = System.Drawing.Color.Black;
            this.newgametext.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.newgametext.ForeColor = System.Drawing.Color.White;
            this.newgametext.Location = new System.Drawing.Point(251, 520);
            this.newgametext.Name = "newgametext";
            this.newgametext.Size = new System.Drawing.Size(0, 39);
            this.newgametext.TabIndex = 6;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // FlappyGhost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1010, 577);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.newgametext);
            this.Controls.Add(this.Bird);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.pipeBottom);
            this.Controls.Add(this.ağ);
            this.Controls.Add(this.pipeTop);
            this.Name = "FlappyGhost";
            this.Text = "Flappy Ghost";
            ((System.ComponentModel.ISupportInitialize)(this.ağ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bird)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Bird;
        private System.Windows.Forms.PictureBox pipeTop;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox pipeBottom;
        private System.Windows.Forms.PictureBox ağ;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.Label newgametext;
        private System.Windows.Forms.Timer gameTimer;
    }
}

