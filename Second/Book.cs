using System;
using System.Collections.Generic;
using System.Text;

namespace Second
{
    public class Book
    {
        private DateTime publicationDate;
        private DateTime dateOfWriting;
        private int pageCount;

        public string Title { get; private set; }
        public int PageCount 
        {
            get => pageCount;
            private set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("Page count not be a negative or zero");
                pageCount = value;
            }
        }
        public DateTime PublicationDate 
        { 
            get => publicationDate; 
            private set
            {
                if (value >= DateTime.Now)
                    throw new ArgumentOutOfRangeException("Publication date not be upper when current date");
                publicationDate = value;
            }
        }
        public DateTime DateOfWriting 
        { 
            get => dateOfWriting; 
            private set
            {
                if (value >= DateTime.Now)
                    throw new ArgumentOutOfRangeException("Date of writing not be upper when current date");
                if (value > PublicationDate)
                    throw new ArgumentOutOfRangeException("Date of writing not be upper when publication date");
                dateOfWriting = value;
            }
        }

        public Author Author { get; private set; }

        public Book(
            string title, 
            int pageCount, 
            DateTime publicationDate, 
            DateTime dateOfWriting,
            Author author)
        {
            Title = title;
            PageCount = pageCount;
            PublicationDate = publicationDate;
            DateOfWriting = dateOfWriting;
            Author = author;
        }

        public override string ToString()
        {
            return $"Title: {Title}{Environment.NewLine}" +
                $"Page count: {PageCount}{Environment.NewLine}" +
                $"Publication date: {PublicationDate.ToString("dd/mm/yyyy")}{Environment.NewLine}" +
                $"Date of writing: {DateOfWriting.ToString("dd/mm/yyyy")}{Environment.NewLine}" +
                Author.ToString();
        }
    }
}
