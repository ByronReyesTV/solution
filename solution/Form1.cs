using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace solution
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int english = Convert.ToInt32(TextBox1.Text);
            int math = Convert.ToInt32(textBox2.Text);
            int science = Convert.ToInt32(textBox3.Text);
            int filipino = Convert.ToInt32(textBox4.Text);
            int history = Convert.ToInt32(textBox5.Text);
            int sum = english + math + science + filipino + history;
            int div = sum / 5;

            String label1 = (namebox.Text);

            Display.Text = "The student passed\nThe general average of " + label1 + "is: " + div;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void secondnum_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
