using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Second
{
    public class Man
    {
        private DateTime birth;
        private float weight;
        private float height;

        public string Name { get; private set; }
        public DateTime BirthDate 
        { 
            get => birth; 
            private set
            {
                if (value >= DateTime.Now)
                    throw new ArgumentOutOfRangeException("Birth date not be upper when current date");
                birth = value;
            }
        }
        public int Age { get => (int)DateTime.Now.Subtract(BirthDate).TotalDays / 365; }
        public float Weight 
        { 
            get => weight; 
            private set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("Weight not be a negative or zero");
                weight = value;
            }
        }
        public float Height
        {
            get => height;
            private set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("Height not be a negative or zero");
                height = value;
            }
        }

        public Man(string name, DateTime birthDate, float weight, float height)
        {
            Name = name;
            BirthDate = birthDate;
            Weight = weight;
            Height = height;
        }

        public override string ToString()
        {
            return $"Name: {Name}{Environment.NewLine}" +
                $"Birth date: {BirthDate.ToString("dd/mm/yyyy")}{Environment.NewLine}" +
                $"Weight: {Weight}{Environment.NewLine}" +
                $"Height: {Height}{Environment.NewLine}";
        }
    }
}
