using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AniMaIndex.View;
using AniMaIndex.View.Admin;

namespace AniMaIndex
{
    public partial class ControlAdminOpts : ControlBase3
    {
        public ControlAdminOpts()
        {
            InitializeComponent();
        }

        private void userEditBut_Click(object sender, EventArgs e)
        {
            FormMain.Instance().ChangeControl(new ControlAdUser());
        }

        private void studioEditBut_Click(object sender, EventArgs e)
        {
            FormMain.Instance().ChangeControl(new ControlAdStudio());
        }

        private void genreEditBut_Click(object sender, EventArgs e)
        {
            FormMain.Instance().ChangeControl(new ControlAdGenre());
        }

        private void pubEditBut_Click(object sender, EventArgs e)
        {
            FormMain.Instance().ChangeControl(new ControlAdPublisher());
        }

        private void staffEditBut_Click(object sender, EventArgs e)
        {
            FormMain.Instance().ChangeControl(new ControlAdStaff());
        }

        private void aniEditBut_Click(object sender, EventArgs e)
        {
            FormMain.Instance().ChangeControl(new ControlAdAnime());
        }

        private void mangaEditBut_Click(object sender, EventArgs e)
        {
            FormMain.Instance().ChangeControl(new ControlAdManga());
        }

        private void usrStat_Click(object sender, EventArgs e)
        {
            FormMain.Instance().ChangeControl(new ControlAdStatus());
        }

        private void typeBut_Click(object sender, EventArgs e)
        {
            FormMain.Instance().ChangeControl(new ControlAdType());
        }

        private void airedBut_Click(object sender, EventArgs e)
        {
            FormMain.Instance().ChangeControl(new ControlAdAired());
        }
    }
}
