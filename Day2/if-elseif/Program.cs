namespace if_elseif
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int n = int.Parse(Console.ReadLine());
            String ans = Prime(n);
            Console.WriteLine(ans);
        }

        private static string Prime(int n)
        {
           if(n == 0)
            {
                return "Number is null";
            }
            else if(n/2==0)
            {
                return "prime number";
            }
            else
            {
                return "not an prime number";
            }
        }
    }
}