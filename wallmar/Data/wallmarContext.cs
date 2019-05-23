using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace wallmar.Models
{
    public class wallmarContext : DbContext
    {
        public wallmarContext (DbContextOptions<wallmarContext> options)
            : base(options)
        {
        }

        public DbSet<wallmar.Models.Departament> Departament { get; set; }
    }
}
