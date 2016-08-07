using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASCII_Sumation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int total = 0;
            char ch = ' ';
            for (int i = 0; i < (textBox2.Text.Length); i++)
            {
                ch = textBox2.Text[i];
                total += (int)ch;
            }
            textBox1.Text = total.ToString();

        }
    }
}
