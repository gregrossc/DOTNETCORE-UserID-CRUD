using System;
using System.Collections.Generic;
using System.Text;
using anabolicdata.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace anabolicdata.Data
{
    public class ApplicationDbContext
               : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder
            .UseSnakeCaseNamingConvention();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");
            base.OnModelCreating(modelBuilder);

            foreach (var entity in modelBuilder.Model.GetEntityTypes())
            {
                var currentTableName = modelBuilder.Entity(entity.Name).Metadata.GetDefaultTableName();
                if (currentTableName.Contains("<"))
                {
                    currentTableName = currentTableName.Split('<')[0];
                }
                modelBuilder.Entity(entity.Name).ToTable(Helper.ToUnderscoreCase(currentTableName));
            }
        }
    }
}