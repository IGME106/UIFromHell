using System;
using System.Windows.Forms;

/// <summary>
/// IGME-106 - Game Development and Algorithmic Problem Solving
/// Homework 1 - UI From Hell
/// Class Description   : Second class and second form for the UI from hell
/// Author              : Benjamin Kleynhans
/// Modified By         : Benjamin Kleynhans
/// Date                : February 6, 2018
/// Filename            : Form2.cs
/// </summary>

namespace UIFromHell
{
    public partial class Form2 : Form
    {
        Random random = new Random();                               // Instantiate random number generator

        private int encryptionShiftBy = 0;
        private string encryptionShiftDirection = "right";          // Set encryption direction

        private string clearName = string.Empty;

        private string encryptedName = string.Empty;

        public Form2()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Takes input from the textbox
        /// </summary>
        /// <param name="sender">Object calling the event</param>
        /// <param name="e">Arguments passed by the event</param>
        private void Form2ClearNameTxtB_KeyDown(object sender, KeyEventArgs e)
        {
            encryptionShiftBy = random.Next(0, 26);
            clearName = Form2PlainNameTxtB.Text;
            
            if (e.KeyCode == Keys.Return)       // Test if "Enter" was pressed and only act if yes
            {
                EncryptString();                // Encrypt the supplied string
            }
        }

        /// <summary>
        /// Helper method that requests the encrypted string and calls the update
        /// to screen
        /// </summary>
        private void EncryptString()
        {
            encryptedName = Cryptograph("encipher", clearName, encryptionShiftBy);

            UpdateDisplaySecondPhase();
        }

        /// <summary>
        /// Defines the encryption/decryption algorithm
        /// </summary>
        /// <param name="direction">Define if we want to "encrypt" or "decrypt"</param>
        /// <param name="ch">The character that needs to be encrypted/decrypted</param>
        /// <param name="key">The numeric key defining the number of shifts to perform</param>
        /// <returns></returns>
        private char Cipher(string direction, char ch, int key)
        {
            char returnValue = ' ';

            if (!char.IsLetter(ch))                             // If the supplied character is anything
            {                                                       // other than a letter, return
                returnValue = ch;                                   // without change
            }
            else
            {
                char d = char.IsUpper(ch) ? 'A' : 'a';          // Determine if the character is upper or lower case

                returnValue = (char)((((ch + key) - d) % 26) + d); // Calculate the encrypted value
            }

            return returnValue;
        }

        /// <summary>
        /// Calls for encryption or decryption depending on passed parameters
        /// </summary>
        /// <param name="direction">Define if we want to "encrypt" or "decrypt"</param>
        /// <param name="ch">The character that needs to be encrypted/decrypted</param>
        /// <param name="key">The numeric key defining the number of shifts to perform</param>
        /// <returns></returns>
        private string Cryptograph(string action, string input, int key)
        {
            string returnValue = String.Empty;

            switch (action)
            {
                case "encipher":
                    foreach (char ch in input)
                        returnValue += Cipher(encryptionShiftDirection, ch, key);

                    break;
                case "decipher":
                    returnValue = Cryptograph("encipher", input, 26 - key);

                    break;
                default:
                    break;
            }

            return returnValue;
        }

