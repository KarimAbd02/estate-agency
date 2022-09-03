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
    public partial class House : Form
    {
        public House()
        {
            InitializeComponent();
            button1.FlatStyle = FlatStyle.Popup;
        }
         int k = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamWriter w = new StreamWriter("a1.txt", true, System.Text.Encoding.Default);
            w.WriteLine(textBox1.Text + ";" + textBox2.Text + "; " + textBox3.Text + ";" + textBox4.Text + ";" + textBox5.Text + ";" + textBox6.Text + "; " + textBox7.Text + ";");
            w.Close();
        }
    }
    }

