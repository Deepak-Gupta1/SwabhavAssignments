using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        string n1;
        string n2;
        public Form2(string n1,string n2)
        {
            this.n1= n1;
            this.n2= n2;
            InitializeComponent();
        }
        

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = n1;
            label2.Text = n2;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
