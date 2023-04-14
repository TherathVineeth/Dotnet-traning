using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Bank_application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice , id , id1;
            string name;
            double depositamount , dep ;
            Accountcreation a1 = null;
            do
            {
                Console.WriteLine("///////////////************************WELCOME*******************///////////////////");
                Console.WriteLine("            $ To create an account press number one");
                Console.WriteLine("            $ To check the balence press number two");
                Console.WriteLine("            $ To check account details press number three");
                Console.WriteLine("            $ To add money to the account press number four ");
                Console.WriteLine("            $ To exit press number zero");
                Console.WriteLine("               Enter your choice ");
                choice = int.Parse(Console.ReadLine());

           
               switch (choice)
            {
                case 0:
                    break;
                case 1:
                    Console.WriteLine("Enter the id");
                    id = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the name of account holder");
                    name = Console.ReadLine();
                    Console.WriteLine("Enter the deposit amount ");
                    depositamount = double.Parse(Console.ReadLine());
                       a1 = new Accountcreation(id,name,depositamount);
                    Console.WriteLine("**** YOUR ID DETAILS ARE  ****");
                        Console.WriteLine($"The name of the account holder is : {a1.Aname}");
                        Console.WriteLine($"The id number of the account is : {a1.Aid}");
                    break;
                case 2:
                          Console.WriteLine("Enter the account id");
                          id1 = int.Parse(Console.ReadLine());
                          a1.Balence(id1);
                        break;
                case 3:
                        Console.WriteLine("Enter the account id");
                        id1 = int.Parse(Console.ReadLine());
                        a1.Display(id1);
                        break;
                case 4:
                        Console.WriteLine("Enter the account id");
                        id1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the amount to be deposite");
                        dep = double.Parse(Console.ReadLine());
                        break;
                default: Console.WriteLine("Sorry wrong choice please enter correct number ");
                        break;


            }
            }
            while (choice != 0) ;




        }

       
    }
}
