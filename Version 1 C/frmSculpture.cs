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

        public void SetDetails(string prName, DateTime prDate, decimal prValue,
                               float prWidth, float prHeight, string prType)
        {
            base.SetDetails(prName, prDate, prValue);
            txtMaterial.Text = Convert.ToString(prWidth);
            txtWeight.Text = Convert.ToString(prHeight);
            txtType.Text = prType;
        }

        public void GetDetails(ref string prName, ref DateTime prDate, ref decimal prValue,
                                       ref float prWidth, ref float prHeight, ref string prType)
        {
            base.GetDetails(ref prName, ref prDate, ref prValue);
            prWidth = Convert.ToSingle(txtMaterial.Text);
            prHeight = Convert.ToSingle(txtWeight.Text);
            prType = txtType.Text;
        }

    }
}

