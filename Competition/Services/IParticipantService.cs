using Competition.Models;

namespace Competition.Services
{
   public interface IParticipantService
   {
      IEnumerable<Participant> GetAllParticipants(string searchString = null);
      Participant GetParticipantById(int id);
      void CreateParticipant(Participant participant);
      void EditParticipant(Participant participant);
      void DeleteParticipant(int id);
   }
}
