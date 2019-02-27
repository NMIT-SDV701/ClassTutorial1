using System;
using System.Windows.Forms;

namespace Version_1_C
{
    [Serializable()] 
    public class clsSculpture : clsWork
    {
        private float theWeight;
        private string theMaterial;

        [NonSerialized()]
        private static frmSculpture sculptDialog;

        public override void EditDetails()
        {
            if (sculptDialog == null)
            {
                sculptDialog = new frmSculpture();
            }
            sculptDialog.SetDetails(_Name, theDate, theValue, theWeight, theMaterial);
            if (sculptDialog.ShowDialog() == DialogResult.OK)
            {
                sculptDialog.GetDetails(ref _Name, ref theDate, ref theValue, ref theWeight, ref theMaterial);
            }
        }
    }
}
