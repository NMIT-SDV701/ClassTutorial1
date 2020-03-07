using System;
//using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Version_1_C
{
    public partial class frmArtist : Form
    {
        public frmArtist()
        {
            InitializeComponent();
        }

        private clsArtistList _ArtistList;
        private clsWorksList _WorksList;
        private byte _SortOrder; // 0 = Name, 1 = Date

        private void UpdateDisplay()
        {
            txtName.Enabled = txtName.Text == "";
            if (_SortOrder == 0)
            {
                _WorksList.SortByName();
                rbByName.Checked = true;
            }
            else
            {
                _WorksList.SortByDate();
                rbByDate.Checked = true;
            }

            lstWorks.DataSource = null;
            lstWorks.DataSource = _WorksList;
            lblTotal.Text = Convert.ToString(_WorksList.GetTotalValue());
        }

        public void SetDetails(string _Name, string _Speciality, string _Phone, 
                               clsWorksList _WorksList, clsArtistList _ArtistList)
        {
            txtName.Text = _Name;
            txtSpeciality.Text = _Speciality;
            txtPhone.Text = _Phone;
            this._ArtistList = _ArtistList;
            this._WorksList = _WorksList;
            _SortOrder = _WorksList.SortOrder;


            UpdateDisplay();
        }

        public void GetDetails(ref string _Name, ref string _Speciality, ref string _Phone)
        {
            _Name = txtName.Text;
            _Speciality = txtSpeciality.Text;
            _Phone = txtPhone.Text;
            _SortOrder = _WorksList.SortOrder;
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _WorksList.DeleteWork(lstWorks.SelectedIndex);
            UpdateDisplay();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _WorksList.AddWork();
            UpdateDisplay();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                DialogResult = DialogResult.OK;
            }
        }

        public virtual Boolean isValid()
        {
            if (txtName.Enabled && txtName.Text != "")
                if (_ArtistList.Contains(txtName.Text))
                {
                    MessageBox.Show("Artist with that name already exists!");
                    return false;
                }
                else
                    return true;
            else
                return true;
        }

        private void lstWorks_DoubleClick(object sender, EventArgs e)
        {
            int _Index = lstWorks.SelectedIndex;
            if (_Index >= 0)
            {
                _WorksList.EditWork(_Index);
                UpdateDisplay();
            }
        }

        private void rbByDate_CheckedChanged(object sender, EventArgs e)
        {
            _SortOrder = Convert.ToByte(rbByDate.Checked);
            UpdateDisplay();
        }

    }
}