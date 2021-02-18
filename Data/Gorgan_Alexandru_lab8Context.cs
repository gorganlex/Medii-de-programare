using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Gorgan_Alexandru_lab8.Models;

namespace Gorgan_Alexandru_lab8.Data
{
    public class Gorgan_Alexandru_lab8Context : DbContext
    {
        public Gorgan_Alexandru_lab8Context (DbContextOptions<Gorgan_Alexandru_lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Gorgan_Alexandru_lab8.Models.Book> Book { get; set; }

        public DbSet<Gorgan_Alexandru_lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Gorgan_Alexandru_lab8.Models.Category> Category { get; set; }
    }
}
