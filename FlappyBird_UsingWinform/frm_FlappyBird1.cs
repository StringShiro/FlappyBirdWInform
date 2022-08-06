using System;
using System.Drawing;
using System.Threading;
using System.Windows;
using System.Windows.Forms;

namespace FlappyBird_UsingWinform
{
    public partial class frm_FlappyBird : Form
    {
        int gravity = 5;
        int pipeSpeed = 4;
        int gameScore = 0;
        bool gameOver = true;

        public frm_FlappyBird()
        {
            InitializeComponent();
            Picbox_bird.BackColor = Color.Transparent;
            Picbox_pipedown.BackColor = Color.Transparent;
            Picbox_pipeup.BackColor = Color.Transparent;
            Picbox_pipedown1.BackColor = Color.Transparent;
            Picbox_pipeup1.BackColor = Color.Transparent;
            Picbox_point.BackColor = Color.Transparent;
        }

        private void frm_FlappyBird_Load(object sender, EventArgs e)
        {

        }

        Random rnd = new Random();

        private void gameTimerEvent(object sender, EventArgs e)
        {
            Picbox_bird.Top += gravity;
            //pipe
            Picbox_point.Left -= pipeSpeed;
            Picbox_pipedown.Left -= pipeSpeed;
            Picbox_pipeup.Left -= pipeSpeed;
            Picbox_pipedown1.Left -= pipeSpeed;
            Picbox_pipeup1.Left -= pipeSpeed;
            //score
            lbl_Score.Text = "Score:" + gameScore;

            //tạo cột ngẫu nhiên && point
            if(Picbox_point.Left < 80)
            {
                Picbox_point.Left = rnd.Next(400, 800);
                gameScore++;
                if (Picbox_pipedown.Left < -100 && Picbox_pipeup.Left < -100)
                {
                    Picbox_pipedown.Left = rnd.Next(400, 800);
                    Picbox_pipeup.Left = rnd.Next(300, 800);
                }
                if (Picbox_pipedown1.Left < -250 && Picbox_pipeup1.Left < -250)
                {
                    Picbox_pipedown1.Left = rnd.Next(400, 700);
                    Picbox_pipeup1.Left = rnd.Next(400, 700);
                }
            }
           
            //tạo event va chạm chủ thể là Picbox_Bird
           if (Picbox_bird.Bounds.IntersectsWith(Picbox_ground.Bounds)
               || Picbox_bird.Bounds.IntersectsWith(Picbox_pipeup.Bounds)
               || Picbox_bird.Bounds.IntersectsWith(Picbox_pipedown.Bounds)
               || Picbox_bird.Bounds.IntersectsWith(Picbox_pipeup1.Bounds)
               || Picbox_bird.Bounds.IntersectsWith(Picbox_pipedown1.Bounds)
               )
            {
                gameTimer.Stop();
                lbl_Score.Text += " Game Over !!!";
            }

            //tăng độ khó game bằng cách tăng tốc độ xuất hiện các cột
            Increase_Hard();
        }

        private void Increase_Hard()
        {
            if (gameScore > 10)
            {
                pipeSpeed = 8;
                    gravity = 7;
            }
            if (gameScore > 20)
            {
                pipeSpeed = 10;
                gravity = 8;
            }
            if (gameScore > 30)
            {
                pipeSpeed = 12;
                gravity = 9;
            }
            if (gameScore > 40)
            {
                pipeSpeed = 14;
                gravity = 10;
            }
        }
        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) {
                gravity = -6;
            }
            else if (e.KeyCode == Keys.Enter) {
                gameTimer.Start();
                gameTimer.Enabled = true;
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 5;
            }
        }
    }
}
