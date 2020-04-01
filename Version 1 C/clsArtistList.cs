using System;
using System.Collections;
using System.Windows.Forms;

namespace Version_1_C
{
    [Serializable()] 
    public class ClsArtistList : SortedList
    {
        private const string _FileName = "gallery.xml";

        public void EditArtist(string _Key)
        {
            ClsArtist _Artist;
            _Artist = (ClsArtist)this[_Key];
            if (_Artist != null)
                _Artist.EditDetails();
            else
                MessageBox.Show("Sorry no artist by this name");
        }
       
        public void NewArtist()
        {
            ClsArtist _Artist = new ClsArtist(this);
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
            foreach (ClsArtist _Artist in Values)
            {
                _Total += _Artist.GetWorksValue();
            }
            return _Total;
        }

        public void Save()
        {
            try
            {
                System.IO.FileStream _FileStream = new System.IO.FileStream(_FileName, System.IO.FileMode.Create);
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

        public static ClsArtistList Retrieve()
        {
            ClsArtistList lcArtistList;
            try
            {
                System.IO.FileStream _FileStream = new System.IO.FileStream(_FileName, System.IO.FileMode.Open);
                System.Runtime.Serialization.Formatters.Soap.SoapFormatter _Formatter =
                    new System.Runtime.Serialization.Formatters.Soap.SoapFormatter();

                lcArtistList = (ClsArtistList)_Formatter.Deserialize(_FileStream);

                _FileStream.Close();
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message, "File Retrieve Error");
                lcArtistList = new ClsArtistList();
            }

            return lcArtistList;
        }
    }
}
