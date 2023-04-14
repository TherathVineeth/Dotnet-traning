using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mailclass
{
     class Mail
    {
         
        private long _id;
        public long Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _to;
        public string To
        {
            get { return _to; }
            set { _to = value; }
        }
        private string _from;

        public string From
        {
             get; set;
        }
        private string _subject;

        public string Subject
        {
            get; set;
        }
        private string _content;
        public string Content
        {
            get; set;
        }
        private DateTime _receivedDate;

        public DateTime ReceivedDate
        {
            get; set;
        }
        private double _size;

        public double Size
        {
            get; set;
        }

        public Mail() { }

        public Mail(long id, string to, string from, string subject, string content,  DateTime receivedDate,  double size)
        {
            _id = id;
            _to = to;
            _from = from;
            _subject = subject;
            _content = content;
            _receivedDate = receivedDate;
            _size = size;
        }

        public override string ToString()
        {
            return $"Id:{_id}";
        }
        //public void Display() {

        //    Console.WriteLine($"Id:{_id}");
        //    Console.WriteLine($"To:{_to}");
        //    Console.WriteLine($"From:{_from}");
        //    Console.WriteLine($"Subject:{_subject}");
        //    Console.WriteLine($"Content:{_content}");
        //    Console.WriteLine($"Received:{_receivedDate.ToString("dd-mm-yyyy")}");
        //    Console.WriteLine($"Size:{_size.ToString("00.0")}");
           
        //}
    }
}
