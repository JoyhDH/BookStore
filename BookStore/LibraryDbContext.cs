using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryData.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStore
{
    public class LibraryDbContext: DbContext
    {
        public LibraryDbContext(DbContextOptions options) : base(options)
        {

        }

        public virtual DbSet<User> Users { get; set; }

    }
}
