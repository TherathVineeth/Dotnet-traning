using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requirement2
{
    internal class Car
    {
        private long _id;
        private string _name;
        private string _model;
        private Int32 _makeyear;
        private string _company;
        private Int32 _comfortLevel;
         ArrayList cars = new ArrayList();

        public long Id { get { return _id; } set { _id = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public string Model { get { return _model; } set { _model = value; } }
        public Int32 Makeyear { get { return _makeyear; }
            set
            {
                _makeyear = value;
            }
        }

        public string Company { get { return _company; } set { _company = value; } }
        public Int32 comfortLevel { get {  return _comfortLevel; } set { _comfortLevel = value; } }

        public Car() { }

        public Car(long id, string name, string model, int makeyear, string company, int comfortLevel)
        {
            _id = id;
            _name = name;
            _model = model;
            _makeyear = makeyear;
            _company = company;
            _comfortLevel = comfortLevel;
            cars.Add(this);
            
        }

        public static  Car FindCar(long id)
        {
            foreach (var items in Car)
            {
                if (items.Id == id)
                {
                    return items;
                }
            }
            return null;
        }
    }
}