        /// <summary>
        /// Update the display with second set of controls when first challenge was completed
        /// </summary>
        private void UpdateDisplaySecondPhase()
        {
            Form2StateEncryptionLbl.Enabled = true;
            Form2StateEncryptionLbl.Visible = true;

            Form2ExamplePlainLbl1.Text = "ABC";                                 // Provides a hint to the player
            Form2ExampleEncryptedLbl1.Text = Cryptograph(
                                                    "encipher", 
                                                    Form2ExamplePlainLbl1.Text,
                                                    encryptionShiftBy
                                                );

            Form2ExamplePlainLbl2.Text = "GIK";                                 // Provides a hint to the player
            Form2ExampleEncryptedLbl2.Text = Cryptograph(
                                                    "encipher",
                                                    Form2ExamplePlainLbl2.Text,
                                                    encryptionShiftBy
                                                );

            Form2ExamplePlainLbl1.Enabled = true;                   // Enable form elements for second phase
            Form2ExamplePlainLbl1.Visible = true;
            Form2ExampleEncryptedLbl1.Enabled = true;
            Form2ExampleEncryptedLbl1.Visible = true;

            Form2ExamplePlainLbl2.Enabled = true;
            Form2ExamplePlainLbl2.Visible = true;
            Form2ExampleEncryptedLbl2.Enabled = true;
            Form2ExampleEncryptedLbl2.Visible = true;

            Form2EncryptedNameLbl.Enabled = true;
            Form2EncryptedNameLbl.Visible = true;

            Form2EncryptedNameTxtB.Enabled = true;
            Form2EncryptedNameTxtB.Visible = true;
        }

        /// <summary>
        /// Read input from text box and passes value to validator
        /// </summary>
        /// <param name="sender">Object calling the event</param>
        /// <param name="e">Arguments passed by the event</param>
        private void Form2EncryptedNameTxtB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                if (IsCorrectValue())
                {
                    DisplayLastElements();
                }
            }            
        }

        /// <summary>
        /// Determine if the value entered by the user matches the calculated value
        /// </summary>
        /// <returns></returns>
        private bool IsCorrectValue()
        {
            bool returnValue = false;

            if (Form2EncryptedNameTxtB.Text.Equals(encryptedName)) {
                returnValue = true;
            }

            return returnValue;
        }

        /// <summary>
        /// Display last elements for the second form
        /// </summary>
        private void DisplayLastElements()
        {
            Form2AskEncryptionTypeLbl.Enabled = true;
            Form2AskEncryptionTypeLbl.Visible = true;

            Form2DirectionLbl.Enabled = true;
            Form2DirectionLbl.Visible = true;

            Form2DirectionCmbB.Items.Add("left");   // Populate combo box with left and right
            Form2DirectionCmbB.Items.Add("right");      // so the user can indicate if it was a
                                                        // left or right cipher.  Left is not implemented, 
            Form2DirectionCmbB.Enabled = true;          // but the user doesn't know that.
            Form2DirectionCmbB.Visible = true;

            for (int i = 0; i < 27; i++)
            {
                Form2QtyCmbB.Items.Add(i);          // Populate combo box with numbers 0 to 26
            }                                           // so user can enter the shift quantity

            Form2QtyLbl.Enabled = true;
            Form2QtyLbl.Visible = true;

            Form2QtyCmbB.Enabled = true;
            Form2QtyCmbB.Visible = true;

            Form2CaeserSubmitBtn.Enabled = true;
            Form2CaeserSubmitBtn.Visible = true;
        }

        /// <summary>
        /// Read the values from the combo boxes and evaluate
        /// </summary>
        /// <param name="sender">Object calling the event</param>
        /// <param name="e">Arguments passed by the event</param>
        private void Form2CaeserSubmitBtn_Click(object sender, EventArgs e)
        {
            if ((Form2DirectionCmbB.Text.Equals(encryptionShiftDirection)) &&
                    ((Form2QtyCmbB.Text.Equals(encryptionShiftBy.ToString()))))
            {                                                           // If the answers are correct
                this.Hide();                                            // hide form 2

                Form3 form3 = new Form3();                              // open form 3
                DialogResult form3Result = form3.ShowDialog(this);

                this.Show();                                            // When form 3 closes, show this form
                this.Close();                                           // and then close it
            }
            else
            {
                MessageBox.Show(                                        // If the answers are incorrect, inform
                owner: this,                                                // the user
                text: "Sorry, that is wrong",
                caption: "You made a Boo-boo",
                buttons: MessageBoxButtons.OK
                );
            }
        }
    }
}
