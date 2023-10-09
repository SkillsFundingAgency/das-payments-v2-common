using ESFA.DC.Logging.Interfaces;

namespace SFA.DAS.Payments.Common.Application.Infrastructure.Logging
{
    public interface IExecutionContextFactory
    {
        IExecutionContext GetExecutionContext();
    }
}