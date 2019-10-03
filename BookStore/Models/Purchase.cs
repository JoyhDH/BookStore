using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class Purchase
    {
        public int ID { get; set; }

        public string Person { get; set; }

        public string Address { get; set; }

        public int BookID { get; set; }

        public DateTime Date { get; set; }
    }
}
