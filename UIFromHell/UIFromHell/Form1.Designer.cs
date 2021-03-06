﻿/// <summary>
/// IGME-106 - Game Development and Algorithmic Problem Solving
/// Homework 1 - UI From Hell
/// Class Description   : Main class and starting form for the UI from hell
/// Author              : Benjamin Kleynhans
/// Modified By         : Benjamin Kleynhans
/// Date                : February 6, 2018
/// Filename            : Form1.Designer.cs
/// </summary>

namespace UIFromHell
{
    partial class Form1
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
            this.Form1Lbl1 = new System.Windows.Forms.Label();
            this.Form1Panel1 = new System.Windows.Forms.Panel();
            this.Form1PanelLeftEntry = new System.Windows.Forms.Panel();
            this.Form1PanelBottomEntry = new System.Windows.Forms.Panel();
            this.Form1PanelRightEntry = new System.Windows.Forms.Panel();
            this.Form1PanelTopEntry = new System.Windows.Forms.Panel();
            this.Form1BtnNext = new System.Windows.Forms.Button();
            this.Form1CmbB1 = new System.Windows.Forms.ComboBox();
            this.Form1Lbl2 = new System.Windows.Forms.Label();
            this.Form1Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Form1Lbl1
            // 
            this.Form1Lbl1.AutoSize = true;
            this.Form1Lbl1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Form1Lbl1.Location = new System.Drawing.Point(25, 23);
            this.Form1Lbl1.Name = "Form1Lbl1";
            this.Form1Lbl1.Size = new System.Drawing.Size(64, 28);
            this.Form1Lbl1.TabIndex = 6;
            this.Form1Lbl1.Text = "label1";
            // 
            // Form1Panel1
            // 
            this.Form1Panel1.Controls.Add(this.Form1PanelLeftEntry);
            this.Form1Panel1.Controls.Add(this.Form1PanelBottomEntry);
            this.Form1Panel1.Controls.Add(this.Form1PanelTopEntry);
            this.Form1Panel1.Controls.Add(this.Form1BtnNext);
            this.Form1Panel1.Controls.Add(this.Form1PanelRightEntry);
            this.Form1Panel1.Location = new System.Drawing.Point(30, 68);
            this.Form1Panel1.Name = "Form1Panel1";
            this.Form1Panel1.Size = new System.Drawing.Size(197, 86);
            this.Form1Panel1.TabIndex = 7;
            // 
            // Form1PanelLeftEntry
            // 
            this.Form1PanelLeftEntry.Location = new System.Drawing.Point(22, 26);
            this.Form1PanelLeftEntry.Name = "Form1PanelLeftEntry";
            this.Form1PanelLeftEntry.Size = new System.Drawing.Size(67, 10);
            this.Form1PanelLeftEntry.TabIndex = 7;
            this.Form1PanelLeftEntry.MouseEnter += new System.EventHandler(this.Form1PanelLeftEntry_MouseEnter);
            // 
            // Form1PanelBottomEntry
            // 
            this.Form1PanelBottomEntry.Location = new System.Drawing.Point(22, 42);
            this.Form1PanelBottomEntry.Name = "Form1PanelBottomEntry";
            this.Form1PanelBottomEntry.Size = new System.Drawing.Size(67, 10);
            this.Form1PanelBottomEntry.TabIndex = 7;
            this.Form1PanelBottomEntry.MouseEnter += new System.EventHandler(this.Form1PanelBottomEntry_MouseEnter);
            // 
            // Form1PanelRightEntry
            // 
            this.Form1PanelRightEntry.Location = new System.Drawing.Point(22, 58);
            this.Form1PanelRightEntry.Name = "Form1PanelRightEntry";
            this.Form1PanelRightEntry.Size = new System.Drawing.Size(67, 10);
            this.Form1PanelRightEntry.TabIndex = 7;
            this.Form1PanelRightEntry.MouseEnter += new System.EventHandler(this.Form1PanelRightEntry_MouseEnter);
            // 
            // Form1PanelTopEntry
            // 
            this.Form1PanelTopEntry.BackColor = System.Drawing.SystemColors.Control;
            this.Form1PanelTopEntry.Location = new System.Drawing.Point(22, 10);
            this.Form1PanelTopEntry.Name = "Form1PanelTopEntry";
            this.Form1PanelTopEntry.Size = new System.Drawing.Size(67, 10);
            this.Form1PanelTopEntry.TabIndex = 6;
            this.Form1PanelTopEntry.MouseEnter += new System.EventHandler(this.Form1PanelTopEntry_MouseEnter);
            // 
            // Form1BtnNext
            // 
            this.Form1BtnNext.Enabled = false;
            this.Form1BtnNext.Location = new System.Drawing.Point(117, 10);
            this.Form1BtnNext.Margin = new System.Windows.Forms.Padding(0);
            this.Form1BtnNext.Name = "Form1BtnNext";
            this.Form1BtnNext.Size = new System.Drawing.Size(68, 29);
            this.Form1BtnNext.TabIndex = 5;
            this.Form1BtnNext.UseVisualStyleBackColor = true;
            this.Form1BtnNext.Click += new System.EventHandler(this.Form1BtnNext_Click);
            // 
            // Form1CmbB1
            // 
            this.Form1CmbB1.Enabled = false;
            this.Form1CmbB1.FormattingEnabled = true;
            this.Form1CmbB1.Location = new System.Drawing.Point(123, 186);
            this.Form1CmbB1.Name = "Form1CmbB1";
            this.Form1CmbB1.Size = new System.Drawing.Size(121, 24);
            this.Form1CmbB1.TabIndex = 8;
            this.Form1CmbB1.Visible = false;
            this.Form1CmbB1.SelectedIndexChanged += new System.EventHandler(this.Form1CmbB1_SelectedIndexChanged);
            // 
            // Form1Lbl2
            // 
            this.Form1Lbl2.AutoSize = true;
            this.Form1Lbl2.Enabled = false;
            this.Form1Lbl2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Form1Lbl2.Location = new System.Drawing.Point(27, 186);
            this.Form1Lbl2.Name = "Form1Lbl2";
            this.Form1Lbl2.Size = new System.Drawing.Size(67, 28);
            this.Form1Lbl2.TabIndex = 9;
            this.Form1Lbl2.Text = "label2";
            this.Form1Lbl2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 263);
            this.Controls.Add(this.Form1Panel1);
            this.Controls.Add(this.Form1Lbl1);
            this.Controls.Add(this.Form1Lbl2);
            this.Controls.Add(this.Form1CmbB1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Form1Panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Form1Lbl1;
        private System.Windows.Forms.Panel Form1Panel1;
        private System.Windows.Forms.Button Form1BtnNext;
        private System.Windows.Forms.Panel Form1PanelLeftEntry;
        private System.Windows.Forms.Panel Form1PanelBottomEntry;
        private System.Windows.Forms.Panel Form1PanelRightEntry;
        private System.Windows.Forms.Panel Form1PanelTopEntry;
        private System.Windows.Forms.ComboBox Form1CmbB1;
        private System.Windows.Forms.Label Form1Lbl2;
    }
}

