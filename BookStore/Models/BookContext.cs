using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class BookContext
    {
        public DbSet<BookItem> books { get; set; }
        public DbSet<Purchase> purchases { get; set; }
    }
}
