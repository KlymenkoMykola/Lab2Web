using System.ComponentModel.DataAnnotations;

namespace Competition.Models
{
   public class Institution
   {
      public int Id { get; set; }

      [Required(ErrorMessage = "Назва закладу обов'язкова")]
      public string Name { get; set; }
      public string City { get; set; }

      public ICollection<Participant> Participants { get; set; }= new List<Participant>();
   }
}
