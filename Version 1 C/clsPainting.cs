using System;
using System.Windows.Forms;

namespace Version_1_C
{
    [Serializable()] 
    public class clsPainting : clsWork
    {
        private float theWidth;
        private float theHeight;
        private string theType;

        [NonSerialized()]
        private static frmPainting paintDialog;

        public override void EditDetails()
        {
            if (paintDialog == null)
            {
                paintDialog = new frmPainting();
            }
            paintDialog.SetDetails(_Name, theDate, theValue, theWidth, theHeight, theType);
            if(paintDialog.ShowDialog() == DialogResult.OK)
            {
               paintDialog.GetDetails(ref _Name, ref theDate, ref theValue, ref theWidth, ref theHeight, ref theType);
            }
        }
    }
}
