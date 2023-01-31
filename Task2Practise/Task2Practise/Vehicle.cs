using System;
using System.Collections.Generic;
using System.Text;

namespace Task2Practise
{
    internal class Vehicle
    {
        protected int _mileage;
        public int Mileage
        {
            get
            {
                return _mileage;
            }
        }

        public virtual void Drive(int km)
        {
            _mileage += km;
        }
    }
}
