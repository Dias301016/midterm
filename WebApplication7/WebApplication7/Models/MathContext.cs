using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication7.Models
{

    public class MathContext : DbContext
    {
        public DbSet<Math> Maths { get; set; }
        public MathContext(DbContextOptions<MathContext> options)
        : base(options)
        {
            Database.EnsureCreated();
        }

    }
}
