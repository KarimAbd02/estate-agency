using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr28
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.FlatStyle = FlatStyle.Popup;
            button2.FlatStyle = FlatStyle.Popup;
            button3.FlatStyle = FlatStyle.Popup;
            button4.FlatStyle = FlatStyle.Popup;
            button5.FlatStyle = FlatStyle.Popup;
            button6.FlatStyle = FlatStyle.Popup;
        }      

        private void button1_Click(object sender, EventArgs e)
        {
            House form2 = new House();
            form2.Show();
            Hide();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Prod form3 = new Prod();
            form3.Show();
            Hide();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Users form4 = new Users();
            form4.Show();
            Hide();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Agents form5 = new Agents();
            form5.Show();
            Hide();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Sell form6 = new Sell();
            form6.Show();
            Hide();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            AboutBox1 form7 = new AboutBox1();
            form7.Show();
            Hide();
        }
    }
}
