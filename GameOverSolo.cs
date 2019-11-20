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
    public partial class GameOverSolo : Form
    {
        Form1 f1;
        static bool CodedExit = false;
        public GameOverSolo(Form1 f1, int Score)
        {
            InitializeComponent();
            ScoreText.Text = Score.ToString();
            this.f1 = f1;
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            f1.Show();
            CodedExit = true;
            Close();
        }

        private void RetryButton_Click(object sender, EventArgs e)
        {
            SnakeSolo ss = new SnakeSolo(f1);
            ss.Show();
            CodedExit = true;
            Close();
        }

        private void GameOverSolo_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (CodedExit == false) 
            {
                Application.Exit();
            }
            CodedExit = false;
        }
    }
}
