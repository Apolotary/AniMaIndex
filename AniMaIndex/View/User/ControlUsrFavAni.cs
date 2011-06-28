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
    public partial class ControlUsrFavAni : ControlUsrEditBase
    {
        public ControlUsrFavAni()
        {
            InitializeComponent();
            type = "favani";
        }
    }
}
