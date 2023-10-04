using System.Collections.Generic;

namespace SFA.DAS.Payments.Common.Model.Core
{
    public class DataLockFailure
    {
        public long? ApprenticeshipId { get; set; }
        public DataLockErrorCode DataLockError { get; set; }
        public List<long> ApprenticeshipPriceEpisodeIds { get; set; }
    }
}