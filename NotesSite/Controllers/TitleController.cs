using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;

namespace NotesSite.Controllers
{
    public class TitleController : Controller
    {
        private readonly INoteTitleService _noteTitleService;

        public TitleController(INoteTitleService noteTitleService)
        {
            _noteTitleService = noteTitleService;
        }

        public IActionResult Index()
        {
            return View(_noteTitleService.GetAll());
        }

        [HttpGet]
        public IActionResult AddNote()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddNote(NoteTitle note)
        {
            _noteTitleService.Insert(note);
            return RedirectToAction("Index");
        }               

        public IActionResult DeleteNote(int id)
        {
            var value = _noteTitleService.GetById(id);
            _noteTitleService.Delete(value);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateNote(int id)
        {
            var value = _noteTitleService.GetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateNote(NoteTitle note)
        {
            _noteTitleService.Update(note);
            return RedirectToAction("Index");
        }
    }
}
