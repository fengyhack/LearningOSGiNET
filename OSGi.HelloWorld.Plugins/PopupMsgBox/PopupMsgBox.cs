using System.Windows.Forms;
using UIShell.OSGi;

namespace PopupMsgBoxPlugin
{
    public class PopupMsgBox:IBundleActivator
    {
        public void Start(IBundleContext context)
        {
           MessageBox.Show("<Start> Hello World!","MsgBox");
        }

        public void Stop(IBundleContext context)
        {
            MessageBox.Show("<Stop> See you.","MsgBox");
        }
    }
}
