using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Alexandru_Gorgan_Proiect.Models;

namespace Alexandru_Gorgan_Proiect.Data
{
    public class Alexandru_Gorgan_ProiectContext : DbContext
    {
        public Alexandru_Gorgan_ProiectContext (DbContextOptions<Alexandru_Gorgan_ProiectContext> options)
            : base(options)
        {
        }

        public DbSet<Alexandru_Gorgan_Proiect.Models.Movie> Movie { get; set; }

        public DbSet<Alexandru_Gorgan_Proiect.Models.Cinema> Cinema { get; set; }

        public DbSet<Alexandru_Gorgan_Proiect.Models.Actor> Actor { get; set; }
    }
}
