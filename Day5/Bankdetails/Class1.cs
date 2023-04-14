using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locker
{
       public class Locker
    {
        private string _lockType;                   //feild
        private string _password;
        private int _number;
        double _amount;
        DateTime _lastOpened;
        public Locker(int _number , string _lockType , string _password,double _amount,DateTime _lastOpened) {
        
            this._number = _number;
            this._lockType = _lockType;
            this._password = _password;
            this._amount = _amount;
            this._lastOpened = _lastOpened;
        }
        public static Locker CreateLocker(string details)
        {
            return details;
        }
        

    }
    public class Bank
    {
        public void AddLockerToBank()
        {

        }  
    }
   
}
