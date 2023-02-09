using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Esrefly.Gui.GuiHome
{
    public partial class Home_UserContro : UserControl
    {
        private static Home_UserContro _Home_UserContro;
        public Home_UserContro()
        {
            InitializeComponent();
        }
        public static Home_UserContro Instance()
        {
            return _Home_UserContro ??(new Home_UserContro());
        }
    }
}
