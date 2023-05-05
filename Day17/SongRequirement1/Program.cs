using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongGroup
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Song> list = new List<Song>();
            for (int i =0 ; i < 2 ; i++)
            {
                Console.WriteLine($"Enter song {i+1} detail:");
                string s1 = Console.ReadLine();
                string[] a = s1.Split(',');
                DateTime dt = DateTime.Parse(a[5]);
                Song song = new Song(a[0], a[1], a[2], double.Parse(a[3]), int.Parse(a[4]),dt );
                list.Add(song);
            }
            foreach (Song s in list)
            {
                Console.WriteLine(s.ToString());
            }
            if (list[0].Equals(list[1]) )
            {
                Console.WriteLine("Song 1 is same as Song 2");
            }
            else
            {
                Console.WriteLine("Song 1 and Song 2 are different");
            }
        }
    }
}
