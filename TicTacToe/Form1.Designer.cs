﻿namespace TicTacToe
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.Font = new Font("Segoe UI Symbol", 24F, FontStyle.Bold);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(165, 104);
            button1.Name = "button1";
            button1.Size = new Size(113, 100);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonHighlight;
            button2.Font = new Font("Segoe UI Symbol", 24F, FontStyle.Bold);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(284, 104);
            button2.Name = "button2";
            button2.Size = new Size(113, 100);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ButtonHighlight;
            button3.Font = new Font("Segoe UI Symbol", 24F, FontStyle.Bold);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(403, 104);
            button3.Name = "button3";
            button3.Size = new Size(113, 100);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ButtonHighlight;
            button4.Font = new Font("Segoe UI Symbol", 24F, FontStyle.Bold);
            button4.ForeColor = Color.Black;
            button4.Location = new Point(165, 210);
            button4.Name = "button4";
            button4.Size = new Size(113, 100);
            button4.TabIndex = 5;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ButtonHighlight;
            button5.Font = new Font("Segoe UI Symbol", 24F, FontStyle.Bold);
            button5.ForeColor = Color.Black;
            button5.Location = new Point(284, 210);
            button5.Name = "button5";
            button5.Size = new Size(113, 100);
            button5.TabIndex = 4;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ButtonHighlight;
            button6.Font = new Font("Segoe UI Symbol", 24F, FontStyle.Bold);
            button6.ForeColor = Color.Black;
            button6.Location = new Point(403, 210);
            button6.Name = "button6";
            button6.Size = new Size(113, 100);
            button6.TabIndex = 3;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.ButtonHighlight;
            button7.Font = new Font("Segoe UI Symbol", 24F, FontStyle.Bold);
            button7.ForeColor = Color.Black;
            button7.Location = new Point(165, 316);
            button7.Name = "button7";
            button7.Size = new Size(113, 100);
            button7.TabIndex = 8;
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.BackColor = SystemColors.ButtonHighlight;
            button8.Font = new Font("Segoe UI Symbol", 24F, FontStyle.Bold);
            button8.ForeColor = Color.Black;
            button8.Location = new Point(284, 316);
            button8.Name = "button8";
            button8.Size = new Size(113, 100);
            button8.TabIndex = 7;
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.BackColor = SystemColors.ButtonHighlight;
            button9.Font = new Font("Segoe UI Symbol", 24F, FontStyle.Bold);
            button9.ForeColor = Color.Black;
            button9.Location = new Point(403, 316);
            button9.Name = "button9";
            button9.Size = new Size(113, 100);
            button9.TabIndex = 6;
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.BackColor = SystemColors.ControlLightLight;
            button10.Font = new Font("Segoe UI Historic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button10.ForeColor = Color.Black;
            button10.Location = new Point(39, 436);
            button10.Name = "button10";
            button10.Size = new Size(286, 52);
            button10.TabIndex = 9;
            button10.Text = "Restart Game";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ControlLightLight;
            textBox1.Font = new Font("Segoe UI Symbol", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.Black;
            textBox1.Location = new Point(362, 436);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(281, 52);
            textBox1.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlText;
            ClientSize = new Size(735, 572);
            Controls.Add(textBox1);
            Controls.Add(button10);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private TextBox textBox1;
    }
}
