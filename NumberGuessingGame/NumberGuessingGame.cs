using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberGuessingGame
{
    public partial class NumberGuessingGame : Form
    {
        static int userTryCount = 0;
        public NumberGuessingGame()
        {
            InitializeComponent();
        }

        private void INST_Label_2_Click(object sender, EventArgs e)
        {

        }

        private void Submission_Button_Click(object sender, EventArgs e)
        {
            userTryCount = userTryCount + 1;
            // setting rnd as a random number between 1 and 100
            int rnd = Convert.ToInt32(lblRandomNumber.Text);
            //setting up the entry validation system
            int guess;
            guess = int.Parse(Guess_Textbox.Text);

            if (int.TryParse(Guess_Textbox.Text, out guess))
            {
                if (guess >= 1 && guess <= 100)
                {
                }
                else
                {
                    MessageBox.Show("Guess must be in the range of 1 to 100");
                }
            }
            else
            {
                MessageBox.Show("Guess must be an interger");
            }
            //this is the mechanism to give hints
            if (rnd > guess)
            {
                MessageBox.Show("Too Low, try guessing higher");
            }
            else if (rnd < guess)
            {
                MessageBox.Show("Too high, try guessing lower");
            }
            else if (rnd == guess)
            {
                MessageBox.Show("Great Job, you guessed correctly! your Number of Trials are " + userTryCount.ToString ());
            }
            //reset cusor to Guess Textbox
            Guess_Textbox.Text = ""; //clear the textbox
            Guess_Textbox.Focus(); //set cursor back on guessing area
        }

        private void Feedback_Label_Click(object sender, EventArgs e)
        {
        }


        private void Exit_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Help_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Trouble shooting tips: " +
                " The number will always include intergers ranging from 1 to 100. " +
                " Type your answers into the labelled textbox in order to get a hint on how to guess next." +
                " I wish you the best of luck with guessing the hidden number ");
        }

        private void NumberGuessingGame_Load(object sender, EventArgs e)
        {
            int rnd;
            Random no = new Random();
            rnd = no.Next(1, 100);
            lblRandomNumber.Text = rnd.ToString ();
            //If the below value is set to true then the Random number is visible on the form.
            //For Debugging and to enhance your application  please set to true and then modify your application.
            lblRandomNumber.Visible = false;

        }
    }
}
