using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AniMaIndex.Model;

namespace AniMaIndex.View
{
    public partial class ControlAdStaff : ControlAdminEditBase
    {
        public ControlAdStaff()
        {
            InitializeComponent();
            type = "staff";
            aniBox.DataSource = AnimeModel.ReturnAllAnimeNames();
            mangaBox.DataSource = MangaModel.ReturnAllMangaNames();
        }

        private void addStaffBut_Click(object sender, EventArgs e)
        {
            try
            {
                StaffModel.AddStaff(AnimeModel.ReturnAnimeID(aniBox.Text),
                    MangaModel.ReturnMangaID(mangaBox.Text), 
                    staffNameBox.Text, staffOccupBox.Text, staffWebBox.Text);
                MessageBox.Show("Done!", "Yay!");
            }
            catch (Exception)
            {
                MessageBox.Show("Something bad has happened :(", "Oh noes");
            }
        }

        private void ControlAdStaff_Load(object sender, EventArgs e)
        {

        }

        private void staffWebBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void staffOccupBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void staffNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void mangaBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void aniBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
