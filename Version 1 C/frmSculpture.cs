using System;

namespace Version_1_C
{
    public partial class frmSculpture : Version_1_C.frmWork
    {

        
        public frmSculpture()
        {
            InitializeComponent();
        }

        public void SetDetails(
            string prName, 
            DateTime prDate, 
            decimal prValue,
            float prWeight, 
            string prMaterial, 
            string prType)
        {
            base.SetDetails(prName, prDate, prValue);
            txtWeight.Text = Convert.ToString(prWeight);
            txtMaterial.Text = prMaterial;
            txtType.Text = prType;
        }

        public void GetDetails(
            ref string prName, 
            ref DateTime prDate, 
            ref decimal prValue,
            ref float prWeight, 
            ref string prMaterial, 
            ref string prType)
        {
            base.GetDetails(ref prName, ref prDate, ref prValue);
            prWeight = Convert.ToSingle(txtWeight.Text);
            prMaterial = txtMaterial.Text;
            prType = txtType.Text;
        }

    }
}

