using System;
using System.Windows.Forms;

/// <summary>
/// IGME-106 - Game Development and Algorithmic Problem Solving
/// Homework 1 - UI From Hell
/// Class Description   : Third class and third form for the UI from hell
/// Author              : Benjamin Kleynhans
/// Modified By         : Benjamin Kleynhans
/// Date                : February 6, 2018
/// Filename            : Form3.cs
/// </summary>

namespace UIFromHell
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();            
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Form3GroupBox2.Enabled = true;
        }

        private void Form3SubmitBtn1_Click(object sender, EventArgs e)
        {
            if ((RadioButton1.Checked == true) || (RadioButton2.Checked == true))
            {
                DisplayMessage("noneSelected");
            }

            if ((Form3Question1RadioBtn3.Checked == true) && (Form3Question2RadioBtn1.Checked == true))
            {
                DisplayMessage("correctAnswer");
            }
            else if (
                        (((Form3Question1RadioBtn1.Checked == true) || (Form3Question1RadioBtn2.Checked == true)) && 
                        (Form3Question2RadioBtn1.Checked == true)
                    ) || (
                        (Form3Question1RadioBtn3.Checked == true) && (Form3Question2RadioBtn2.Checked == true))                        
                    )
            {
                DisplayMessage("incorrectAnswer");
            }
            else if (((Form3Question1RadioBtn1.Checked == true) || (Form3Question1RadioBtn2.Checked == true)) &&
                        (Form3Question2RadioBtn2.Checked == true))
            {
                DisplayMessage("almostCorrect");
            }
        }

        private void DisplayMessage(string optionString)
        {
            string message = String.Empty;
            string heading = String.Empty;

            switch (optionString)
            {
                case "noneSelected":
                    message = "You have not made a valid selection";
                    heading = "Invalid selection";

                    break;
                case "incorrectAnswer":
                    message = "At least one of the answers is incorrect";
                    heading = "Incorrect Answers";

                    break;
                case "correctAnswer":
                    message = "Congratulations, you won the game";
                    heading = "YOU WON!!!";

                    break;
                case "almostCorrect":
                    message = "Congratulations, you won the game (kind of)...\n\n" +
                        "You had the answer wrong, but you admitted you didn't know\n" +
                        "so I'll let it pass";
                    heading = "YOU WON!!!";

                    break;
                default:
                    break;
            }

            MessageBox.Show(
                owner: this,
                text: message,
                caption: heading,
                buttons: MessageBoxButtons.OK
            );

            if ((optionString.Equals("correctAnswer")) || (optionString.Equals("almostCorrect")))
            {
                this.Close();
            }
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Form3SubmitBtn1.Enabled = true;
        }
    }
}
