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

      public IActionResult Delete(int id)
      {
         var participant = _participantService.GetParticipantById(id);

         if(participant == null)
         {
            return NotFound();
         }
         return View(participant);
      }

      [HttpPost, ActionName("Delete")]
      public IActionResult DeleteConfirmed(int id)
      {
         _participantService.DeleteParticipant(id);
         return RedirectToAction(nameof(Index));
      }

      public IActionResult Edit(int id)
      {
         var participant = _participantService.GetParticipantById(id);

         if(participant == null)
         {
            return NotFound();
         }

         var institutions = _institutionService.GetAllInstitutions();
         ViewBag.Institutions = new SelectList(institutions, "Id", "Name", participant.InstitutionId);

         return View(participant);
      }

      [HttpPost]
      public IActionResult Edit(int id, Participant participant)
      {
         if(id != participant.Id)
         {
            return NotFound();
         }

         if (ModelState.IsValid)
         {
            _participantService.EditParticipant(participant);
            return RedirectToAction(nameof(Index));
         }

         var institutions = _institutionService.GetAllInstitutions();
         ViewBag.Institutions = new SelectList(institutions, "Id", "Name", participant.InstitutionId);

         return View(participant);
      }
   }
}
