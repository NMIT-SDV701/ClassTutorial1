using System;
using System.Collections;
using System.Windows.Forms;

namespace Version_1_C
{
    [Serializable()] 
    public class clsArtistList : SortedList
    {
        private const string _fileName = "gallery.xml";
        public void EditArtist(string prKey)
        {
            clsArtist _Artist;
            _Artist = (clsArtist)this[prKey];
            if (_Artist != null)
                _Artist.EditDetails();
            else
                MessageBox.Show("Sorry no artist by this name");
        }
       
        public void NewArtist()
        {
            clsArtist _Artist = new clsArtist(this);
            try
            {
                if (_Artist.GetKey() != "")
                {
                    Add(_Artist.GetKey(), _Artist);
                    MessageBox.Show("Artist added!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Duplicate Key!");
            }
        }
        
        public decimal GetTotalValue()
        {
            decimal _Total = 0;
            foreach (clsArtist lcArtist in Values)
            {
                _Total += lcArtist.GetWorksValue();
            }
            return _Total;
        }

        public void Save()
        {
            try
            {
                System.IO.FileStream _FileStream = new System.IO.FileStream(_fileName, System.IO.FileMode.Create);
                System.Runtime.Serialization.Formatters.Soap.SoapFormatter _Formatter =
                    new System.Runtime.Serialization.Formatters.Soap.SoapFormatter();

                _Formatter.Serialize(_FileStream, this);
                _FileStream.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "File Save Error");
            }
        }

        public static clsArtistList Retrieve()
        {
            clsArtistList lcArtistList;
            try
            {
                System.IO.FileStream _FileStream = new System.IO.FileStream(_fileName, System.IO.FileMode.Open);
                System.Runtime.Serialization.Formatters.Soap.SoapFormatter _Formatter =
                    new System.Runtime.Serialization.Formatters.Soap.SoapFormatter();

                lcArtistList = (clsArtistList)_Formatter.Deserialize(_FileStream);
                _FileStream.Close();
            }

            catch (Exception e)
            {
                lcArtistList = new clsArtistList();
                MessageBox.Show(e.Message, "File Retrieve Error");
            }

            return lcArtistList;
        }




    }

}
