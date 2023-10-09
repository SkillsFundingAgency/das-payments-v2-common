using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace SFA.DAS.Payments.Common.Application.Batch
{
    public interface IBatchedDataCache<T>
    {
        Task AddPayment(T model, CancellationToken cancellationToken);
        Task<List<T>> GetPayments(int batchSize, CancellationToken cancellationToken);
    }
}
