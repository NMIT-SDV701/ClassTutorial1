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

        public virtual void SetDetails(string prName, DateTime prDate, decimal prValue,
                                       float prWeight, string prMaterial)
        {
            base.SetDetails(prName, prDate, prValue);
            txtWeight.Text = Convert.ToString(prWeight);
            txtMaterial.Text = prMaterial;
        }

        public virtual void GetDetails(ref string prName, ref DateTime prDate, ref decimal prValue,
                                       ref float prWeight, ref string prMaterial)
        {
            base.GetDetails(ref prName, ref prDate, ref prValue);
            prWeight = Convert.ToSingle(txtWeight.Text);
            prMaterial = txtMaterial.Text;
        }
    }
}

