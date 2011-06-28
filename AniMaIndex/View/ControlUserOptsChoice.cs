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
    public partial class ControlUserOptsChoice : ControlBase3
    {
        public ControlUserOptsChoice()
        {
            InitializeComponent();
            unameLabel.Text = UserModel.ReturnUserName(UserLogModel.lastid);
        }

        private void aniEditBut_Click(object sender, EventArgs e)
        {
            FormMain.Instance().ChangeControl(new ControlUsrAniList());
        }

        private void mangaEditBut_Click(object sender, EventArgs e)
        {
            FormMain.Instance().ChangeControl(new ControlUsrMangaList());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormMain.Instance().ChangeControl(new ControlUsrFavAni());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormMain.Instance().ChangeControl(new ControlUsrFavManga());
        }

        private void staffEditBut_Click(object sender, EventArgs e)
        {
            FormMain.Instance().ChangeControl(new ControlUsrFavStaff());
        }
    }
}
