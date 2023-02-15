using DataAccessLayer.GenericRepository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface INoteTitleDal:IGenericDal<NoteTitle>
    {
        NoteTitle GetNoteTitle(Expression<Func<NoteTitle, bool>> filter);
    }
}
