using SongGroup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SongReq2
{
    internal class PlayList
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private List<Song> _songList; 
        public List<Song> SongList
        {
            get { return _songList; }
            set { _songList = value; }
        }

        public PlayList() { }

        public PlayList(string name,List<Song> songlist) {
            _name = name;
            _songList = songlist;
        
        }
        public override string ToString()
        {
            return string.Format("name");
        }

        public void AddSongToPlaylist(Song song)
        {
               SongList.Add(song);
        }
        public bool RemoveSongFromPlaylist(string name)
        {
            int count = 0;
            foreach (var item in SongList)
            {
                
                if (item.Name == name)
                {
                    SongList.Remove(item);
                    count++;
                }
            }
            if(count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void DisplaySongs()
        {
            foreach(var song in SongList)
            {
                Console.WriteLine(song);
            }
           
        }
    }
}
