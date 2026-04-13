using Competition.Data;
using Competition.Models;

namespace Competition.Repositories
{
   public class InstitutionRepository : IInstitutionRepository
   {
      private readonly CompetitionDbContext _context;

      public InstitutionRepository(CompetitionDbContext context)
      {
         _context = context;
      }

      public IEnumerable<Institution> GetAllInstitutions()
      {
         return _context.Institutions.ToList();
      }
   }
}
