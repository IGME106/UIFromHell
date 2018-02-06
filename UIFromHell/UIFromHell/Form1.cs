using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIFromHell
{
    public partial class Form1 : Form
    {

        private static bool TopEntry = false;
        private static bool TopExit = false;
        private static bool LeftEntry = false;
        private static bool LeftExit = false;
        private static bool BottomEntry = false;
        private static bool BottomExit = false;
        private static bool RightEntry = false;
        private static bool RightExit = false;

        public Form1()
        {   
            InitializeComponent();

            Form1Lbl1.Text = "To continue you must go back, \n" +
                "but to go back you must have gone forward, \n" +
                "Before you can go forward, you must go up, \n" +
                "but to go up you must have gone down.";

            SetDisplaySize();
        }

        private void Form1BtnNext_Click(object sender, EventArgs e)
        {
            DisableStep1();
            EnableStep2();
        }

        private void DisableStep1()
        {
            ResetLocks("reset");
            Form1Panel1.Visible = false;
            Form1Panel1.Enabled = false;

            Form1Lbl1.Visible = false;
            Form1Lbl1.Enabled = false;
        }

        private void EnableStep2()
        {
            this.Form1Lbl2.Enabled = true;
            this.Form1Lbl2.Visible = true;

            this.Form1CmbB1.Enabled = true;
            this.Form1CmbB1.Visible = true;

            this.Size = new Size(600, 150);

            this.Form1Lbl2.Text = "What is code and section of this course?";

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    this.Form1CmbB1.Items.Add("IGME.10" + i + ".0" + j);
                }
            }
        }

        private void SetDisplaySize()
        {
            int labelWidth = Form1Lbl1.Size.Width;
            int labelHeight = Form1Lbl1.Size.Height;

            this.Form1Lbl1.Location = new Point(25, 25);
            this.Form1Lbl1.Size = new Size(labelWidth, labelHeight);

            int paneWidth = labelWidth;
            int paneHeight = labelHeight + 40;
            this.Form1Panel1.Location = new Point(30, 60 + labelHeight);
            this.Form1Panel1.Size = new Size(paneWidth, paneHeight);

            int mouseHoverObjectHeight = 40;

            int buttonWidth = labelWidth;
            int buttonHeight = labelHeight;
            this.Form1BtnNext.Location = new Point(20, 20);
            this.Form1BtnNext.Size = new Size(buttonWidth, buttonHeight);

            SetBorderButtons(paneWidth, paneHeight);

            int comboBoxLblWidth = 300;
            int comboBoxLblHeight = 20;
            this.Form1Lbl2.Location = new Point(25, 25);
            this.Form1Lbl2.Size = new Size(comboBoxLblWidth, comboBoxLblHeight);

            int comboBoxWidth = 100;
            int comboBoxHeight = 20;
            this.Form1CmbB1.Location = new Point(comboBoxLblWidth + 100, 25);
            this.Form1CmbB1.Size = new Size(comboBoxWidth, comboBoxHeight);

            this.Size = new Size(labelWidth + 70, (labelHeight + paneHeight + mouseHoverObjectHeight + 85));
        }

        private void SetBorderButtons(int nextButtonWidth, int nextButtonHeight)
        {
            this.Form1PanelTopEntry.Location = new Point(20, 0);
            this.Form1PanelTopEntry.Size = new Size((nextButtonWidth - 40), 20);

            this.Form1PanelLeftEntry.Location = new Point(0, 20);
            this.Form1PanelLeftEntry.Size = new Size(20, nextButtonHeight - 40);

            this.Form1PanelBottomEntry.Location = new Point(20, (nextButtonHeight - 20));
            this.Form1PanelBottomEntry.Size = new Size(nextButtonWidth - 40, 20);

            this.Form1PanelRightEntry.Location = new Point((nextButtonWidth - 20), 20);
            this.Form1PanelRightEntry.Size = new Size(20, nextButtonHeight - 40);
        }
        
        private void Form1PanelTopEntry_MouseEnter(object sender, EventArgs e)
        {
            UpdateLockStatus("Form1PanelTopEntry");
        }

        private void Form1PanelLeftEntry_MouseEnter(object sender, EventArgs e)
        {
            UpdateLockStatus("Form1PanelLeftEntry");
        }

        private void Form1PanelBottomEntry_MouseEnter(object sender, EventArgs e)
        {
            UpdateLockStatus("Form1PanelBottomEntry");
        }

        private void Form1PanelRightEntry_MouseEnter(object sender, EventArgs e)
        {
            UpdateLockStatus("Form1PanelRightEntry");
        }

        private void UpdateLockStatus(string sender)
        {
            string element = (string)sender;

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
                        TopEntry = true;
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
                        TopExit = true;
                        this.Form1PanelTopEntry.BackColor = Color.Green;
                    } else
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
                        LeftEntry = true;
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
                        LeftExit = true;
                        this.Form1PanelLeftEntry.BackColor = Color.Green;
                    }
                    else
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
                        BottomExit = true;
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
                        BottomEntry = true;
                        this.Form1PanelBottomEntry.BackColor = Color.Green;
                    }
                    else
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
                        RightExit = true;
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
                        RightEntry = true;
                        this.Form1PanelRightEntry.BackColor = Color.Green;
                    }
                    else
                    {
                        ResetLocks("error");
                    }

                    break;
                default:
                    break;
            }

            if (
                TopEntry == true &&
                TopExit == true &&
                LeftEntry == true &&
                LeftExit == true &&
                BottomEntry == true &&
                BottomExit == true &&
                RightEntry == true &&
                RightExit == true)
            {
                this.Form1BtnNext.Enabled = true;
                this.Form1BtnNext.Text = "Click here to Continue";

                int nextButtonXLocation = Form1BtnNext.PointToScreen(Point.Empty).X;
                int nextButtonYLocation = Form1BtnNext.PointToScreen(Point.Empty).Y;

                nextButtonXLocation += (this.Form1BtnNext.Size.Width / 2);
                nextButtonYLocation += (this.Form1BtnNext.Size.Height / 2);

                this.Cursor = new Cursor(Cursor.Current.Handle);
                Cursor.Position = new Point(nextButtonXLocation, nextButtonYLocation);
            }
        }

        private void ResetLocks(string why)
        {
            if (why.Equals("error"))
            {
                MessageBox.Show(
                owner: this,
                text: "Wrong order, try again",
                caption: "You made a Boo-boo",
                buttons: MessageBoxButtons.OK
                );
            }

            TopEntry = false;
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

            this.Form1BtnNext.Text = "";

            this.Cursor = new Cursor(Cursor.Current.Handle);
            Cursor.Position = new Point(0, 0);
        }

        private void Form1CmbB1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = (string)Form1CmbB1.SelectedItem;

            if (selectedValue.Equals("IGME.106.02")) {
                this.Hide();

                Form2 form2 = new Form2();
                DialogResult form2Result = form2.ShowDialog(this);

                this.Show();
                this.Close();
            }            
        }
    }
}
