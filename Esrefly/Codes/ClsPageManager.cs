using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Windows.Forms;

namespace Esrefly.Codes
{
    class ClsPageManager
    {
        private readonly Main main;

        public ClsPageManager(Main main)
        {
            this.main = main;
        }
        public void LoadPage(UserControl PageuserControl)
        {
            //Load Old Page
            var oldpage = main.panelContainer.Controls.OfType<UserControl>().FirstOrDefault();
            if (oldpage!=null)
            {
                main.panelContainer.Controls.Remove(oldpage);
                oldpage.Dispose();
            }
            //Load New Page
            PageuserControl.Dock = DockStyle.Fill;
            main.panelContainer.Controls.Add(PageuserControl);
        }
    }
}
