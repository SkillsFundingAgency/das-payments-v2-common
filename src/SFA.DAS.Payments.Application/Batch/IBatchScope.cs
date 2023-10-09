using SFA.DAS.Payments.Common.Application.Infrastructure.UnitOfWork;

namespace SFA.DAS.Payments.Common.Application.Batch
{
    public interface IBatchScope: IUnitOfWorkScope
    {
        IBatchProcessor<T> GetBatchProcessor<T>();
    }
}