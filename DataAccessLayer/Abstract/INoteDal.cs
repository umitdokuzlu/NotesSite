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
    public interface INoteDal:IGenericDal<Note>
    {
        List<Note> GetNoteListWithNoteTitle();
        List<Note> GetAll(Expression<Func<Note, bool>> filter);
        List<Note> GetNoteListWithNoteTitleStatus();
        Note GetByTitleId(Expression<Func<Note, bool>> filter);
        List<Note> GetNoteListWithNoteTitleStatusFalse();
        List<Note> GetListAdding();
    }
}
