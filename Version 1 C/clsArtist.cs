using System;

namespace Version_1_C
{
    [Serializable()] 
    public class ClsArtist
    {
        private string _Name;
        private string _Speciality;
        private string _Phone;
        
        private decimal TotalValue;

        private clsWorksList _WorksList;
        private ClsArtistList _ArtistList;

        // All forms should be singletons, right?

        private static frmArtist artistDialog = new frmArtist();

        public string Name { get => _Name; set => _Name = value; }
        public string Speciality { get => _Speciality; set => _Speciality = value; }
        public string Phone { get => _Phone; set => _Phone = value; }
        public decimal _TotalValue { get => TotalValue; }
        public ClsArtistList ArtistList { get => _ArtistList; }
        public clsWorksList WorksList { get => _WorksList; }

        public ClsArtist(ClsArtistList _ArtistList)
        {
            _WorksList = new clsWorksList();
            this._ArtistList = _ArtistList;
            EditDetails();
        }
        
        public void EditDetails()
        {
            artistDialog.SetDetails(this);
            TotalValue = _WorksList.GetTotalValue();
        
        }

    }
}
