using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using EntityLayer.Dtos;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class NoteManager : IGenericService<Note>,INoteService
    {
        private readonly INoteDal _noteDal;
        private readonly INoteTitleDal _noteTitleDal;

        public NoteManager(INoteDal noteDal, INoteTitleDal noteTitleDal)
        {
            _noteDal = noteDal;
            _noteTitleDal = noteTitleDal;
        }

        public void Delete(Note note)
        {
            _noteDal.Delete(note);
        }

        public void DeleteNote(Note note)
        {
           
            if (note.Status==false)
            {
                Note note1 = new Note()
                {
                    NoteId = note.NoteId,
                    NoteTitle = note.NoteTitle,
                    NoteDescription = note.NoteDescription,
                    Status = true,
                };
                _noteDal.Update(note1);
            }
            else
            {
                Note note1 = new Note()
                {
                    NoteId = note.NoteId,
                    NoteTitle = note.NoteTitle,
                    NoteDescription = note.NoteDescription,
                    Status = false,

                };
                _noteDal.Update(note1);
            }
            
        }

        public List<Note> GetAll()
        {
            return _noteDal.GetAll();
        }

        public List<Note> GetAll(int id)
        {
            return _noteDal.GetAll(x=>x.NoteTitle.TitleId==id);
        }


        public Note GetById(int id)
        {
            return _noteDal.GetById(id);
        }

        public List<Note> GetListAdding()
        {
            return _noteDal.GetListAdding();
        }

        public List<Note> GetNoteListWithNoteTitle()
        {
            return _noteDal.GetNoteListWithNoteTitle();
        }

        public List<Note> GetNoteListWithNoteTitleStatus()
        {
            return _noteDal.GetNoteListWithNoteTitleStatus();
        }

        public List<Note> GetNoteListWithNoteTitleStatusFalse()
        {
            return _noteDal.GetNoteListWithNoteTitleStatusFalse();
        }

        public void Insert(Note note)
        {
            _noteDal.Insert(note);
        }

        public void Update(Note note)
        {
            _noteDal.Update(note);
        }
    }
}
