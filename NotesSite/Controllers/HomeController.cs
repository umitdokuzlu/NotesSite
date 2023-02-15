using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using NotesSite.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace NotesSite.Controllers
{
    public class HomeController : Controller
    {
        private readonly INoteService _noteService;
        private readonly INoteTitleService _noteTitleService;
        
        public HomeController(INoteService noteService, INoteTitleService noteTitleService)
        {
            _noteService = noteService;
            _noteTitleService = noteTitleService;
        }

        public IActionResult Index(int id)
        {            
            return View(_noteService.GetNoteListWithNoteTitle());
        }       
        public IActionResult GetNotesTitle()
        {
            return View(_noteTitleService.GetAll());
        }
        public IActionResult NoteDetails(int id)
        {
            return View(_noteService.GetAll(id));
        }

    }
}
