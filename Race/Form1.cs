using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Race
{
    public partial class Form1 : Form
    {
        private int roadSpeed;
        private int traficSpeed;
        private int playerSpeed = 5;

        private int score;
        private int carImage;
        

        private Random rand = new Random();
        private Random carPosition = new Random();

        private bool goleft;
        private bool goright;

        private bool goup;
        private bool godown;
        
        public Form1()
        {
            
            InitializeComponent();
            timer1.Tick += Timer_Tick;
            timer1.Interval = 10;
            Score_label.Font = new Font("Arial", 25);
            
            Level_label.Font = new Font("Arial", 25);
            Start_button.Font = new Font("Arial", 25);
            Start_button.Text = "Старт";

            // Level_label.Text = "Рівень: 1";
            
            // this.Size = new Size(1151, 1200);
            roadTrack3.Image = Properties.Resources.road;
            roadTrack3.SizeMode = PictureBoxSizeMode.StretchImage;
            ResetGame();
            
            // this.Load+= OnLoad;
            
            
        }
        
        [SuppressMessage("ReSharper.DPA", "DPA0003: Excessive memory allocations in LOH", MessageId = "type: System.Byte[]; size: 249MB")]
        [SuppressMessage("ReSharper.DPA", "DPA0000: DPA issues")]
        private void Timer_Tick(object sender, EventArgs e)
        {
            Score_label.Text = "Балів : " + score;
            score++;
            
            // if (goleft == true && player.Left > 5)
            // {
            //     player.Left -= playerSpeed;
            //     
            // }
            
            if (goleft == true && player.Left > 5)
            {
                player.Left -= playerSpeed;
                
            }

            if (goright == true && player.Left < 720)
            {
                player.Left += playerSpeed;
            }
            
            if (goup == true && player.Top > 5)
            {
                player.Top -= playerSpeed;
                
            }

            if (godown == true && player.Top < 720)
            {
                player.Top += playerSpeed;
            }

            roadTrack3.Top += roadSpeed;
            roadTrack4.Top += roadSpeed;

            if (roadTrack4.Top > 1148)
            {
                roadTrack4.Top = -1148;
            }
            if (roadTrack3.Top > 1148)
            {
                roadTrack3.Top = -1148;
            }

            AI1.Top += traficSpeed;
            AI2.Top += traficSpeed;

            if (AI1.Top > 1148)
            {
                changeAIcars(AI1);
            }
            
            if (AI2.Top > 1148)
            {
                changeAIcars(AI2);
            }
            
            if (player.Bounds.IntersectsWith(AI1.Bounds) || player.Bounds.IntersectsWith(AI2.Bounds))
            {
                gameOver();
            }

            if (score > 0 && score < 1000)
            {
                Level_label.Text = "Рівень: 1";
                Level_label.ForeColor = Color.Green;
                award.Image = Properties.Resources.BronzeAward;
            }


            if (score > 1000 && score < 3000)
            { 
                Level_label.Text = "Рівень: 2";
                Level_label.ForeColor = Color.Teal;
                player.Image = Properties.Resources.BlueCarL21;
                award.Image = Properties.Resources.BronzeIcreased;
                // roadTrack3.Image = Properties.Resources.roadWarn;
                // roadTrack4.Image = Properties.Resources.roadWarn;
                roadSpeed = 18;
                traficSpeed = 15;
            }

            if (score > 3000 && score < 5000)
            {
                Level_label.ForeColor = Color.MediumBlue;
                Level_label.Text = "Рівень: 3";
                player.Image = Properties.Resources.BlueCarL31;
                award.Image = Properties.Resources.SilverAward;
                traficSpeed = 23;
                roadSpeed = 20;
            }
            if (score > 5000 && score < 8000)
            {
                Level_label.Text = "Рівень: 4";
                Level_label.ForeColor = Color.Orange;
                player.Image = Properties.Resources.YellowRedCar1;
                award.Image = Properties.Resources.SilverIcreased;
                traficSpeed = 27;
                roadSpeed = 25;
            }
            if (score > 8000 && score < 10000)
            {
                Level_label.Text = "Рівень: 5";
                Level_label.ForeColor = Color.DarkRed;
                player.Image = Properties.Resources.BlueCarL4F11;
                award.Image = Properties.Resources.GoldAward;
                traficSpeed = 30;
                roadSpeed = 32;
            }
            if (score > 10000)
            {
                Level_label.Text = "Рівень: 6";
                Level_label.ForeColor = Color.Black;
                player.Image = Properties.Resources.PoliceCar1;
                award.Image = Properties.Resources.LegendAward;
                traficSpeed = 35;
                roadSpeed = 38;
            }
            



        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = true;
            }
            if (e.KeyCode == Keys.Up)
            {
                goup = true;
            }

            if (e.KeyCode == Keys.Down)
            {
                godown = true;
            }

            
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                goup = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                godown = false;
            }
        }

        private void changeAIcars(PictureBox tempCar)
        {
            carImage = rand.Next(1, 16);

            switch (carImage)
            {
                case 1:
                    tempCar.Image = Properties.Resources.AcuraCar1;
                    break;
                case 2:
                    tempCar.Image = Properties.Resources.AstonMartinCar1;
                    break;
                case 3:
                    tempCar.Image = Properties.Resources.KoenigseggCar1;
                    break;
                case 4:
                    tempCar.Image = Properties.Resources.LamboCar1;
                    break;
                case 5:
                    tempCar.Image = Properties.Resources.SimpleBlueCar1;
                    break;
                case 6:
                    tempCar.Image = Properties.Resources.PoliceCar1;
                    break;
                case 7:
                    tempCar.Image = Properties.Resources.SimpleGrayCar1;
                    break;
                case 8:
                    tempCar.Image = Properties.Resources.SimpleGreenCar1;
                    break;
                case 9:
                    tempCar.Image = Properties.Resources.SimpleOrangeCar1;
                    break;
                
                case 10:
                    tempCar.Image = Properties.Resources.SimpleRedCar1;
                    break;
                case 11:
                    tempCar.Image = Properties.Resources.SimpleYellowCar1;
                    break;
                case 12:
                    tempCar.Image = Properties.Resources.TaxiCar1;
                    break;
                case 13:
                    tempCar.Image = Properties.Resources.WhiteCar1;
                    break;
                case 14:
                    tempCar.Image = Properties.Resources.YellowCar1;
                    break;
                case 15:
                    tempCar.Image = Properties.Resources.YellowRedCar1;
                    break;
                case 16:
                    tempCar.Image = Properties.Resources.NeGenCar1;
                    break;
            }

            tempCar.Top = carPosition.Next(100, 500) * -1;

            if ((string)tempCar.Tag == "Left")
            {
                tempCar.Left = carPosition.Next(5, 200);
            }
            if ((string)tempCar.Tag == "Right")
            {
                tempCar.Left = carPosition.Next(350, 750);
            }

        }

        private void gameOver()
        {
            // playSound();
            timer1.Stop();
            explosion.Visible = true;
            player.Controls.Add(explosion);
            explosion.Location = new Point(15, 15);
            explosion.BackColor = Color.Transparent;

            award.Visible = true;
            award.BringToFront();

            Start_button.Enabled = true;
        }

        private void ResetGame()
        {
            roadTrack3.Location = new Point(0, -1148);
            roadTrack4.Location = new Point(0, 0);
            roadTrack3.Image = Properties.Resources.road;
            roadTrack4.Image = Properties.Resources.road;
            player.Image = Properties.Resources.BlueCarL12;
            // roadTrack1.Size = new Size(475,521);
            // roadTrack2.Size = new Size(475,521);
            Start_button.Enabled = false;
            explosion.Visible = false;
            goleft = false;
            goright = false;
            score = 0;
            award.Image = Properties.Resources.BronzeAward;
            award.Visible = false;


            roadSpeed = 12;
            traficSpeed = 10;
            
            AI1.Top = carPosition.Next(200, 500) * -1;
            AI1.Left = carPosition.Next(5, 200);// интервал по ОХ где може заспавниться машинка

            AI2.Top = carPosition.Next(200,500) * -1;
            AI2.Left = carPosition.Next(350, 700);// интервал по ОХ где може заспавниться машинка
            
            
            timer1.Start();
            
            
        }
        
        
        // private void playSound()
        // {
        //     // System.Media.SoundPlayer playCrash = new System.Media.SoundPlayer(Properties.Resources.hit);
        //     // playCrash.Play();
        //     
        // }


        private void Start_button_Click(object sender, EventArgs e)
        {
            ResetGame();
        }
    }
}