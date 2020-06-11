using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace Second
{
    class Program
    {
        static void Main(string[] args)
        {
            FileReader reader = new FileReader("man.txt");
            foreach (var man in reader.GetMans())
            {
                Console.WriteLine(man.ToString());
            }
            reader.Path = "students.txt";
            foreach (var student in reader.GetStudents())
            {
                Console.WriteLine(student.ToString());
            }
            reader.Path = "authors.txt";
            foreach (var author in reader.GetAuthors())
            {
                Console.WriteLine(author.ToString());
            }
            reader.Path = "books.txt";
            foreach (var book in reader.GetBooks())
            {
                Console.WriteLine(book.ToString());
            }
        }
    }
}