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
    public partial class Agents : Form
    {
        public Agents()
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
            StreamWriter w = new StreamWriter("a4.txt", true, System.Text.Encoding.Default);
            w.WriteLine(textBox1.Text + ";" + textBox2.Text + "; " + textBox3.Text + ";" + textBox4.Text + ";" + textBox5.Text + ";" + comboBox1.Text + ";" + textBox7.Text);
            w.Close();
        }
        
    }
}
