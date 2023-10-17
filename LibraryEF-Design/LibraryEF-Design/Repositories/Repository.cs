using LibraryEF_Context.Contexts;
using LibraryEF_Context.Entitys;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryEF_Design.Repositories
{
    public class Repository<T> : IRepository<T> where T : BaseEntity, new()
    {
        private readonly LibraryDbContext _context;
        private readonly DbSet<T> _dbSet;

        public Repository()
        {
            _context = new LibraryDbContext();
            _dbSet = _context.Set<T>();
        }

        public void Add(T entity)
        {
            if (entity == null) throw new ArgumentNullException("Data is Null");
            _dbSet.Add(entity);
            SaveChanges();
        }

        public void AddRange(ICollection<T> entities)
        {
            if (entities == null || entities.Count == 0) throw new ArgumentNullException("Data is Null");
            _dbSet.AddRange(entities);
            SaveChanges();
        }

        public void RemoveRange(ICollection<T> entities)
        {
            if (entities == null || entities.Count == 0) throw new ArgumentNullException("Data is Null");
            _dbSet.RemoveRange(entities);
            SaveChanges();
        }

        public ICollection<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public T? GetById(int id)
        {
            return _dbSet.FirstOrDefault(p => p.Id == id);
        }

        public void Remove(T entity)
        {
            var en = _dbSet.FirstOrDefault(p => p.Id == entity.Id);
            if (en == null) return;

            _dbSet.Remove(entity);
            SaveChanges();
        }

        public void Remove(int id)
        {
            var entity = _dbSet.FirstOrDefault(p => p.Equals(id));
            if (entity == null) throw new Exception("No Data");

            _dbSet.Remove(entity);
            SaveChanges();
        }
        public void Update(T entity)
        {
            var en = _dbSet.FirstOrDefault(p => p.Id == entity.Id);
            if (en == null) throw new Exception("No Data");
            _dbSet.Update(entity);
            SaveChanges();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }


    }
}
