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
    public partial class ControlAdManga : ControlAdminEditBase
    {
        public ControlAdManga()
        {
            InitializeComponent();
            type = "manga";
            manGenreBox.DataSource = GenreModel.ReturnAllGenreNames();
            publisherBox.DataSource = PublisherModel.ReturnAllPublisherName();
            publishedStatBox.DataSource = AiredModel.ReturnAllAiredNames();
        }

        private void addManBut_Click(object sender, EventArgs e)
        {
            try
            {
                MangaModel.AddManga(AiredModel.ReturnAiredID(publishedStatBox.Text),
                Convert.ToInt32(chapsBox.Text), GenreModel.ReturnGenreID(manGenreBox.Text),
                manNameBox.Text, Convert.ToInt32(yearBox.Text), PublisherModel.ReturnPublisherID(publisherBox.Text),
                descriptionBox.Text, Convert.ToInt32(thomesBox.Text));
                MessageBox.Show("Done!", "Yay!");
            }
            catch (Exception)
            {
                MessageBox.Show("Something bad has happened :(", "Oh noes");
            }
            
        }
    }
}
