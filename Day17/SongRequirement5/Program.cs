using SongGroup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requirement5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Song> list = new List<Song>();

            Console.WriteLine("Enter the number of Songs");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string s1 = Console.ReadLine();
                string[] a = s1.Split(',');
                DateTime dt = DateTime.Parse(a[5]);
                Song song = new Song(a[0], a[1], a[2], double.Parse(a[3]), int.Parse(a[4]), dt);
                list.Add(song);
            }
            
            SortedDictionary<String,int> keyValuePairs = new SortedDictionary<String,int>();
            keyValuePairs = Song.CalculateTypeCount(list);
            Console.WriteLine("Songtype \t Count");
            foreach (var item in keyValuePairs)
            {
                Console.WriteLine(item.Key+"\t\t"+item.Value);
            }
            
        }
    }
}
