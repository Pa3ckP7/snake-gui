using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake_gui
{
    public partial class SnakeSolo : Form
    {
        static List<Circle> Snake = new List<Circle>();
        static Keys LastKey;
        static Circle food = new Circle();
        static Random rng = new Random();
        Form1 f1;
        static bool CodedExit = false;
        public SnakeSolo(Form1 f1)
        {
            InitializeComponent();
            this.f1 = f1;
            new SettingsSolo();
            GameTimer.Interval = 1000 / SettingsSolo.Speed;
            GameTimer.Start();
            GenerateFood();
            StartGame();
        }

        private void UpdateScreen(object sender, EventArgs e)
        {
            if (SettingsSolo.GameOver)
            {
                GameOverSolo gos = new GameOverSolo(f1,SettingsSolo.Score);
                gos.Show();
                CodedExit = true;
                Close();
            }
            else 
            {
                if (Input.KeyPressed(Keys.Up) && SettingsSolo.direction != Directions.Down)
                {
                    SettingsSolo.direction = Directions.Up;
                }
                else if (Input.KeyPressed(Keys.Left) && SettingsSolo.direction != Directions.Right)
                {
                    SettingsSolo.direction = Directions.Left;
                }
                else if (Input.KeyPressed(Keys.Down) && SettingsSolo.direction != Directions.Up)
                {
                    SettingsSolo.direction = Directions.Down;
                }
                else if (Input.KeyPressed(Keys.Right) && SettingsSolo.direction != Directions.Left) 
                {
                    SettingsSolo.direction = Directions.Right;
                }
                Moves();
                if (SettingsSolo.direction != Directions.None)
                {
                    if (Snake[0].X == food.X && Snake[0].Y == food.Y)
                    {
                        SettingsSolo.Score++;
                        ScoreText.Text = SettingsSolo.Score.ToString();
                        Circle segment = new Circle(Snake[Snake.Count - 1].X, Snake[Snake.Count - 1].Y);
                        Snake.Add(segment);
                        GenerateFood();
                    }
                    if (Snake[0].X > PbCanvas.Size.Width / SettingsSolo.Width || Snake[0].X < 0 || Snake[0].Y < 0 || Snake[0].Y > PbCanvas.Size.Height / SettingsSolo.Height)
                    {
                        SettingsSolo.GameOver = true;
                    }
                    for (int i = 1; i < Snake.Count; i++) 
                    {
                        if (Snake[0].X == Snake[i].X && Snake[0].Y == Snake[i].Y) 
                        {
                            SettingsSolo.GameOver = true;
                        }
                    }
                }
                if (SettingsSolo.GameOver == true) 
                {
                    DateTime time1 = DateTime.Now;
                    DateTime time2 = DateTime.Now;
                    while (time2.Subtract(time1).TotalSeconds < 3) 
                    {
                        time2 = DateTime.Now;
                        continue;
                    }
                }
                
            }
            PbCanvas.Invalidate();
        }
        private void StartGame() 
        {
            new SettingsSolo();
            Snake.Clear();
            Circle head = new Circle(PbCanvas.Size.Width/32,PbCanvas.Size.Height/32);
            Snake.Add(head);
            for (int i = 0; i < SettingsSolo.StartingLength;i++) 
            {
                Circle segment = new Circle(PbCanvas.Size.Width / 32, PbCanvas.Size.Height / 32);
                Snake.Add(segment);
            }

        }
        private void GenerateFood() 
        {
            int maxX = PbCanvas.Size.Width / SettingsSolo.Width;
            int maxY = PbCanvas.Size.Height / SettingsSolo.Height;
            food = new Circle(rng.Next(0,maxX),rng.Next(0,maxY));
        }

        private void PbCanvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;
            if (!SettingsSolo.GameOver)
            {
                Brush color;
                for (int i = 0; i < Snake.Count; i++)
                {
                    if (i == 0)
                    {
                        color = Brushes.YellowGreen;
                        
                    }
                    else
                    {
                        color = Brushes.Lime;
                        color = Brushes.MediumPurple;
                    }
                    canvas.FillRectangle(color, new Rectangle(Snake[i].X * SettingsSolo.Width, Snake[i].Y * SettingsSolo.Height, SettingsSolo.Width, SettingsSolo.Height));
                    canvas.FillEllipse(Brushes.Red, new Rectangle(food.X * SettingsSolo.Width, food.Y * SettingsSolo.Height, SettingsSolo.Width, SettingsSolo.Height));
                }
            }
            else 
            {
                SettingsSolo.GameOver = true;
            }
        }
        private void Moves() 
        {
            for (int i = Snake.Count-1; i >= 0; i--) 
            {
                if (i == 0) 
                {
                    switch (SettingsSolo.direction) 
                    {
                        case Directions.Up:
                            Snake[i].Y--;
                            break;
                        case Directions.Left:
                            Snake[i].X--;
                            break;
                        case Directions.Down:
                            Snake[i].Y++;
                            break;
                        case Directions.Right:
                            Snake[i].X++;
                            break;
                    }
                }
                else 
                {
                    Snake[i].X = Snake[i - 1].X;
                    Snake[i].Y = Snake[i - 1].Y;
                }
            }
        }

        private void SnakeSolo_KeyDown(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, true);
            LastKey = e.KeyCode;
        }
        private void SnakeSolo_KeyUp(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, false);
        }

        private void SnakeSolo_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (CodedExit == false) 
            {
                f1.Show();
                
            }
            CodedExit = false;
            Input.ChangeState(LastKey, false);
        }
    }
}
