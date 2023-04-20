using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requirement4
{
    internal class sedan
    {
        class Sedan : Car

        {

            private bool _absEnabled;

            private Int32 _bootspace;

            public bool AbsEnabled

            {

                get

                {

                    return _absEnabled;

                }

                set

                {

                    _absEnabled = value;

                }

            }

            public Int32 Bootspace

            {

                get

                {

                    return _bootspace;

                }

                set

                {

                    _bootspace = value;

                }

            }

            public Sedan()

            {

            }

            public Sedan(long id, string name, bool absEnabled, int bootspace) : base(id, name)

            {

                _absEnabled = absEnabled;

                _bootspace = bootspace;

            }

            public override double CalculateDriveCost(double km)
            {
                throw new NotImplementedException();
            }
        }
    }
}
