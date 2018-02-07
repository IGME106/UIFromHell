using System;
using System.Drawing;
using System.Windows.Forms;

/// <summary>
/// IGME-106 - Game Development and Algorithmic Problem Solving
/// Homework 1 - UI From Hell
/// Class Description   : Main class and starting form for the UI from hell
/// Author              : Benjamin Kleynhans
/// Modified By         : Benjamin Kleynhans
/// Date                : February 6, 2018
/// Filename            : Form1.cs
/// </summary>

namespace UIFromHell
{
    /// <summary>
    /// Starting form for the UI from hell game.  The second form
    /// is launched from this form after certain parameters have been met.
    /// 
    /// The game is designed into a number of sections.  The sections are made
    /// available to the player one at a time as the previous obstacle is overcome.
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// Global variables defined for easy form manipulation to assist with
        /// active borders on first challenge
        /// </summary>
        private static bool TopEntry = false;
        private static bool TopExit = false;
        private static bool LeftEntry = false;
        private static bool LeftExit = false;
        private static bool BottomEntry = false;
        private static bool BottomExit = false;
        private static bool RightEntry = false;
        private static bool RightExit = false;

        /// <summary>
        /// Component initialization
        /// </summary>
        public Form1()
        {   
            InitializeComponent();

            Form1Lbl1.Text = "To continue you must go back, \n" +       // Text of first label
                "but to go back you must have gone forward, \n" +
                "Before you can go forward, you must go up, \n" +
                "but to go up you must have gone down.";

            SetDisplaySize();                                           // Configure and design remaining controls
        }

        /// <summary>
        /// Disables the controls that modifies the first step of the puzzle
        /// and enables the controls for the second step of the puzzle.
        /// </summary>
        /// <param name="sender">Object calling the event</param>
        /// <param name="e">Arguments passed by the event</param>
        private void Form1BtnNext_Click(object sender, EventArgs e)
        {
            DisableStep1();
            EnableStep2();
        }

        /// <summary>
        /// Method that disables the first phase of the game
        /// </summary>
        private void DisableStep1()
        {
            ResetLocks("reset");
            Form1Panel1.Visible = false;
            Form1Panel1.Enabled = false;

            Form1Lbl1.Visible = false;
            Form1Lbl1.Enabled = false;
        }

        /// <summary>
        /// Method that enables the second phase of the game
        /// </summary>
        private void EnableStep2()
        {
            this.Form1Lbl2.Enabled = true;      // Enable and set label visible
            this.Form1Lbl2.Visible = true;

            this.Form1CmbB1.Enabled = true;     // Enable and set combo box visible
            this.Form1CmbB1.Visible = true;

            this.Size = new Size(560, 125);     // Redefine canvas/form size

            this.Form1Lbl2.Text = "What is code and section of this course?";

            for (int i = 0; i < 10; i++)        // Populate the combo box
            {
                for (int j = 0; j < 5; j++)
                {
                    this.Form1CmbB1.Items.Add("IGME.10" + i + ".0" + j);
                }
            }
        }

        /// <summary>
        /// Sets the sizes and locations of the elements on the form
        /// </summary>
        private void SetDisplaySize()
        {
            int labelWidth = Form1Lbl1.Size.Width;                      // Set parameters for first label
            int labelHeight = Form1Lbl1.Size.Height;

            this.Form1Lbl1.Location = new Point(25, 25);                // Define starting point for label
            this.Form1Lbl1.Size = new Size(labelWidth, labelHeight);

            int paneWidth = labelWidth;                                 // Set parameters for first pane
            int paneHeight = labelHeight + 40;
            this.Form1Panel1.Location = new Point(30, 60 + labelHeight);    // Define starting point for panel
            this.Form1Panel1.Size = new Size(paneWidth, paneHeight);

            int buttonWidth = labelWidth - 40;                               // Set parameters for button
            int buttonHeight = labelHeight;
            this.Form1BtnNext.Location = new Point(20, 20);             // Define starting point for button
            this.Form1BtnNext.Size = new Size(buttonWidth, buttonHeight);

            SetBorderPanes(paneWidth, paneHeight);                      // Set parameters for panes surrounding button

            int comboBoxLblWidth = 300;                                 // Set size of combo box label for second phase
            int comboBoxLblHeight = 20;
            this.Form1Lbl2.Location = new Point(25, 25);                // Define starting point of label
            this.Form1Lbl2.Size = new Size(comboBoxLblWidth, comboBoxLblHeight);

            int comboBoxWidth = 100;                                    // Set size of combo box for second phase
            int comboBoxHeight = 20;
            this.Form1CmbB1.Location = new Point(comboBoxLblWidth + 100, 25);   // Define starting point of combo box
            this.Form1CmbB1.Size = new Size(comboBoxWidth, comboBoxHeight);
            
            this.Size = new Size(labelWidth + 70, (labelHeight + paneHeight + 125));    // Resize form to include
                                                                            // all controls
        }

