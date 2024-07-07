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
    }
}
