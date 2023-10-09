using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        List<DSSV> lst;
        public Form1()
        {
            InitializeComponent();
            dgvSV.CellClick += dgvSV_CellClick;
        }
        private bool IsNumeric(string value)
        {
            return long.TryParse(value, out long _);
        }

        private bool IsDuplicateID(string id)
        {
            foreach (DataGridViewRow row in dgvSV.Rows)
            {
                if (row.Cells["Column1"].Value != null && row.Cells["Column1"].Value.ToString() == id)
                {
                    return true;
                }
            }
            return false;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (!IsNumeric(tbId.Text))
            {
                MessageBox.Show("ID chỉ nên chứa số. Vui lòng nhập lại.");
                return;
            }

            if (IsDuplicateID(tbId.Text))
            {
                MessageBox.Show("ID đã tồn tại. Vui lòng nhập ID khác.");
                return;
            }
            // Get the image from PictureBox
            if (pbImage.Image != null)
            {
                dgvSV.Rows.Add(tbId.Text, tbName.Text, ckGender.Checked, pbImage.Image);
            }
            else
            {
                // Handle the case where the PictureBox doesn't have an image.
                MessageBox.Show("Please select a valid image first.");
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            int idx = dgvSV.CurrentCell.RowIndex;
            dgvSV.Rows.RemoveAt(idx);
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            if (dgvSV.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvSV.SelectedRows[0];

                selectedRow.Cells[0].Value = tbId.Text;
                selectedRow.Cells[1].Value = tbName.Text;
               
                selectedRow.Cells[2].Value = ckGender.Checked;
                selectedRow.Cells["Column4"].Value = pbImage.Image;

                // Optionally, if you want to refresh the DataGridView
                dgvSV.Refresh();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dgvSV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            tbId.Text = dgvSV.Rows[idx].Cells[0].Value.ToString();
            tbName.Text = dgvSV.Rows[idx].Cells[1].Value.ToString();
            ckGender.Checked = bool.Parse(dgvSV.Rows[idx].Cells[2].Value.ToString());

            pbImage.Image = (Image)dgvSV.Rows[idx].Cells["Column4"].Value;
        }

        private void btFile_Click(object sender, EventArgs e)
        {
            
            pbImage.SizeMode = PictureBoxSizeMode.StretchImage;
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Open Image";
            dlg.Filter = "JPEG files (*.jpg) |*.jpg";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pbImage.ImageLocation = dlg.FileName;
            }


            

        }

        private void dgvSV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            tbId.Text = dgvSV.Rows[idx].Cells[0].Value.ToString();
            tbName.Text = dgvSV.Rows[idx].Cells[1].Value.ToString();
            ckGender.Checked = bool.Parse(dgvSV.Rows[idx].Cells[2].Value.ToString());

            pbImage.Image = (Image)dgvSV.Rows[idx].Cells["Column4"].Value;
        }
    }
}
