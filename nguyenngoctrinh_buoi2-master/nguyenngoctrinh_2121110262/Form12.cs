using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nguyenngoctrinh_2121110262
{
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

       

        private void btnOK_Click(object sender, EventArgs e)
        {
            string item = comboBox1.SelectedItem.ToString();
            tbDisplay.Text = "Bạn là sinh viên khoa: " + item;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox1.SelectedIndex;
            tbDisplay.Text = "Bạn đã chọn khoa thứ: " + index.ToString();
        }
    }
}