        /// <summary>
        /// Defines the layout of the panels surrounding the continue button
        /// which form part of the game logic to unlock the control
        /// </summary>
        /// <param name="nextButtonWidth">Width of the main button in the form</param>
        /// <param name="nextButtonHeight">Height of the main button in the form</param>
        private void SetBorderPanes(int nextButtonWidth, int nextButtonHeight)
        {
            this.Form1PanelTopEntry.Location = new Point(20, 0);                    // Starting location of panel
            this.Form1PanelTopEntry.Size = new Size((nextButtonWidth - 40), 20);    // Size of panel

            this.Form1PanelLeftEntry.Location = new Point(0, 20);
            this.Form1PanelLeftEntry.Size = new Size(20, nextButtonHeight - 40);

            this.Form1PanelBottomEntry.Location = new Point(20, (nextButtonHeight - 20));
            this.Form1PanelBottomEntry.Size = new Size(nextButtonWidth - 40, 20);

            this.Form1PanelRightEntry.Location = new Point((nextButtonWidth - 20), 20);
            this.Form1PanelRightEntry.Size = new Size(20, nextButtonHeight - 40);
        }

        /// <summary>
        /// Event triggered when the mouse moves over the panel on top of the button
        /// </summary>
        /// <param name="sender">Object calling the event</param>
        /// <param name="e">Arguments passed by the event</param>
        private void Form1PanelTopEntry_MouseEnter(object sender, EventArgs e)
        {
            UpdateLockStatus("Form1PanelTopEntry");
        }

        /// <summary>
        /// Event triggered when the mouse moves over the panel on the left of the button
        /// </summary>
        /// <param name="sender">Object calling the event</param>
        /// <param name="e">Arguments passed by the event</param>
        private void Form1PanelLeftEntry_MouseEnter(object sender, EventArgs e)
        {
            UpdateLockStatus("Form1PanelLeftEntry");
        }

        /// <summary>
        /// Event triggered when the mouse moves over the panel on the bottom of the button
        /// </summary>
        /// <param name="sender">Object calling the event</param>
        /// <param name="e">Arguments passed by the event</param>
        private void Form1PanelBottomEntry_MouseEnter(object sender, EventArgs e)
        {
            UpdateLockStatus("Form1PanelBottomEntry");
        }

        /// <summary>
        /// Event triggered when the mouse moves over the panel on the right of the button
        /// </summary>
        /// <param name="sender">Object calling the event</param>
        /// <param name="e">Arguments passed by the event</param>
        private void Form1PanelRightEntry_MouseEnter(object sender, EventArgs e)
        {
            UpdateLockStatus("Form1PanelRightEntry");
        }

