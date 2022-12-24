using Microsoft.EntityFrameworkCore;
using SinemaYonetimPaneli.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaYonetimPaneli.Persistence.Contexts
{
    public class SinemaYonetimPaneliDbContext : DbContext
    {
        public SinemaYonetimPaneliDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Film> Films { get; set; }
        public DbSet<Salon> Salons { get; set; }
        public DbSet<Gosterim> Gosterims { get; set; }
    }
}
