using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text;

namespace Pr28
{
    public partial class Sell : Form
    {
        public Sell()
        {
            InitializeComponent();
            button1.FlatStyle = FlatStyle.Popup;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamWriter w = new StreamWriter("a5.txt", true, System.Text.Encoding.Default);
            w.WriteLine(maskedTextBox2.Text + ";" + textBox2.Text + "; " + textBox3.Text + ";" + textBox4.Text + ";" + maskedTextBox1.Text + ";" + textBox6.Text + ";" + textBox7.Text + ";");
            w.Close();
        }

        private void Sell_Load(object sender, EventArgs e)
        {

        }
    }
}
