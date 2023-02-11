using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Esrefly.Codes;


namespace Esrefly
{
    public partial class Main : Form
    {
        private readonly ClsPageManager clsPageManager;
        public Main()
        {
            InitializeComponent();
            clsPageManager = new ClsPageManager(this);
            //Load HomePage
            clsPageManager.LoadPage(Gui.GuiHome.Home_UserControl.Instance());
        }
        #region
        private void btnMain_Click(object sender, EventArgs e)
        {
            clsPageManager.LoadPage( Gui.GuiHome.Home_UserControl.Instance());
        }
        #endregion
    }

}
