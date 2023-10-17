using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryEF_Design.Repositories
{
    public interface IRepository<T>
    {
        T? GetById(int id);
        void Add(T entity);
        void AddRange(ICollection<T> entities);
        ICollection<T> GetAll();
        void Remove(T entity);
        void Remove(int id);
        void Update(T entity);
        void SaveChanges();

    }
}
