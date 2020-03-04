using HuntTheWumups;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HuntTheWumpus
{
    public partial class Form1 : Form
    {
        UI ui;
        int x = 100;
        int y = 100;
        int animationNumber = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void construct_objects_Click(object sender, EventArgs e)
        {
            Cave cave = new Cave();
            GameControl game = new GameControl();
            HighScore highScore = new HighScore(0);
            Trivia trivia = new Trivia();
            ui = new UI();
        }

        private void movePlayer_Click(object sender, EventArgs e)
        {
            x = Convert.ToInt32(playerInputX.Text);
            y = Convert.ToInt32(playerInputY.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(ui != null)
            {
                ui.drawPlayer(x, y, true, player, animationNumber);
                if(animationNumber < 3)
                {
                    animationNumber++;
                }
                else
                {
                    animationNumber = 0;
                }
            }
        }
    }
}
