using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AniMaIndex.Model;
using AniMaIndex.Model.LINQ;

namespace AniMaIndex.View
{
    public partial class ControlUsrEditBase : UserControl
    {
        public Anime[] anitemp;
        public Staff[] stafftemp;
        public Manga[] mangatemp;
        public string statname = "";
        public string type = "";
        public ControlUsrEditBase()
        {
            InitializeComponent();
            unameLabel.Text = UserModel.ReturnUserName(UserLogModel.lastid);
            srchGenreBox.DataSource = GenreModel.ReturnAllGenreNames();
        }

        private void homeBut_Click(object sender, EventArgs e)
        {
            FormMain.Instance().ChangeControl(new ControlUserOptsChoice());
        }

        public void UFillGrid(object[] obj)
        {
            outGrid.DataSource = obj;
            outGrid.Invalidate();
        }

        public int[] UReturnSelected()
        {
            Int32 selectedRowCount =
                    outGrid.Rows.GetRowCount(DataGridViewElementStates.Selected);

            int[] row = new int[selectedRowCount];
            for (int i = 0; i < selectedRowCount; ++i)
            {
                row[i] = outGrid.SelectedRows[i].Index;
            }

            return row;
        }

        public void FillGridSearch(object[] obj)
        {
            searchGrid.DataSource = obj;
            searchGrid.Invalidate();
        }

        public int[] ReturnSelectedSearch()
        {
            Int32 selectedRowCount =
                    searchGrid.Rows.GetRowCount(DataGridViewElementStates.Selected);

            int[] row = new int[selectedRowCount];
            for (int i = 0; i < selectedRowCount; ++i)
            {
                row[i] = searchGrid.SelectedRows[i].Index;
            }

            return row;
        }

        private void loadBut_Click(object sender, EventArgs e)
        {
            try
            {
                if (type == "favani")
                {
                    UFillGrid(FavAnimeModel.ReturnAllFavAnime());
                }
                if (type == "favstaff")
                {
                    UFillGrid(FavStaffModel.ReturnAllFavStaff());
                }
                if (type == "favmanga")
                {
                    UFillGrid(FavMangaModel.ReturnAllFavManga());
                }
                if (type == "anilist")
                {
                    UFillGrid(AnimeListModel.ReturnAllAnimeList());
                }
                if (type == "mangalist")
                {
                    UFillGrid(MangaListModel.ReturnAllMangaList());
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something bad has happened", "Whoops!");
            }
            
        }

        private void remButt_Click(object sender, EventArgs e)
        {
            try
            {
                if (type == "favani")
                {
                    int[] temp = UReturnSelected();
                    for (int i = 0; i < temp.Count(); ++i)
                    {
                        if (i > 0)
                        {
                            temp[i] -= i;
                        }
                        FavAnimeModel.RemoveFavAnime(temp[i]);
                    }
                }
                if (type == "favstaff")
                {
                    int[] temp = UReturnSelected();
                    for (int i = 0; i < temp.Count(); ++i)
                    {
                        if (i > 0)
                        {
                            temp[i] -= i;
                        }
                        FavStaffModel.RemoveFavStaff(temp[i]);
                    }
                }
                if (type == "favmanga")
                {
                    int[] temp = UReturnSelected();
                    for (int i = 0; i < temp.Count(); ++i)
                    {
                        if (i > 0)
                        {
                            temp[i] -= i;
                        }
                        FavMangaModel.RemoveFavManga(temp[i]);
                    }
                }
                if (type == "anilist")
                {
                    int[] temp = UReturnSelected();
                    for (int i = 0; i < temp.Count(); ++i)
                    {
                        if (i > 0)
                        {
                            temp[i] -= i;
                        }
                        AnimeListModel.RemoveAnimeList(temp[i]);
                    }
                }
                if (type == "mangalist")
                {
                    int[] temp = UReturnSelected();
                    for (int i = 0; i < temp.Count(); ++i)
                    {
                        if (i > 0)
                        {
                            temp[i] -= i;
                        }
                        MangaListModel.RemoveMangaList(temp[i]);
                    }
                }
                MessageBox.Show("Done!", "Yay!");
            }
            catch (Exception)
            {
                MessageBox.Show("Something bad has happened", "Whoops!");
            }
            
        }

        private void srchGenre_Click(object sender, EventArgs e)
        {
            try
            {
                if (type == "favani" || type == "anilist")
                {
                    FillGridSearch(FavAnimeModel.ReturnAllFavAnimeByGenre(srchGenreBox.Text, ref anitemp));
                }
                if (type == "favstaff")
                {
                    FillGridSearch(FavStaffModel.ReturnAllFavStaffByGenre(srchGenreBox.Text, ref stafftemp));
                }
                if (type == "favmanga" || type == "mangalist")
                {
                    FillGridSearch(FavMangaModel.ReturnAllFavMangaByGenre(srchGenreBox.Text, ref mangatemp));
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something bad has happened", "Whoops!");
            }
            
        }

        private void srchYear_Click(object sender, EventArgs e)
        {

        }

        private void addButt_Click(object sender, EventArgs e)
        {
            try
            {
                if (type == "favani")
                {
                    int[] temp = ReturnSelectedSearch();
                    for (int i = 0; i < temp.Count(); ++i)
                    {
                        FavAnimeModel.AddFavAnime(anitemp[temp[i]].TitleID, UserLogModel.lastid);
                    }
                }
                if (type == "favstaff")
                {
                    int[] temp = ReturnSelectedSearch();
                    for (int i = 0; i < temp.Count(); ++i)
                    {
                        FavStaffModel.AddFavStaff(stafftemp[temp[i]].StaffID, UserLogModel.lastid);
                    }
                }
                if (type == "favmanga")
                {
                    int[] temp = ReturnSelectedSearch();
                    for (int i = 0; i < temp.Count(); ++i)
                    {
                        FavMangaModel.AddFavManga(mangatemp[temp[i]].MangaID, UserLogModel.lastid);
                    }
                }
                MessageBox.Show("Done!", "Yaay!");
            }
            catch (Exception)
            {
                MessageBox.Show("Something bad has happened", "Whoops!");
            }
            
            
        }
    }
}
