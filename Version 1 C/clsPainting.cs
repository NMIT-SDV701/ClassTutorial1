using System;
using System.Windows.Forms;

namespace Version_1_C
{
    [Serializable()] 
    public class ClsPainting : ClsWork
    {
        public float _Width;
        public float _Height;
        public string _Type;

        [NonSerialized()]
        private static frmPainting paintDialog;

        public float Width { get => _Width; set => _Width = value; }
        public float Height { get => _Height; set => _Height = value; }
        public string Type { get => _Type; set => _Type = value; }

        public override void EditDetails()
        {
            if (paintDialog == null)
            {
                paintDialog = new frmPainting();
            }
            paintDialog.SetDetails(this);

        }
    }
}
