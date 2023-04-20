using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requirement2
{
    internal class MemberCar
    {
        long _id;
        string _member;
        string _car;
        string _carRegistrationNumber;
        string _carColor;

        public long Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Member
        {
            get { return _member; }
            set { _member = value; }
        }
        public string Car
        {
            get { return _car; }
            set { _car = value; }
        }
        public string CarRegistrationNumber
        {
            get { return _carRegistrationNumber; }
            set
            {
                _carRegistrationNumber = value;
            }
        }
        public string CarColor
        {
            get { return _carColor; }
            set
            {
                _carColor = value;
            }
        }
        public MemberCar() { }

        public MemberCar(long id, string member, string car, string carRegistrationNumber,  string carColor)
        {
            _id = id;
            _member = member;
            _car = car;
            _carRegistrationNumber = carRegistrationNumber;
            _carColor = carColor;
            
        }



        public static MemberCar FindMember(long id)
        {
           
        }
    }
}
