using BusinessLayer.Abstract;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace NoteList.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NoteListController : ControllerBase
    {
        private readonly INoteService _noteService;

        public NoteListController(INoteService noteService)
        {
            _noteService = noteService;
        }

        [HttpGet]
        public IActionResult GetDeleteList()
        {
            var list = _noteService.GetNoteListWithNoteTitleStatusFalse();
            return Ok(list);
        }

        [HttpGet("GetAddingList")]
        public IActionResult GetAddingList()
        {
            var list = _noteService.GetListAdding();
            return Ok(list);
        }
    }
}
