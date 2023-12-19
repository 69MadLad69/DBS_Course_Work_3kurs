using DBS_Course_Work_3kurs.EF;
using DBS_Course_Work_3kurs.Repositories.Implementation;
using DBS_Course_Work_3kurs.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBS_Course_Work_3kurs
{
    public class RepositoryFactory
    {
        private static LibraryDBContext _context;

        public static void Initialize(LibraryDBContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public static IBooksRepository GetBooksRepository()
        {
            EnsureInitialized();
            return new BooksRepository(_context);
        }

        public static ICustomersRepository GetCustomersRepository()
        {
            EnsureInitialized();
            return new CustomersRepository(_context);
        }

        public static IDiscountsRepository GetDiscountsRepository()
        {
            EnsureInitialized();
            return new DiscountsRepository(_context);
        }

        public static IFinesRepository GetFinesRepository()
        {
            EnsureInitialized();
            return new FinesRepository(_context);
        }

        public static ILendingsRepository GetLendingsRepository()
        {
            EnsureInitialized();
            return new LendingsRepository(_context);
        }

        public static IUnitOfWork GetEFUnitOfWork()
        {
            EnsureInitialized();
            return new EFUnitOfWork(_context);
        }

        private static void EnsureInitialized()
        {
            if (_context == null)
            {
                throw new InvalidOperationException("Factory not initialized. Please call Initialize method first.");
            }
        }
    }
}
