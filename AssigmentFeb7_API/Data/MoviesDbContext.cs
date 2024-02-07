using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AssigmentFeb7_API.Models;

namespace AssigmentFeb7_API.Data
{
    public class MoviesDbContext : DbContext
    {
        public MoviesDbContext (DbContextOptions<MoviesDbContext> options)
            : base(options)
        {
        }

        public DbSet<AssigmentFeb7_API.Models.Movies> Movies { get; set; } = default!;
    }
}
