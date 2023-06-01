using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Fitness.Models;

namespace Fitness.Data
{
    public class FitnesssContext : DbContext
    {
        public FitnesssContext (DbContextOptions<FitnesssContext> options)
            : base(options)
        {
        }

        public DbSet<Fitness.Models.Register> Register { get; set; } = default!;

        public DbSet<Fitness.Models.Feedback>? Feedback { get; set; }
        public DbSet<LK_Gender> LK_Gender { get; set; }
        public DbSet<LK_Plan> LK_Plan { get; set; }
        public DbSet<LK_countries> LK_countries { get; set; }
        public DbSet<Fitness.Models.RegisterFormTrainer>? RegisterFormTrainer { get; set; }
        public DbSet<Fitness.Models.Contact>? Contact { get; set; }

    }
}
