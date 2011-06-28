using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AniMaIndex.Model;
using AniMaIndex.View;

namespace AniMaIndex
{
    public partial class ControlUserOpts : ControlBase3
    {
        public ControlUserOpts()
        {
            InitializeComponent();
        }

        private void enterUNameBut_Click(object sender, EventArgs e)
        {
            try
            {
                UserLogModel.AddUserLog(UserModel.ReturnUserID(userTBox.Text));
                FormMain.Instance().ChangeControl(new ControlUserOptsChoice());
            }
            catch (Exception)
            {
                MessageBox.Show("No such user. Please add it in admin direcotry", "ahem");
            }
            
        }
    }
}
