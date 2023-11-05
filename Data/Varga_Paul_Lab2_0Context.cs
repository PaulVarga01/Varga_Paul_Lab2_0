using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Varga_Paul_Lab2_0.Models;

namespace Varga_Paul_Lab2_0.Data
{
    public class Varga_Paul_Lab2_0Context : DbContext
    {
        public Varga_Paul_Lab2_0Context (DbContextOptions<Varga_Paul_Lab2_0Context> options)
            : base(options)
        {
        }

        public DbSet<Varga_Paul_Lab2_0.Models.Book> Book { get; set; } = default!;

        public DbSet<Varga_Paul_Lab2_0.Models.Publisher>? Publisher { get; set; }

        public DbSet<Varga_Paul_Lab2_0.Models.Category>? Category { get; set; }

        public DbSet<Varga_Paul_Lab2_0.Models.Author>? Author { get; set; }
    }
}
