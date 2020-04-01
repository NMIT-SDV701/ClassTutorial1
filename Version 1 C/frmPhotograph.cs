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

        protected override void updateForm()
        {
            base.updateForm();
            ClsPhotograph lcWork = (ClsPhotograph)_Work;
            txtWidth.Text = lcWork.Width.ToString();
            txtHeight.Text = lcWork.Height.ToString();
            txtType.Text = lcWork.Type;

        }

        protected override void pushData()
        {
            base.pushData();
            ClsPhotograph lcWork = (ClsPhotograph)_Work;
            lcWork.Width = Single.Parse(txtWidth.Text);
            lcWork.Height = Single.Parse(txtHeight.Text);
            lcWork.Type = txtType.Text;
        }

    }
}

