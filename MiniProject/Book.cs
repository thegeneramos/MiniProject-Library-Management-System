using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject
{ 
    enum Genre
    {
        None,
        Fiction,
        NonFiction,
        Mystery,
        Fantasy,
        Biography,
        Science,
        History,
        Romance
    }
    internal struct Book
    {
        public string Title {  get; set; }
        public string Author { get; set; }
        public Genre Genre { get; set; }
    }
}
