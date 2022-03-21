#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PracaInz.Models;

namespace PracaInz.Data
{
    public class PracaInzContext : DbContext
    {
        public PracaInzContext (DbContextOptions<PracaInzContext> options)
            : base(options)
        {
        }

        public DbSet<PracaInz.Models.Movie> Movie { get; set; }

        public DbSet<PracaInz.Models.Genre> Genre { get; set; }
    }
}
