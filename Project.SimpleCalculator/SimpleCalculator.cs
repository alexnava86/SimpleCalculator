using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class SimpleCalculatorForm : Form
    {
        decimal op1;
        decimal op2;
        public SimpleCalculatorForm()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            if (IsDecimal(Operand1Textbox, Operand1Textbox.Text) && IsDecimal(Operand2Textbox, Operand2Textbox.Text) && IsOperator(OperatorTextbox, OperatorTextbox.Text[0]))
            {
                try
                {
                    op1 = Convert.ToDecimal(Operand1Textbox.Text);
                    op2 = Convert.ToDecimal(Operand2Textbox.Text);
                    char op = OperatorTextbox.Text[0];
                    IsValidData();
                    ResultTextbox.Text = Math.Round(Calculate(op1, op2), 4).ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\n\n" + ex.GetType().ToString() + "\n" + ex.StackTrace, "Exception");
                    ResultTextbox.Focus();
                }
            }  
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private decimal Calculate(decimal a, decimal b)
        {
            char op = OperatorTextbox.Text[0];
            decimal result = 0;

            switch (op)
            {
                case '+':
                    result = a + b;
                    break;

                case '-':
                    result = a - b;
                    break;

                case '*':
                    result = a * b;
                    break;

                case '/':
                    result = a / b;
                    break;
            }
            return result;
        }

        private void Operand1Textbox_TextChanged(object sender, EventArgs e)
        {
            ResultTextbox.Text = string.Empty;
        }

        private void OperatorTextbox_TextChanged(object sender, EventArgs e)
        {
            ResultTextbox.Text = string.Empty;
        }

        private void Operand2Textbox_TextChanged(object sender, EventArgs e)
        {
            ResultTextbox.Text = string.Empty;
        }

        private bool IsPresent(TextBox tb, string name)
        {
            if (Operand1Textbox.Text == "")
            {
                MessageBox.Show(name + " is a required field.", "Entry Error");
                tb.Focus();
            }    
            return false;
        }

        private bool IsDecimal(TextBox tb, string name)
        {
            decimal num = 0m;
            if (Decimal.TryParse(tb.Text, out num))
                return true;
            else
            {
                MessageBox.Show(name + " must be decimal value.", "Entry Error");
                tb.Focus();
                return false;
            }
        }

        private bool IsWithinRange(TextBox tb, string name, decimal min, decimal max)
        {
            decimal num = Convert.ToDecimal(tb.Text);
            if (num < min || num > max)
            {
                MessageBox.Show(name + " must be between " + min.ToString() + " and " + max.ToString() + ".", "Entry Error");
                tb.Focus();
                return false;
            }
            else
                return true;
        }

        private bool IsOperator(TextBox tb, char name)
        {
            name = tb.Text[0];
            if (tb.Text.Length == 1)
            {
                switch (name)
                {
                    case '+':
                        return true;
                    case '-':
                        return true;
                    case '*':
                        return true;
                    case '/':
                        return true;
                }
            }
            MessageBox.Show(tb.Text + " must be single digit operator value.", "Entry Error");
            tb.Focus();
            return false;
        }

        private bool IsValidData()
        {
            if (IsPresent(Operand1Textbox, Operand1Textbox.Text) && IsDecimal(Operand1Textbox, Operand1Textbox.Text) && IsWithinRange(Operand1Textbox, Operand1Textbox.Text, 0m, 1000000m))
                return true;
            if (IsPresent(Operand2Textbox, Operand2Textbox.Text) && IsDecimal(Operand2Textbox, Operand2Textbox.Text) && IsWithinRange(Operand2Textbox, Operand2Textbox.Text, 0m, 1000000m))
                return true;
            if (IsOperator(OperatorTextbox, OperatorTextbox.Text[0]))
                return true;
            else
                return false;
        }
    }
}
