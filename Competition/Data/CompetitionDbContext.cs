using Competition.Models;
using Microsoft.EntityFrameworkCore;

namespace Competition.Data
{
   public class CompetitionDbContext : DbContext
   {
      public CompetitionDbContext(DbContextOptions<CompetitionDbContext> options)
         : base(options)
      {
      }

      public DbSet<Participant> Participants { get; set; }
      public DbSet<Institution> Institutions { get; set; }

      protected override void OnModelCreating(ModelBuilder modelBuilder)
      {
         base.OnModelCreating(modelBuilder);

         modelBuilder.Entity<Institution>().HasData(
            new Institution { Id = 1, Name = "ДЮКФП міста Звягеля", City = "Звягель"},
            new Institution { Id = 2, Name = "Олевська дитячо-юнацька спортивна школа", City = "Олевськ" },
            new Institution { Id = 3, Name = "Баранівська районна дитячо-юнацька спортивна школа", City = "Баранівка" },
            new Institution { Id = 4, Name = "Андрушівська ДЮСШ", City = "Андрушівка" },
            new Institution { Id = 5, Name = "Бердичівська дитячо-юнацька спортивна школа ім. В.О. Лонського", City = "Бердичів" },
            new Institution { Id = 6, Name = "Дитячо-юнацька спортивна школа ЖМР", City = "Житомир" }
            );
      }
   }
}
