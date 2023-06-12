namespace MyCalculator_Project
{
    public partial class Form1 : Form
    {

        private double firstNumber;
        private String sign;
        public Form1()
        {
            InitializeComponent();
            display.Text = "0";
        }

        private void replaceZero()
        {
            if (display.Text.Equals("0"))
            {
                display.Clear();
            }
        }
        private void zero_Click(object sender, EventArgs e)
        {

            if (!display.Text.Equals("0"))
            {
                display.Text += "0";
            }
        }

        private void one_Click(object sender, EventArgs e)
        {
            replaceZero();
            display.Text += "1";
        }

        private void two_Click(object sender, EventArgs e)
        {
            replaceZero();
            display.Text += "2";
        }

        private void three_Click(object sender, EventArgs e)
        {
            replaceZero();
            display.Text += "3";
        }

        private void four_Click(object sender, EventArgs e)
        {
            replaceZero();
            display.Text += "4";
        }

        private void five_Click(object sender, EventArgs e)
        {
            replaceZero();
            display.Text += "5";
        }

        private void six_Click(object sender, EventArgs e)
        {
            replaceZero();
            display.Text += "6";
        }

        private void seven_Click(object sender, EventArgs e)
        {
            replaceZero();
            display.Text += "7";
        }

        private void eight_Click(object sender, EventArgs e)
        {
            replaceZero();
            display.Text += "8";
        }

        private void nine_Click(object sender, EventArgs e)
        {
            replaceZero();
            display.Text += "9";
        }
        private void plus_Click(object sender, EventArgs e)
        {
            firstNumber = double.Parse(display.Text);
            display.Clear();
            sign = "+";
        }

        private void minus_Click(object sender, EventArgs e)
        {
            firstNumber = double.Parse(display.Text);
            display.Clear();
            sign = "-";
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            firstNumber = double.Parse(display.Text);
            display.Clear();
            sign = "x";
        }

        private void divide_Click(object sender, EventArgs e)
        {
            firstNumber = double.Parse(display.Text);
            display.Clear();
            sign = "/";
        }

        private void clear_Click(object sender, EventArgs e)
        {
            display.Clear();
            display.Text = "0";
        }

        private void dot_Click(object sender, EventArgs e)
        {
            if (!display.Text.Contains("."))
            {
                display.Text += ".";
            }
        }

        private void equal_Click(object sender, EventArgs e)
        {
            double secondNumber = double.Parse(display.Text);
            display.Clear();
            double result = 0;
            switch (sign)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "x":
                    result = firstNumber * secondNumber;
                    break;
                case "/":
                    result = firstNumber / secondNumber;
                    break;
            }
            display.Text = result.ToString();
        }

        private void display_TextChanged(object sender, EventArgs e)
        {

        }

        private void negative_positive_Click(object sender, EventArgs e)
        {
            if (!display.Text.Equals("0"))
            {

                display.Text = (double.Parse(display.Text) * -1).ToString();
            }
        }

        private void backspace_Click(object sender, EventArgs e)
        {   
            display.Text = display.Text.Remove(display.Text.Length - 1);
        }
    }
}