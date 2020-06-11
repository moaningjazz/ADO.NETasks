using System;
using System.Collections.Generic;
using System.Text;

namespace Second
{
    public class Author
    {
        private DateTime birth;
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
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

        public Author(string firstName, string lastName, DateTime birthDate)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
        }

        public override string ToString()
        {
            return $"FirstName: {FirstName}{Environment.NewLine}" +
                $"LastName: {LastName}{Environment.NewLine}" +
                $"Birth date: {BirthDate.ToString("dd/mm/yyyy")}{Environment.NewLine}";
        }
    }
}
