using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Version_1_C
{
    public partial class frmMain : Form
    {
        /// <summary>
        /// Matthias Otto, NMIT, 2010-2016
        /// </summary>
        public frmMain()
        {
            InitializeComponent();
        }

        private clsArtistList _ArtistList = new clsArtistList();
        

        private void UpdateDisplay()
        {
            string[] _DisplayList = new string[_ArtistList.Count];

            lstArtists.DataSource = null;
            _ArtistList.Keys.CopyTo(_DisplayList, 0);
            lstArtists.DataSource = _DisplayList;
            lblValue.Text = Convert.ToString(_ArtistList.GetTotalValue());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _ArtistList.NewArtist();
            UpdateDisplay();
        }

        private void lstArtists_DoubleClick(object sender, EventArgs e)
        {
            string _Key;

            _Key = Convert.ToString(lstArtists.SelectedItem);
            if (_Key != null)
            {
                _ArtistList.EditArtist(_Key);
                UpdateDisplay();
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            _ArtistList.Save();
            Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string _Key;

            _Key = Convert.ToString(lstArtists.SelectedItem);
            if (_Key != null)
            {
                lstArtists.ClearSelected();
                _ArtistList.Remove(_Key);
                UpdateDisplay();
            }
        }

       

        private void frmMain_Load(object sender, EventArgs e)
        {
            _ArtistList = clsArtistList.Retrieve();
            UpdateDisplay();
        }
    }
}