using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using binary_calculation;

namespace Binary_Calculator_v2
{
    public partial class binOperation : Form
    {
        calculation calculation = new calculation();
        public binOperation()
        {
            InitializeComponent();
        }

        private void buttonHome2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            operationTextBox.Text += "1";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            operationTextBox.Text += "0";
        }

        private void buttonAddition_Click(object sender, EventArgs e)
        {
            operationTextBox.Text += "+";
        }

        private void buttonSubtraction_Click(object sender, EventArgs e)
        {
            operationTextBox.Text += "-";
        }

        private void buttonMultiplication_Click(object sender, EventArgs e)
        {
            operationTextBox.Text += "×";
        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            operationTextBox.Text += "÷";
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            operationTextBox.Text += ".";
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            string[] operations = { "+", "-", "×", "÷" };
            string inputText = operationTextBox.Text;

            if (inputText.Contains("+"))
            {
                var binary = new List<string>(inputText.Split('+'));

                string output = calculation.binAddition(binary[0], binary[1]);

                operationTextBox.Text = output;

            }
            else if (inputText.Contains("-"))
            {
                var binary = new List<string>(inputText.Split('-'));

                string output = calculation.binSubtraction(binary[0], binary[1]);

                operationTextBox.Text = output;

            }
            else if (inputText.Contains("×"))
            {
                var binary = new List<string>(inputText.Split('×'));

                string output = calculation.binMultiplication(binary[0], binary[1]);

                operationTextBox.Text = output;

            }
            else if (inputText.Contains("÷"))
            {
                var binary = new List<string>(inputText.Split('÷'));

                string output = calculation.binDivision(binary[0], binary[1]);

                operationTextBox.Text = output;

            }

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            operationTextBox.Text = string.Empty;
        }

        private void buttonBackSpace_Click(object sender, EventArgs e)
        {
            if (operationTextBox.Text.Length > 0)
            {
                operationTextBox.Text = operationTextBox.Text.Substring(0, operationTextBox.Text.Length - 1);
                operationTextBox.SelectionStart = operationTextBox.Text.Length;
            }
        }
    }
}
