using Competition.Models;

namespace Competition.Repositories
{
   public interface IParticipantRepository
   {
      IEnumerable<Participant> GetAllParticipants();
      Participant GetParticipantById(int id);
      void AddParticipant(Participant participant);
      void RemoveParticipant(int id);
      void UpdateParticipant(Participant participant);
   }
}
