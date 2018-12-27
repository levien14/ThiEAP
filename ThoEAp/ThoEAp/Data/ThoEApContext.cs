using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ThoEAp.Models
{
    public class ThoEApContext : DbContext
    {
        public ThoEApContext (DbContextOptions<ThoEApContext> options)
            : base(options)
        {
        }

        public DbSet<ThoEAp.Models.Employee> Employee { get; set; }
    }
}
