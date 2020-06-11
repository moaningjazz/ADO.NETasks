using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace Second
{
    public class FileReader
    {
        public string Path { get; set; }

        private Man GetManFromString(string stringData)
        {
            var splitingData = stringData.Split(' ');

            DateTime birthDate;
            float weight;
            float height;

            if (splitingData.Length == 4 &&
                DateTime.TryParse(splitingData[1], out birthDate) &&
                float.TryParse(splitingData[2], out weight) &&
                float.TryParse(splitingData[2], out height))
            {
                return new Man(splitingData[0], birthDate, weight, height);
            }
            else
                throw new FormatException("File format error!");
        }

        private Student GetStudentFromString(string stringData)
        {
            var splitingData = stringData.Split(' ');

            DateTime birthDate;
            float weight;
            float height;
            DateTime startEducationDate;
            int courseNumber;
            int groupNumber;

            if (splitingData.Length == 7 &&
                DateTime.TryParse(splitingData[1], out birthDate) &&
                float.TryParse(splitingData[2], out weight) &&
                float.TryParse(splitingData[3], out height) &&
                DateTime.TryParse(splitingData[4], out startEducationDate) &&
                int.TryParse(splitingData[5], out courseNumber) &&
                int.TryParse(splitingData[6], out groupNumber))
            {
                return new Student(splitingData[0],
                    birthDate,
                    weight,
                    height,
                    startEducationDate,
                    courseNumber,
                    groupNumber);
            }
            else
                throw new FormatException("File format error!");
        }

        private Book GetBookFromString(string stringData)
        {
            var splitingData = stringData.Split(' ');

            int pageCount;
            DateTime publishedDate;
            DateTime dateOfWriting;
            DateTime birthDate;


            if (splitingData.Length == 7 &&
                int.TryParse(splitingData[1], out pageCount) &&
                DateTime.TryParse(splitingData[2], out publishedDate) &&
                DateTime.TryParse(splitingData[3], out dateOfWriting) &&
                DateTime.TryParse(splitingData[6], out birthDate))
            {
                return new Book(splitingData[0], 
                    pageCount, 
                    publishedDate, 
                    dateOfWriting, 
                    new Author(splitingData[4], splitingData[5], birthDate));
            }
            else
                throw new FormatException("File format error!");
        }

        private Author GetAuthorFromString(string stringData)
        {
            var splitingData = stringData.Split(' ');

            DateTime birthDate;

            if (splitingData.Length == 3 &&
                DateTime.TryParse(splitingData[2], out birthDate))
            {
                return new Author(splitingData[0], splitingData[1], birthDate);
            }
            else
                throw new FormatException("File format error!");
        }

        public Man GetMan()
        {
            using (StreamReader input = new StreamReader(Path))
            {
                return GetManFromString(input.ReadLine());
            }
        }

        public IEnumerable<Man> GetMans()
        {
            using (StreamReader input = new StreamReader(Path))
            {
                List<Man> mans = new List<Man>();
                while (!input.EndOfStream)
                {
                    mans.Add(GetManFromString(input.ReadLine()));
                }
                return mans;
            }
        }

        public Student GetStudent()
        {
            using (StreamReader input = new StreamReader(Path))
            {
                return GetStudentFromString(input.ReadLine());
            }
        }

        public IEnumerable<Student> GetStudents()
        {
            using (StreamReader input = new StreamReader(Path))
            {
                List<Student> students = new List<Student>();
                while (!input.EndOfStream)
                {
                    students.Add(GetStudentFromString(input.ReadLine()));
                }
                return students;
            }
        }

        public Author GetAuthor()
        {
            using (StreamReader input = new StreamReader(Path))
            {
                return GetAuthorFromString(input.ReadLine());
            }
        }

        public IEnumerable<Author> GetAuthors()
        {
            using (StreamReader input = new StreamReader(Path))
            {
                List<Author> authors = new List<Author>();
                while (!input.EndOfStream)
                {
                    authors.Add(GetAuthorFromString(input.ReadLine()));
                }
                return authors;
            }
        }

        public Book GetBook()
        {
            using (StreamReader input = new StreamReader(Path))
            {
                return GetBookFromString(input.ReadLine());
            }
        }

        public IEnumerable<Book> GetBooks()
        {
            using (StreamReader input = new StreamReader(Path))
            {
                List<Book> books = new List<Book>();
                while (!input.EndOfStream)
                {
                    books.Add(GetBookFromString(input.ReadLine()));
                }
                return books;
            }
        }

        public FileReader(string path) => Path = path;
    }
}
