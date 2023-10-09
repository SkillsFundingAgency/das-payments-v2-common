using System.Collections.Generic;
using SFA.DAS.Payments.Common.Model.Core;

namespace SFA.DAS.Payments.Common.Messages.Core.Events
{
    public interface IEarningEvent : IPaymentsEvent
    {
        List<PriceEpisode> PriceEpisodes { get; }
        short CollectionYear { get; }
    }
}
