using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBS_Course_Work_3kurs.Repositories.Interfaces
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();
        T Get(int id);

        IEnumerable<T> GetPage(int pageSize, int pageNum);

        int CountPages(int pageSize);

        IEnumerable<T> Find(Func<T, Boolean> predicate, int pageNumber, int pageSize);

        void Create(T entity);
        void Update(T entity);
        void Delete(int id);
        void Save();
    }
}
