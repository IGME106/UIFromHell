/// <summary>
/// IGME-106 - Game Development and Algorithmic Problem Solving
/// Homework 1 - UI From Hell
/// Class Description   : Third class and third form for the UI from hell
/// Author              : Benjamin Kleynhans
/// Modified By         : Benjamin Kleynhans
/// Date                : February 6, 2018
/// Filename            : Form3.Designer.cs
/// </summary>

namespace UIFromHell
{
    partial class Form3
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
            this.Form3Label1 = new System.Windows.Forms.Label();
            this.Form3SubmitBtn1 = new System.Windows.Forms.Button();
            this.Form3GroupBox1 = new System.Windows.Forms.GroupBox();
            this.RadioButton1 = new System.Windows.Forms.RadioButton();
            this.Form3Question1RadioBtn2 = new System.Windows.Forms.RadioButton();
            this.Form3Question1RadioBtn1 = new System.Windows.Forms.RadioButton();
            this.Form3GroupBox2 = new System.Windows.Forms.GroupBox();
            this.RadioButton2 = new System.Windows.Forms.RadioButton();
            this.Form3Question2RadioBtn2 = new System.Windows.Forms.RadioButton();
            this.Form3Question2RadioBtn1 = new System.Windows.Forms.RadioButton();
            this.Form3Question1RadioBtn3 = new System.Windows.Forms.RadioButton();
            this.Form3GroupBox1.SuspendLayout();
            this.Form3GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Form3Label1
            // 
            this.Form3Label1.Location = new System.Drawing.Point(23, 22);
            this.Form3Label1.Name = "Form3Label1";
            this.Form3Label1.Size = new System.Drawing.Size(247, 41);
            this.Form3Label1.TabIndex = 1;
            // 
            // Form3SubmitBtn1
            // 
            this.Form3SubmitBtn1.Enabled = false;
            this.Form3SubmitBtn1.Location = new System.Drawing.Point(26, 344);
            this.Form3SubmitBtn1.Name = "Form3SubmitBtn1";
            this.Form3SubmitBtn1.Size = new System.Drawing.Size(244, 23);
            this.Form3SubmitBtn1.TabIndex = 6;
            this.Form3SubmitBtn1.Text = "Submit";
            this.Form3SubmitBtn1.UseVisualStyleBackColor = true;
            this.Form3SubmitBtn1.Click += new System.EventHandler(this.Form3SubmitBtn1_Click);
            // 
            // Form3GroupBox1
            // 
            this.Form3GroupBox1.Controls.Add(this.Form3Question1RadioBtn3);
            this.Form3GroupBox1.Controls.Add(this.RadioButton1);
            this.Form3GroupBox1.Controls.Add(this.Form3Question1RadioBtn2);
            this.Form3GroupBox1.Controls.Add(this.Form3Question1RadioBtn1);
            this.Form3GroupBox1.Location = new System.Drawing.Point(26, 22);
            this.Form3GroupBox1.Name = "Form3GroupBox1";
            this.Form3GroupBox1.Size = new System.Drawing.Size(244, 184);
            this.Form3GroupBox1.TabIndex = 7;
            this.Form3GroupBox1.TabStop = false;
            this.Form3GroupBox1.Text = "Does a pound of gold or a pound of feathers weigh more?";
            // 
            // radioButton1
            // 
            this.RadioButton1.AutoSize = true;
            this.RadioButton1.Checked = true;
            this.RadioButton1.Location = new System.Drawing.Point(32, 58);
            this.RadioButton1.Name = "radioButton1";
            this.RadioButton1.Size = new System.Drawing.Size(122, 21);
            this.RadioButton1.TabIndex = 5;
            this.RadioButton1.TabStop = true;
            this.RadioButton1.Text = "None Selected";
            this.RadioButton1.UseVisualStyleBackColor = true;
            this.RadioButton1.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // Form3Question1RadioBtn2
            // 
            this.Form3Question1RadioBtn2.AutoSize = true;
            this.Form3Question1RadioBtn2.Location = new System.Drawing.Point(32, 112);
            this.Form3Question1RadioBtn2.Name = "Form3Question1RadioBtn2";
            this.Form3Question1RadioBtn2.Size = new System.Drawing.Size(85, 21);
            this.Form3Question1RadioBtn2.TabIndex = 4;
            this.Form3Question1RadioBtn2.Text = "Feathers";
            this.Form3Question1RadioBtn2.UseVisualStyleBackColor = true;
            // 
            // Form3Question1RadioBtn1
            // 
            this.Form3Question1RadioBtn1.AutoSize = true;
            this.Form3Question1RadioBtn1.Location = new System.Drawing.Point(32, 85);
            this.Form3Question1RadioBtn1.Name = "Form3Question1RadioBtn1";
            this.Form3Question1RadioBtn1.Size = new System.Drawing.Size(59, 21);
            this.Form3Question1RadioBtn1.TabIndex = 3;
            this.Form3Question1RadioBtn1.Text = "Gold";
            this.Form3Question1RadioBtn1.UseVisualStyleBackColor = true;
            // 
            // Form3GroupBox2
            // 
            this.Form3GroupBox2.Controls.Add(this.RadioButton2);
            this.Form3GroupBox2.Controls.Add(this.Form3Question2RadioBtn2);
            this.Form3GroupBox2.Controls.Add(this.Form3Question2RadioBtn1);
            this.Form3GroupBox2.Enabled = false;
            this.Form3GroupBox2.Location = new System.Drawing.Point(26, 212);
            this.Form3GroupBox2.Name = "Form3GroupBox2";
            this.Form3GroupBox2.Size = new System.Drawing.Size(244, 116);
            this.Form3GroupBox2.TabIndex = 8;
            this.Form3GroupBox2.TabStop = false;
            this.Form3GroupBox2.Text = "Are you sure?";
            // 
            // RadioButton2
            // 
            this.RadioButton2.AutoSize = true;
            this.RadioButton2.Checked = true;
            this.RadioButton2.Location = new System.Drawing.Point(32, 29);
            this.RadioButton2.Name = "RadioButton2";
            this.RadioButton2.Size = new System.Drawing.Size(122, 21);
            this.RadioButton2.TabIndex = 8;
            this.RadioButton2.TabStop = true;
            this.RadioButton2.Text = "None Selected";
            this.RadioButton2.UseVisualStyleBackColor = true;
            this.RadioButton2.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged);
            // 
            // Form3Question2RadioBtn2
            // 
            this.Form3Question2RadioBtn2.AutoSize = true;
            this.Form3Question2RadioBtn2.Location = new System.Drawing.Point(32, 83);
            this.Form3Question2RadioBtn2.Name = "Form3Question2RadioBtn2";
            this.Form3Question2RadioBtn2.Size = new System.Drawing.Size(47, 21);
            this.Form3Question2RadioBtn2.TabIndex = 7;
            this.Form3Question2RadioBtn2.Text = "No";
            this.Form3Question2RadioBtn2.UseVisualStyleBackColor = true;
            // 
            // Form3Question2RadioBtn1
            // 
            this.Form3Question2RadioBtn1.AutoSize = true;
            this.Form3Question2RadioBtn1.Location = new System.Drawing.Point(32, 56);
            this.Form3Question2RadioBtn1.Name = "Form3Question2RadioBtn1";
            this.Form3Question2RadioBtn1.Size = new System.Drawing.Size(53, 21);
            this.Form3Question2RadioBtn1.TabIndex = 6;
            this.Form3Question2RadioBtn1.Text = "Yes";
            this.Form3Question2RadioBtn1.UseVisualStyleBackColor = true;
            // 
            // Form3Question1RadioBtn3
            // 
            this.Form3Question1RadioBtn3.AutoSize = true;
            this.Form3Question1RadioBtn3.Location = new System.Drawing.Point(32, 140);
            this.Form3Question1RadioBtn3.Name = "Form3Question1RadioBtn3";
            this.Form3Question1RadioBtn3.Size = new System.Drawing.Size(156, 21);
            this.Form3Question1RadioBtn3.TabIndex = 6;
            this.Form3Question1RadioBtn3.TabStop = true;
            this.Form3Question1RadioBtn3.Text = "The weigh the same";
            this.Form3Question1RadioBtn3.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 386);
            this.Controls.Add(this.Form3GroupBox2);
            this.Controls.Add(this.Form3GroupBox1);
            this.Controls.Add(this.Form3SubmitBtn1);
            this.Controls.Add(this.Form3Label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Form3GroupBox1.ResumeLayout(false);
            this.Form3GroupBox1.PerformLayout();
            this.Form3GroupBox2.ResumeLayout(false);
            this.Form3GroupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label Form3Label1;
        private System.Windows.Forms.Button Form3SubmitBtn1;
        private System.Windows.Forms.GroupBox Form3GroupBox1;
        private System.Windows.Forms.RadioButton Form3Question1RadioBtn2;
        private System.Windows.Forms.RadioButton Form3Question1RadioBtn1;
        private System.Windows.Forms.GroupBox Form3GroupBox2;
        private System.Windows.Forms.RadioButton Form3Question2RadioBtn2;
        private System.Windows.Forms.RadioButton Form3Question2RadioBtn1;
        private System.Windows.Forms.RadioButton RadioButton1;
        private System.Windows.Forms.RadioButton RadioButton2;
        private System.Windows.Forms.RadioButton Form3Question1RadioBtn3;
    }
}