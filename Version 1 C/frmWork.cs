using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Version_1_C
{
    public partial class frmWork : Form
    {

        public frmWork()
        {
            InitializeComponent();
        }

        public void SetDetails(string prName, DateTime prDate, decimal prValue)
        {
            txtName.Text = prName;
            txtCreation.Text = prDate.ToShortDateString();
            txtValue.Text = Convert.ToString(prValue);
        }

        public void GetDetails(ref string prName, ref DateTime prDate, ref decimal prValue)
        {
            prName = txtName.Text;
            prDate = Convert.ToDateTime(txtCreation.Text);
            prValue = Convert.ToDecimal(txtValue.Text);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (isValid() == true)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
        
        public virtual bool isValid()
        {
            return true;
        }
    
    }
}