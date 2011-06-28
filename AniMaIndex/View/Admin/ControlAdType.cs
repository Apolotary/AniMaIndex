﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AniMaIndex.Model;

namespace AniMaIndex.View.Admin
{
    public partial class ControlAdType : ControlAdminEditBase
    {
        public ControlAdType()
        {
            InitializeComponent();
            type = "type";
        }

        private void addUsrBut_Click(object sender, EventArgs e)
        {
            try
            {
                TypeModel.AddType(nameBox.Text);
                MessageBox.Show("Done!", "Yay!");
            }
            catch (Exception)
            {
                MessageBox.Show("Something bad has happened :(", "Oh noes");
            }
            
        }
    }
}
