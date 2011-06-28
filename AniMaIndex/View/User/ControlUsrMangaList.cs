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
    public partial class ControlUsrMangaList : ControlUsrEditBase
    {
        public ControlUsrMangaList()
        {
            InitializeComponent();
            type = "mangalist";
            statusBox.DataSource = StatusModel.ReturnAllStatuNames();
        }

        private void addMangaBut_Click(object sender, EventArgs e)
        {
            try
            {
                int[] temp = ReturnSelectedSearch();
                for (int i = 0; i < temp.Count(); ++i)
                {
                    MangaListModel.AddMangaList(mangatemp[temp[i]].MangaID, UserLogModel.lastid, StatusModel.ReturnStatusID(statusBox.Text),
                        Convert.ToInt32(scoreBox.Text), Convert.ToInt32(thomesRBox.Text), Convert.ToInt32(chapsRBox.Text));
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
