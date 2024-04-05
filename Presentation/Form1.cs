namespace Presentation
{
    public partial class Form1 : Form
    {

        decimal num1;
        decimal num2;
        string option;
        decimal res;



        public Form1()
        {
            InitializeComponent();
        }

        #region Click Event
        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtCalculate.Text == "0")
            {
                txtCalculate.Clear();
                txtCalculate.Text += "0";
            }
            else { txtCalculate.Text += "0"; }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtCalculate.Text == "0")
            {
                txtCalculate.Clear();
                txtCalculate.Text += "1";
            }
            else { txtCalculate.Text += "1"; }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtCalculate.Text == "0")
            {
                txtCalculate.Clear();
                txtCalculate.Text += "2";
            }
            else { txtCalculate.Text += "2"; }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtCalculate.Text == "0")
            {
                txtCalculate.Clear();
                txtCalculate.Text += "3";
            }
            else { txtCalculate.Text += "3"; }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtCalculate.Text == "0")
            {
                txtCalculate.Clear();
                txtCalculate.Text += "4";
            }
            else { txtCalculate.Text += "4"; }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtCalculate.Text == "0")
            {
                txtCalculate.Clear();
                txtCalculate.Text += "5";
            }
            else { txtCalculate.Text += "5"; }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtCalculate.Text == "0")
            {
                txtCalculate.Clear();
                txtCalculate.Text += "6";
            }
            else { txtCalculate.Text += "6"; }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtCalculate.Text == "0")
            {
                txtCalculate.Clear();
                txtCalculate.Text += "7";
            }
            else { txtCalculate.Text += "7"; }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtCalculate.Text == "0")
            {
                txtCalculate.Clear();
                txtCalculate.Text += "8";
            }
            else { txtCalculate.Text += "8"; }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtCalculate.Text == "0")
            {
                txtCalculate.Clear();
                txtCalculate.Text += "9";
            }
            else { txtCalculate.Text += "9"; }
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            try
            {
                option = "+";
                num1 = decimal.Parse(txtCalculate.Text);
                txtCalculate.Clear();
            }
            catch (OverflowException)
            {
                MessageBox.Show("The value is either too small or too large.");
            }
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            try
            {
                option = "-";
                num1 = decimal.Parse(txtCalculate.Text);
                txtCalculate.Clear();
            }
            catch (OverflowException)
            {
                MessageBox.Show("The value is either too small or too large.");
            }
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            try
            {
                option = "*";
                num1 = decimal.Parse(txtCalculate.Text);
                txtCalculate.Clear();
            }
            catch (OverflowException)
            {
                MessageBox.Show("The value is either too small or too large.");
            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            try
            {
                option = "/";
                num1 = decimal.Parse(txtCalculate.Text);
                txtCalculate.Clear();
            }
            catch (OverflowException)
            {
                MessageBox.Show("The value is either too small or too large.");
            }

        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            try
            {
                num2 = decimal.Parse(txtCalculate.Text);
                switch (option)
                {
                    case "+":
                        res = num1 + num2;
                        break;
                    case "-":
                        res = num1 - num2;
                        break;
                    case "*":
                        res = num1 * num2;
                        break;
                    case "/":
                        res = num1 / num2;
                        break;
                }
                txtCalculate.Text = res.ToString();
            }
            catch (OverflowException)
            {
                MessageBox.Show("The value is either too small or too large.");
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtCalculate.Text = "0";
            res = 0;
            num1 = 0;
            num2 = 0;
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (txtCalculate.Text.Contains(".") == false)
            {
                txtCalculate.Text += ".";
            }
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtCalculate.Text = "0";
        }

        private void btnCorrection_Click(object sender, EventArgs e)
        {
            if (txtCalculate.Text.Length > 1)
            {
                txtCalculate.Text = txtCalculate.Text.Remove(txtCalculate.Text.Length - 1, 1);
            }
            else
            {
                txtCalculate.Text = "0";
            }
        }
        #endregion

        #region KeyDown Event
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    Close();
                    // Numbers:
                    break;
                case Keys.D0 or Keys.NumPad0:
                    if (txtCalculate.Text == "0")
                    {
                        txtCalculate.Clear();
                        txtCalculate.Text += "0";
                    }
                    else { txtCalculate.Text += "0"; }
                    break;
                case Keys.D1 or Keys.NumPad1:
                    if (txtCalculate.Text == "0")
                    {
                        txtCalculate.Clear();
                        txtCalculate.Text += "1";
                    }
                    else { txtCalculate.Text += "1"; }
                    break;
                case Keys.D2 or Keys.NumPad2:
                    if (txtCalculate.Text == "0")
                    {
                        txtCalculate.Clear();
                        txtCalculate.Text += "2";
                    }
                    else { txtCalculate.Text += "2"; }
                    break;
                case Keys.D3 or Keys.NumPad3:
                    if (txtCalculate.Text == "0")
                    {
                        txtCalculate.Clear();
                        txtCalculate.Text += "3";
                    }
                    else { txtCalculate.Text += "3"; }
                    break;
                case Keys.D4 or Keys.NumPad4:
                    if (txtCalculate.Text == "0")
                    {
                        txtCalculate.Clear();
                        txtCalculate.Text += "4";
                    }
                    else { txtCalculate.Text += "4"; }
                    break;
                case Keys.D5 or Keys.NumPad5:
                    if (txtCalculate.Text == "0")
                    {
                        txtCalculate.Clear();
                        txtCalculate.Text += "5";
                    }
                    else { txtCalculate.Text += "5"; }
                    break;
                case Keys.D6 or Keys.NumPad6:
                    if (txtCalculate.Text == "0")
                    {
                        txtCalculate.Clear();
                        txtCalculate.Text += "6";
                    }
                    else { txtCalculate.Text += "6"; }
                    break;
                case Keys.D7 or Keys.NumPad7:
                    if (txtCalculate.Text == "0")
                    {
                        txtCalculate.Clear();
                        txtCalculate.Text += "7";
                    }
                    else { txtCalculate.Text += "7"; }
                    break;
                case Keys.D8 or Keys.NumPad8:
                    if (txtCalculate.Text == "0")
                    {
                        txtCalculate.Clear();
                        txtCalculate.Text += "8";
                    }
                    else { txtCalculate.Text += "8"; }
                    break;
                case Keys.D9 or Keys.NumPad9:
                    if (txtCalculate.Text == "0")
                    {
                        txtCalculate.Clear();
                        txtCalculate.Text += "9";
                    }
                    else { txtCalculate.Text += "9"; }
                    break;
                case Keys.Decimal:
                    if (txtCalculate.Text.Contains(".") == false)
                    {
                        txtCalculate.Text += ".";
                    }
                    break;
                // Actions:
                case Keys.Add:
                    try
                    {
                        option = "+";
                        num1 = decimal.Parse(txtCalculate.Text);
                        txtCalculate.Clear();
                    }
                    catch (OverflowException)
                    {
                        MessageBox.Show("The value is either too small or too large.");
                    }
                    break;
                case Keys.Subtract:
                    try
                    {
                        option = "-";
                        num1 = decimal.Parse(txtCalculate.Text);
                        txtCalculate.Clear();
                    }
                    catch (OverflowException)
                    {
                        MessageBox.Show("The value is either too small or too large.");
                    }
                    break;
                case Keys.Multiply:
                    try
                    {
                        option = "*";
                        num1 = decimal.Parse(txtCalculate.Text);
                        txtCalculate.Clear();
                    }
                    catch (OverflowException)
                    {
                        MessageBox.Show("The value is either too small or too large.");
                    }
                    break;
                case Keys.Divide:
                    try
                    {
                        option = "/";
                        num1 = decimal.Parse(txtCalculate.Text);
                        txtCalculate.Clear();
                    }
                    catch (OverflowException)
                    {
                        MessageBox.Show("The value is either too small or too large.");
                    }
                    break;
                case Keys.Enter:
                    try
                    {
                        num2 = decimal.Parse(txtCalculate.Text);
                        switch (option)
                        {
                            case "+":
                                res = num1 + num2;
                                break;
                            case "-":
                                res = num1 - num2;
                                break;
                            case "*":
                                res = num1 * num2;
                                break;
                            case "/":
                                res = num1 / num2;
                                break;
                        }
                        txtCalculate.Text = res.ToString();
                    }
                    catch (OverflowException)
                    {
                        MessageBox.Show("The value is either too small or too large.");
                    }
                    break;
                case Keys.Back:
                    if (txtCalculate.Text.Length > 1)
                    {
                        txtCalculate.Text = txtCalculate.Text.Remove(txtCalculate.Text.Length - 1, 1);
                    }
                    else
                    {
                        txtCalculate.Text = "0";
                    }
                    break;
                case Keys.Delete:
                    txtCalculate.Text = "0";
                    break;
            }
        }
        #endregion
    }
}
