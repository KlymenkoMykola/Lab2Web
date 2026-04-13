using Competition.Data;
using Competition.Models;
using Microsoft.EntityFrameworkCore;

namespace Competition.Repositories
{
   public class ParticipantRepository : IParticipantRepository
   {
      private readonly CompetitionDbContext _context;

      public ParticipantRepository(CompetitionDbContext context)
      {
         _context = context;
      }

      public void AddParticipant(Participant participant)
      {
         _context.Participants.Add(participant);
      }

      public IEnumerable<Participant> GetAllParticipants()
      {
         return _context.Participants.Include(p => p.Institution).ToList();
      }

      public Participant GetParticipantById(int id)
      {
         return _context.Participants.Include(p => p.Institution).FirstOrDefault(p => p.Id == id);
      }

      public void RemoveParticipant(int id)
      {
         var participant = _context.Participants.Find(id);
         if(participant != null)
         {
            _context.Participants.Remove(participant);
            _context.SaveChanges();
         }
      }

      public void UpdateParticipant(Participant participant)
      {
         _context.Participants.Update(participant);
         _context.SaveChanges();
      }
   }
}
