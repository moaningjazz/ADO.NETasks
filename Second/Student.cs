using System;
using System.Collections.Generic;
using System.Text;

namespace Second
{
    public class Student : Man
    {
        private DateTime startEducationDate;
        public DateTime StartEducationDate
        {
            get => startEducationDate;
            private set
            {
                if (value >= DateTime.Now)
                    throw new ArgumentOutOfRangeException("Start education date not be upper when current date");
                startEducationDate = value;
            }
        }
        public int CourseNumber { get; private set; }
        public int GroupNumber { get; private set; }

        public Student(
            string name, 
            DateTime birthDate, 
            float weight, 
            float height,
            DateTime startEducationDate,
            int courseNumber,
            int groupNumber) : 
            base(name, birthDate, weight, height)
        {
            StartEducationDate = startEducationDate;
            CourseNumber = courseNumber;
            GroupNumber = groupNumber;
        }

        public override string ToString()
        {
            return base.ToString() +
                $"Start education date: {StartEducationDate}{Environment.NewLine}" +
                $"Course number: {CourseNumber}{Environment.NewLine}" +
                $"Group number: {GroupNumber}{Environment.NewLine}";
        }
    }
}
