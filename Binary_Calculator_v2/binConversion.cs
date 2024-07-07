﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Checker;

namespace Binary_Calculator_v2
{
    public partial class binConversion : Form
    {
        conversion conversions = new conversion();
        public binConversion()
        {
            InitializeComponent();

            binaryInput.TextChanged += new EventHandler(binaryInput_TextChanged);
            deciInput.TextChanged += new EventHandler(deciInput_TextChanged);
            octalInput.TextChanged += new EventHandler(octalInput_TextChanged);
            hexaInput.TextChanged += new EventHandler(hexaInput_TextChanged);
        }

        private void backToHome1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Close();
        }

        private void binaryInput_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(binaryInput.Text))
            {
                deciInput.ReadOnly = false;
                octalInput.ReadOnly = false;
                hexaInput.ReadOnly = false;
            }
            else
            {
                deciInput.ReadOnly = true;
                octalInput.ReadOnly = true;
                hexaInput.ReadOnly = true;
            }

        }

        private void deciInput_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty (deciInput.Text))
            {
                binaryInput.ReadOnly = false;
                octalInput.ReadOnly = false;
                hexaInput.ReadOnly = false;
            }
            else
            {
                binaryInput.ReadOnly = true;
                octalInput.ReadOnly = true;
                hexaInput.ReadOnly = true;
            }
        }

        private void octalInput_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(octalInput.Text))
            {
                binaryInput.ReadOnly = false;
                deciInput.ReadOnly = false;
                hexaInput.ReadOnly = false;
            }
            else
            {
                binaryInput.ReadOnly = true;
                deciInput.ReadOnly = true;
                hexaInput.ReadOnly = true;
            }
        }

        private void hexaInput_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(hexaInput.Text))
            {
                binaryInput.ReadOnly = false;
                deciInput.ReadOnly = false;
                octalInput.ReadOnly = false;
            }
            else
            {
                binaryInput.ReadOnly = true;
                deciInput.ReadOnly = true;
                octalInput.ReadOnly = true;
            }
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            if (!binaryInput.ReadOnly)
            {
                string inputText = binaryInput.Text;
                deciInput.Text = conversions.binaryDecimalChecker(inputText);
                octalInput.Text = conversions.binaryOctalChecker(inputText);
                hexaInput.Text = conversions.binaryHexaChecker(inputText);
            }
            else if (!deciInput.ReadOnly)
            {
                string inputText = deciInput.Text;
                string output = conversions.decimalBinaryChecker(inputText);
                binaryInput.Text = output;
                octalInput.Text = conversions.binaryOctalChecker(output);
                hexaInput.Text = conversions.binaryHexaChecker(output);
            }
            else if (!octalInput.ReadOnly) // BUG REPORT: even though a typed an unsigned octal value(671.01), it will still give me a negative output
                                           // most likely because of the binary
            {
                string inputText = octalInput.Text;
                string output = conversions.octalBinaryChecker(inputText);
                binaryInput.Text = output;
                deciInput.Text = conversions.binaryDecimalChecker(output);
                hexaInput.Text = conversions.binaryHexaChecker(output);
            }
            else if (!hexaInput.ReadOnly) // BUG REPORT: unsigned value (start the value with 8), negative output
            {
                string inputText = hexaInput.Text;
                string output = conversions.hexaBinaryChecker(inputText);
                binaryInput.Text = output;
                deciInput.Text = conversions.binaryDecimalChecker(output);
                octalInput.Text = conversions.binaryOctalChecker(output);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            binaryInput.Text = string.Empty;
            deciInput.Text = string.Empty;
            octalInput.Text = string.Empty;
            hexaInput.Text = string.Empty;
        }
    }
}