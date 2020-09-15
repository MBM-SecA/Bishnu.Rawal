using System;

namespace EnumsAndProperties
{
    internal class Person
    {
        private byte age;
        private int grade;
        private DateTime dob;

        // getter-setter
        public byte Age
        {
            get { return age; }
            set
            {
                if (value > 30 && value < 40)
                {
                    age = value;
                }
            }
        }

        // Auto-implemented properties
        public string Address { get; set; }

        // Read-only
        public string Name { get; }
    }
}