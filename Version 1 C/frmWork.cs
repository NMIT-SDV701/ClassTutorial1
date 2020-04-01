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

        public void SetDetails(string _Name, DateTime _Date, decimal _Value)
        {
            txtName.Text = _Name;
            txtCreation.Text = _Date.ToShortDateString();
            txtValue.Text = Convert.ToString(_Value);
        }

        public void GetDetails(ref string _Name, ref DateTime _Date, ref decimal _Value)
        {
            _Name = txtName.Text;
            _Date = Convert.ToDateTime(txtCreation.Text);
            _Value = Convert.ToDecimal(txtValue.Text);
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