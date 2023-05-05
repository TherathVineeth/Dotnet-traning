using SongReq2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongGroup
{
    internal class Song
    {
        List<Song> ls = new List<Song>();
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
            ls.Add(this);
        
        }

        public override string ToString()
        {
            return string.Format($"Name\tArtist\tSongType\tRating\tNumberOfDownloads\tDate Download\n {_name}\t{_artist}\t{_songType}\t{_rating}\t{_numberOfDownloads}\t {_dateDownloaded.ToString("dd-MM-yyyy")}");
        }

        public static Song CreateSong(string song)
        {
            string[] a = song.Split(',');
            DateTime dt = DateTime.Parse(a[5]);
            Song song1 = new Song(a[0], a[1], a[2], double.Parse(a[3]), int.Parse(a[4]), dt);
            return song1;
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
