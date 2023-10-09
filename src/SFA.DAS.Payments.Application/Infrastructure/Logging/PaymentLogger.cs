using ESFA.DC.Logging;
using ESFA.DC.Logging.Config.Interfaces;
using ESFA.DC.Logging.Interfaces;

namespace SFA.DAS.Payments.Common.Application.Infrastructure.Logging
{
    public class PaymentLogger : SeriLogger, IPaymentLogger
    {
        public PaymentLogger(IApplicationLoggerSettings applicationLoggerSettings, IExecutionContext executionContext, ISerilogLoggerFactory loggerFactory = null)
            : base(applicationLoggerSettings, executionContext, loggerFactory)
        {

        }

    }
}
