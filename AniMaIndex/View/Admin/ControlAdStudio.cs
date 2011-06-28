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
    public partial class ControlAdStudio : ControlAdminEditBase
    {
        public ControlAdStudio()
        {
            InitializeComponent();
            type = "studio";
        }

        private void addStudBut_Click(object sender, EventArgs e)
        {
            try
            {
                StudioModel.AddStudios(studNameBox.Text, studWebBox.Text);
                MessageBox.Show("Done!", "Yay!");
            }
            catch (Exception)
            {
                MessageBox.Show("Something bad has happened :(", "Oh noes");
            }
            
        }
    }
}
