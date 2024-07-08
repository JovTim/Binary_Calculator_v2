using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Binary_Calculator_v2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonConversion_Click(object sender, EventArgs e)
        {
            this.Hide();
            binConversion binConversion = new binConversion();
            binConversion.ShowDialog();
            this.Close();
        }

        private void buttonOperation_Click(object sender, EventArgs e)
        {
            this.Hide();
            binOperation binOperation = new binOperation();
            binOperation.ShowDialog();
            this.Close();
        }

        private void helpMain_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip((LinkLabel)sender, "About");
            System.Diagnostics.Process.Start("https://docs.google.com/document/d/1duJQtTT5Admqme4ptnmh1tJQFGwwXRcIe0WIcJAYrns/edit?usp=sharing");
        }
    }
}
