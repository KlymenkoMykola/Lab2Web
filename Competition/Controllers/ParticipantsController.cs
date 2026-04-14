using Competition.Models;
using Competition.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Competition.Controllers
{
   public class ParticipantsController : Controller
   {
      private readonly IInstitutionService _institutionService;
      private readonly IParticipantService _participantService;

      public ParticipantsController(IParticipantService participantService, IInstitutionService institutionService)
      {
         _institutionService = institutionService;
         _participantService = participantService;
      }

      public IActionResult Index()
      {
         var participants = _participantService.GetAllParticipants();
         return View(participants);
      }

      public IActionResult Create()
      {
         var institutions = _institutionService.GetAllInstitutions();
         ViewBag.Institutions = new SelectList(institutions, "Id", "Name");
         return View();
      }

      [HttpPost]
      public IActionResult Create(Participant participant)
      {

         if (ModelState.IsValid)
         {
            _participantService.CreateParticipant(participant);
            return RedirectToAction(nameof(Index));
         }

         var institutions = _institutionService.GetAllInstitutions();
         ViewBag.Institutions = new SelectList(institutions, "Id", "Name");
         return View(participant);
      }
   }
}
