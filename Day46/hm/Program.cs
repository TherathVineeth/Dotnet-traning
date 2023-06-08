namespace hm
{
    internal class Program
    {
        static void Main(string[] args)
       {
            Console.WriteLine("Enter the row");
            int n = int.Parse(Console.ReadLine());
            int s = n, st = n;

            for(int i = 0; i < n; i++)
            {
                for(int j = 1; j <= s-1; j++)
                {
                    Console.Write(" ");
                }
                for (int k = s-1; k < st ; k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
                s--;
            }
        }
    }
}