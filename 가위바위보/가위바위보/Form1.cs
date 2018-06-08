using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 가위바위보
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        int com_ran = 0;
        int user_ran = 0;
        int com_move = 1;
        int user_move = 1;
        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources._2;
            user_ran = 2;
            Com_Random();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources._1;
            user_ran = 1;
            Com_Random();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources._3;
            user_ran = 3;
            Com_Random();
        }

        public void Com_Random()
        {
            Random random = new Random();
            com_ran = random.Next(1, 4);

           if(com_ran == 1)
            {
                
                if(user_ran == 3)
                {
                    Moves(1);
                }
                else if(user_ran == 2)
                {
                    Moves(0);
                }
                pictureBox2.Image = Properties.Resources._1;
            }
            if (com_ran == 2)
            {
                
                if (user_ran == 1)
                {
                    Moves(1);
                }
                else if(user_ran == 3)
                {
                    Moves(0);
                }
                pictureBox2.Image = Properties.Resources._2;
            }
            if (com_ran == 3)
            {
                
                if (user_ran == 2)
                {
                    Moves(1);
                }
                else if(user_ran == 1)
                {
                    Moves(0);
                }
                pictureBox2.Image = Properties.Resources._3;
            }
        }

        public void Back(int a)
        {
            Console.WriteLine("d");

            if (a == 0)
            {
                switch (com_move)
                {
                    case 2:
                        C_2.Visible = false;
                        C_1.Visible = true;
                        com_move = 1;
                        break;
                    case 3:
                        C_3.Visible = false;
                        C_1.Visible = true;
                        com_move = 1;
                        break;
                    case 4:
                        C_4.Visible = false;
                        C_2.Visible = true;
                        com_move = 2;
                        break;
                    case 5:
                        C_5.Visible = false;
                        C_3.Visible = true;
                        com_move = 3;
                        break;
                    case 6:
                        C_6.Visible = false;
                        C_4.Visible = true;
                        com_move = 4;
                        break;
                    case 7:
                        C_7.Visible = false;
                        C_5.Visible = true;
                        com_move = 5;
                        break;
                    case 8:
                        C_8.Visible = false;
                        C_6.Visible = true;
                        com_move = 6;
                        break;
                }
            }
            else
            {
                switch (user_move)
                {
                    case 2:
                        U_2.Visible = false;
                        U_1.Visible = true;
                        user_move = 1;
                        break;
                    case 3:
                        U_3.Visible = false;
                        U_1.Visible = true;
                        user_move = 1;
                        break;
                    case 4:
                        U_4.Visible = false;
                        U_2.Visible = true;
                        user_move = 2;
                        break;
                    case 5:
                        U_5.Visible = false;
                        U_3.Visible = true;
                        user_move = 3;
                        break;
                    case 6:
                        U_6.Visible = false;
                        U_4.Visible = true;
                        user_move = 4;
                        break;
                    case 7:
                        U_7.Visible = false;
                        U_5.Visible = true;
                        user_move = 5;
                        break;
                    case 8:
                        U_8.Visible = false;
                        U_6.Visible = true;
                        user_move = 6;
                        break;
                }
            }
            this.Refresh();
            Console.WriteLine(com_move);
        }

        public void Moves(int a)
        {
            if(a == 0)
            {
                switch (com_move)
                {
                    case 1:
                        
                        C_1.Visible = false;
                        C_4.Visible = true;
                        Console.WriteLine("H");
                        com_move = 4;
                        break;
                    case 2:
                        C_2.Visible = false;
                        C_5.Visible = true;
                        com_move = 5;
                        break;
                    case 3:
                        C_3.Visible = false;
                        C_6.Visible = true;
                        com_move = 6;
                        break;
                    case 4:
                        C_4.Visible = false;
                        C_7.Visible = true;
                        com_move = 7;
                        break;
                    case 5:
                        C_5.Visible = false;
                        C_8.Visible = true;
                        com_move = 8;
                        break;
                    case 6:
                        C_6.Visible = false;
                        C_9.Visible = true;
                        com_move = 9;
                        label3.Text = "Computer Win";
                        label3.Visible = true;
                        button4.Visible = true;
                        break;
                    case 7:
                        C_7.Visible = false;
                        C_9.Visible = true;
                        com_move = 9;
                        label3.Text = "Computer Win";
                        label3.Visible = true;
                        button4.Visible = true;
                        break;
                    case 8:
                        C_8.Visible = false;
                        C_9.Visible = true;
                        com_move = 9;
                        label3.Text = "Computer Win";
                        label3.Visible = true;
                        button4.Visible = true;
                        break;
                }
                Back(1);
            }
            else{
                    switch (user_move)
                    {
                        case 1:
                            U_1.Visible = false;
                            U_4.Visible = true;
                            user_move = 4;
                            break;
                        case 2:
                            U_2.Visible = false;
                            U_5.Visible = true;
                            user_move = 5;
                            break;
                        case 3:
                            U_3.Visible = false;
                            U_6.Visible = true;
                            user_move = 6;
                            break;
                        case 4:
                            U_4.Visible = false;
                            U_7.Visible = true;
                            user_move = 7;
                            break;
                        case 5:
                            U_5.Visible = false;
                            U_8.Visible = true;
                            user_move = 8;
                            break;
                        case 6:
                            U_6.Visible = false;
                            U_9.Visible = true;
                            user_move = 9;
                            label3.Text = "User Win";
                        label3.Visible = true;
                        button4.Visible = true;
                        break;
                    case 7:
                        U_7.Visible = false;
                        U_9.Visible = true;
                        user_move = 9;
                        label3.Text = "User Win";
                        label3.Visible = true;
                        button4.Visible = true;
                        break;
                    case 8:
                        U_8.Visible = false;
                        U_9.Visible = true;
                        user_move = 9;
                        label3.Text = "User Win";
                        label3.Visible = true;
                        button4.Visible = true;
                        break;
                }

                Back(0);
            }
            this.Refresh();
            }

        private void button4_Click(object sender, EventArgs e)
        {
            com_move = 1;
            user_move = 1;
            button4.Visible = false;
            label3.Visible = false;
            C_1.Visible = true;
            C_2.Visible = false;
            C_3.Visible = false;
            C_4.Visible = false;
            C_5.Visible = false;
            C_6.Visible = false;
            C_7.Visible = false;
            C_8.Visible = false;
            C_9.Visible = false;

            U_1.Visible = true;
            U_2.Visible = false;
            U_3.Visible = false;
            U_4.Visible = false;
            U_5.Visible = false;
            U_6.Visible = false;
            U_7.Visible = false;
            U_8.Visible = false;
            U_9.Visible = false;
        }
    }
    }