        /// <summary>
        /// Updates the status of the button depending on the logic that has been completed.
        /// It works like a combination lock
        /// </summary>
        /// <param name="sender"></param>
        private void UpdateLockStatus(string sender)
        {
            string element = (string)sender;        // Event triggering the event

            switch (element)
            {
                case "Form1PanelTopEntry":
                    if (
                        TopEntry == false &&
                        TopExit == false &&
                        LeftEntry == false &&
                        LeftExit == false &&
                        BottomEntry == false &&
                        BottomExit == false &&
                        RightEntry == false &&
                        RightExit == false)
                    {
                        TopEntry = true;                    // Set TopEntry boolean variable to true
                    }
                    else if (
                        TopEntry == true &&
                        TopExit == false &&
                        LeftEntry == false &&
                        LeftExit == false &&
                        BottomEntry == true &&
                        BottomExit == true &&
                        RightEntry == false &&
                        RightExit == false)
                    {
                        TopExit = true;                     // Set TopExit boolean variable to true
                        this.Form1PanelTopEntry.BackColor = Color.Green; // When both TopEntry and TopExit
                    }                                                       // variables are true, unlock the
                    else                                                    // top door
                    {
                        ResetLocks("error");
                    }

                    break;
                case "Form1PanelLeftEntry":
                    if (
                        TopEntry == true &&
                        TopExit == true &&
                        LeftEntry == false &&
                        LeftExit == false &&
                        BottomEntry == true &&
                        BottomExit == true &&
                        RightEntry == false &&
                        RightExit == false)
                    {
                        LeftEntry = true;                    // Set LeftEntry boolean variable to true
                    }
                    else if (
                      TopEntry == true &&
                      TopExit == true &&
                      LeftEntry == true &&
                      LeftExit == false &&
                      BottomEntry == true &&
                      BottomExit == true &&
                      RightEntry == true &&
                      RightExit == true)
                    {
                        LeftExit = true;                    // Set LeftExit boolean variable to true
                        this.Form1PanelLeftEntry.BackColor = Color.Green; // When both LeftEntry and LeftExit
                    }                                                       // variables are true, unlock the
                    else                                                    // left door
                    {
                        ResetLocks("error");
                    }

                    break;
                case "Form1PanelBottomEntry":
                    if (
                        TopEntry == true &&
                        TopExit == false &&
                        LeftEntry == false &&
                        LeftExit == false &&
                        BottomEntry == false &&
                        BottomExit == false &&
                        RightEntry == false &&
                        RightExit == false)
                    {
                        BottomExit = true;                    // Set BottomExit boolean variable to true
                    }
                    else if (
                      TopEntry == true &&
                      TopExit == false &&
                      LeftEntry == false &&
                      LeftExit == false &&
                      BottomEntry == false &&
                      BottomExit == true &&
                      RightEntry == false &&
                      RightExit == false)
                    {
                        BottomEntry = true;                    // Set BottomEntry boolean variable to true
                        this.Form1PanelBottomEntry.BackColor = Color.Green; // When both BottomEntry and BottomExit
                    }                                                           // variables are true, unlock the
                    else                                                        // bottom door
                    {
                        ResetLocks("error");
                    }

                    break;
                case "Form1PanelRightEntry":
                    if (
                        TopEntry == true &&
                        TopExit == true &&
                        LeftEntry == true &&
                        LeftExit == false &&
                        BottomEntry == true &&
                        BottomExit == true &&
                        RightEntry == false &&
                        RightExit == false)
                    {
                        RightExit = true;                    // Set RightExit boolean variable to true
                    }
                    else if (
                      TopEntry == true &&
                      TopExit == true &&
                      LeftEntry == true &&
                      LeftExit == false &&
                      BottomEntry == true &&
                      BottomExit == true &&
                      RightEntry == false &&
                      RightExit == true)
                    {
                        RightEntry = true;                    // Set RightEntry boolean variable to true
                        this.Form1PanelRightEntry.BackColor = Color.Green; // When both RightEntry and RightExit
                    }                                                       // variables are true, unlock the
                    else                                                    // right door
                    {
                        ResetLocks("error");
                    }

                    break;
                default:
                    break;
            }

            if (                                                // When all the doors are unlocked
                TopEntry == true &&
                TopExit == true &&
                LeftEntry == true &&
                LeftExit == true &&
                BottomEntry == true &&
                BottomExit == true &&
                RightEntry == true &&
                RightExit == true)
            {
                this.Form1BtnNext.Enabled = true;               // Enable the button control
                this.Form1BtnNext.Text = "Click here to Continue";
                                                                
                int nextButtonXLocation = Form1BtnNext.PointToScreen(Point.Empty).X; // Get coordinates of button on screen
                int nextButtonYLocation = Form1BtnNext.PointToScreen(Point.Empty).Y;

                nextButtonXLocation += (this.Form1BtnNext.Size.Width / 2);  // Calculate center of button
                nextButtonYLocation += (this.Form1BtnNext.Size.Height / 2);

                this.Cursor = new Cursor(Cursor.Current.Handle);            // Place mouse cursor in center of button
                Cursor.Position = new Point(nextButtonXLocation, nextButtonYLocation);
            }
        }

        /// <summary>
        /// Close all the locks if the combination is entered incorrectly
        /// </summary>
        /// <param name="why"></param>
        private void ResetLocks(string why)
        {
            if (why.Equals("error"))
            {
                DisplayMessage("errorSection1");
            }   

            TopEntry = false;                   // Close all locks
            TopExit = false;
            LeftEntry = false;
            LeftExit = false;
            BottomEntry = false;
            BottomExit = false;
            RightEntry = false;
            RightExit = false;

            this.Form1PanelTopEntry.BackColor = SystemColors.Control;
            this.Form1PanelLeftEntry.BackColor = SystemColors.Control;
            this.Form1PanelBottomEntry.BackColor = SystemColors.Control;
            this.Form1PanelRightEntry.BackColor = SystemColors.Control;

            this.Form1BtnNext.Text = "";        // Reset button text

            this.Cursor = new Cursor(Cursor.Current.Handle);
            Cursor.Position = new Point(0, 0);  // Move cursor out of the way
        }

        /// <summary>
        /// Get input from combo box to determine selection
        /// </summary>
        /// <param name="sender">Object calling the event</param>
        /// <param name="e">Arguments passed by the event</param>
        private void Form1CmbB1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = (string)Form1CmbB1.SelectedItem;

            if (selectedValue.Equals("IGME.106.02")) {  // If correct value selected
                this.Hide();                                // hide this form

                Form2 form2 = new Form2();              // Open Form2
                DialogResult form2Result = form2.ShowDialog(this);

                this.Show();                            // Once Form2 closes, un-hide this form
                this.Close();                               // and close it
            }
            else
            {
                DisplayMessage("errorSection2");
            }
        }

        /// <summary>
        /// Displays a message to the user depending on the key request
        /// </summary>
        /// <param name="key">Key value to define which message to display</param>
        private void DisplayMessage(string key)
        {
            string message = string.Empty;
            string heading = string.Empty;

            switch (key)                    // Define message output parameters
            {
                case "errorSection1":
                    message = "Wrong order, try again";
                    heading = "You made a Boo-boo";

                    break;
                case "errorSection2":
                    message = "The course/section combination you chose is incorrect, try again";
                    heading = "Invalid Selection";

                    break;
                default:
                    break;
            }
            
            MessageBox.Show(                // Display a message stating reset
                owner: this,
                text: message,
                caption: heading,
                buttons: MessageBoxButtons.OK
            );
            
        }
    }
}
