using SFA.DAS.Payments.Application.Infrastructure.UnitOfWork;

namespace SFA.DAS.Payments.Application.Batch
{
    public interface IBatchScope: IUnitOfWorkScope
    {
        IBatchProcessor<T> GetBatchProcessor<T>();
    }
}