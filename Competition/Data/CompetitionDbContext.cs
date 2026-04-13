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
   }
}
