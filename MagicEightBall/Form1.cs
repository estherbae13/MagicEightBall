using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagicEightBall
{
    public partial class Form1 : Form
    {
        Random randGen = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void inputButton_Click(object sender, EventArgs e)
        {
            int num = randGen.Next(1, 7);

            switch (num)
            {
                case 1:
                    outputLabel.Text = "Yes, for sure!!!";
                    break;
                case 2:
                    outputLabel.Text = "Ask again later.";
                    break;
                case 3:
                    outputLabel.Text = "Probably not.";
                    break;
                case 4:
                    outputLabel.Text = "No.";
                    break;
                case 5:
                    outputLabel.Text = "Probably!";
                    break;
                case 6:
                    outputLabel.Text = "Don't count on it.";
                    break;
            }
        }
    }
}
