namespace MyCalculator_Project
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            negative_positive = new Button();
            one = new Button();
            four = new Button();
            seven = new Button();
            button5 = new Button();
            backspace = new Button();
            eight = new Button();
            five = new Button();
            two = new Button();
            zero = new Button();
            clear = new Button();
            nine = new Button();
            six = new Button();
            three = new Button();
            dot = new Button();
            divide = new Button();
            multiply = new Button();
            minus = new Button();
            plus = new Button();
            equal = new Button();
            display = new TextBox();
            SuspendLayout();
            // 
            // negative_positive
            // 
            negative_positive.BackColor = Color.LemonChiffon;
            negative_positive.Font = new Font("Comic Sans MS", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            negative_positive.Location = new Point(12, 476);
            negative_positive.Name = "negative_positive";
            negative_positive.Size = new Size(110, 80);
            negative_positive.TabIndex = 0;
            negative_positive.Text = "+/-";
            negative_positive.UseVisualStyleBackColor = false;
            negative_positive.Click += negative_positive_Click;
            // 
            // one
            // 
            one.BackColor = Color.LemonChiffon;
            one.Font = new Font("Comic Sans MS", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            one.Location = new Point(12, 390);
            one.Name = "one";
            one.Size = new Size(110, 80);
            one.TabIndex = 1;
            one.Text = "1";
            one.UseVisualStyleBackColor = false;
            one.Click += one_Click;
            // 
            // four
            // 
            four.BackColor = Color.LemonChiffon;
            four.Font = new Font("Comic Sans MS", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            four.Location = new Point(12, 304);
            four.Name = "four";
            four.Size = new Size(110, 80);
            four.TabIndex = 2;
            four.Text = "4";
            four.UseVisualStyleBackColor = false;
            four.Click += four_Click;
            // 
            // seven
            // 
            seven.BackColor = Color.LemonChiffon;
            seven.Font = new Font("Comic Sans MS", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            seven.Location = new Point(12, 218);
            seven.Name = "seven";
            seven.Size = new Size(110, 80);
            seven.TabIndex = 3;
            seven.Text = "7";
            seven.UseVisualStyleBackColor = false;
            seven.Click += seven_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.LemonChiffon;
            button5.Font = new Font("Comic Sans MS", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(12, 132);
            button5.Name = "button5";
            button5.Size = new Size(110, 80);
            button5.TabIndex = 4;
            button5.Text = "?";
            button5.UseVisualStyleBackColor = false;
            // 
            // backspace
            // 
            backspace.BackColor = Color.LemonChiffon;
            backspace.Font = new Font("Comic Sans MS", 24F, FontStyle.Bold, GraphicsUnit.Point);
            backspace.Location = new Point(244, 132);
            backspace.Name = "backspace";
            backspace.Size = new Size(110, 80);
            backspace.TabIndex = 9;
            backspace.Text = "Back";
            backspace.UseVisualStyleBackColor = false;
            backspace.Click += backspace_Click;
            // 
            // eight
            // 
            eight.BackColor = Color.LemonChiffon;
            eight.Font = new Font("Comic Sans MS", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            eight.Location = new Point(128, 218);
            eight.Name = "eight";
            eight.Size = new Size(110, 80);
            eight.TabIndex = 8;
            eight.Text = "8";
            eight.UseVisualStyleBackColor = false;
            eight.Click += eight_Click;
            // 
            // five
            // 
            five.BackColor = Color.LemonChiffon;
            five.Font = new Font("Comic Sans MS", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            five.Location = new Point(128, 304);
            five.Name = "five";
            five.Size = new Size(110, 80);
            five.TabIndex = 7;
            five.Text = "5";
            five.UseVisualStyleBackColor = false;
            five.Click += five_Click;
            // 
            // two
            // 
            two.BackColor = Color.LemonChiffon;
            two.Font = new Font("Comic Sans MS", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            two.Location = new Point(128, 390);
            two.Name = "two";
            two.Size = new Size(110, 80);
            two.TabIndex = 6;
            two.Text = "2";
            two.UseVisualStyleBackColor = false;
            two.Click += two_Click;
            // 
            // zero
            // 
            zero.BackColor = Color.LemonChiffon;
            zero.Font = new Font("Comic Sans MS", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            zero.Location = new Point(128, 476);
            zero.Name = "zero";
            zero.Size = new Size(110, 80);
            zero.TabIndex = 5;
            zero.Text = "0";
            zero.UseVisualStyleBackColor = false;
            zero.Click += zero_Click;
            // 
            // clear
            // 
            clear.BackColor = Color.LemonChiffon;
            clear.Font = new Font("Comic Sans MS", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            clear.Location = new Point(128, 132);
            clear.Name = "clear";
            clear.Size = new Size(110, 80);
            clear.TabIndex = 14;
            clear.Text = "C";
            clear.UseVisualStyleBackColor = false;
            clear.Click += clear_Click;
            // 
            // nine
            // 
            nine.BackColor = Color.LemonChiffon;
            nine.Font = new Font("Comic Sans MS", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            nine.Location = new Point(244, 218);
            nine.Name = "nine";
            nine.Size = new Size(110, 80);
            nine.TabIndex = 13;
            nine.Text = "9";
            nine.UseVisualStyleBackColor = false;
            nine.Click += nine_Click;
            // 
            // six
            // 
            six.BackColor = Color.LemonChiffon;
            six.Font = new Font("Comic Sans MS", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            six.Location = new Point(244, 304);
            six.Name = "six";
            six.Size = new Size(110, 80);
            six.TabIndex = 12;
            six.Text = "6";
            six.UseVisualStyleBackColor = false;
            six.Click += six_Click;
            // 
            // three
            // 
            three.BackColor = Color.LemonChiffon;
            three.Font = new Font("Comic Sans MS", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            three.Location = new Point(244, 390);
            three.Name = "three";
            three.Size = new Size(110, 80);
            three.TabIndex = 11;
            three.Text = "3";
            three.UseVisualStyleBackColor = false;
            three.Click += three_Click;
            // 
            // dot
            // 
            dot.BackColor = Color.LemonChiffon;
            dot.Font = new Font("Comic Sans MS", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            dot.Location = new Point(244, 476);
            dot.Name = "dot";
            dot.Size = new Size(110, 80);
            dot.TabIndex = 10;
            dot.Text = ".";
            dot.UseVisualStyleBackColor = false;
            dot.Click += dot_Click;
            // 
            // divide
            // 
            divide.BackColor = Color.LemonChiffon;
            divide.Font = new Font("Comic Sans MS", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            divide.Location = new Point(360, 132);
            divide.Name = "divide";
            divide.Size = new Size(110, 80);
            divide.TabIndex = 19;
            divide.Text = "÷";
            divide.UseVisualStyleBackColor = false;
            divide.Click += divide_Click;
            // 
            // multiply
            // 
            multiply.BackColor = Color.LemonChiffon;
            multiply.Font = new Font("Comic Sans MS", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            multiply.Location = new Point(360, 218);
            multiply.Name = "multiply";
            multiply.Size = new Size(110, 80);
            multiply.TabIndex = 18;
            multiply.Text = "x";
            multiply.UseVisualStyleBackColor = false;
            multiply.Click += multiply_Click;
            // 
            // minus
            // 
            minus.BackColor = Color.LemonChiffon;
            minus.Font = new Font("Comic Sans MS", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            minus.Location = new Point(360, 304);
            minus.Name = "minus";
            minus.Size = new Size(110, 80);
            minus.TabIndex = 17;
            minus.Text = "-";
            minus.UseVisualStyleBackColor = false;
            minus.Click += minus_Click;
            // 
            // plus
            // 
            plus.BackColor = Color.LemonChiffon;
            plus.Font = new Font("Comic Sans MS", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            plus.Location = new Point(360, 390);
            plus.Name = "plus";
            plus.Size = new Size(110, 80);
            plus.TabIndex = 16;
            plus.Text = "+";
            plus.UseVisualStyleBackColor = false;
            plus.Click += plus_Click;
            // 
            // equal
            // 
            equal.BackColor = Color.LemonChiffon;
            equal.Font = new Font("Comic Sans MS", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            equal.Location = new Point(360, 476);
            equal.Name = "equal";
            equal.Size = new Size(110, 80);
            equal.TabIndex = 15;
            equal.Text = "=";
            equal.UseVisualStyleBackColor = false;
            equal.Click += equal_Click;
            // 
            // display
            // 
            display.BackColor = Color.LightSteelBlue;
            display.Font = new Font("Cascadia Code", 36F, FontStyle.Regular, GraphicsUnit.Point);
            display.ForeColor = SystemColors.WindowText;
            display.Location = new Point(12, 43);
            display.Name = "display";
            display.Size = new Size(458, 63);
            display.TabIndex = 20;
            display.TextAlign = HorizontalAlignment.Right;
            display.TextChanged += display_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(486, 568);
            Controls.Add(display);
            Controls.Add(divide);
            Controls.Add(multiply);
            Controls.Add(minus);
            Controls.Add(plus);
            Controls.Add(equal);
            Controls.Add(clear);
            Controls.Add(nine);
            Controls.Add(six);
            Controls.Add(three);
            Controls.Add(dot);
            Controls.Add(backspace);
            Controls.Add(eight);
            Controls.Add(five);
            Controls.Add(two);
            Controls.Add(zero);
            Controls.Add(button5);
            Controls.Add(seven);
            Controls.Add(four);
            Controls.Add(one);
            Controls.Add(negative_positive);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button negative_positive;
        private Button one;
        private Button four;
        private Button seven;
        private Button button5;
        private Button backspace;
        private Button eight;
        private Button five;
        private Button two;
        private Button zero;
        private Button clear;
        private Button nine;
        private Button six;
        private Button three;
        private Button dot;
        private Button divide;
        private Button multiply;
        private Button minus;
        private Button plus;
        private Button equal;
        private TextBox display;
    }
}