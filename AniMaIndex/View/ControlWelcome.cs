using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AniMaIndex.View;

namespace AniMaIndex
{
    public partial class ControlWelcome : ControlBase
    {
        public ControlWelcome()
        {
            InitializeComponent();
        }

        private void userBut_Click(object sender, EventArgs e)
        {
            FormMain.Instance().ChangeControl(new ControlUserOpts());
        }

        private void adminBut_Click(object sender, EventArgs e)
        {
            FormMain.Instance().ChangeControl(new ControlAdminOpts());
        }

        private void aboutBut_Click(object sender, EventArgs e)
        {
            FormMain.Instance().ChangeControl(new ControlAbout());
        }
    }
}
