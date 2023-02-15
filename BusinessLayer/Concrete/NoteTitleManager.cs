using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class NoteTitleManager : IGenericService<NoteTitle>, INoteTitleService
    {
        private readonly INoteTitleDal _noteTitleDal;

        public NoteTitleManager(INoteTitleDal noteTitleDal)
        {
            _noteTitleDal = noteTitleDal;
        }

        public void Delete(NoteTitle note)
        {
            _noteTitleDal.Delete(note);
        }

        public List<NoteTitle> GetAll()
        {
            return _noteTitleDal.GetAll();
        }

        public NoteTitle GetById(int id)
        {
            return _noteTitleDal.GetById(id);
        }

        public void Insert(NoteTitle note)
        {
            _noteTitleDal.Insert(note);
        }

        public void Update(NoteTitle note)
        {
            _noteTitleDal.Update(note);
        }
    }
}
