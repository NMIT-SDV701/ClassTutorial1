using System;

namespace Version_1_C
{
    [Serializable()] 
    public class clsArtist
    {
        private string name;
        private string speciality;
        private string phone;
        
        private decimal theTotalValue;

        private clsWorksList theWorksList;
        private clsArtistList theArtistList;
        
        private static frmArtist artistDialog = new frmArtist();
        private byte sortOrder;

        public clsArtist(clsArtistList prArtistList)
        {
            theWorksList = new clsWorksList();
            theArtistList = prArtistList;
            EditDetails();
        }
        
        public void EditDetails()
        {
            artistDialog.SetDetails(name, speciality, phone, sortOrder, theWorksList, theArtistList);
            if (artistDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                artistDialog.GetDetails(ref name, ref speciality, ref phone, ref sortOrder);
                theTotalValue = theWorksList.GetTotalValue();
            }
        }

        public string GetKey()
        {
            return name;
        }

        public decimal GetWorksValue()
        {
            return theTotalValue;
        }
    }
}
