using System;
using System.Windows.Forms;

namespace Version_1_C
{
    [Serializable()]
    public class clsPhotograph : clsWork
    {
        private float _Width;
        private float _Height;
        private string _Type;

        [NonSerialized()]
        private static frmPhotograph photographDialog;

        public override void EditDetails()
        {
            if(photographDialog == null)
            {
                photographDialog = new frmPhotograph();
            }
            photographDialog.SetDetails(_Name, _Date, _Value, _Width, _Height, _Type);

            if(photographDialog.ShowDialog() == DialogResult.OK)
            {
                photographDialog.GetDetails(ref _Name, ref _Date, ref _Value, ref _Width, ref _Height, ref _Type);
            }
        }
    }
}
