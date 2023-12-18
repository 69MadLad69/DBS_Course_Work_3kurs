using DBS_Course_Work_3kurs.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBS_Course_Work_3kurs.Repositories.Implementation
{
    public class BaseRepository<T> : IRepository<T> where T : class
    {
        private readonly DbSet<T> _set;
        private readonly DbContext _context;
        public BaseRepository(DbContext context)
        {
            _context = context;
            _set = context.Set<T>();
        }

        public void Create(T item)
        {
            _set.Add(item);
        }

        public void Delete(int id)
        {
            var item = Get(id);
            _set.Remove(item);
        }

        public T Get(int id)
        {
            return _set.Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            return _set.ToList();
        }

        public IEnumerable<T> GetPage(int pageSize, int pageNum) 
        { 
            return _set.Skip(pageSize*pageNum).Take(pageSize).ToList();
        }

        public int CountPages(int pageSize) 
        {

            int numOfPages = _set.Count() / pageSize;

            if (_set.Count() % pageSize <= 0.5) 
            {
                numOfPages++;
            }

            return numOfPages;
        }

        public IEnumerable<T> Find(
            Func<T, bool> predicate,
            int pageNumber,
            int pageSize)
        {
            return _set.Where(predicate)
                .Skip(pageSize * pageNumber)
                .Take(pageNumber)
                .ToList();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(T item)
        {
            _context.Entry(item).State = EntityState.Modified;
        }
    }
}
