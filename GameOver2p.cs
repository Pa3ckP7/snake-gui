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
    public partial class GameOver2p : Form
    {
        Form1 f1;
        static bool CodedExit = false;
        public GameOver2p(Form1 f1)
        {
            InitializeComponent();
            this.f1 = f1;
        }

        private void RematchButton_Click(object sender, EventArgs e)
        {
            Snake2p s2p = new Snake2p(f1);
            s2p.Show();
            CodedExit = true;
            Close();
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            f1.Show();
            CodedExit = true;
            Close();
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GameOver2p_Load(object sender, EventArgs e)
        {
            Score1Text.Text = Settings2p.Score.ToString();
            Score2Text.Text = Settings2p.Score2.ToString();
            switch (Settings2p.match_Result) 
            {
                case Match_Result.P1Wins:
                    MatchResultText.Text = "Player1 Wins";
                    this.BackgroundImage = Image.FromFile("assets/menu/p1win.png");
                    break;
                case Match_Result.P2Wins:
                    MatchResultText.Text = "Player2 Wins";
                    this.BackgroundImage = Image.FromFile("assets/menu/p2win.png");
                    break;
                case Match_Result.Draw:
                    MatchResultText.Text = "It's a Draw";
                    this.BackgroundImage = Image.FromFile("assets/menu/draw.png");
                    break;
            }
        }

        private void GameOver2p_FormClosed(object sender, FormClosedEventArgs e)
        {

            if (CodedExit == false)
            {
                Application.Exit();
            }
            CodedExit = false;
        }
    }
}
