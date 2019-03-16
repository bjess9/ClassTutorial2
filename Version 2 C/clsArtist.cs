using System;
using System.Collections.Generic;

namespace Version_2_C
{
    [Serializable()]
    public class clsArtist
    {
        private string _Name;
        private string _Speciality;
        private string _Phone;

        //private decimal _TotalValue;

        private clsWorksList _WorksList;
        private clsArtistList _ArtistList;

        //private static frmArtist _ArtistDialog = new frmArtist();

        public clsArtist() { }

        public clsArtist(clsArtistList prArtistList)
        {
            _WorksList = new clsWorksList();
            ArtistList = prArtistList;
            //EditDetails();
        }

        //public void EditDetails()
        //{
        //    _ArtistDialog.SetDetails(this);
        //    _TotalValue = _WorksList.GetTotalValue();
        //}
        public void NewArtist()
        {
            if (!string.IsNullOrEmpty(Name))
                ArtistList.Add(Name, this);
            else
                throw new Exception("No artist name entered");
        }


        public bool IsDuplicate(string prArtistName)
        {
            return ArtistList.ContainsKey(prArtistName);
        }

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public string Speciality
        {
            get { return _Speciality; }
            set { _Speciality = value; }
        }

        public string Phone
        {
            get { return _Phone; }
            set { _Phone = value; }
        }

        //public decimal TotalValue
        //{
        //    get { return _TotalValue; }

        //}

        public clsWorksList WorksList
        {
            get { return _WorksList; }
        }

        public clsArtistList ArtistList { get => _ArtistList; set => _ArtistList = value; }
    }
}
