using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Casino
{
    public partial class GameScreen : Form
    {
        public GameScreen()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            GlobalStuff.gBlackJack.Show();

            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            GlobalStuff.gRoulette.Show();

            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            GlobalStuff.gPoker.Show();

            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            GlobalStuff.gCraps.Show();
            this.Hide();
        }
    }
}
