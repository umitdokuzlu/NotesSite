using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IGenericService<T> where T : class
    {
        void Insert(T note);
        void Delete(T note);
        void Update(T note);
        List<T> GetAll();
        T GetById(int id);
    }
}
