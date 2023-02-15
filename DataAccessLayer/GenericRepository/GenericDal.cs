using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.GenericRepository
{
    public class GenericDal<T> : IGenericDal<T> where T : class
    {

        public void Delete(T note)
        {
            using var c = new NoteContext();
            c.Remove(note);
            c.SaveChanges();
        }

        public List<T> GetAll()
        {
            using var c=new NoteContext();
            return c.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            using var c = new NoteContext();
            return c.Set<T>().Find(id);
        }

        public void Insert(T note)
        {
            using var c = new NoteContext();
            c.Add(note);
            c.SaveChanges();
        }

        public void Update(T note)
        {
            using var c = new NoteContext();
            c.Update(note);
            c.SaveChanges();
        }
    }
}
