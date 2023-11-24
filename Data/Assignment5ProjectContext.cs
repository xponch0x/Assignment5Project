using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Assignment5Project.Models;

namespace Assignment5Project.Data
{
    public class Assignment5ProjectContext : DbContext
    {
        public Assignment5ProjectContext (DbContextOptions<Assignment5ProjectContext> options)
            : base(options)
        {
        }

        public DbSet<Assignment5Project.Models.Music> Music { get; set; } = default!;
    }
}
