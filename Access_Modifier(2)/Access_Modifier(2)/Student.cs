using System;
using System.Collections.Generic;
using System.Text;

namespace Access_Modifier_2_
{
    internal class Student
    {
        public string Fullname;
        private byte _age;

        public byte Age
        {
            set
            {
                if (value >= 15)
                {
                    _age= value;
                }
            }
            get
            {
                return _age;
            }
        }
    }
}
