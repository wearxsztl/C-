using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataBank.Name1 = textBox1.Text;
            DataBank.Name2 = textBox2.Text;
          
            Form2 frm2 = new Form2();
            frm2.ShowDialog();
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataBank.Name1 = textBox1.Text;
            DataBank.Name2 = textBox2.Text;
            DataBank.firstPlayer = 1;
            Form2 frm2 = new Form2();

            frm2.ShowDialog();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataBank.Name1 = textBox1.Text;
            DataBank.Name2 = textBox2.Text;
            DataBank.firstPlayer = 0;
            Form2 frm2 = new Form2();
            frm2.ShowDialog();
        }
    }
}
