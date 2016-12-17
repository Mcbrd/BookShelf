using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookList.Models
{
    public class Book
    {
        public int Id { get; set; }
        public long ISBN13 { get; set; }
        public int ISBN10 { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }


    }
}