using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using EntityLayer.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NotesSite.Controllers
{
    public class AdminController : Controller
    {
        private readonly INoteService _noteService;
        private readonly INoteTitleService _noteTitleService;
        public AdminController(INoteService noteService, INoteTitleService noteTitleService)
        {
            _noteService = noteService;
            _noteTitleService = noteTitleService;
        }

        public IActionResult Index()
        {
            return View(_noteService.GetNoteListWithNoteTitleStatus());
        }

        [HttpGet]
        public IActionResult AddNote()
        {
            List<SelectListItem> values = (from x in _noteTitleService.GetAll()
                                           select new SelectListItem
                                           {
                                               Text = x.TitleName,
                                               Value = x.TitleId.ToString(),
                                           }).ToList();
            ViewBag.v = values;
            return View();
        }

        [HttpPost]
        public IActionResult AddNote(Note note)
        {
            note.Status = true;
            _noteService.Insert(note);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateNote(int id)
        {
            List<SelectListItem> values = (from x in _noteTitleService.GetAll()
                                           select new SelectListItem
                                           {
                                               Text = x.TitleName,
                                               Value = x.TitleId.ToString(),
                                           }).ToList();
            ViewBag.v = values;
            var value = _noteService.GetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateNote(Note note)
        {
            note.Status = true;
            _noteService.Update(note);
            return RedirectToAction("Index");
        }
        

        //public IActionResult DeleteNote(int id)
        //{

        //    var value = _noteService.GetById(id);
        //    _noteService.Delete(value);
        //    return RedirectToAction("Index");
        //}

        public IActionResult DeleteNote(int id)
        {
            var value = _noteService.GetById(id);
            _noteService.DeleteNote(value);
            return RedirectToAction("Index");
        }
    }
}
