using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace nguyenngoctrinh_2121110262
{
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void ckDiscount_CheckedChanged(object sender, EventArgs e)
        {
            if (ckDiscount.Checked == true) 
                tbDiscount.Enabled = true;
            else
                tbDiscount.Enabled=false;
        }

        private void btRun_Click(object sender, EventArgs e)
        {   
            string msg = null;
            int disc = 0;
            if (rbMale.Checked == true) msg += "Ông ";
            if (rbFemale.Checked == true) msg += "Bà ";
            if (ckDiscount.Checked == true) 
                disc = int.Parse(tbDiscount.Text);
            tbResult.Text = msg + tbName.Text + " được giảm " + disc.ToString() + " % "+ "\r\n";

        }
    }
    
}
