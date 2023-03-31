using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    public class Book
    {
        public string Title { get; set; }
        public int PublishingYear { get; set; }

        public Book(string title, int publishingYear)
        {
            Title = title;
            PublishingYear = publishingYear;
        }
        public override string ToString()
        {
            return $"{Title} ({PublishingYear})";
        }
    }

}