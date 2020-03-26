using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EX1C.Models;

namespace EX1C.Data
{
    public class EX1CContext : DbContext
    {
        public EX1CContext (DbContextOptions<EX1CContext> options)
            : base(options)
        {
        }

        public DbSet<EX1C.Models.Movie> Movie { get; set; }
    }
}
