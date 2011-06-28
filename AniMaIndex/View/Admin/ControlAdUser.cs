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
    public partial class ControlAdUser : ControlAdminEditBase
    {
        public ControlAdUser()
        {
            InitializeComponent();
            type = "user";
        }

        private void addUsrBut_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime bd = Convert.ToDateTime(yearBox.Text);
                UserModel.AddUser(nameBox.Text, bd, genderBox.Text);
                MessageBox.Show("Done!", "Yay!");
            }
            catch (Exception)
            {
                MessageBox.Show("Something bad has happened :(", "Oh noes");
            }
            
        }

        private void loadBut_Click(object sender, EventArgs e)
        {
        }

        private void loadBut_Click_1(object sender, EventArgs e)
        {
        }

        private void remButt_Click(object sender, EventArgs e)
        {

        }
    }
}
