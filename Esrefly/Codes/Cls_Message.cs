using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Esrefly.Properties;

namespace Esrefly.Codes
{
    public static class Cls_Message
    {
        //Message
        public static void ShowEmptyMessage()
        {
            MessageBox.Show(Resources.EmptyMessageText, Resources.EmptyMessageCaption,
                MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        //Dialog
    }
}
