namespace forloop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number to count");
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}