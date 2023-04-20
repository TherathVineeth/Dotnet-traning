using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requirement3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1,Valid Car registration Number");
            Console.WriteLine("2,Convert Driving Licence");
            Console.WriteLine("Enter the choice:");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {

                case 1: Console.WriteLine("Enter the registration number:");
                     string carRegNumber = Console.ReadLine();
                    if (IsValideCarRegistrationNumber(carRegNumber))
                    {
                        Console.WriteLine(carRegNumber + "is Valid");
                    }
                    else
                    {
                        Console.WriteLine(carRegNumber + "is Invalid");
                    }
                    break;

                    case 2: Console.WriteLine("Enter car registration number:");
                            string CarRegNumberConvert = Console.ReadLine();
                    string convertedCarRegNumber = convertedCarNumber(CarRegNumberConvert);
                    Console.WriteLine(convertedCarRegNumber);
                    break;

                    case 3: Console.WriteLine("Enter driving licence issue date (dd-mm-yyyy):");
                    DateTime issue = DateTime.ParseExact(Console.ReadLine(), "dd-mm-yyyy", null);
                    if(IsValideDrivingLicence(issue))
                    {
                        Console.WriteLine((DateTime.Now.Year - issue.Year)+"Year old licence- expaired");
                    }
                    else
                    {
                        Console.WriteLine((DateTime.Now.Year - issue.Year) + "Year old licence- valid");
                    }
                    break;





            }
        }

        private static bool IsValideDrivingLicence(DateTime issue)
        {
            DateTime curr = DateTime.Now;
            DateTime exp = issue.AddYears(10);
            return curr> exp;
        }

        private static string convertedCarNumber(string carRegNumberConvert)
        {
            return carRegNumberConvert.Replace('@','-').Replace('*','-').ToUpper();
        }

        private static bool IsValideCarRegistrationNumber(string carRegNumber)
        {
            string pattern = @"^[A-Z]{2}-\d{2}-[A-Z]{2}-\d{4}$";
            return System.Text.RegularExpressions.Regex.IsMatch(pattern, carRegNumber);
        }
    }
}
