using SongGroup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace song_req_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Song> list = new List<Song>();

            Console.WriteLine("Enter the number of Songs");
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                string s1 = Console.ReadLine();
                string[] a = s1.Split(',');
                DateTime dt = DateTime.Parse(a[5]);
                Song song = new Song(a[0], a[1], a[2], double.Parse(a[3]), int.Parse(a[4]), dt);
                list.Add(song);
            }
            Console.WriteLine("Enter a search type");
            Console.WriteLine("1.Song Type\n2.Date of Download\n3.Rating");
            int n1  = int.Parse(Console.ReadLine());
            switch(n1)
            {
                case 1:
                    Console.WriteLine("Enter the type");
                    string s2 = Console.ReadLine();
                    List<Song> l = new List<Song>();
                    SongBO songBO = new SongBO();
                   l = songBO.FindSong(list, s2);
                    Console.WriteLine("Name : \t  Artist \t type");
                    foreach( var item in l )
                    {
                        Console.WriteLine($"{item.Name}\t {item.Artist} \t {item.SongType}");
                    }
                    break;
              case 2:
                    Console.WriteLine("Enter the date");
                    DateTime n3 = DateTime.Parse(Console.ReadLine());
                    SongBO song = new SongBO();
                    song.FindSong(list, n3);
                    break;
             case 3:
                    Console.WriteLine("Enter the rating:");
                    double s = double.Parse(Console.ReadLine());
                    SongBO sBO = new SongBO();
                    sBO.FindSong(list, s);
                    break;
            default: Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}
