using System;
using System.Threading.Tasks;

namespace SFA.DAS.Payments.Common.Application.Infrastructure.UnitOfWork
{
    public interface IUnitOfWorkScope : IDisposable
    {
        T Resolve<T>();
        void Abort();
        Task Commit();
    }
}