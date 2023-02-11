using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Esrefly.Gui.GuiHome
{
    public partial class Home_UserControl : UserControl
    {
        private static Home_UserControl _Home_UserContro;
        public Home_UserControl()
        {
            InitializeComponent();
        }
        public static Home_UserControl Instance()
        {
            return _Home_UserContro ??(new Home_UserControl());
        }
    }
}
