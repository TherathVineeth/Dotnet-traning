using Antlr.Runtime;
using GSF.Net.Smtp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mail_folder_Application
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Enter the name of the folder");
            List<Mail> li = new List<Mail>();
            string name = Console.ReadLine();
            MailFolder mf = new MailFolder(name,li);
            Mail mail = new Mail();
            bool the = true;
           

            do
            {
                Console.WriteLine("1.Add Mail\n2.Delete Mail\n3.Display Mail\n4.Exit\nEnter your choice:");

                int ans = int.Parse(Console.ReadLine());

                switch (ans)
                {
                    case 1: Console.WriteLine("Enter the details of mail in CVS format:");
                     string s = Console.ReadLine();
                        mail = Mail.CreateMail(s);
                        mf.AddMailToFolder(mail); 
                       Console.WriteLine("Mail Successfully added");
                        break;
                    case 2: Console.WriteLine("Enter the id of the mail to be deleted");
                        long ln = long.Parse(Console.ReadLine());
                        if (mf.RemoveMailFromFolder(ln))
                        {
                            Console.WriteLine("Mail successfully deleted");
                        }
                        else
                        {
                            Console.WriteLine("Mail not found in the folder");
                        }
                        break;
                    case 3:
                        mf.DisplayMails();
                        break;
                    case 4:
                        the= false;
                        break;
                    
                }
            }while (the);
            
        }

       
    }
}
