using System;
using System.Drawing;
using System.Windows.Forms;

namespace FinalProject
{
    internal class clsUpdateControls
    {
        internal static void UpdateStatusBar(StatusStrip stsStatus, string strMessage, Color color)
        {

            // show error in status bar
            stsStatus.Items.Clear();
            stsStatus.Items.Add(strMessage);
            stsStatus.ForeColor = color;
            stsStatus.Update();
        }
    }
}