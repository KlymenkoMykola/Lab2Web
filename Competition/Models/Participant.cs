using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Competition.Models
{
   public class Participant
   {
      public int Id { get; set; }

      [Required]
      public string LastName { get; set; }

      [Required]
      public string FirstName { get; set; }

      [Required]
      public string MiddleName { get; set; }

      [NotMapped]
      public string FullName => $"{LastName} {FirstName} {MiddleName}";

      public string CoachName { get; set; }

      [Required]
      public float Squat { get; set; }

      [Required]
      public float BenchPress { get; set; }

      [Required]
      public float Deadlift { get; set; }

      [NotMapped]
      public float TotalScore => Squat + Deadlift + Deadlift;

      [Required]
      public int InstitutionId { get; set; }
      public Institution Institution { get; set; }

   }
}
