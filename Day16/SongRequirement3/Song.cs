using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongGroup
{
    internal class Song
    {
        List<Song> list = new List<Song>();
        private string _name;
        public string Name { get { return _name; } set { _name = value; } }
        private string _artist;
        public string Artist { get { return _artist; } set { _artist = value; } }

        private string _songType;
        public string SongType
        {
            get { return _songType; }
            set { _songType = value; }
        }

        private double _rating;
        public double Rating
        {
            get { return _rating; }
            set { _rating = value; }
        }

        private int _numberOfDownloads;
        public int NumberOfDownloads
        {
            get { return _numberOfDownloads; }
            set { _numberOfDownloads = value; }
        }

        private DateTime _dateDownloaded;

        public DateTime DateDownloaded
        {
            get { return _dateDownloaded; }
            set
            {
                _dateDownloaded = value;
            }
        }
       

        public Song() { }

        public Song(string name,  string artist, string songType,double rating, int numberOfDownloads,  DateTime dateDownloaded)
        {
            _name = name;
            _artist = artist;
            _songType = songType;
            _rating = rating;
            _numberOfDownloads = numberOfDownloads;
            _dateDownloaded = dateDownloaded;
            list.Add(this);
        
        }

        public override string ToString()
        {
            return string.Format($"Name: {_name}\nArtist: {_artist}\nSongType: {_songType}\nRating: {_rating}\nNumberOfDownloads: {_numberOfDownloads}\nDate Download {_dateDownloaded.ToString("dd-MM-yyyy")}");
        }

        //public bool Equals(Song other)
        //{
        //    Song obj = other as Song;
        //    if(obj._name == Name && obj._artist == Artist && obj._songType == SongType)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
    }
}
