using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ConsoleWinFormApp
{
    internal class WelcomesForm:Form
    {
        public WelcomesForm()
        {
            this.Text = "Welcome";
            Label label = new Label();
            label.Text = "DEVELOPED BY @DEEPAK";
            label.Location = new System.Drawing.Point(150, 150);
            this.Controls.Add(label);
            this.Height = 400;
            this.Width = 500;
            Button button = new Button();
            button.Location = new System.Drawing.Point(100, 100);
            this.Controls.Add(button);
        }
    }
}
