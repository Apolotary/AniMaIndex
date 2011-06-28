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
    public partial class ControlAdPublisher : ControlAdminEditBase
    {
        public ControlAdPublisher()
        {
            InitializeComponent();
            type = "publisher";
        }

        private void addPubBut_Click(object sender, EventArgs e)
        {
            try
            {
                PublisherModel.AddPublisher(pubNameBox.Text, pubWebBox.Text);
                MessageBox.Show("Done!", "Yay!");
            }
            catch (Exception)
            {
                MessageBox.Show("Something bad has happened :(", "Oh noes");
            }
            
        }
    }
}
