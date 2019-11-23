using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MyProject.Models
{
    public class MyProjectContext : DbContext
    {
        public MyProjectContext (DbContextOptions<MyProjectContext> options)
            : base(options)
        {
        }
        public DbSet<Player> Player { get; set; }
        public DbSet<MyProject.Models.Team> Team { get; set; }
    }
}
