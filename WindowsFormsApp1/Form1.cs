using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        static class Globals
        {
            public static int guessnumber = 1;
            public static int[] answer = new int[5];
            public static int[] guess = new int[5];
            public static int rightplace = 0;
            public static int rightcolor = 0;
            public static bool ingame = false;
            public static int currentskin = 1;
        }
        public Form1()
        {
            InitializeComponent();
            password1.BackColor = Color.Red;
            password2.BackColor = Color.Red;
            password3.BackColor = Color.Red;
            password4.BackColor = Color.Red;
            password5.BackColor = Color.Red;
            guess1.BackColor = Color.Red;
            guess2.BackColor = Color.Red;
            guess3.BackColor = Color.Red;
            guess4.BackColor = Color.Red;
            guess5.BackColor = Color.Red;
            hide_guesses();
            this.KeyPreview = true;


        }

        private void password1_Click(object sender, EventArgs e)
        {
            change_Color_Answer(ref password1);
        }

        private void password2_Click(object sender, EventArgs e)
        {
            change_Color_Answer(ref password2);
        }

        private void password3_Click(object sender, EventArgs e)
        { 
            change_Color_Answer(ref password3);
        }

        private void password4_Click(object sender, EventArgs e)
        {
            change_Color_Answer(ref password4);
        }

        private void password5_Click(object sender, EventArgs e)
        {
            change_Color_Answer(ref password5);
        }

        private void change_Color_Guess(ref System.Windows.Forms.Button button)
        {
            String color = button.BackColor.ToString();
            int which = 0;
            if (button.Name == "guess1")
            {
                which = 1;
            }
            if (button.Name == "guess2")
            {
                which = 2;
            }
            if (button.Name == "guess3")
            {
                which = 3;
            }
            if (button.Name == "guess4")
            {
                which = 4;
            }
            if (button.Name == "guess5")
            {
                which = 5;
            }

            switch (color)
            {
                case "Color [Red]":
                    button.BackColor = Color.Yellow;
                    Globals.guess[which - 1] = 1;
                    break;
                case "Color [Yellow]":
                    button.BackColor = Color.Blue;
                    Globals.guess[which - 1] = 2;
                    break;
                case "Color [Blue]":
                    button.BackColor = Color.Black;
                    Globals.guess[which - 1] = 3;
                    break;
                case "Color [Black]":
                    button.BackColor = Color.Green;
                    Globals.guess[which - 1] = 4;
                    break;
                case "Color [Green]":
                    button.BackColor = Color.DarkCyan;
                    Globals.guess[which - 1] = 5;
                    break;
                case "Color [DarkCyan]":
                    button.BackColor = Color.HotPink;
                    Globals.guess[which - 1] = 6;
                    break;
                case "Color [HotPink]":
                    button.BackColor = Color.Aqua;
                    Globals.guess[which - 1] = 7;
                    break;
                case "Color [Aqua]":
                    button.BackColor = Color.Gray;
                    Globals.guess[which - 1] = 8;
                    break;
                case "Color [Gray]":
                    button.BackColor = Color.Purple;
                    Globals.guess[which - 1] = 9;
                    break;
                case "Color [Purple]":
                    button.BackColor = Color.Red;
                    Globals.guess[which - 1] = 0;
                    break;
                default:
                    Console.WriteLine(color);
                    break;


            }
          
            
        }

        private void change_Color_Answer(ref System.Windows.Forms.Button button)
        {
            String color = button.BackColor.ToString();
            int which = 0;
            if (button.Name == "password1")
            {
                which = 1;
            }
            if (button.Name == "password2")
            {
                which = 2;
            }
            if (button.Name == "password3")
            {
                which = 3;
            }
            if (button.Name == "password4")
            {
                which = 4;
            }
            if (button.Name == "password5")
            {
                which = 5;
            }

            switch (color)
            {
                case "Color [Red]":
                    button.BackColor = Color.Yellow;
                    Globals.answer[which - 1] = 1;
                    break;
                case "Color [Yellow]":
                    button.BackColor = Color.Blue;
                    Globals.answer[which - 1] = 2;
                    break;
                case "Color [Blue]":
                    button.BackColor = Color.Black;
                    Globals.answer[which - 1] = 3;
                    break;
                case "Color [Black]":
                    button.BackColor = Color.Green;
                    Globals.answer[which - 1] = 4;
                    break;
                case "Color [Green]":
                    button.BackColor = Color.DarkCyan;
                    Globals.answer[which - 1] = 5;
                    break;
                case "Color [DarkCyan]":
                    button.BackColor = Color.HotPink;
                    Globals.answer[which - 1] = 6;
                    break;
                case "Color [HotPink]":
                    button.BackColor = Color.Aqua;
                    Globals.answer[which - 1] = 7;
                    break;
                case "Color [Aqua]":
                    button.BackColor = Color.Gray;
                    Globals.answer[which - 1] = 8;
                    break;
                case "Color [Gray]":
                    button.BackColor = Color.Purple;
                    Globals.answer[which - 1] = 9;
                    break;
                case "Color [Purple]":
                    button.BackColor = Color.Red;
                    Globals.answer[which - 1] = 0;
                    break;
                default:
                    Console.WriteLine(color);
                    break;


            }


        }

        private void play_Click(object sender, EventArgs e)
        {
            hide_answer();
            Globals.ingame = true;
        }

        private void give_up_Click(object sender, EventArgs e)
        {
            if (Globals.ingame)
            {
                show_answer();
                string message = " Get better\n Do you want to play again?";
                string caption = "Sad";
                show_answer();
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;



                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    end_game();

                }
                else
                {
                    this.Close();
                }
            }
        }

        private void randomize_Click(object sender, EventArgs e)
        {
            if (!Globals.ingame)
            {
                Globals.ingame = true;
                hide_answer();
                password1.BackColor = Color.Red;
                password2.BackColor = Color.Red;
                password3.BackColor = Color.Red;
                password4.BackColor = Color.Red;
                password5.BackColor = Color.Red;
                Globals.answer[0] = 0;
                Globals.answer[1] = 0;
                Globals.answer[2] = 0;
                Globals.answer[3] = 0;
                Globals.answer[4] = 0;
                if (repeat.Checked)
                {
                    Random rnd = new Random();
                    int t1 = rnd.Next(10);
                    for (int i = 0; i < t1; i++)
                    {
                        change_Color_Answer(ref password1);
                    }
                    int t2 = rnd.Next(10);
                    for (int i = 0; i < t2; i++)
                    {
                        change_Color_Answer(ref password2);
                    }
                    int t3 = rnd.Next(10);
                    for (int i = 0; i < t3; i++)
                    {
                        change_Color_Answer(ref password3);
                    }
                    int t4 = rnd.Next(10);
                    for (int i = 0; i < t4; i++)
                    {
                        change_Color_Answer(ref password4);
                    }
                    int t5 = rnd.Next(10);
                    for (int i = 0; i < t5; i++)
                    {
                        change_Color_Answer(ref password5);
                    }
                }
                else
                {
                    int[] list = new int[10];
                    Random rnd = new Random();
                    for (int i = 0; i < 10; i++)
                    {
                        list[i] = i;
                    }

                    list = list.OrderBy(x => rnd.Next()).ToArray();

                    for (int i = 0; i < list[0]; i++)
                    {
                        change_Color_Answer(ref password1);
                    }
                    for (int i = 0; i < list[1]; i++)
                    {
                        change_Color_Answer(ref password2);
                    }
                    for (int i = 0; i < list[2]; i++)
                    {
                        change_Color_Answer(ref password3);
                    }
                    for (int i = 0; i < list[3]; i++)
                    {
                        change_Color_Answer(ref password4);
                    }
                    for (int i = 0; i < list[4]; i++)
                    {
                        change_Color_Answer(ref password5);
                    }
                }
            }
            
        }

        private void guess1_Click(object sender, EventArgs e)
        {
            change_Color_Guess(ref guess1);
        }

        private void guess2_Click(object sender, EventArgs e)
        {
            change_Color_Guess(ref guess2);
        }

        private void guess3_Click(object sender, EventArgs e)
        {
            change_Color_Guess(ref guess3);
        }

        private void guess4_Click(object sender, EventArgs e)
        {
            change_Color_Guess(ref guess4);
        }

        private void guess5_Click(object sender, EventArgs e)
        {
            change_Color_Guess(ref guess5);
        }

        private void makeguess_Click(object sender, EventArgs e)
        {
            if (Globals.ingame)
            {
                show_guesses();
                compare();
                set_label();
                if (Globals.rightplace == 5)
                {
                    string message = "EZ WIN\n Do you want to play again?";
                    string caption = "Congratz";
                    show_answer();
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result;
                    


                    result = MessageBox.Show(message, caption, buttons);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {


                    }
                    else
                    {
                        this.Close();
                    }
                    end_game();
                }
                
                if (Globals.rightplace!=5 && Globals.guessnumber == 8)
                {
                    string message = "not EZ WIN\n Do you want to play again?";
                    string caption = "not Congratz";
                    show_answer();
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result;
                    


                    result = MessageBox.Show(message, caption, buttons);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {


                    }
                    else
                    {
                        this.Close();
                    }
                    end_game();
                }
                if (Globals.ingame)
                {
                    Globals.guessnumber++;
                }


            }
            
        }

        private void hide_guesses()
        {
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            button15.Visible = false;
            button16.Visible = false;
            button17.Visible = false;
            button18.Visible = false;
            button19.Visible = false;
            button20.Visible = false;
            button21.Visible = false;
            button22.Visible = false;
            button23.Visible = false;
            button24.Visible = false;
            button25.Visible = false;
            button26.Visible = false;
            button27.Visible = false;
            button28.Visible = false;
            button29.Visible = false;
            button30.Visible = false;
            button31.Visible = false;
            button32.Visible = false;
            button33.Visible = false;
            button34.Visible = false;
            button35.Visible = false;
            button36.Visible = false;
            button37.Visible = false;
            button38.Visible = false;
            button39.Visible = false;
            button40.Visible = false;
        }

        private void show_guesses()
        {
            switch (Globals.guessnumber)
            {
                case (1):
                    button1.BackColor = guess1.BackColor;
                    button2.BackColor = guess2.BackColor;
                    button3.BackColor = guess3.BackColor;
                    button4.BackColor = guess4.BackColor;
                    button5.BackColor = guess5.BackColor;
                    button1.Visible = true;
                    button2.Visible = true;
                    button3.Visible = true;
                    button4.Visible = true;
                    button5.Visible = true;
                    break;
                case (2):
                    button6.BackColor = guess1.BackColor;
                    button7.BackColor = guess2.BackColor;
                    button8.BackColor = guess3.BackColor;
                    button9.BackColor = guess4.BackColor;
                    button10.BackColor = guess5.BackColor;
                    button6.Visible = true;
                    button7.Visible = true;
                    button8.Visible = true;
                    button9.Visible = true;
                    button10.Visible = true;
                    break;
                case (3):
                    button11.BackColor = guess1.BackColor;
                    button12.BackColor = guess2.BackColor;
                    button13.BackColor = guess3.BackColor;
                    button14.BackColor = guess4.BackColor;
                    button15.BackColor = guess5.BackColor;
                    button11.Visible = true;
                    button12.Visible = true;
                    button13.Visible = true;
                    button14.Visible = true;
                    button15.Visible = true;
                    break;
                case (4):
                    button16.BackColor = guess1.BackColor;
                    button17.BackColor = guess2.BackColor;
                    button18.BackColor = guess3.BackColor;
                    button19.BackColor = guess4.BackColor;
                    button20.BackColor = guess5.BackColor;
                    button16.Visible = true;
                    button17.Visible = true;
                    button18.Visible = true;
                    button19.Visible = true;
                    button20.Visible = true;
                    break;
                case (5):
                    button21.BackColor = guess1.BackColor;
                    button22.BackColor = guess2.BackColor;
                    button23.BackColor = guess3.BackColor;
                    button24.BackColor = guess4.BackColor;
                    button25.BackColor = guess5.BackColor;
                    button21.Visible = true;
                    button22.Visible = true;
                    button23.Visible = true;
                    button24.Visible = true;
                    button25.Visible = true;
                    break;
                case (6):
                    button26.BackColor = guess1.BackColor;
                    button27.BackColor = guess2.BackColor;
                    button28.BackColor = guess3.BackColor;
                    button29.BackColor = guess4.BackColor;
                    button30.BackColor = guess5.BackColor;
                    button26.Visible = true;
                    button27.Visible = true;
                    button28.Visible = true;
                    button29.Visible = true;
                    button30.Visible = true;
                    break;
                case (7):
                    button31.BackColor = guess1.BackColor;
                    button32.BackColor = guess2.BackColor;
                    button33.BackColor = guess3.BackColor;
                    button34.BackColor = guess4.BackColor;
                    button35.BackColor = guess5.BackColor;
                    button31.Visible = true;
                    button32.Visible = true;
                    button33.Visible = true;
                    button34.Visible = true;
                    button35.Visible = true;
                    break;
                case (8):
                    button36.BackColor = guess1.BackColor;
                    button37.BackColor = guess2.BackColor;
                    button38.BackColor = guess3.BackColor;
                    button39.BackColor = guess4.BackColor;
                    button40.BackColor = guess5.BackColor;
                    button36.Visible = true;
                    button37.Visible = true;
                    button38.Visible = true;
                    button39.Visible = true;
                    button40.Visible = true;
                    break;
                default:
                    Console.WriteLine("smth went wrong, you should never get here");
                    break;

            }
        }

        private void show_answer()
        {
            password1.Visible = true;
            password2.Visible = true;
            password3.Visible = true;
            password4.Visible = true;
            password5.Visible = true;
        }

        private void hide_answer()
        {
            password1.Visible = false;
            password2.Visible = false;
            password3.Visible = false;
            password4.Visible = false;
            password5.Visible = false;
        }

        private void compare()
        {
            Console.WriteLine("answers: " + Globals.answer[0].ToString()+ Globals.answer[1].ToString()+ Globals.answer[2].ToString()+ Globals.answer[3].ToString()+ Globals.answer[4].ToString());
            Console.WriteLine("guesses: " + Globals.guess[0].ToString() + Globals.guess[1].ToString() + Globals.guess[2].ToString() + Globals.guess[3].ToString() + Globals.guess[4].ToString());
            Globals.rightplace = 0;
            Globals.rightcolor = 0;
            int[] buffanswers = new int[5];
            int[] buffguesses = new int[5];
            Array.Copy(Globals.answer, buffanswers, 5);
            Array.Copy(Globals.guess, buffguesses, 5);
            for (int i = 0; i < 5; i++)
            {
                if (buffguesses[i] == buffanswers[i])
                {
                    Globals.rightplace++;
                    
                    buffanswers[i] = -1;
                    buffguesses[i] = -2;
                }
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (j != i)
                    {
                        if (buffguesses[i] == buffanswers[j])
                        {
                            Globals.rightcolor++;
                            
                            buffanswers[j] = -1;
                            buffguesses[j] = -2;
                            break;
                        }
                    }
                }
            }
                
            
        }
       
        private void set_label()
        {
            switch (Globals.guessnumber)
            {
                case (1):
                    label1.Text = Globals.rightplace.ToString();
                    label2.Text = Globals.rightcolor.ToString();
                    break;
                case (2):
                    label3.Text = Globals.rightplace.ToString();
                    label4.Text = Globals.rightcolor.ToString();
                    break;
                case (3):
                    label5.Text = Globals.rightplace.ToString();
                    label6.Text = Globals.rightcolor.ToString();
                    break;
                case (4):
                    label7.Text = Globals.rightplace.ToString();
                    label8.Text = Globals.rightcolor.ToString();
                    break;
                case (5):
                    label9.Text = Globals.rightplace.ToString();
                    label10.Text = Globals.rightcolor.ToString();
                    break;
                case (6):
                    label11.Text = Globals.rightplace.ToString();
                    label12.Text = Globals.rightcolor.ToString();
                    break;
                case (7):
                    label13.Text = Globals.rightplace.ToString();
                    label14.Text = Globals.rightcolor.ToString();
                    break;
                case (8):
                    label15.Text = Globals.rightplace.ToString();
                    label16.Text = Globals.rightcolor.ToString();
                    break;
                default:
                    Console.WriteLine("smth went wrong, you should never get here");
                    break;

            }
        }

        private void end_game()
        {
            Globals.ingame = false;
            hide_guesses();
            Globals.guessnumber = 1;
            null_labels();
        }

        private void null_labels()
        {
            label1.Text = null;
            label2.Text = null;
            label3.Text = null;
            label4.Text = null;
            label5.Text = null;
            label6.Text = null;
            label7.Text = null;
            label8.Text = null;
            label9.Text = null;
            label10.Text = null;
            label11.Text = null;
            label12.Text = null;
            label13.Text = null;
            label14.Text = null;
            label15.Text = null;
            label16.Text = null;
        }

        private void change_skin_Click(object sender, EventArgs e)
        {
            string appPath = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            Console.WriteLine(appPath);
            String[] path = new string[4];
            for (int i = 0; i < appPath.Length - 27; i++) 
            {
                path[0] += appPath[i];
                path[1] += appPath[i];
                path[2] += appPath[i];
                path[3] += appPath[i];
            }
            
            path[1] = path[1] + "\\foty\\gora2.jpg";
            path[2] = path[2] + "\\foty\\miasto2.jpg";
            path[3] = path[3] + "\\foty\\street2.jpg";
            path[0] = path[0] + "\\foty\\las2.jpg";
            
            
                switch (Globals.currentskin)
                {
                    case 1:
                        Image myimage2 = new Bitmap(path[1]);
                        this.BackgroundImage = myimage2;
                        Globals.currentskin = 2;
                        break;
                    case 2:
                        Image myimage3 = new Bitmap(path[2]);
                        this.BackgroundImage = myimage3;
                        Globals.currentskin = 3;
                        break;
                    case 3:
                        Image myimage4 = new Bitmap(path[3]);
                        this.BackgroundImage = myimage4;
                        Globals.currentskin = 4;
                        break;
                    case 4:
                        Image myimage1 = new Bitmap(path[0]);
                        this.BackgroundImage = myimage1;
                        Globals.currentskin = 1;
                        break;
                    default:
                        break;
                }
            
            
            
            
        }
    }
}
