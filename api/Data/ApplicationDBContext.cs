using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Models;

namespace Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions dBContextOptions)
            : base(dBContextOptions)
        {
            
        }

        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}