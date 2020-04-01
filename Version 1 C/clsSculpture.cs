using System;
using System.Windows.Forms;

namespace Version_1_C
{
    [Serializable()] 
    public class ClsSculpture : ClsWork
    {
        public float _Weight;
        public string _Material;

        [NonSerialized()]
        private static frmSculpture sculptureDialog;

        public float Weight { get => _Weight; set => _Weight = value; }
        public string Material { get => _Material; set => _Material = value; }

        public override void EditDetails()
        {
            if (sculptureDialog == null)
            {
                sculptureDialog = new frmSculpture();
            }
            sculptureDialog.SetDetails(this);

        }
        
    }
}
