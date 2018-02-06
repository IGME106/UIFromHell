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
        Random random = new Random();

        private int encryptionShiftBy = 0;
        private string encryptionShiftDirection = "right";

        private string clearName = string.Empty;

        private string encryptedName = string.Empty;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2ClearNameTxtB_KeyDown(object sender, KeyEventArgs e)
        {
            encryptionShiftBy = random.Next(0, 26);
            clearName = Form2PlainNameTxtB.Text;
            
            if (e.KeyCode == Keys.Return)
            {
                EncryptString();                
            }
        }

        private void EncryptString()
        {
            encryptedName = Cryptograph("encipher", clearName, encryptionShiftBy);

            UpdateDisplaySecondPhase();
        }

        private void DecryptString()
        {

        }

        private char Cipher(string direction, char ch, int key)
        {
            char returnValue = ' ';

            if (!char.IsLetter(ch))
            {
                returnValue = ch;
            }
            else
            {
                char d = char.IsUpper(ch) ? 'A' : 'a';

                returnValue = (char)((((ch + key) - d) % 26) + d);
            }

            return returnValue;
        }

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

        private void UpdateDisplaySecondPhase()
        {
            Form2StateEncryptionLbl.Enabled = true;
            Form2StateEncryptionLbl.Visible = true;

            Form2ExamplePlainLbl1.Text = "ABC";
            Form2ExampleEncryptedLbl1.Text = Cryptograph(
                                                    "encipher", 
                                                    Form2ExamplePlainLbl1.Text,
                                                    encryptionShiftBy
                                                );

            Form2ExamplePlainLbl2.Text = "GIK";
            Form2ExampleEncryptedLbl2.Text = Cryptograph(
                                                    "encipher",
                                                    Form2ExamplePlainLbl2.Text,
                                                    encryptionShiftBy
                                                );

            Form2ExamplePlainLbl1.Enabled = true;
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

        private bool IsCorrectValue()
        {
            bool returnValue = false;

            if (Form2EncryptedNameTxtB.Text.Equals(encryptedName)) {
                returnValue = true;
            }

            return returnValue;
        }

        private void DisplayLastElements()
        {
            Form2AskEncryptionTypeLbl.Enabled = true;
            Form2AskEncryptionTypeLbl.Visible = true;

            Form2DirectionLbl.Enabled = true;
            Form2DirectionLbl.Visible = true;

            Form2DirectionCmbB.Items.Add("left");
            Form2DirectionCmbB.Items.Add("right");

            Form2DirectionCmbB.Enabled = true;
            Form2DirectionCmbB.Visible = true;

            for (int i = 0; i < 27; i++)
            {
                Form2QtyCmbB.Items.Add(i);
            }

            Form2QtyLbl.Enabled = true;
            Form2QtyLbl.Visible = true;

            Form2QtyCmbB.Enabled = true;
            Form2QtyCmbB.Visible = true;

            Form2CaeserSubmitBtn.Enabled = true;
            Form2CaeserSubmitBtn.Visible = true;
        }
        
        private void Form2CaeserSubmitBtn_Click(object sender, EventArgs e)
        {
            if ((Form2DirectionCmbB.Text.Equals(encryptionShiftDirection)) &&
                    ((Form2QtyCmbB.Text.Equals(encryptionShiftBy.ToString()))))
            {
                this.Hide();

                Form3 form3 = new Form3();
                DialogResult form3Result = form3.ShowDialog(this);

                this.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show(
                owner: this,
                text: "Sorry, that is wrong",
                caption: "You made a Boo-boo",
                buttons: MessageBoxButtons.OK
                );
            }
        }
    }
}
