using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace WebApplication13.DataContext
{
    public class BookDataContext: DbContext

    {
        public BookDataContext(DbContextOptions<BookDataContext> options): base(options)
        {

        }

        public DbSet<Books> Books { get; set;  }
    }
}
