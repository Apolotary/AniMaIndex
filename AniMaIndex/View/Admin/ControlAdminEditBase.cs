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
    public partial class ControlAdminEditBase : UserControl
    {
        public ControlAdminEditBase()
        {
            InitializeComponent();
        }

        public string type = "none";

        private void homeBut_Click(object sender, EventArgs e)
        {
            FormMain.Instance().ChangeControl(new ControlAdminOpts());
        }
        public void FillGrid(object[] obj)
        {
            outGrid.DataSource = obj;
            outGrid.Invalidate();
        }

        public int[] ReturnSelected()
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

        private void loadBut_Click(object sender, EventArgs e)
        {
            try
            {
                if (type == "user")
                {
                    FillGrid(UserModel.ReturnAllUsers());
                }
                if (type == "type")
                {
                    FillGrid(TypeModel.ReturnAllTypes());
                }
                if (type == "studio")
                {
                    FillGrid(StudioModel.ReturnAllStudios());
                }
                if (type == "status")
                {
                    FillGrid(StatusModel.ReturnAllStatus());
                }
                if (type == "publisher")
                {
                    FillGrid(PublisherModel.ReturnAllPublisher());
                }
                if (type == "genre")
                {
                    FillGrid(GenreModel.ReturnAllGenre());
                }
                if (type == "aired")
                {
                    FillGrid(AiredModel.ReturnAllAired());
                }
                if (type == "anime")
                {
                    FillGrid(AnimeModel.ReturnAllAnime());
                }
                if (type == "manga")
                {
                    FillGrid(MangaModel.ReturnAllManga());
                }
                if (type == "staff")
                {
                    FillGrid(StaffModel.ReturnAllStaff());
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something bad has happened :(", "Oh noes");
            }
            
        }

        private void remButt_Click(object sender, EventArgs e)
        {
            try
            {
                if (type == "user")
                {
                    int[] temp = ReturnSelected();
                    for (int i = 0; i < temp.Count(); ++i)
                    {
                        if (i > 0)
                        {
                            temp[i] -= i;
                        }
                        UserModel.RemoveUser(temp[i]);
                    }
                }
                if (type == "type")
                {
                    int[] temp = ReturnSelected();
                    for (int i = 0; i < temp.Count(); ++i)
                    {
                        if (i > 0)
                        {
                            temp[i] -= i;
                        }
                        TypeModel.RemoveType(temp[i]);
                    }
                }
                if (type == "studio")
                {
                    int[] temp = ReturnSelected();
                    for (int i = 0; i < temp.Count(); ++i)
                    {
                        if (i > 0)
                        {
                            temp[i] -= i;
                        }
                        StudioModel.RemoveStudios(temp[i]);
                    }
                }
                if (type == "status")
                {
                    int[] temp = ReturnSelected();
                    for (int i = 0; i < temp.Count(); ++i)
                    {
                        if (i > 0)
                        {
                            temp[i] -= i;
                        }
                        StatusModel.RemoveStatus(temp[i]);
                    }
                }
                if (type == "publisher")
                {
                    int[] temp = ReturnSelected();
                    for (int i = 0; i < temp.Count(); ++i)
                    {
                        if (i > 0)
                        {
                            temp[i] -= i;
                        }
                        PublisherModel.RemovePublisher(temp[i]);
                    }
                }
                if (type == "genre")
                {
                    int[] temp = ReturnSelected();
                    for (int i = 0; i < temp.Count(); ++i)
                    {
                        if (i > 0)
                        {
                            temp[i] -= i;
                        }
                        GenreModel.RemoveGenre(temp[i]);
                    }
                }
                if (type == "aired")
                {
                    int[] temp = ReturnSelected();
                    for (int i = 0; i < temp.Count(); ++i)
                    {
                        if (i > 0)
                        {
                            temp[i] -= i;
                        }
                        AiredModel.RemoveAired(temp[i]);
                    }
                }
                if (type == "anime")
                {
                    int[] temp = ReturnSelected();
                    for (int i = 0; i < temp.Count(); ++i)
                    {
                        if (i > 0)
                        {
                            temp[i] -= i;
                        }
                        AnimeModel.RemoveAnime(temp[i]);
                    }
                }
                if (type == "manga")
                {
                    int[] temp = ReturnSelected();
                    for (int i = 0; i < temp.Count(); ++i)
                    {
                        if (i > 0)
                        {
                            temp[i] -= i;
                        }
                        MangaModel.RemoveManga(temp[i]);
                    }
                }
                if (type == "staff")
                {
                    int[] temp = ReturnSelected();
                    for (int i = 0; i < temp.Count(); ++i)
                    {
                        if (i > 0)
                        {
                            temp[i] -= i;
                        }
                        StaffModel.RemoveStaff(temp[i]);
                    }
                }
                MessageBox.Show("Done!", "Yay!");
            }
            catch (Exception)
            {
                MessageBox.Show("Something bad has happened :(", "Oh noes");
            }
            
        }
    }
}
