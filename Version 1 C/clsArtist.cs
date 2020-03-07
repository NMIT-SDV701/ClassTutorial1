using System;

namespace Version_1_C
{
    [Serializable()] 
    public class clsArtist
    {
        private string Name;
        private string Speciality;
        private string Phone;
       
        
        private decimal _TotalValue;

        private clsWorksList _WorksList;
        private clsArtistList _ArtistList;
        
        private static frmArtist artistDialog = new frmArtist();
        

        public clsArtist(clsArtistList _ArtistList)
        {
            _WorksList = new clsWorksList();
            this._ArtistList = _ArtistList;
            EditDetails();
        }
        
        public void EditDetails()
        {
            artistDialog.SetDetails(Name, Speciality, Phone, _WorksList, _ArtistList);
            if (artistDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                artistDialog.GetDetails(ref Name, ref Speciality, ref Phone);
                _TotalValue = _WorksList.GetTotalValue();
            }
        }

        public string GetKey()
        {
            return Name;
        }

        public decimal GetWorksValue()
        {
            return _TotalValue;
        }
    }
}
