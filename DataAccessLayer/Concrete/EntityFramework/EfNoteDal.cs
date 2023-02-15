using DataAccessLayer.Abstract;
using DataAccessLayer.GenericRepository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EfNoteDal : GenericDal<Note>, INoteDal
    {
        public List<Note> GetNoteListWithNoteTitle()
        {
            using (var c = new NoteContext())
            {
                return c.Notes.Include(x => x.NoteTitle).ToList();
            }
        }
               

        public List<Note> GetNoteListWithNoteTitleStatus()
        {
            using (var c = new NoteContext())
            {
                return c.Notes.Include(x => x.NoteTitle).Where(x => x.Status == true).ToList();
            }
        }

        public List<Note> GetListAdding()
        {
            using (var c = new NoteContext())
            {
                return c.Notes.Where(x => x.Status == true).ToList();
            }
        }

        public List<Note> GetNoteListWithNoteTitleStatusFalse()
        {
            using (var c = new NoteContext())
            {
                return c.Notes.Where(x => x.Status == false).ToList();
            }
        }

        public Note GetByTitleId(Expression<Func<Note, bool>> filter)
        {
            using var c = new NoteContext();
            return c.Set<Note>().Where(filter).FirstOrDefault();
        }

        public List<Note> GetAll(Expression<Func<Note, bool>> filter)
        {
            using var c = new NoteContext();
            return c.Set<Note>().Where(filter).ToList();
        }
    }
}
