using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Lavinia_Bolos_Lab2.Models;

namespace Lavinia_Bolos_Lab2.Data
{
    public class Lavinia_Bolos_Lab2Context : DbContext
    {
        public Lavinia_Bolos_Lab2Context (DbContextOptions<Lavinia_Bolos_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Lavinia_Bolos_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Lavinia_Bolos_Lab2.Models.Publisher> Publisher { get; set; } = default!;
    }
}
