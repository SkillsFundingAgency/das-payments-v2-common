using SFA.DAS.Payments.Common.Model.Core.OnProgramme;

namespace SFA.DAS.Payments.Common.Model.Core.Incentives
{
    public class IncentiveEarning : Earning
    {
        public IncentiveEarningType Type { get; set; }
    }
}