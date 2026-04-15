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
         _repository.AddParticipant(participant);
      }

      public void DeleteParticipant(int id)
      {
         _repository.RemoveParticipant(id);
      }

      public IEnumerable<Participant> GetAllParticipants()
      {
         return _repository.GetAllParticipants();
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
