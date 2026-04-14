using Competition.Models;
using Competition.Repositories;

namespace Competition.Services
{
   public class InstitutionService : IInstitutionService
   {
      private readonly IInstitutionRepository _repository;

      public InstitutionService(IInstitutionRepository repository)
      {
         _repository = repository;
      }

      public IEnumerable<Institution> GetAllInstitutions()
      {
         return _repository.GetAllInstitutions();
      }
   }
}
