using System.Threading;
using System.Threading.Tasks;
using SFA.DAS.Payments.Common.Messages.Core.Events;

namespace SFA.DAS.Payments.Common.Application.Messaging
{
    public interface IDuplicateEarningEventService
    {
        Task<bool> IsDuplicate(IPaymentsEvent earningEvent, CancellationToken cancellationToken);
    }
}