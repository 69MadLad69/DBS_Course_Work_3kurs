using DBS_Course_Work_3kurs.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBS_Course_Work_3kurs.EF
{
    public interface IUnitOfWork : IDisposable
    {
        IBooksRepository books { get; }
        ICustomersRepository customers { get; }
        IDiscountsRepository discounts { get; }
        IFinesRepository fines { get; }
        ILendingsRepository lendings { get; }
    }
}
