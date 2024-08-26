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
using System.Diagnostics;
using System.Security;
using System.Drawing.Text;
using System.Runtime.CompilerServices;

namespace TicTacToe
{
    public partial class Form2 : Form
    {
        /*private int axisX = 226; 
        private int axisY = 50; 
        */
        
        private int player;
        private string firstPlayer;
        private int counter = 0;
        private Button[,] buttons= new Button[3,3];
        
        public Form2()
        {
            InitializeComponent();
            this.Height = 600;
            this.Width = 800;
            player = DataBank.firstPlayer;
                if (player == 0)
            {
                firstPlayer = DataBank.Name2;
            } else
            {
                firstPlayer = DataBank.Name1;
            }
            label1.Text = "Aktueller Zug: " +  firstPlayer ;
            for (int i = 0; i < buttons.Length / 3; i++)
            {
                for (int j = 0; j < buttons.Length / 3; j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Size = new Size(112, 115);
                }
            }
            setButtons();
        }
        private void setButtons()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    buttons[i, j].Location = new Point(226 + 115 * i, 50 + 118 * j);
                    buttons[i,j].Click += button1_Click;
                    buttons[i,j].Font = new Font(new FontFamily("Microsoft Sans Serif"), 66);
                    this.Controls.Add(buttons[i, j]);
                }
            }
        }
        /*public Form2(Form1 f)
        {
            InitializeComponent();

        }*/
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Button offButton = (Button)sender;
            switch(player) {
                case 1:
                    sender.GetType().GetProperty("Text").SetValue(sender, "x");
                    player = 0;
                    counter += 1;
                    label1.Text = "Aktueller Zug: " + DataBank.Name2;
                    break;
                    
                case 0:
                sender.GetType().GetProperty("Text").SetValue(sender, "o");
                    player = 1;
                    counter += 1;
                    label1.Text = "Aktueller Zug: " + DataBank.Name1;
                    break;
                   
            }

            offButton.Enabled = false;
            if (CheckWin() == true)
            {
                if (player == 1)
                {
                    MessageBox.Show(DataBank.Name2 + " Won");
                }
                else {
                    MessageBox.Show(DataBank.Name1 + " Won");
                }
            }
            if (counter > 8 && CheckWin() == false)
            {
                MessageBox.Show("Draw");
            }
        }

                                                  
        private bool CheckWin()
        {
            //Horizontal Winning Condition
            if (buttons[0, 0].Text == buttons[0,1].Text && buttons[0, 1].Text == buttons[0,2].Text)
            {
                if (buttons[0,1].Text != "")
                {
                    return true;                
                }
            }


            if (buttons[1,0].Text == buttons[1,1].Text && buttons[1,1].Text == buttons[1,2].Text)
            {
                if (buttons[1,1].Text != "")
                {
                    return true;
                }
            }

            if (buttons[2,0].Text == buttons[2,1].Text && buttons[2, 1].Text == buttons[2, 2].Text)
            {
                if (buttons[2,1].Text != "")
                {
                    return true;
                }

            }

            //Vertical Winning Condition
            if (buttons[0, 0].Text == buttons[1, 0].Text && buttons[1,0].Text == buttons[2,0].Text)
            {
                if (buttons[1,0].Text != "")
                {
                    return true;


                }
            }

            if (buttons[0,1].Text == buttons[1,1].Text && buttons[1,1].Text == buttons[2,1].Text)
            {
                if (buttons[1,1].Text != "")
                {
                    return true;

                }
            }

            if (buttons[0,2].Text == buttons[1,2].Text && buttons[1,2].Text == buttons[2,2].Text)
            {
                if (buttons[1,2].Text != "")
                {
                    return true;

                }
            }

            //Diagonal Winning Condition
            if (buttons[0,0].Text == buttons[1,1].Text && buttons[1,1].Text == buttons[2,2].Text)
            {
                if (buttons[1,1].Text != "")
                {
                    return true;

                }
            }

            if (buttons[0,2].Text == buttons[1,1].Text && buttons[1,1].Text == buttons[2,0].Text)
            {
                if (buttons[1,1].Text != "")
                {
                    return true;

                }
            }

            
            return false;
            

            CheckWin();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            { 
                for (int j = 0; j < 3; j++) 
                {
                    buttons[i, j].Text="" ;
                    counter = 0;
                    buttons[i, j].Enabled = true;

                }
            }
        }
    }
}
