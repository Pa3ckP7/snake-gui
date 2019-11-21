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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SoloButton_Click(object sender, EventArgs e)
        {
            SnakeSolo ss = new SnakeSolo(this);
            ss.Show();
            Hide();
        }

        private void Player2Button_Click(object sender, EventArgs e)
        {
            Snake2p sm = new Snake2p(this);
            sm.Show();
            Hide();
        }
    }
}
