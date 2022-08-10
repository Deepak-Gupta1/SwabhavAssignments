using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TDDTicTacToeSln;
using TicTacToeLib.Model;
using TicTacToeLib;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string p1="";
        string p2="";
        Player[] p = new Player[2];
        Board board;
        Game game;


        public Form1()
        {
            p[0] = new Player(p1, MarkType.O);
            p[1] = new Player(p2, MarkType.X);
            board = new Board(new Cell[9]);
            game = new Game(p, board, new ResultAnalyzer(board));
            //game.Play();
            InitializeComponent();
        }
        
        private void label1_Click(object sender, EventArgs e)
        {
            

        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           p2=textBox2.Text;


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            p1=textBox1.Text;

        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //game.Play(int.Parse(button10.Text)); //1
        }

        private void button9_Click(object sender, EventArgs e)
        {
           // game.Play(int.Parse(button9.Text));  //2
        }

        private void button8_Click(object sender, EventArgs e)
        {
           // game.Play(int.Parse(button3.Text));  //3
        }

        private void button7_Click(object sender, EventArgs e)
        {
           // game.Play(int.Parse(button4.Text));  //4
        }

        private void button5_Click(object sender, EventArgs e)
        {
           // game.Play(int.Parse(button5.Text));  //5
        }

        private void button4_Click(object sender, EventArgs e)
        {
           // game.Play(int.Parse(button6.Text));  //6
        }

        private void button6_Click(object sender, EventArgs e)
        {
           // game.Play(int.Parse(button7.Text));  //7
        }

        private void button3_Click(object sender, EventArgs e)
        {
           // game.Play(int.Parse(button8.Text));  //8
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //game.Play(int.Parse(button9.Text));  //9
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2= new Form2(p1,p2);
            form2.ShowDialog();
            

        }
        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string loc = button.Text;
            button.Text = game.CurrentPlayer.Mark.ToString();
            game.Play(int.Parse(loc)-1);
            label4.Text = game.Status;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
