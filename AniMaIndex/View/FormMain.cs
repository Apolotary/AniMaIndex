using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AniMaIndex
{
    public partial class FormMain : Form
    {
        private static FormMain _instance;

        // this instance is used to avoid
        // creating new window every time
        // when new control is loaded
        public static FormMain Instance()
        {
            if (_instance == null)
                _instance = new FormMain();

            return _instance;
        }

        public FormMain()
        {
            InitializeComponent();
        }
        
        // closes prev. control and adds new control
        public void ChangeControl(UserControl control)
        {
            this.Controls.Clear();
            control.Location = new Point(0, 0);
            this.Controls.Add(control);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            ControlWelcome mc1 = new ControlWelcome();
            mc1.Location = new Point(0, 0);
            this.Controls.Add(mc1);
        }

        private void FormMain_Load_1(object sender, EventArgs e)
        {

        }
    }
}
