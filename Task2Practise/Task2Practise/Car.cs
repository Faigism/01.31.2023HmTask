using System;
using System.Collections.Generic;
using System.Text;

namespace Task2Practise
{
    internal class Car:Vehicle
    {
        public Car(int fuelcapacity)
        {
            _fuelCapacity= fuelcapacity;
        }
        private int _fuelCapacity;

        public int FuelCapacity
        {
            set
            {
                if(value>=0&&CurrentFuel<=value)
                    _fuelCapacity = value;
            }
            get
            {
                return _fuelCapacity;
            }
        }
        private int _currentFuel;

        public int CurrentFuel=>_currentFuel;

        public int FuelFor1Km;

        public void AddFuel(int fuel)
        {
            if(_currentFuel+fuel<=FuelCapacity)
                _currentFuel += fuel;
        }
        public override void Drive(int km)
        {
            int neededFuel = km + FuelFor1Km;
            if (_currentFuel >= neededFuel)
            {
                _currentFuel -= neededFuel;
                _mileage += km;
            }
        }
    }
}
