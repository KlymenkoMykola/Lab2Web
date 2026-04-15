using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Competition.Models
{
   public class Participant
   {
      public int Id { get; set; }

      [Required(ErrorMessage = "Прізвище є обов'язковим")]
      public string LastName { get; set; }

      [Required(ErrorMessage = "Ім'я є обов'язковим")]
      public string FirstName { get; set; }

      public string MiddleName { get; set; }

      [NotMapped]
      public string FullName => $"{LastName} {FirstName} {MiddleName}";

      [Required(ErrorMessage = "ПІБ тренера є обов'язковим")]
      public string CoachName { get; set; }

      [Required(ErrorMessage = "Введіть результат присяду")]
      [Range(0, 500, ErrorMessage = "Вага має бути від 0 до 500 кг")]
      public float Squat { get; set; }

      [Required(ErrorMessage = "Введіть результат жиму лежачи")]
      [Range(0, 500, ErrorMessage = "Вага має бути від 0 до 500 кг")]
      public float BenchPress { get; set; }

      [Required(ErrorMessage = "Введіть результат станової тяги")]
      [Range(0, 500, ErrorMessage = "Вага має бути від 0 до 500 кг")]
      public float Deadlift { get; set; }

      [NotMapped]
      public float TotalScore => Squat + Deadlift + Deadlift;

      [Required(ErrorMessage = "Оберіть навчальний заклад")]
      public int InstitutionId { get; set; }

      [ForeignKey("InstitutionId")]
      [ValidateNever]
      public Institution Institution { get; set; }

   }
}
