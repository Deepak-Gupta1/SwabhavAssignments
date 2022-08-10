using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToeLib.Model;

namespace TicTacToeGame
{
    public partial class Form2 : Form
    {
        string p1 = "";
        string p2 = "";
        Player[] p = new Player[2];
        Board board;
        Game game;
        public Form2(string player1 ,string player2)
        {
            p1= player1;
            p2= player2;
            p[0] = new Player(p1, MarkType.O);
            p[1] = new Player(p2, MarkType.X);
            board = new Board(new Cell[9]);
            game = new Game(p, board, new ResultAnalyzer(board));
            InitializeComponent();
        }
        private void Form2_Load_1(object sender, EventArgs e)
        {
            label7.Text = p1;
            label6.Text = game.Status.ToString();
        }

        private void button_Click(object sender, EventArgs e)
        {
            label7.Text = game.CurrentPlayer.Name;
            Button button = (Button)sender;
            string loc = button.Text;
            button.Text = game.CurrentPlayer.Mark.ToString();
            game.Play(int.Parse(loc) - 1);
            label6.Text = game.Status.ToString();
            if (game.Status == ResultType.WIN)
            {
                label5.Text = "\nCongratulation!! "+game.CurrentPlayer.Name+ " WON 🎉🎊";
            }
            if (game.Status == ResultType.DRAW)
            {
                label5.Text = "\nGame DRAW , Try Again !!🤝";
            }
            label7.Text = game.CurrentPlayer.Name;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
