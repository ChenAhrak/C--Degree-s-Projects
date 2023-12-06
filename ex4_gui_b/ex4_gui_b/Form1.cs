using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex4_gui_b
{
    public partial class Form1 : Form
    {
        int index = 0;
        string[] images = { "0.jpg", "1.jpg", "2.jpg", "3.jpg", "4.jpg", "5.jpg", "6.jpg", "7.jpg", "8.jpg", "9.jpg" };
        string[,] fAnswers = { { "computer", "pencil" }, { "cup", "book" }, { "TV", "plant" }, 
                                { "chair", "table" }, { "pen", "phone" },
                                 { "building", "screen" }, { "cup", "spoon" }, {"lamp","book"},
                                 {"speaker","keyboard" },{"plant","note"} };
        string[] tAnswers = { "book","mouse","computer","curtain","pencil","keyboard","mouse",
                                "speaker","cup","computer" };
        Player p1;
        bool flag;
        int seconds = 20;
        int check = 0;

       private void shuffles(string[] images, string[,] fAnswers, string[] tAnswers)
        {
            Random rnd = new Random();
            string tmp1;
            string tmp2;
            string tmp3;
            string tmp4;
            int r;
            for (int i = 0; i < images.Length; i++)
            {
                tmp1 = images[i];
                
                r = rnd.Next(i, images.Length);
                images[i] = images[r];
                images[r] = tmp1;

                tmp2 = tAnswers[i];
                tAnswers[i] = tAnswers[r];
                tAnswers[r] = tmp2;
                
                tmp3 = fAnswers[i, 0];
                fAnswers[i, 0] = fAnswers[r, 0];
                fAnswers[r, 0] = tmp3;

                tmp4 = fAnswers[i, 1];
                fAnswers[i, 1] = fAnswers[r, 1];
                fAnswers[r, 1] = tmp4;
                
                

                }
                
            }
       
        public void show(string[] images, string[,] fAnswers, string[] tAnswers)
        {
            if(index>9)
            {
                MessageBox.Show("You Are A Fucking Winner!!!");
                this.Close();
            }
            pictureBox1.ImageLocation = @"..\..\..\img\" + images[index];
            btn1.Text = fAnswers[index,0];
            btn2.Text = fAnswers[index, 1];
            btn3.Text = tAnswers[index];
            lblscore.Text = $"Score:  {p1.SCORE.ToString()}";


        }

        private bool checkAnswer(string str)
        {
            if (str == tAnswers[index])
            {
                if(check==1)
                {
                    p1.SCORE = p1.SCORE + 0.5;
                }
                else
                {
                    p1.SCORE++;
                }
                
                index++;
                seconds = 20 - index * 2;
                show(images, fAnswers, tAnswers);
                check = 0;
                btn1.Enabled = true;
                btn2.Enabled = true;
                btn3.Enabled = true;
                return true;
            }
            else if (check == 1)
            {
                MessageBox.Show("Game Over You Are A Loser!!!");
                if  (MessageBox.Show("Play Again?", "Game Over", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No){ this.Close();
                    return false;
                }
                else
                    newGame();
            }
            else
            {
                check++;
                return false;
            }

            
        }

        private void newGame()
        {
            index = 0;
            seconds = 20;
            check = 0;

            timer1.Start();
            shuffles(images, fAnswers, tAnswers);
            show(images, fAnswers, tAnswers);
        }

        public Form1()
        {
            InitializeComponent();
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (txtName.Text != "")
            {
               
                p1 = new Player(txtName.Text);
                MessageBox.Show("You have 20 second to remmber the picture:");
                lblName.Visible = false;
                txtName.Visible = false;
                btnStart.Visible = false;
                pnl1.Visible = true;
                pictureBox1.Visible = true;

              
                timer1.Start();
                shuffles(images, fAnswers, tAnswers);
                show(images, fAnswers, tAnswers);
            }
            else
            {
                MessageBox.Show("The field is empty!!");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = $"Timer: {seconds.ToString()}";
            if(seconds<=0)
            {
                pictureBox1.Visible = false;
                timer1.Stop();
   
            }
           
            seconds--;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (!checkAnswer(btn1.Text))
            {
                btn1.Enabled = false;
            }
            
        }

        private void lblTimer_Click(object sender, EventArgs e)
        {

        }

        private void lbltxt_Click(object sender, EventArgs e)
        {

        }

        private void btn2_Click(object sender, EventArgs e)
        {

            if (!checkAnswer(btn2.Text))
            {
                btn2.Enabled = false;
            }

        }

        private void btn3_Click(object sender, EventArgs e)
        {

            if (!checkAnswer(btn3.Text))
            {
                btn3.Enabled = false;
            }


        }
    }
}
