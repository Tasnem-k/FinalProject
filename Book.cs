using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    public class Book:Author
    {
        public string Title { get; set; }
        public Author Author { get; set; }
    }
}
