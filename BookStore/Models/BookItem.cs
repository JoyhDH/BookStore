using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class BookItem
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Author { get; set; }

        public DateTime ReleaseYear { get; set; }

        public int Price { get; set; }
    }
}
