using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        string currentValue { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
           textArea.Text += "0";
           currentValue += "0";
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            textArea.Text += ".";
            currentValue += ".";
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            textArea.Text += "1";
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            textArea.Text += "2";
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            textArea.Text += "3";
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            textArea.Text += "4";
            currentValue += "4";
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            textArea.Text += "5";
            currentValue += "5";
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            textArea.Text += "6";
            currentValue += "6";
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            textArea.Text += "7";
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            textArea.Text += "8";
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            textArea.Text += "9";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textArea.Text = "";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            try
            {
                string text = textArea.Text.Trim();
                string value = new DataTable().Compute(text, null).ToString();
                textArea.Text = value;
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            textArea.Text += "+";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            textArea.Text += "-";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            textArea.Text += "*";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            textArea.Text += "/";
        }
    }
}
