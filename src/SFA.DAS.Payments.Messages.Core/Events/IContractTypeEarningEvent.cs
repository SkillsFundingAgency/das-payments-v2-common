using System.Collections.Generic;
using SFA.DAS.Payments.Common.Model.Core.Incentives;
using SFA.DAS.Payments.Common.Model.Core.OnProgramme;

namespace SFA.DAS.Payments.Common.Messages.Core.Events
{
    public interface IContractTypeEarningEvent : IEarningEvent
    {
        List<OnProgrammeEarning> OnProgrammeEarnings { get; }
        List<IncentiveEarning> IncentiveEarnings { get;  }
    }
}
