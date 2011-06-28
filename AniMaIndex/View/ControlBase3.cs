using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AniMaIndex.View
{
    public partial class ControlBase3 : ControlBase
    {
        public ControlBase3()
        {
            InitializeComponent();
        }

        private void homeBut_Click(object sender, EventArgs e)
        {
            FormMain.Instance().ChangeControl(new ControlWelcome());
        }
    }
}
