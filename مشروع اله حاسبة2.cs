using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        string operation = "";
        double result = 0;
        bool isoperation = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button but = (Button)sender;
            if (textBox1.Text == "0" || isoperation == true) { textBox1.Clear(); }
            if (but.Text == ".")
            {
                if (!textBox1.Text.Contains("."))
                { textBox1.Text = textBox1.Text + but.Text; }

            }
            else { textBox1.Text = textBox1.Text + but.Text; }
            isoperation = false;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Button but = (Button)sender;
            operation = but.Text;
            result = double.Parse(textBox1.Text);
            isoperation = true;
        }

        private void button15_Clic(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    textBox1.Text = (result + double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (result - double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (result / double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (result * double.Parse(textBox1.Text)).ToString();
                    break;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {

            textBox1.Clear();
            


        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            result = 0;
        }
    }
}
