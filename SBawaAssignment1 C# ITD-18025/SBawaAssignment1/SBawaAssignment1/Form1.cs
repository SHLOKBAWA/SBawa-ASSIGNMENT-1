using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SBawaAssignment1
{
    public partial class Form1 : Form
    {

        string[,] seats = new string[5, 3];
        string[] waiting = new string[10];
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int x = 0; x < 5; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    seats[x, y] = "";
                }
            }

            for (int i = 0; i < waiting.Length; i++)
            {
                waiting[i] = "";
            }
        }
        private void button21_Click(object sender, EventArgs e)
        {
            /*-----MODIFY-----*/
            richTextBox2.Text = "";
            for (int i = 0; i < waiting.Length; i++)
            {
                richTextBox2.Text += waiting[i] + "\n";
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            /*-----MODIFY HERE-----*/
            if (textBox1.Text == "")
            {
                MessageBox.Show("PLEASE ENTER A NAME");
            }
            try
            {
                if (seats[listBox1.SelectedIndex, listBox2.SelectedIndex] == "")
                {
                    seats[listBox1.SelectedIndex, listBox2.SelectedIndex] = textBox1.Text;
                    MessageBox.Show("BOOKING SUCCESSFUL");
                }
                else
                {
                    MessageBox.Show("SEATS IS BOOKED PLEASE CHOOSE ANOTHER ");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("PLEASE SELECT SEAT");
            }
           
        }

        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                if (seats[listBox1.SelectedIndex, listBox2.SelectedIndex] == "")
                {
                    textBox2.Text = "AVAILABLE";
                }
                else
                {
                    textBox2.Text = "NOT AVAILABLE";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("PLEASE SELCE A SEAT");
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            try
            {
                if (seats[listBox1.SelectedIndex, listBox2.SelectedIndex] != "")
                {
                    seats[listBox1.SelectedIndex, listBox2.SelectedIndex] = "";
                    MessageBox.Show("CANCELLATION SUCCESSFUL");
                    for (int i = 0; i < 10; i++)
                    {
                        if (waiting[i] != "")
                        {
                            seats[listBox1.SelectedIndex, listBox2.SelectedIndex] = waiting[i];
                            waiting[i] = "";
                            for (int x = 0; x < 10; x++)
                            {
                                waiting[x++] = waiting[x--];
                            }
                            throw new moveout();
                        }
                    }

                }
            }
            catch (moveout)
            {

            }

            catch (IndexOutOfRangeException)
            {
 
            }
        }



        private void button19_Click(object sender, EventArgs e)
        {
            /*--------MODIFY HERE-------*/
            try
            {
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (seats[i, j] == "")
                        {
                            throw new stillavail();
                        }
                        
                    }

                }

                for (int x = 0; x < waiting.Length; x++)
                {
                    if (waiting[x] == "")
                    {
                        waiting[x] = textBox1.Text;
                        throw new moveout();

                    }
                                
                }
                        throw new full();

            }
            catch (stillavail)
            {
                MessageBox.Show("PLEASE RECHECK BEFORE ADDING THERE ARE SOME AVAILABLE SEATS");
            }
            catch (full)
            {
                MessageBox.Show("SORRY THE WAITING LIST IS ALSO FULL PLEASE COME BACK LATER ");
            }
            catch (moveout)
            {
                MessageBox.Show("YOU HAVE BEEN ADDED TO WAITING LIST ");
            }

        }


        private void button22_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    seats[i, j] = "GOD";
                }
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            if (seats[0, 0] == "")
            {
                richTextBox1.Text = richTextBox1.Text + "SEAT NO. A0 IS AVAILABLE " + "\n";
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "A0 IS FILLED BY  " + seats[0, 0] + "\n";
            }
            if (seats[0, 1] == "")
            {
                richTextBox1.Text = richTextBox1.Text + "SEAT NO. A1 IS AVAILABLE " + "\n";
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "A1 IS FILLED BY  " + seats[0, 1] + "\n";
            }
            if (seats[0, 2] == "")
            {
                richTextBox1.Text = richTextBox1.Text + "SEAT NO. A2 IS AVAILABLE " + "\n";
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "A2 IS FILLED BY  " + seats[0, 2] + "\n";
            }
            if (seats[1, 0] == "")
            {
                richTextBox1.Text = richTextBox1.Text + "SEAT NO. B0 IS AVAILABLE " + "\n";
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "B0 IS FILLED BY  " + seats[1, 0] + "\n";
            }
            if (seats[1, 1] == "")
            {
                richTextBox1.Text = richTextBox1.Text + "SEAT NO. B1 IS AVAILABLE " + "\n";
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "B1 IS FILLED BY  " + seats[1, 1] + "\n";
            }
            if (seats[1, 2] == "")
            {
                richTextBox1.Text = richTextBox1.Text + "SEAT NO. B2 IS AVAILABLE " + "\n";
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "B2 IS FILLED BY  " + seats[1, 2] + "\n";
            }
            if (seats[2, 0] == "")
            {
                richTextBox1.Text = richTextBox1.Text + "SEAT NO. C0 IS AVAILABLE " + "\n";
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "C0 IS FILLED BY  " + seats[2, 0] + "\n";
            }
            if (seats[2, 1] == "")
            {
                richTextBox1.Text = richTextBox1.Text + "SEAT NO. C1 IS AVAILABLE " + "\n";
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "C1 IS FILLED BY  " + seats[2, 1] + "\n";
            }
            if (seats[2, 2] == "")
            {
                richTextBox1.Text = richTextBox1.Text + "SEAT NO. C2 IS AVAILABLE " + "\n";
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "C2 IS FILLED BY  " + seats[2, 2] + "\n";
            }
            if (seats[3, 0] == "")
            {
                richTextBox1.Text = richTextBox1.Text + "SEAT NO. D0 IS AVAILABLE " + "\n";
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "D0 IS FILLED BY  " + seats[3, 0] + "\n";
            }
            if (seats[3, 1] == "")
            {
                richTextBox1.Text = richTextBox1.Text + "SEAT NO. D1 IS AVAILABLE " + "\n";
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "D1 IS FILLED BY  " + seats[3, 1] + "\n";
            }
            if (seats[3, 2] == "")
            {
                richTextBox1.Text = richTextBox1.Text + "SEAT NO. D2 IS AVAILABLE " + "\n";
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "D2 IS FILLED BY  " + seats[3, 2] + "\n";
            }
            if (seats[4, 0] == "")
            {
                richTextBox1.Text = richTextBox1.Text + "SEAT NO. E0 IS AVAILABLE " + "\n";
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "E0 IS FILLED BY  " + seats[4, 0] + "\n";
            }
            if (seats[4, 1] == "")
            {
                richTextBox1.Text = richTextBox1.Text + "SEAT NO. E1 IS AVAILABLE " + "\n";
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "E1 IS FILLED BY  " + seats[4, 1] + "\n";
            }
            if (seats[4, 2] == "")
            {
                richTextBox1.Text = richTextBox1.Text + "SEAT NO. E2 IS AVAILABLE " + "\n";
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "E2 IS FILLED BY  " + seats[4, 2] + "\n";
            }




        }

        private void button23_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    seats[i, j] = "";
                }
            }
        }


    }
    public class stillavail : Exception
    {
        public stillavail()
        {
           
        }
    }
    public class full : Exception
    {
        public full()
        {

        }
    }
    public class moveout : Exception
    {
        public moveout()
        {

        }
    }
    

}
