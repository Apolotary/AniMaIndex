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
    public partial class ControlUsrAniList : ControlUsrEditBase
    {
        public ControlUsrAniList()
        {
            InitializeComponent();
            type = "anilist";
            statusBox.DataSource = StatusModel.ReturnAllStatuNames();
        }

        private void aniBut_Click(object sender, EventArgs e)
        {
            try
            {
                int[] temp = ReturnSelectedSearch();
                for (int i = 0; i < temp.Count(); ++i)
                {
                    AnimeListModel.AddAnimeList(anitemp[temp[i]].TitleID, UserLogModel.lastid, StatusModel.ReturnStatusID(statusBox.Text),
                        Convert.ToInt32(scoreBox.Text), Convert.ToInt32(epsWBox.Text));
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
