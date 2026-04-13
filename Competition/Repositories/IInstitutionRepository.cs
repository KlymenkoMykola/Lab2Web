using Competition.Models;

namespace Competition.Repositories
{
   public interface IInstitutionRepository
   {
      IEnumerable<Institution> GetAllInstitutions();
   }
}
