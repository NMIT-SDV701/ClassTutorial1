using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Version_1_C
{
    public partial class frmSculpture : Version_1_C.frmWork
    {

        
        public frmSculpture()
        {
            InitializeComponent();
        }

        public void SetDetails(string _Name, DateTime _Date, decimal _Value, float _Weight, string _Material)
        {
            base.SetDetails(_Name, _Date, _Value);
            txtWeight.Text = Convert.ToString(_Weight);
            txtMaterial.Text = _Material;
        }

        public void GetDetails(ref string _Name, ref DateTime _Date, ref decimal _Value, ref float _Weight, ref string _Material)
        {
            base.GetDetails(ref _Name, ref _Date, ref _Value);
            _Weight = Convert.ToSingle(txtWeight.Text);
            _Material = txtMaterial.Text;

        }
    }
}

