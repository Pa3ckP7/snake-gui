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
    public partial class Snake2p : Form
    {
        static List<Circle> SnakeP1 = new List<Circle>();
        static List<Circle> SnakeP2 = new List<Circle>();
        static Keys LastKey;
        static Circle food1 = new Circle();
        static Circle food2 = new Circle();
        static Circle food3 = new Circle();
        static Circle food4 = new Circle();
        static Random rng = new Random();
        Form1 f1;
        static bool CodedExit = false;
        public Snake2p(Form1 f1)
        {
            InitializeComponent();
            this.f1 = f1;
            new Settings2p();
            GameTimer.Interval = 1000 / Settings2p.Speed;
            GameTimer.Start();
            GenerateFood();
            StartGame();
        }
        private void GenerateFood()
        {
            int maxX = PbCanvas.Size.Width / Settings2p.Width;
            int maxY = PbCanvas.Size.Height / Settings2p.Height;
            food1 = new Circle(rng.Next(0, maxX), rng.Next(0, maxY));
            food2 = new Circle(rng.Next(0, maxX), rng.Next(0, maxY));
            food3 = new Circle(rng.Next(0, maxX), rng.Next(0, maxY));
            food4 = new Circle(rng.Next(0, maxX), rng.Next(0, maxY));
        }
        private void StartGame()
        {
            new Settings2p();
            SnakeP1.Clear();
            Circle head = new Circle(70, PbCanvas.Size.Height / 32);
            SnakeP1.Add(head);
            for (int i = 0; i < Settings2p.StartingLength; i++)
            {
                Circle segment = new Circle(70, PbCanvas.Size.Height / 32);
                SnakeP1.Add(segment);
            }
            SnakeP2.Clear();
            head = new Circle(2, PbCanvas.Size.Height / 32);
            SnakeP2.Add(head);
            for (int i = 0; i < Settings2p.StartingLength; i++)
            {
                Circle segment = new Circle(2, PbCanvas.Size.Height / 32);
                SnakeP2.Add(segment);
            }

        }

        private void Snake2p_KeyDown(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, true);
            LastKey = e.KeyCode;
        }

        private void Snake2p_KeyUp(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, false);
        }

        private void PbCanvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;
            if (!Settings2p.GameOver)
            {
                Brush color;
                for (int i = 0; i < SnakeP1.Count; i++)
                {
                    if (i == 0)
                    {
                        color = Brushes.YellowGreen;

                    }
                    else
                    {
                        color = Brushes.Lime;

                    }
                    canvas.FillRectangle(color, new Rectangle(SnakeP1[i].X * Settings2p.Width, SnakeP1[i].Y * Settings2p.Height, Settings2p.Width, Settings2p.Height));
                    
                }for (int i = 0; i < SnakeP2.Count; i++)
                {
                    if (i == 0)
                    {
                        color = Brushes.LightBlue;

                    }
                    else
                    {
                        color = Brushes.Blue;

                    }
                    canvas.FillRectangle(color, new Rectangle(SnakeP2[i].X * Settings2p.Width, SnakeP2[i].Y * Settings2p.Height, Settings2p.Width, Settings2p.Height));
                    
                }
                canvas.FillEllipse(Brushes.Red, new Rectangle(food1.X * Settings2p.Width, food1.Y * Settings2p.Height, Settings2p.Width, Settings2p.Height));
                canvas.FillEllipse(Brushes.Red, new Rectangle(food2.X * Settings2p.Width, food2.Y * Settings2p.Height, Settings2p.Width, Settings2p.Height));
                canvas.FillEllipse(Brushes.Red, new Rectangle(food3.X * Settings2p.Width, food3.Y * Settings2p.Height, Settings2p.Width, Settings2p.Height));
                canvas.FillEllipse(Brushes.Red, new Rectangle(food4.X * Settings2p.Width, food4.Y * Settings2p.Height, Settings2p.Width, Settings2p.Height));
            }
           
        }
        private void Update(object sender, EventArgs e)
        {
            if (Settings2p.GameOver)
            {
                GameOver2p go = new GameOver2p(f1);
                go.Show();
                CodedExit = true;
                Close();
            }
            else
            {
                if (Input.KeyPressed(Keys.Up) && Settings2p.direction != Directions.Down)
                {
                    Settings2p.direction = Directions.Up;
                }
                else if (Input.KeyPressed(Keys.Left) && Settings2p.direction != Directions.Right)
                {
                    Settings2p.direction = Directions.Left;
                }
                else if (Input.KeyPressed(Keys.Down) && Settings2p.direction != Directions.Up)
                {
                    Settings2p.direction = Directions.Down;
                }
                else if (Input.KeyPressed(Keys.Right) && Settings2p.direction != Directions.Left)
                {
                    Settings2p.direction = Directions.Right;
                }

                if (Input.KeyPressed(Keys.W) && Settings2p.direction2 != Directions.Down)
                {
                    Settings2p.direction2 = Directions.Up;
                }
                else if (Input.KeyPressed(Keys.A) && Settings2p.direction2 != Directions.Right)
                {
                    Settings2p.direction2 = Directions.Left;
                }
                else if (Input.KeyPressed(Keys.S) && Settings2p.direction2 != Directions.Up)
                {
                    Settings2p.direction2 = Directions.Down;
                }
                else if (Input.KeyPressed(Keys.D) && Settings2p.direction2 != Directions.Left)
                {
                    Settings2p.direction2 = Directions.Right;
                }
                Moves();
                if (Settings2p.direction != Directions.None)
                {
                    FoodCollision();
                    if (SnakeP1[0].X >= PbCanvas.Size.Width / Settings2p.Width || SnakeP1[0].X < 0 || SnakeP1[0].Y < 0 || SnakeP1[0].Y >= PbCanvas.Size.Height / Settings2p.Height)
                    {
                        Settings2p.GameOver = true;
                        Settings2p.match_Result = Match_Result.P2Wins;
                    }
                    if (SnakeP2[0].X >= PbCanvas.Size.Width / Settings2p.Width || SnakeP2[0].X < 0 || SnakeP2[0].Y < 0 || SnakeP2[0].Y >= PbCanvas.Size.Height / Settings2p.Height)
                    {
                        Settings2p.GameOver = true;
                        Settings2p.match_Result = Match_Result.P1Wins;
                    }
                   
                    SnakeonSnakeCollision();
                    if (SnakeP1[0].X == SnakeP2[0].X && SnakeP1[0].Y == SnakeP2[0].Y)
                    {
                        Settings2p.GameOver = true;
                        Settings2p.match_Result = Match_Result.Draw;
                    }
                }
                if (Settings2p.GameOver == true)
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

        private static void SnakeonSnakeCollision()
        {
            for (int i = 1; i < SnakeP1.Count; i++)
            {
                if (SnakeP1[0].X == SnakeP1[i].X && SnakeP1[0].Y == SnakeP1[i].Y)
                {
                    Settings2p.GameOver = true;
                    Settings2p.match_Result = Match_Result.P2Wins;
                }
            }
            for (int i = 1; i < SnakeP2.Count; i++)
            {
                if (SnakeP2[0].X == SnakeP2[i].X && SnakeP2[0].Y == SnakeP2[i].Y)
                {
                    Settings2p.GameOver = true;
                    Settings2p.match_Result = Match_Result.P1Wins;
                }
            }
            for (int i = 1; i < SnakeP2.Count; i++)
            {
                if (SnakeP1[0].X == SnakeP2[i].X && SnakeP1[0].Y == SnakeP2[i].Y)
                {
                    Settings2p.GameOver = true;
                    Settings2p.match_Result = Match_Result.P2Wins;
                }
            }
            for (int i = 1; i < SnakeP1.Count; i++)
            {
                if (SnakeP2[0].X == SnakeP1[i].X && SnakeP2[0].Y == SnakeP1[i].Y)
                {
                    Settings2p.GameOver = true;
                    Settings2p.match_Result = Match_Result.P1Wins;
                }
            }
        }

        private void FoodCollision()
        {
            int maxX = PbCanvas.Size.Width / Settings2p.Width;
            int maxY = PbCanvas.Size.Height / Settings2p.Height;
            if (SnakeP1[0].X == food1.X && SnakeP1[0].Y == food1.Y)
            {
                Settings2p.Score++;
                ScoreText1.Text = Settings2p.Score.ToString();
                Circle segment = new Circle(SnakeP1[SnakeP1.Count - 1].X, SnakeP1[SnakeP1.Count - 1].Y);
                SnakeP1.Add(segment);
                food1= new Circle(rng.Next(0, maxX), rng.Next(0, maxY));
            }
            if (SnakeP1[0].X == food2.X && SnakeP1[0].Y == food2.Y)
            {
                Settings2p.Score++;
                ScoreText1.Text = Settings2p.Score.ToString();
                Circle segment = new Circle(SnakeP1[SnakeP1.Count - 1].X, SnakeP1[SnakeP1.Count - 1].Y);
                SnakeP1.Add(segment);
                food2 = new Circle(rng.Next(0, maxX), rng.Next(0, maxY));
            }
            if (SnakeP1[0].X == food3.X && SnakeP1[0].Y == food3.Y)
            {
                Settings2p.Score++;
                ScoreText1.Text = Settings2p.Score.ToString();
                Circle segment = new Circle(SnakeP1[SnakeP1.Count - 1].X, SnakeP1[SnakeP1.Count - 1].Y);
                SnakeP1.Add(segment);
                food3= new Circle(rng.Next(0, maxX), rng.Next(0, maxY));
            }
            if (SnakeP1[0].X == food4.X && SnakeP1[0].Y == food4.Y)
            {
                Settings2p.Score++;
                ScoreText1.Text = Settings2p.Score.ToString();
                Circle segment = new Circle(SnakeP1[SnakeP1.Count - 1].X, SnakeP1[SnakeP1.Count - 1].Y);
                SnakeP1.Add(segment);
                food4= new Circle(rng.Next(0, maxX), rng.Next(0, maxY));
            }
            if (SnakeP2[0].X == food1.X && SnakeP2[0].Y == food1.Y)
            {
                Settings2p.Score2++;
                ScoreText2.Text = Settings2p.Score2.ToString();
                Circle segment = new Circle(SnakeP2[SnakeP2.Count - 1].X, SnakeP2[SnakeP2.Count - 1].Y);
                SnakeP2.Add(segment);
                food1 = new Circle(rng.Next(0, maxX), rng.Next(0, maxY));
            }
            if (SnakeP2[0].X == food2.X && SnakeP2[0].Y == food2.Y)
            {
                Settings2p.Score2++;
                ScoreText2.Text = Settings2p.Score2.ToString();
                Circle segment = new Circle(SnakeP2[SnakeP2.Count - 1].X, SnakeP2[SnakeP2.Count - 1].Y);
                SnakeP2.Add(segment);
                food2 = new Circle(rng.Next(0, maxX), rng.Next(0, maxY));
            }
            if (SnakeP2[0].X == food3.X && SnakeP2[0].Y == food3.Y)
            {
                Settings2p.Score2++;
                ScoreText2.Text = Settings2p.Score2.ToString();
                Circle segment = new Circle(SnakeP2[SnakeP2.Count - 1].X, SnakeP2[SnakeP2.Count - 1].Y);
                SnakeP2.Add(segment);
                food3 = new Circle(rng.Next(0, maxX), rng.Next(0, maxY));
            }
            if (SnakeP2[0].X == food4.X && SnakeP2[0].Y == food4.Y)
            {
                Settings2p.Score2++;
                ScoreText2.Text = Settings2p.Score2.ToString();
                Circle segment = new Circle(SnakeP2[SnakeP2.Count - 1].X, SnakeP2[SnakeP2.Count - 1].Y);
                SnakeP2.Add(segment);
                food4 = new Circle(rng.Next(0, maxX), rng.Next(0, maxY));
            }
        }
        private void Moves() 
        {
            for (int i = SnakeP1.Count - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    switch (Settings2p.direction)
                    {
                        case Directions.Up:
                            SnakeP1[i].Y--;
                            break;
                        case Directions.Left:
                            SnakeP1[i].X--;
                            break;
                        case Directions.Down:
                            SnakeP1[i].Y++;
                            break;
                        case Directions.Right:
                            SnakeP1[i].X++;
                            break;
                    }
                }
                else
                {
                    SnakeP1[i].X = SnakeP1[i - 1].X;
                    SnakeP1[i].Y = SnakeP1[i - 1].Y;
                }
            }
            for (int i = SnakeP2.Count - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    switch (Settings2p.direction2)
                    {
                        case Directions.Up:
                            SnakeP2[i].Y--;
                            break;
                        case Directions.Left:
                            SnakeP2[i].X--;
                            break;
                        case Directions.Down:
                            SnakeP2[i].Y++;
                            break;
                        case Directions.Right:
                            SnakeP2[i].X++;
                            break;
                    }
                }
                else
                {
                    SnakeP2[i].X = SnakeP2[i - 1].X;
                    SnakeP2[i].Y = SnakeP2[i - 1].Y;
                }
            }
        }

        private void Snake2p_FormClosed(object sender, FormClosedEventArgs e)
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
