using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Titel { get; set; }
        public string FNAuthor { get; set; }
        public string ENAuthor { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }
        public string ISBN { get; set; }
    }
}
