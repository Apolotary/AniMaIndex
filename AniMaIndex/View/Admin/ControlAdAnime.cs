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
    public partial class ControlAdAnime : ControlAdminEditBase
    {
        public ControlAdAnime()
        {
            InitializeComponent();
            type = "anime";
            aniGenreBox.DataSource = GenreModel.ReturnAllGenreNames();
            mangaBox.DataSource = MangaModel.ReturnAllMangaNames();
            studBox.DataSource = StudioModel.ReturnAllStudioNames();
            airedBox.DataSource = AiredModel.ReturnAllAiredNames();
            typeBox.DataSource = TypeModel.ReturnAllTypeNames();
        }

        private void addAniBut_Click(object sender, EventArgs e)
        {
            try
            {
                AnimeModel.AddAnime(MangaModel.ReturnMangaID(mangaBox.Text),
                                StudioModel.ReturnStudioID(studBox.Text),
                                Convert.ToInt32(yearBox.Text),
                                aniNameBox.Text,
                                TypeModel.ReturnTypeID(typeBox.Text),
                                GenreModel.ReturnGenreID(aniGenreBox.Text),
                                descriptionBox.Text,
                                Convert.ToInt32(aniEpsBox.Text),
                                AiredModel.ReturnAiredID(airedBox.Text));
                MessageBox.Show("Done!", "Yay!");
            }
            catch (Exception)
            {
                MessageBox.Show("Something bad has happened :(", "Oh noes");
            }
            
        }
    }
}
