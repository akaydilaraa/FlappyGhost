using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyGhost
{
    public partial class FlappyGhost : Form
    {
        // Oyun ilk başladığında boru hızı,yerçekimi ve skor gibi temel değişkenlerini tanımlar.

        int pipeSpeed = 10;// Boruların hareket hızı
        int gravity = 15;// Kuşa etki eden yerçekimi
        int score = 0;// Oyuncunun puanı
        int highscore = 0;//En yüksek puan
        public FlappyGhost()
        {
            InitializeComponent();
            //Klavye olayları için
            this.KeyDown += new KeyEventHandler(gamekeyisdown); // Tuş basıldığında ne olacağını söyler
            this.KeyUp += new KeyEventHandler(gamekeyisup); // Tuş bırakıldığında ne olacağını söyler
            this.KeyPreview = true; // Formdaki kontrollerden önce klavye olaylarını işleve koymak için
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            Bird.Top += gravity;// Kuşu düşürür veya yükseltir.
            pipeBottom.Left -= pipeSpeed; // Alt boruyu sola kaydırır.
            pipeTop.Left -= pipeSpeed;// Üst boruyu sola kaydırır.
            scoreText.Text = "Score :" + score;// Puanı ekranda gösterir.

            // Alt boru ekranın solundan çıkarsa başa alır ve puanı artırır.
            if (pipeBottom.Left < -150)
            {
                pipeBottom.Left = 800;
                score++;
            }
            // Üst boru ekranın solundan çıkarsa başa alır ve puanı artırır.
            if (pipeTop.Left < -180)
            {
                pipeTop.Left = 950;
                score++;

            }
            // Kuşun borulara, zemine veya ekranın üst kısmına çarpmasını kontrol eder.
            if (Bird.Bounds.IntersectsWith(pipeBottom.Bounds) ||
                Bird.Bounds.IntersectsWith(pipeTop.Bounds) ||
                Bird.Bounds.IntersectsWith(ground.Bounds) || Bird.Top < -25)
            {

                // Eğer temas ederse oyun biter.
                endGame();
            }

            // Puan 5'i geçerse boru hızını artırır.
            if (score > 5)
            {
                pipeSpeed = 20;
            }
            //Puan 20'yi geçerse 
            if (score > 20)
            {
                pipeSpeed = 26;
            }
        }

        // Bir tuş basıldığında çalışır.
        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)// Eğer Space tuşuna basıldıysa
            {
                if (!gameTimer.Enabled) // Oyun bitmemişse
                {
                    restartGame(); // Yeniden başlat
                }
                else//Oyun devam ediyorsa
                {
                    gravity = -15; // Kuşu yukarı it
                }
            }
        }
            private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)// Eğer Space tuşu bırakıldıysa
            {
                gravity = 15;// Kuşu aşağı düşürür.
            }


        }
        // Oyun sona erdiğinde çalışır.
        private void endGame()
        {
            gameTimer.Stop(); // Zamanlayıcıyı durdurur.
            scoreText.Text += "\nGAME OVER!!!";// Oyun bitti mesajı ekler.

            //Eğer score highscore dan büyük olursa highscore a atama yapılsın.
            if (score > highscore)
            {
                highscore = score;
                scoreText.Text = "Congratulations" + "\nHighscore: " + highscore;
            }
            //Değilse yeniden deneyiniz yazısı ile mevcut hihgscoree yazılsın.
            else
            {
                scoreText.Text = "Try again" + "\nHighscore: " + highscore;
            }

            newgametext.Text += "Press SPACE to restart...";// Yeniden başlatma bilgisi.
        }
        // Oyunu yeniden başlatır.
        private void restartGame()
        {
            score = 0;// Skoru sıfırlar.
            scoreText.Text = "Score: " + score;
            newgametext.Text = ""; // Bilgilendirme metnini temizler.

            // Boruları ve kuşu başlangıç konumlarına getirir.
            pipeBottom.Left = 800;
            pipeTop.Left = 950;
            Bird.Top = 100;
            gravity = 15;// Yerçekimini varsayılan değere döndürür.
            gameTimer.Start();//Zamanlayıcıyı başlatır.
        }
    }
}
