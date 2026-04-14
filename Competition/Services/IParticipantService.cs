using Competition.Models;

namespace Competition.Services
{
   public interface IParticipantService
   {
      IEnumerable<Participant> GetAllParticipant();
      Participant GetParticipantById(int id);
      void CreateParticipant(Participant participant);
      void UpdateParticipant(Participant participant);
      void DeleteParticipant(int id);
   }
}
