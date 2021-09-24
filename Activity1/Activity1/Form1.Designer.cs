namespace Activity1
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
            this.AdditionTerm1 = new System.Windows.Forms.TextBox();
            this.AdditionTerm2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AdditionOutput = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.Subtract = new System.Windows.Forms.Button();
            this.SubtractionTerm1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SubtractionTerm2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SubtractionOutput = new System.Windows.Forms.Label();
            this.Multiply = new System.Windows.Forms.Button();
            this.MultiplicationTerm1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.MultiplicationTerm2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.MultiplicationOutput = new System.Windows.Forms.Label();
            this.Divide = new System.Windows.Forms.Button();
            this.DivisionTerm1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DivisionTerm2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.DivisionOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AdditionTerm1
            // 
            this.AdditionTerm1.Location = new System.Drawing.Point(93, 14);
            this.AdditionTerm1.Name = "AdditionTerm1";
            this.AdditionTerm1.Size = new System.Drawing.Size(50, 20);
            this.AdditionTerm1.TabIndex = 0;
            this.AdditionTerm1.Text = "0";
            // 
            // AdditionTerm2
            // 
            this.AdditionTerm2.Location = new System.Drawing.Point(168, 14);
            this.AdditionTerm2.Name = "AdditionTerm2";
            this.AdditionTerm2.Size = new System.Drawing.Size(50, 20);
            this.AdditionTerm2.TabIndex = 1;
            this.AdditionTerm2.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "+";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "=";
            // 
            // AdditionOutput
            // 
            this.AdditionOutput.AutoSize = true;
            this.AdditionOutput.Location = new System.Drawing.Point(243, 17);
            this.AdditionOutput.Name = "AdditionOutput";
            this.AdditionOutput.Size = new System.Drawing.Size(13, 13);
            this.AdditionOutput.TabIndex = 4;
            this.AdditionOutput.Text = "0";
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(12, 12);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 5;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Subtract
            // 
            this.Subtract.Location = new System.Drawing.Point(12, 41);
            this.Subtract.Name = "Subtract";
            this.Subtract.Size = new System.Drawing.Size(75, 23);
            this.Subtract.TabIndex = 6;
            this.Subtract.Text = "Subtract";
            this.Subtract.UseVisualStyleBackColor = true;
            this.Subtract.Click += new System.EventHandler(this.Subtract_Click);
            // 
            // SubtractionTerm1
            // 
            this.SubtractionTerm1.Location = new System.Drawing.Point(93, 43);
            this.SubtractionTerm1.Name = "SubtractionTerm1";
            this.SubtractionTerm1.Size = new System.Drawing.Size(50, 20);
            this.SubtractionTerm1.TabIndex = 7;
            this.SubtractionTerm1.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(152, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "-";
            // 
            // SubtractionTerm2
            // 
            this.SubtractionTerm2.Location = new System.Drawing.Point(168, 43);
            this.SubtractionTerm2.Name = "SubtractionTerm2";
            this.SubtractionTerm2.Size = new System.Drawing.Size(50, 20);
            this.SubtractionTerm2.TabIndex = 9;
            this.SubtractionTerm2.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(224, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "=";
            // 
            // SubtractionOutput
            // 
            this.SubtractionOutput.AutoSize = true;
            this.SubtractionOutput.Location = new System.Drawing.Point(243, 46);
            this.SubtractionOutput.Name = "SubtractionOutput";
            this.SubtractionOutput.Size = new System.Drawing.Size(13, 13);
            this.SubtractionOutput.TabIndex = 11;
            this.SubtractionOutput.Text = "0";
            // 
            // Multiply
            // 
            this.Multiply.Location = new System.Drawing.Point(12, 70);
            this.Multiply.Name = "Multiply";
            this.Multiply.Size = new System.Drawing.Size(75, 23);
            this.Multiply.TabIndex = 12;
            this.Multiply.Text = "Multiply";
            this.Multiply.UseVisualStyleBackColor = true;
            this.Multiply.Click += new System.EventHandler(this.Multiply_Click);
            // 
            // MultiplicationTerm1
            // 
            this.MultiplicationTerm1.Location = new System.Drawing.Point(93, 72);
            this.MultiplicationTerm1.Name = "MultiplicationTerm1";
            this.MultiplicationTerm1.Size = new System.Drawing.Size(50, 20);
            this.MultiplicationTerm1.TabIndex = 13;
            this.MultiplicationTerm1.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(152, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "*";
            // 
            // MultiplicationTerm2
            // 
            this.MultiplicationTerm2.Location = new System.Drawing.Point(168, 72);
            this.MultiplicationTerm2.Name = "MultiplicationTerm2";
            this.MultiplicationTerm2.Size = new System.Drawing.Size(50, 20);
            this.MultiplicationTerm2.TabIndex = 15;
            this.MultiplicationTerm2.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(224, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "=";
            // 
            // MultiplicationOutput
            // 
            this.MultiplicationOutput.AutoSize = true;
            this.MultiplicationOutput.Location = new System.Drawing.Point(243, 75);
            this.MultiplicationOutput.Name = "MultiplicationOutput";
            this.MultiplicationOutput.Size = new System.Drawing.Size(13, 13);
            this.MultiplicationOutput.TabIndex = 17;
            this.MultiplicationOutput.Text = "0";
            // 
            // Divide
            // 
            this.Divide.Location = new System.Drawing.Point(12, 99);
            this.Divide.Name = "Divide";
            this.Divide.Size = new System.Drawing.Size(75, 23);
            this.Divide.TabIndex = 18;
            this.Divide.Text = "Divide";
            this.Divide.UseVisualStyleBackColor = true;
            this.Divide.Click += new System.EventHandler(this.Divide_Click);
            // 
            // DivisionTerm1
            // 
            this.DivisionTerm1.Location = new System.Drawing.Point(93, 101);
            this.DivisionTerm1.Name = "DivisionTerm1";
            this.DivisionTerm1.Size = new System.Drawing.Size(50, 20);
            this.DivisionTerm1.TabIndex = 19;
            this.DivisionTerm1.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(149, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "/";
            // 
            // DivisionTerm2
            // 
            this.DivisionTerm2.Location = new System.Drawing.Point(168, 101);
            this.DivisionTerm2.Name = "DivisionTerm2";
            this.DivisionTerm2.Size = new System.Drawing.Size(50, 20);
            this.DivisionTerm2.TabIndex = 21;
            this.DivisionTerm2.Text = "1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(224, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "=";
            // 
            // DivisionOutput
            // 
            this.DivisionOutput.AutoSize = true;
            this.DivisionOutput.Location = new System.Drawing.Point(243, 104);
            this.DivisionOutput.Name = "DivisionOutput";
            this.DivisionOutput.Size = new System.Drawing.Size(13, 13);
            this.DivisionOutput.TabIndex = 23;
            this.DivisionOutput.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 135);
            this.Controls.Add(this.DivisionOutput);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DivisionTerm2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DivisionTerm1);
            this.Controls.Add(this.Divide);
            this.Controls.Add(this.MultiplicationOutput);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.MultiplicationTerm2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.MultiplicationTerm1);
            this.Controls.Add(this.Multiply);
            this.Controls.Add(this.SubtractionOutput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SubtractionTerm2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SubtractionTerm1);
            this.Controls.Add(this.Subtract);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.AdditionOutput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AdditionTerm2);
            this.Controls.Add(this.AdditionTerm1);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AdditionTerm1;
        private System.Windows.Forms.TextBox AdditionTerm2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label AdditionOutput;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Subtract;
        private System.Windows.Forms.TextBox SubtractionTerm1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SubtractionTerm2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label SubtractionOutput;
        private System.Windows.Forms.Button Multiply;
        private System.Windows.Forms.TextBox MultiplicationTerm1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox MultiplicationTerm2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label MultiplicationOutput;
        private System.Windows.Forms.Button Divide;
        private System.Windows.Forms.TextBox DivisionTerm1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DivisionTerm2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label DivisionOutput;
    }
}

