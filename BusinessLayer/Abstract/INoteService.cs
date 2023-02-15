using EntityLayer.Abstract;
using EntityLayer.Concrete;
using EntityLayer.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface INoteService:IGenericService<Note>
    {
        List<Note> GetNoteListWithNoteTitle();
        List<Note> GetNoteListWithNoteTitleStatus();
        List<Note> GetNoteListWithNoteTitleStatusFalse();
        List<Note> GetAll(int id);
        List<Note> GetListAdding();
        void DeleteNote(Note note);
    }
}
