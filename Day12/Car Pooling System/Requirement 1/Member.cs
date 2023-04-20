using Requirement2;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Pooling_System.Requirement_1
{
    internal class Member
    {
        private long _id;
        private string _firstname;
        private string _lastname;
        private string _email;
        private string _contactNumber;
        private string _licensenumber;
        private DateTime _licenseStartDate;
        private DateTime _licenseExpiryDate;
        private ArrayList members = new ArrayList(); 
        private ArrayList carList = new ArrayList();
       

        public long Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Firstname
        {
            get { return _firstname; }
                set { _firstname = value; }
        }
        public string Lastname
        {
            get { return _lastname; }
            set
            {
                _lastname = value;
            }
        }
        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;
            }
        }
        public string ContactNumber
        {
            get { return _contactNumber; }
            set
            {
                _contactNumber = value;
            }
        }
        public string LicenseNumber
        {
            get { return _licensenumber; }
        }
        public DateTime LicenseStartDate
        {
                get { return _licenseStartDate; }
            set
            {
                _licenseStartDate = value;
            }
        }
        public DateTime LicenseExpiryDate
        {
                get { return _licenseExpiryDate; }
            set
            {
                _licenseExpiryDate = value;
            }
        }

        public Member() { }

        public Member(long id, string firstname, string lastname, string email, string contactNumber, string licensenumber, DateTime licenseStartDate, DateTime licenseExpiryDate   )
        {
            _id = id;
            _firstname = firstname;
             _lastname = lastname;
            _email = email;
            _contactNumber = contactNumber;
            _licensenumber = licensenumber;
           _licenseStartDate = licenseStartDate;
            _licenseExpiryDate= licenseExpiryDate;
            members.Add( this );
           
        }
        public override string ToString()
        {
            return String.Format($"Member:{_firstname},{_lastname}\n" +
                $"Member contact details:{_contactNumber},{_email}");
        }
        public override bool Equals(object obj)
        {
            Member member = obj as Member;
           if(_email.ToLower() == member._email.ToLower() && _contactNumber.ToLower() == member._contactNumber.ToLower())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //public static Member FindMember(long id)
        //{
        //    foreach(Member member in members)
        //    {
        //        if(member.Id == id)
        //        {
        //            return member;
        //        }
                
        //    }
        //   return null;
        //}
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
