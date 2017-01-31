using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class Form1 : Form
    {
        Double result = 0;
        String operation = "";
        bool isOperationPerformed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            if ((txtDisplay.Text == "0") || (isOperationPerformed))
            {
                txtDisplay.Clear();
            }
            isOperationPerformed = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!(txtDisplay.Text.Contains(".")))
                {
                    txtDisplay.Text = txtDisplay.Text + button.Text;
                }
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + button.Text;
            }
            
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (result != 0)
            {
                btnEquals.PerformClick();
                operation = button.Text;
                result = Double.Parse(txtDisplay.Text);
                txtLabel.Text = result + " " + operation;
                isOperationPerformed = true;
            }
            else
            {
                operation = button.Text;
                result = Double.Parse(txtDisplay.Text);
                txtLabel.Text = result + " " + operation;
                isOperationPerformed = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            result = 0;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            int length = txtDisplay.Text.Length;
            int number = txtDisplay.Text.Length - 1;
            if (length > 0)
            {
                StringBuilder back = new StringBuilder(txtDisplay.Text);
                back.Remove(number, 1);
                String store = back.ToString();
                txtDisplay.Text = store;
            }
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    txtDisplay.Text = (result + Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "-":
                    txtDisplay.Text = (result - Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "*":
                    txtDisplay.Text = (result * Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "/":
                    txtDisplay.Text = (result / Double.Parse(txtDisplay.Text)).ToString();
                    break;
                default:
                    break;
            }
            result = Double.Parse(txtDisplay.Text);
            txtLabel.Text = "";
        }
    }
}
