using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    public class Author:Genre
    {
        public string Name { get; set; }
        public Genre Genre { get; set; }
    }
}
