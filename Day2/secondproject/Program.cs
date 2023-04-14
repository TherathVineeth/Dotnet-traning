namespace secondproject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the age:");
            int n = int.Parse(Console.ReadLine());
             String ans = Voteelg(n);
            Console.WriteLine(ans);
        }
       public static String Voteelg(int n)
        {
            if (n >= 18)
            {
                return "Eligible";
            }else { return "Not Eligible"; } 
        }
    }
}