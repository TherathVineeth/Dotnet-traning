using SongGroup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongReq2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Song> list = new List<Song>();
            Console.WriteLine("Enter the Play list name ");
            string s = Console.ReadLine();
            PlayList playList = new PlayList(s,list);
            bool a=true;
            do
            {
                
                Console.WriteLine("1.Add Song \n2.Remove Song\n3.Display\n4.Exit");
                Console.WriteLine("Enter the choice");
                int n = int.Parse(Console.ReadLine());
               
                
                switch(n)
                {
                    case 1:
                        Console.WriteLine("Enter the Number of Songs:");
                        int n1 = int.Parse(Console.ReadLine());
                        for(int i = 0; i < n1; i++)
                        {
                            Console.WriteLine("Enter song " + (i + 1) + "details");
                            string sc = Console.ReadLine();
                            Song song = new Song();
                            song = Song.CreateSong(sc);
                            list.Add(song);
                          // PlayList playList1 = new PlayList();
                            playList.AddSongToPlaylist(song);
                            
                        }
                        break;
                    case 2:
                        Console.WriteLine("Enter the name of the song to be deleted");
                        string sc1 = Console.ReadLine() ;
                       
                       bool ans = playList.RemoveSongFromPlaylist(sc1);
                        if (ans)
                        {
                            Console.WriteLine("Song deleted sucessfully");
                        }
                        else
                        {
                            Console.WriteLine("No song in that name");
                        }
                        break;

                   case 3:
                        if(list.Count > 0)
                        {
                            
                            playList.DisplaySongs();
                        }
                        else
                        {
                            Console.WriteLine("No song to show");
                        }
                        break;
                   case 4:
                        a = false;
                        break;
                }
            } while (a);
        }
    }
}
