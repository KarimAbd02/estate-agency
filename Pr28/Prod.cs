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

namespace Pr28
{
    public partial class Prod : Form
    {
        public Prod()
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

        private void Prod_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamWriter w = new StreamWriter("a2.txt", true, System.Text.Encoding.Default);
            w.WriteLine(textBox1.Text + ";" + textBox2.Text + "; " + textBox3.Text + ";" + maskedTextBox1.Text + ";" + textBox5.Text + ";");
            w.Close();
        }
    }
}
