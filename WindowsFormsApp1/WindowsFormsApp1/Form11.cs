using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nguyenngoctrinh_2121110262
{
    public partial class Form11 : Form
    {
        private double memory;
        private bool opFlag = false;
        private bool memFlag;
        private double Value;
        string op;

        public Form11()
        {
            InitializeComponent();
            btnMC.Enabled = false;
            btnMR.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            memory += Double.Parse(txtDisplay.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            memory = 0;
            btnMC.Enabled = false;
            btnMR.Enabled = false;
        }

        private void btnMS_Click(object sender, EventArgs e)
        {
            memory = Double.Parse(txtDisplay.Text);
            btnMC.Enabled = true;
            btnMR.Enabled = true;
            memFlag = true;
        }

        private void btnMR_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = memory.ToString();
            memFlag = true;
        }

        private void btnMSub_Click(object sender, EventArgs e)
        {
            memory -= Double.Parse(txtDisplay.Text);
        }

        private void btnSqr_Click(object sender, EventArgs e)
        {

        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            Value = Double.Parse(txtDisplay.Text);
            op = "+";
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Contains("."))
                return;
            else
                txtDisplay.Text += ".";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            //if (txtDisplay.Text == "0" || opFlag == true || memFlag == true)
            if(txtDisplay.Text == "0")
            {
                txtDisplay.Text = "1";
                opFlag = false;
                memFlag = false;
            }else
                txtDisplay.Text = txtDisplay.Text + "1";
            //double v = Double.Parse(txtDisplay.Text);
            //int pos = 0;
            //if (txtDisplay.Text.Contains("."))
            //{
            //    pos = txtDisplay.Text.Length - txtDisplay.Text.IndexOf('.');
            //    if (pos == 1) return;
            //    string formatStr = "{0:N" + (pos - 1) + "}";
            //    txtDisplay.Text = string.Format(formatStr, v);
            //}
            //else
            //    txtDisplay.Text = string.Format("{0:N0}", v);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "2";
                
            }
            else
                txtDisplay.Text = txtDisplay.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "3";
               
            }
            else
                txtDisplay.Text = txtDisplay.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "4";
               
            }
            else
                txtDisplay.Text = txtDisplay.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "5";
              
            }
            else
                txtDisplay.Text = txtDisplay.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "6";
               
            }
            else
                txtDisplay.Text = txtDisplay.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "7";
               
            }
            else
                txtDisplay.Text = txtDisplay.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "8";
             
            }
            else
                txtDisplay.Text = txtDisplay.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "9";
               
            }
            else
                txtDisplay.Text = txtDisplay.Text + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "0";

            }
            else
                txtDisplay.Text = txtDisplay.Text + "0";
        }

        private void btnPlusMinus_Click(object sender, EventArgs e)
        {
            double v = Double.Parse(txtDisplay.Text);
            txtDisplay.Text = (-v).ToString();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            Double rValue = Double.Parse(txtDisplay.Text);
            switch (op)
            {
                case "+":
                    txtDisplay.Text = (Value + rValue).ToString();
                    break;
                case "-":
                    txtDisplay.Text = (Value - rValue).ToString();
                    break;
                case "*":
                    txtDisplay.Text = (Value * rValue).ToString();
                    break;
                case "/":
                    txtDisplay.Text = (Value / rValue).ToString();
                    break;

            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            Value = Double.Parse(txtDisplay.Text);
            op = "-";
        }

        private void btnTimes_Click(object sender, EventArgs e)
        {
            Value = Double.Parse(txtDisplay.Text);
            op = "*";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            Value = Double.Parse(txtDisplay.Text);
            op = "/";
        }
    }
}
