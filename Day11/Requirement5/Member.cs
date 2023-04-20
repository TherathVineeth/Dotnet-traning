using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requirement5
{
    internal class Member
    {
        int _sno;
        string _name;
        string _name2;
        string _email;
        string _phonenumber;
        string _accode;
        DateTime _date;
        DateTime _date2;
     //   ArrayList arr = new ArrayList();

        public int Sno
        {
            get { return _sno; }
            set { _sno = value; }
        }
        public string Name
        {
            get { return _name; }
                set { _name = value; }
        }
        public string Name2
        {
            get { return _name2; }
            set { _name2 = value; }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        public string Phonenumber
        {
                get { return _phonenumber; }
            set
            {
                _phonenumber = value;
            }
        }
        public DateTime Date
        {
            get { return _date; }
            set
            {
                _date = value;
            }
        }
        public DateTime Date2 {
            get { return _date2; }
            set
            {
                _date2 = value;
            }
        }

        public Member() { }

        public  Member(int sno, string name,string name2, string email, string phonenumber, string accode)  //, DateTime date, DateTime date2
        {
            _sno = sno;
            _name = name;
            _name2 = name2;
            _email = email;
            _phonenumber = phonenumber;
            _accode = accode;
         //   _date = date;
          //  _date2 = date2;

        //    arr.Add(this);
           
        }

        public override string ToString()
        {
            return string.Format($"{_sno},{_name},{_email},{_phonenumber}");
        }

        public void checking(string email)
        {
            if(email.Contains("@") && ((email.Contains(".com"))||(email.Contains(".org")))) {

                Console.WriteLine("");
            }
            else
            {
                throw new InvalidEmailException(email);
            }
        }
    }
}
