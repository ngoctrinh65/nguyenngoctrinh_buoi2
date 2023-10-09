using System;
using System.Collections;
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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }
        public ArrayList GetData()
        {
            ArrayList lst = new ArrayList();

            Faculty f = new Faculty();
            f.Id = "K01";
            f.Name = "Công nghệ thông tin";
            f.Quantity = 1200;
            lst.Add(f);

            f = new Faculty();
            f.Id = "K02";
            f.Name = "Ngoại ngữ";
            f.Quantity = 1300;
            lst.Add(f);

            f = new Faculty();
            f.Id = "K03";
            f.Name = "Quản trị kinh doanh";
            f.Quantity = 1280;
            lst.Add(f);

            f = new Faculty();
            f.Id = "K04";
            f.Name = "Điện";
            f.Quantity = 2200;
            lst.Add(f);

            f = new Faculty();
            f.Id = "K05";
            f.Name = "Cơ khí";
            f.Quantity = 2200;
            lst.Add(f);
            return lst;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            cb_Faculty.ValueMember = "Name";
            string name = cb_Faculty.SelectedValue.ToString();
            tbDisplay.Text = "Bạn đã chọn khoa có tên: " + name;
        }

        private void cb_Faculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_Faculty.ValueMember = "Id";
            string id = cb_Faculty.SelectedValue.ToString();
            tbDisplay.Text = "Bạn đã chọn khoa có mã: " + id;
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            ArrayList lst = GetData();
            cb_Faculty.DataSource = lst;
            cb_Faculty.DisplayMember = "Name";
        }
    }
}
