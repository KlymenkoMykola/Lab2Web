using Competition.Models;
using Competition.Repositories;

namespace Competition.Services
{
   public class ParticipantService : IParticipantService
   {
      private readonly IParticipantRepository _repository;

      public ParticipantService(IParticipantRepository repository)
      {
         _repository = repository;
      }

      public void CreateParticipant(Participant participant)
      {
         var existingParticipants = _repository.GetAllParticipants();

         bool isDuplicate = existingParticipants.Any(p => 
         p.FirstName.ToLower() == participant.FirstName.ToLower() &&
         p.LastName.ToLower() == participant.LastName.ToLower() &&
         p.InstitutionId == participant.InstitutionId);

         if (isDuplicate)
         {
            throw new ArgumentException("Спортсмен з таким ім'ям та прізвищем вже зареєстрований від цього навчального закладу!");
         }

         _repository.AddParticipant(participant);
      }

      public void DeleteParticipant(int id)
      {
         _repository.RemoveParticipant(id);
      }

      public IEnumerable<Participant> GetAllParticipants(string searchString = null)
      {
         var participants = _repository.GetAllParticipants();

         if (!string.IsNullOrEmpty(searchString))
         {
            participants = participants.Where(p =>
            p.LastName.Contains(searchString, StringComparison.OrdinalIgnoreCase));
         }

         return participants
            .OrderBy(p => p.TotalScore)
            .ThenBy(p => p.LastName)
            .ToList();

      }

      public Participant GetParticipantById(int id)
      {
         return _repository.GetParticipantById(id);
      }

      public void EditParticipant(Participant participant)
      {
         _repository.EditParticipant(participant);
      }
   }
}
