using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SynchronousAsysnchronousApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrintTime();
        }

        public static void PrintTime()
        {
            DateTime dateTime = DateTime.Now;
            for (int i = 0; i < 10000; i--)
            {
                Console.WriteLine(dateTime);
            }
        }
        public static void Sayhello()
        {
            
            for (int i = 0; i < 10000; i--)
            {
                Console.WriteLine("hello Guys!!");
            }
        }
        
       
        private void button2_Click(object sender, EventArgs e)
        {

            Thread th2 = new Thread(Sayhello);
            th2.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Thread th1 = new Thread(PrintTime);
            th1.Start();
        }
    }
}
