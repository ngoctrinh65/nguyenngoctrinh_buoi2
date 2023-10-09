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
    public partial class Form17 : Form
    {
        public Form17()
        {
            InitializeComponent();
        }

        private void btSelect_Click(object sender, EventArgs e)
        {
            string song = lbSong.SelectedItem.ToString();
            lbFavorite.Items.Add(song);
            lbSong.Items.RemoveAt(lbSong.SelectedIndex);
        }
        private void lbSong_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.lbSong.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                string song = lbSong.Items[index].ToString();
                lbFavorite.Items.Add(song);
                lbSong.Items.RemoveAt(lbSong.SelectedIndex);

            }
        }

        private void btSelectAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lbSong.Items.Count; i++) {
                string song = lbSong.Items[i].ToString();
                lbFavorite.Items.Add(song);
                lbSong.Items.RemoveAt(i);
            }
        }

        private void btDeselectAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lbFavorite.Items.Count; i++)
            {
                string song = lbFavorite.Items[i].ToString();
                lbSong.Items.Add(song);
                lbFavorite.Items.RemoveAt(i);
            }
        }

        private void lbFavorite_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.lbFavorite.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                string song = lbFavorite.Items[index].ToString();
                lbSong.Items.Add(song);
                lbFavorite.Items.RemoveAt(lbFavorite.SelectedIndex);

            }
        }

        private void btDeselect_Click(object sender, EventArgs e)
        {
            string song = lbFavorite.SelectedItem.ToString();
            lbSong.Items.Add(song);
            lbFavorite.Items.RemoveAt(lbFavorite.SelectedIndex);
        }

        
    }
}