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
    public partial class ControlAdGenre : ControlAdminEditBase
    {
        public ControlAdGenre()
        {
            InitializeComponent();
            type = "genre";
        }

        private void remButt_Click(object sender, EventArgs e)
        {

        }

        private void addGenBut_Click(object sender, EventArgs e)
        {
            try
            {
                GenreModel.AddGenre(genreNameBox.Text);
                MessageBox.Show("Done!", "Yay!");
            }
            catch (Exception)
            {
                MessageBox.Show("Something bad has happened :(", "Oh noes");
            }
            
        }
    }
}
