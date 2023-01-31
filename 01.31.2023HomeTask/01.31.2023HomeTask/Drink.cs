using System;
using System.Collections.Generic;
using System.Text;

namespace _01._31._2023HomeTask
{
    internal class Drink:Product
    {
        private double _alcoholPercent;

        public double AlcoholPercent
        {
            set
            {
                if (value >= 0 && value <= 100)
                {
                    _alcoholPercent = value;
                }
            }
            get
            {
                return _alcoholPercent;
            }
        }
    }
}
