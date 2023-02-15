using DataAccessLayer.Abstract;
using DataAccessLayer.GenericRepository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EfNoteTitleDal : GenericDal<NoteTitle>, INoteTitleDal
    {
        public NoteTitle GetNoteTitle(Expression<Func<NoteTitle, bool>> filter)
        {
            using var c = new NoteContext();
            return c.Set<NoteTitle>().Where(filter).FirstOrDefault();
        }
    }
}
