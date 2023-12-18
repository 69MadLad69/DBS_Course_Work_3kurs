using DBS_Course_Work_3kurs.EF;
using DBS_Course_Work_3kurs.Entities;
using DBS_Course_Work_3kurs.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBS_Course_Work_3kurs.Repositories.Implementation
{
    public class BooksRepository : BaseRepository<Book>, IBooksRepository
    {
        public BooksRepository(LibraryDBContext context) 
            : base (context)
        { 
        }
    }
}
