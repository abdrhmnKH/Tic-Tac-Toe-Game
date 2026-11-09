using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tic_Tac_Toe_Game.Properties;

namespace Tic_Tac_Toe_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color White = Color.FromArgb(255,255,255,255);
            Pen Pen = new Pen(White);
            Pen.Width = 10;
            Pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            Pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            e.Graphics.DrawLine(Pen, 300, 187, 750, 187);
            e.Graphics.DrawLine(Pen, 300, 293, 750, 293);

            e.Graphics.DrawLine(Pen, 450, 80, 450, 400);
            e.Graphics.DrawLine(Pen, 600, 80, 600, 400);
        }
        byte WhoIsPlaying()
        {
            if (PlayerTurn.Text == "Player 1")
                return 1;
            else if(PlayerTurn.Text=="Player 2")
                return 2;
            return 0;
        }
        bool IsDraw()
        {
            return picbox1.Tag.ToString() != "?" &&
                   picbox2.Tag.ToString() != "?" &&
                   picbox3.Tag.ToString() != "?" &&
                   picbox4.Tag.ToString() != "?" &&
                   picbox5.Tag.ToString() != "?" &&
                   picbox6.Tag.ToString() != "?" &&
                   picbox7.Tag.ToString() != "?" &&
                   picbox8.Tag.ToString() != "?" &&
                   picbox9.Tag.ToString() != "?";
        }
        void Player1and2Turn(object sender) {
            PictureBox picture = (PictureBox)sender;
            if (picture.Tag.ToString() == "?")
            {
                if (WhoIsPlaying() == 1)
                {
                    picture.Image = Resources.x_mark1;
                    picture.Tag = "X";
                    PlayerTurn.Text = "Player 2";
                    
                }
                else if (WhoIsPlaying() == 2)
                {
                    picture.Image = Resources.o_mark1;
                    picture.Tag = "O";
                    PlayerTurn.Text = "Player 1";
                }
            }
        }
        void GameOverMessage(short Wplayer) {
                label6.Text = "Player " + Wplayer + " Wins";
                MessageBox.Show("Game Over", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }
        public bool CheckValues(PictureBox a, PictureBox b, PictureBox c) {
           
            if ((a.Tag.ToString() != "?") && (a.Tag.ToString() == b.Tag.ToString()) && (b.Tag.ToString() == c.Tag.ToString()))
            {
                if (a.Tag.ToString() == "X") {
                    a.BackColor = Color.GreenYellow;
                    b.BackColor = Color.GreenYellow;
                    c.BackColor = Color.GreenYellow;
                    GameOverMessage(1);
                    return true;
                }

                else if(a.Tag.ToString() == "O")
                {

                    a.BackColor = Color.GreenYellow;
                    b.BackColor = Color.GreenYellow;
                    c.BackColor = Color.GreenYellow;
                    GameOverMessage(2);
                    return true;
                }  
            }
            if (IsDraw()) {
                label6.Text = "Draw !";
            }
            return false;
        }
        void IsWinner() {
            if (CheckValues(picbox1, picbox2, picbox3))
            {

                return;

            }
            else if (CheckValues(picbox1, picbox5, picbox9))
            {

                return;
            }
            else if (CheckValues(picbox4, picbox5, picbox6))
            {

                return;
            }
            else if (CheckValues(picbox7, picbox8, picbox9))
            {

                return;
            }
            else if (CheckValues(picbox1, picbox4, picbox7))
            {
                return;
            }
            else if (CheckValues(picbox2, picbox5, picbox8))
            {
                return;
            }
            else if (CheckValues(picbox3, picbox6, picbox9))
            {
                return;
            }
            else if (CheckValues(picbox3, picbox5, picbox7))
            {
                return;
            }
            else
                label6.Text = label6.Text;
        }
        private void picbox1_Click(object sender, EventArgs e)
        {
            Player1and2Turn(sender);
            IsWinner();
        }

        private void picbox2_Click(object sender, EventArgs e)
        {
            Player1and2Turn(sender);
            IsWinner();
        }

        private void picbox3_Click(object sender, EventArgs e)
        {
            Player1and2Turn(sender);
            IsWinner();
        }

        private void picbox4_Click(object sender, EventArgs e)
        {
            Player1and2Turn(sender);
            IsWinner();
        }

        private void picbox5_Click(object sender, EventArgs e)
        {
            Player1and2Turn(sender);
            IsWinner();
        }

        private void picbox6_Click(object sender, EventArgs e)
        {
            Player1and2Turn(sender);
            IsWinner();
        }

        private void picbox7_Click(object sender, EventArgs e)
        {
            Player1and2Turn(sender);
            IsWinner();
        }

        private void picbox8_Click(object sender, EventArgs e)
        {
            Player1and2Turn(sender);
            IsWinner();
        }

        private void picbox9_Click(object sender, EventArgs e)
        {
            Player1and2Turn(sender);
            IsWinner();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            PlayerTurn.Text = "Player 1";
            label6.Text = "In Progress";
            picbox1.Image = Resources.Screenshot_2026_11_09_160132;
            picbox1.Tag = "?";
            picbox2.Image = Resources.Screenshot_2026_11_09_160132;
            picbox2.Tag = "?";
            picbox3.Image = Resources.Screenshot_2026_11_09_160132;
            picbox3.Tag = "?";
            picbox4.Image = Resources.Screenshot_2026_11_09_160132;
            picbox4.Tag = "?";
            picbox5.Image = Resources.Screenshot_2026_11_09_160132;
            picbox5.Tag = "?";
            picbox6.Image = Resources.Screenshot_2026_11_09_160132;
            picbox6.Tag = "?";
            picbox7.Image = Resources.Screenshot_2026_11_09_160132;
            picbox7.Tag = "?";
            picbox8.Image = Resources.Screenshot_2026_11_09_160132;
            picbox8.Tag = "?";
            picbox9.Image = Resources.Screenshot_2026_11_09_160132;
            picbox9.Tag = "?";
        }

    }
}
