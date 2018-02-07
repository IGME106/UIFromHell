/// <summary>
/// IGME-106 - Game Development and Algorithmic Problem Solving
/// Homework 1 - UI From Hell
/// Class Description   : Second class and second form for the UI from hell
/// Author              : Benjamin Kleynhans
/// Modified By         : Benjamin Kleynhans
/// Date                : February 6, 2018
/// Filename            : Form2.Designer.cs
/// </summary>

namespace UIFromHell
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Form2AskPlainNameLbl = new System.Windows.Forms.Label();
            this.Form2ExamplePlainLbl1 = new System.Windows.Forms.Label();
            this.Form2ExampleEncryptedLbl1 = new System.Windows.Forms.Label();
            this.Form2PlainNameTxtB = new System.Windows.Forms.TextBox();
            this.Form2EncryptedNameTxtB = new System.Windows.Forms.TextBox();
            this.Form2ExamplePlainLbl2 = new System.Windows.Forms.Label();
            this.Form2ExampleEncryptedLbl2 = new System.Windows.Forms.Label();
            this.Form2DirectionLbl = new System.Windows.Forms.Label();
            this.Form2QtyLbl = new System.Windows.Forms.Label();
            this.Form2DirectionCmbB = new System.Windows.Forms.ComboBox();
            this.Form2QtyCmbB = new System.Windows.Forms.ComboBox();
            this.Form2StateEncryptionLbl = new System.Windows.Forms.Label();
            this.Form2EncryptedNameLbl = new System.Windows.Forms.Label();
            this.Form2AskEncryptionTypeLbl = new System.Windows.Forms.Label();
            this.Form2CaeserSubmitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Form2AskPlainNameLbl
            // 
            this.Form2AskPlainNameLbl.Location = new System.Drawing.Point(28, 26);
            this.Form2AskPlainNameLbl.Name = "Form2AskPlainNameLbl";
            this.Form2AskPlainNameLbl.Size = new System.Drawing.Size(316, 17);
            this.Form2AskPlainNameLbl.TabIndex = 0;
            this.Form2AskPlainNameLbl.Text = "Enter your first name and press enter";
            // 
            // Form2ExamplePlainLbl1
            // 
            this.Form2ExamplePlainLbl1.Location = new System.Drawing.Point(28, 185);
            this.Form2ExamplePlainLbl1.Name = "Form2ExamplePlainLbl1";
            this.Form2ExamplePlainLbl1.Size = new System.Drawing.Size(151, 17);
            this.Form2ExamplePlainLbl1.TabIndex = 1;
            this.Form2ExamplePlainLbl1.Text = "label2";
            this.Form2ExamplePlainLbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Form2ExamplePlainLbl1.Visible = false;
            // 
            // Form2ExampleEncryptedLbl1
            // 
            this.Form2ExampleEncryptedLbl1.Location = new System.Drawing.Point(28, 217);
            this.Form2ExampleEncryptedLbl1.Name = "Form2ExampleEncryptedLbl1";
            this.Form2ExampleEncryptedLbl1.Size = new System.Drawing.Size(151, 17);
            this.Form2ExampleEncryptedLbl1.TabIndex = 2;
            this.Form2ExampleEncryptedLbl1.Text = "label3";
            this.Form2ExampleEncryptedLbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Form2ExampleEncryptedLbl1.Visible = false;
            // 
            // Form2PlainNameTxtB
            // 
            this.Form2PlainNameTxtB.Location = new System.Drawing.Point(31, 52);
            this.Form2PlainNameTxtB.Name = "Form2PlainNameTxtB";
            this.Form2PlainNameTxtB.Size = new System.Drawing.Size(313, 22);
            this.Form2PlainNameTxtB.TabIndex = 3;
            this.Form2PlainNameTxtB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2ClearNameTxtB_KeyDown);
            // 
            // Form2EncryptedNameTxtB
            // 
            this.Form2EncryptedNameTxtB.Location = new System.Drawing.Point(31, 310);
            this.Form2EncryptedNameTxtB.Name = "Form2EncryptedNameTxtB";
            this.Form2EncryptedNameTxtB.Size = new System.Drawing.Size(313, 22);
            this.Form2EncryptedNameTxtB.TabIndex = 4;
            this.Form2EncryptedNameTxtB.Visible = false;
            this.Form2EncryptedNameTxtB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2EncryptedNameTxtB_KeyDown);
            // 
            // Form2ExamplePlainLbl2
            // 
            this.Form2ExamplePlainLbl2.Location = new System.Drawing.Point(185, 185);
            this.Form2ExamplePlainLbl2.Name = "Form2ExamplePlainLbl2";
            this.Form2ExamplePlainLbl2.Size = new System.Drawing.Size(159, 17);
            this.Form2ExamplePlainLbl2.TabIndex = 5;
            this.Form2ExamplePlainLbl2.Text = "label4";
            this.Form2ExamplePlainLbl2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Form2ExamplePlainLbl2.Visible = false;
            // 
            // Form2ExampleEncryptedLbl2
            // 
            this.Form2ExampleEncryptedLbl2.Location = new System.Drawing.Point(185, 217);
            this.Form2ExampleEncryptedLbl2.Name = "Form2ExampleEncryptedLbl2";
            this.Form2ExampleEncryptedLbl2.Size = new System.Drawing.Size(159, 17);
            this.Form2ExampleEncryptedLbl2.TabIndex = 6;
            this.Form2ExampleEncryptedLbl2.Text = "label5";
            this.Form2ExampleEncryptedLbl2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Form2ExampleEncryptedLbl2.Visible = false;
            // 
            // Form2DirectionLbl
            // 
            this.Form2DirectionLbl.Location = new System.Drawing.Point(28, 383);
            this.Form2DirectionLbl.Name = "Form2DirectionLbl";
            this.Form2DirectionLbl.Size = new System.Drawing.Size(43, 17);
            this.Form2DirectionLbl.TabIndex = 7;
            this.Form2DirectionLbl.Text = "Shift";
            this.Form2DirectionLbl.Visible = false;
            // 
            // Form2QtyLbl
            // 
            this.Form2QtyLbl.Location = new System.Drawing.Point(218, 383);
            this.Form2QtyLbl.Name = "Form2QtyLbl";
            this.Form2QtyLbl.Size = new System.Drawing.Size(25, 17);
            this.Form2QtyLbl.TabIndex = 8;
            this.Form2QtyLbl.Text = "by";
            this.Form2QtyLbl.Visible = false;
            // 
            // Form2DirectionCmbB
            // 
            this.Form2DirectionCmbB.FormattingEnabled = true;
            this.Form2DirectionCmbB.Location = new System.Drawing.Point(77, 380);
            this.Form2DirectionCmbB.Name = "Form2DirectionCmbB";
            this.Form2DirectionCmbB.Size = new System.Drawing.Size(121, 24);
            this.Form2DirectionCmbB.TabIndex = 9;
            this.Form2DirectionCmbB.Visible = false;
            // 
            // Form2QtyCmbB
            // 
            this.Form2QtyCmbB.FormattingEnabled = true;
            this.Form2QtyCmbB.Location = new System.Drawing.Point(259, 380);
            this.Form2QtyCmbB.Name = "Form2QtyCmbB";
            this.Form2QtyCmbB.Size = new System.Drawing.Size(85, 24);
            this.Form2QtyCmbB.TabIndex = 10;
            this.Form2QtyCmbB.Visible = false;
            // 
            // Form2StateEncryptionLbl
            // 
            this.Form2StateEncryptionLbl.Location = new System.Drawing.Point(28, 92);
            this.Form2StateEncryptionLbl.Name = "Form2StateEncryptionLbl";
            this.Form2StateEncryptionLbl.Size = new System.Drawing.Size(316, 64);
            this.Form2StateEncryptionLbl.TabIndex = 11;
            this.Form2StateEncryptionLbl.Text = "Your name has been encrypted using a shift left/right Caesar cypher.Below are two" +
    " shift index values to assist with your decryption.";
            this.Form2StateEncryptionLbl.Visible = false;
            // 
            // Form2EncryptedNameLbl
            // 
            this.Form2EncryptedNameLbl.Location = new System.Drawing.Point(28, 258);
            this.Form2EncryptedNameLbl.Name = "Form2EncryptedNameLbl";
            this.Form2EncryptedNameLbl.Size = new System.Drawing.Size(316, 39);
            this.Form2EncryptedNameLbl.TabIndex = 12;
            this.Form2EncryptedNameLbl.Text = "Enter your first name in encrypted form and press enter";
            this.Form2EncryptedNameLbl.Visible = false;
            // 
            // Form2AskEncryptionTypeLbl
            // 
            this.Form2AskEncryptionTypeLbl.Location = new System.Drawing.Point(28, 344);
            this.Form2AskEncryptionTypeLbl.Name = "Form2AskEncryptionTypeLbl";
            this.Form2AskEncryptionTypeLbl.Size = new System.Drawing.Size(316, 27);
            this.Form2AskEncryptionTypeLbl.TabIndex = 13;
            this.Form2AskEncryptionTypeLbl.Text = "What type of Caesar Cypher was used?";
            this.Form2AskEncryptionTypeLbl.Visible = false;
            // 
            // Form2CaeserSubmitBtn
            // 
            this.Form2CaeserSubmitBtn.Enabled = false;
            this.Form2CaeserSubmitBtn.Location = new System.Drawing.Point(31, 425);
            this.Form2CaeserSubmitBtn.Name = "Form2CaeserSubmitBtn";
            this.Form2CaeserSubmitBtn.Size = new System.Drawing.Size(313, 23);
            this.Form2CaeserSubmitBtn.TabIndex = 14;
            this.Form2CaeserSubmitBtn.Text = "Submit";
            this.Form2CaeserSubmitBtn.UseVisualStyleBackColor = true;
            this.Form2CaeserSubmitBtn.Visible = false;
            this.Form2CaeserSubmitBtn.Click += new System.EventHandler(this.Form2CaeserSubmitBtn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 474);
            this.Controls.Add(this.Form2CaeserSubmitBtn);
            this.Controls.Add(this.Form2AskEncryptionTypeLbl);
            this.Controls.Add(this.Form2EncryptedNameLbl);
            this.Controls.Add(this.Form2StateEncryptionLbl);
            this.Controls.Add(this.Form2QtyCmbB);
            this.Controls.Add(this.Form2DirectionCmbB);
            this.Controls.Add(this.Form2QtyLbl);
            this.Controls.Add(this.Form2DirectionLbl);
            this.Controls.Add(this.Form2ExampleEncryptedLbl2);
            this.Controls.Add(this.Form2ExamplePlainLbl2);
            this.Controls.Add(this.Form2EncryptedNameTxtB);
            this.Controls.Add(this.Form2PlainNameTxtB);
            this.Controls.Add(this.Form2ExampleEncryptedLbl1);
            this.Controls.Add(this.Form2ExamplePlainLbl1);
            this.Controls.Add(this.Form2AskPlainNameLbl);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Form2AskPlainNameLbl;
        private System.Windows.Forms.Label Form2ExamplePlainLbl1;
        private System.Windows.Forms.Label Form2ExampleEncryptedLbl1;
        private System.Windows.Forms.TextBox Form2PlainNameTxtB;
        private System.Windows.Forms.TextBox Form2EncryptedNameTxtB;
        private System.Windows.Forms.Label Form2ExamplePlainLbl2;
        private System.Windows.Forms.Label Form2ExampleEncryptedLbl2;
        private System.Windows.Forms.Label Form2DirectionLbl;
        private System.Windows.Forms.Label Form2QtyLbl;
        private System.Windows.Forms.ComboBox Form2DirectionCmbB;
        private System.Windows.Forms.ComboBox Form2QtyCmbB;
        private System.Windows.Forms.Label Form2StateEncryptionLbl;
        private System.Windows.Forms.Label Form2EncryptedNameLbl;
        private System.Windows.Forms.Label Form2AskEncryptionTypeLbl;
        private System.Windows.Forms.Button Form2CaeserSubmitBtn;
    }
}