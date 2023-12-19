using DBS_Course_Work_3kurs.Repositories.Implementation;
using DBS_Course_Work_3kurs.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBS_Course_Work_3kurs.EF
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private LibraryDBContext db;
        private BooksRepository booksRepository;
        private CustomersRepository customersRepository;
        private DiscountsRepository discountsRepository;
        private FinesRepository finesRepository;
        private LendingsRepository lendingsRepository;
        public EFUnitOfWork(LibraryDBContext context)
        {
            db = context;
        }

        public IBooksRepository books 
        {
            get
            {
                if (booksRepository == null) 
                {
                    booksRepository = new BooksRepository(db);
                }
                return booksRepository;
            }
        }

        public ICustomersRepository customers
        {
            get
            {
                if (customersRepository == null)
                {
                    customersRepository = new CustomersRepository(db);
                }
                return customersRepository;
            }
        }

        public IDiscountsRepository discounts
        {
            get
            {
                if (discountsRepository == null)
                {
                    discountsRepository = new DiscountsRepository(db);
                }
                return discountsRepository;
            }
        }

        public IFinesRepository fines
        {
            get
            {
                if (finesRepository == null)
                {
                    finesRepository = new FinesRepository(db);
                }
                return finesRepository;
            }
        }

        public ILendingsRepository lendings
        {
            get
            {
                if (lendingsRepository == null)
                {
                    lendingsRepository = new LendingsRepository(db);
                }
                return lendingsRepository;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }

        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
