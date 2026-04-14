using Competition.Models;

namespace Competition.Services
{
   public interface IInstitutionService
   {
      IEnumerable<Institution> GetAllInstitutions();
   }
}
