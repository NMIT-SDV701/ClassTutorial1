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

        protected override void updateForm()
        {
            base.updateForm();
            ClsSculpture lcWork = (ClsSculpture)_Work;
            txtWeight.Text = lcWork.Weight.ToString();
            txtMaterial.Text = lcWork.Material;
        }

        protected override void pushData()
        {
            base.pushData();
            ClsSculpture lcWork = (ClsSculpture)_Work;
            lcWork.Weight = Single.Parse(txtWeight.Text);
            lcWork.Material = txtMaterial.Text;
        }

    }
}

