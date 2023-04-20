using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requirement4
{
    abstract class Car
    {
        private long _id;

        private string _name;
        public long Id
        {
            get

            {  return _id; }

            set { _id = value; }

        }

        public string Name

        {

            get

            {

                return _name;

            }

            set

            { _name = value;}

        }

        public Car(){ }

        public Car(long id, string name){

            _id = Id;
            _name = Name;
        }

        public abstract double CalculateDriveCost(double km);
    }
}
