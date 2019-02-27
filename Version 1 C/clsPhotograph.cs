using System;
using System.Windows.Forms;

namespace Version_1_C
{
    [Serializable()]
    public class clsPhotograph : clsWork
    {
        private float theWidth;
        private float theHeight;
        private string theType;

        [NonSerialized()]
        private static frmPhotograph photoDialog;

        public override void EditDetails()
        {
            if (photoDialog == null)
            {
                photoDialog = new frmPhotograph();
            }
            photoDialog.SetDetails(_Name, theDate, theValue, theWidth, theHeight, theType);
            if (photoDialog.ShowDialog() == DialogResult.OK)
            {
                photoDialog.GetDetails(ref _Name, ref theDate, ref theValue, ref theWidth, ref theHeight, ref theType);
            }
        }
    }
}
