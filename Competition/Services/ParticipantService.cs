using Competition.Models;
using Competition.Repositories;

namespace Competition.Services
{
   public class ParticipantService : IParticipantService
   {
      private readonly IParticipantRepository _repository;

      ParticipantService(IParticipantRepository repository)
      {
         _repository = repository;
      }

      public void CreateParticipant(Participant participant)
      {
         _repository.AddParticipant(participant);
      }

      public void DeleteParticipant(int id)
      {
         _repository.RemoveParticipant(id);
      }

      public IEnumerable<Participant> GetAllParticipant()
      {
         return _repository.GetAllParticipants();
      }

      public Participant GetParticipantById(int id)
      {
         return _repository.GetParticipantById(id);
      }

      public void UpdateParticipant(Participant participant)
      {
         _repository.UpdateParticipant(participant);
      }
   }
}
