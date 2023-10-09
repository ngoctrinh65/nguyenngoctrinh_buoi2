using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nguyenngoctrinh_2121110262
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbSoX_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            int x = int.Parse(tbSoX.Text);
            int y = int.Parse(tbSoY.Text);
            int kq = x + y;
            tbKQ.Text = tbKQ.Text + x.ToString() + "+" + y.ToString() + "=" + kq.ToString() + "\r\n";

        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            int x = int.Parse(tbSoX.Text);
            int y = int.Parse(tbSoY.Text);
            int kq = x * y;
            tbKQ.Text = tbKQ.Text + x.ToString() + "*" + y.ToString() + "=" + kq.ToString() + "\r\n";

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("Calculator.txt", true);
            sw.Write(tbKQ.Text);
            sw.Close();
        }

        private void tbKQ_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
