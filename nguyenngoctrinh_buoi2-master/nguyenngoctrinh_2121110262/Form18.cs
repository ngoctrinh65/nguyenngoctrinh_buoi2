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
    public partial class Form18 : Form
    {
        public Form18()
        {
            InitializeComponent();
        }
        public ArrayList GetData()
        {
            ArrayList lst = new ArrayList();

            Song s = new Song();
            s.Id = 53418;
            s.Name = "Giấc mơ cha pi";
            s.Author = "Trần Tiến";
            lst.Add(s);

            s = new Song(); 
            s.Id = 52616;
            s.Name = "Đôi mắt pleiku"; 
            s.Author = "Nguyễn Cường"; 
            lst.Add(s);

            s = new Song();
            s.Id = 51172;
            s.Name = "Em muốn sống bên anh chọn đời";
            s.Author = "Nguyễn Cường";
            lst.Add(s);
            return lst;
        }

        private void Form18_Load(object sender, EventArgs e)
        {
            ArrayList lst = GetData();
            lbSong.DataSource = lst;
            lbSong.DisplayMember = "Name";

        }

        private void btSelect_Click(object sender, EventArgs e)
        {
            Song song = (Song)lbSong.SelectedItem; 
            string id = song.Id.ToString();
            string name = song.Name; 
            string author = song.Author;
            lbFavorite.Items.Add(id + " - " + name + " - " + author);
       

        }

        private void btDeselect_Click(object sender, EventArgs e)
        {
            // Check if an item is selected in lbFavorite
            if (lbFavorite.SelectedItem != null)
            {
                // Get the selected name from lbFavorite
                string selectedName = lbFavorite.SelectedItem.ToString();

                // Get the data source (ArrayList) from lbSong
                ArrayList lst = (ArrayList)lbSong.DataSource;

                // Add the selected name back to the data source (ArrayList)
                if (lst != null)
                {
                    lst.Add(selectedName);

                    // Update lbSong to reflect the changes
                    lbSong.DataSource = null;
                    lbSong.DataSource = lst;
                    lbSong.DisplayMember = "Name";
                }

                // Remove the selected name from lbFavorite
                lbFavorite.Items.Remove(lbFavorite.SelectedItem);
            }
        }







    }
}
