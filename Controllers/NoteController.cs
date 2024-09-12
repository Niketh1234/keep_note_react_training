using KeepNote.Models;
using KeepNote.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KeepNote.Controllers
{
    public class NoteController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Note c)
        {
            NoteRepository.Notes.Add(c);
            return RedirectToAction("Index");
        }
        public IActionResult Index()
        {
            return View(NoteRepository.Notes);
        }
        public IActionResult Edit(int id)
        {
            return View(NoteRepository.Notes.FirstOrDefault((cus) => cus.NoteId == id));

        }
        [HttpPost]
        public IActionResult Edit(int id, Note c)
        {
            var result = NoteRepository.Notes.FirstOrDefault(x => x.NoteId == id);
            if (result != null)
            {
                result.NoteTitle = c.NoteTitle;
                result.NoteStatus = c.NoteStatus;
                result.NoteContent = c.NoteContent;
                result.NoteId = c.NoteId;
            }
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            return View(NoteRepository.Notes.FirstOrDefault((cus) => cus.NoteId == id));
        }
        [HttpPost]
        public IActionResult Delete(int id, Note c)
        {
            var cus = NoteRepository.Notes.FirstOrDefault(c => c.NoteId == id);
            if (cus != null)
            {
                NoteRepository.Notes.Remove(cus);
            }
            return RedirectToAction("Index");
        }

    }
}
