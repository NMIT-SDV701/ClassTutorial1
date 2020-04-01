using System;
using System.Windows.Forms;

namespace Version_1_C
{
    [Serializable()]
    public class ClsPhotograph : ClsWork
    {
        public float _Width;
        public float _Height;
        public string _Type;

        [NonSerialized()]
        private static frmPhotograph photoDialog;

        public float Width { get => _Width; set => _Width = value; }
        public float Height { get => _Height; set => _Height = value; }
        public string Type { get => _Type; set => _Type = value; }

        public override void EditDetails()
        {
            if (photoDialog == null)
            {
                photoDialog = new frmPhotograph();
            }
            photoDialog.SetDetails(this);

        }
        
    }
}
