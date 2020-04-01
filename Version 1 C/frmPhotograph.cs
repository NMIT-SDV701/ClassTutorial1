using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Version_1_C
{
    public partial class frmPhotograph : Version_1_C.frmWork
    {

        public frmPhotograph()
        {
            InitializeComponent();
        }

        public void SetDetails(string _Name, DateTime _Date, decimal _Value,
                                       float _Width, float _Height, string _Type)
        {
            base.SetDetails(_Name, _Date, _Value);
            txtWidth.Text = Convert.ToString(_Width);
            txtHeight.Text = Convert.ToString(_Height);
            txtType.Text = _Type;
        }

        public void GetDetails(ref string _Name, ref DateTime _Date, ref decimal _Value,
                                       ref float _Width, ref float _Height, ref string _Type)
        {
            base.GetDetails(ref _Name, ref _Date, ref _Value);
            _Width = Convert.ToSingle(txtWidth.Text);
            _Height = Convert.ToSingle(txtHeight.Text);
            _Type = txtType.Text;
        }
    }
}

