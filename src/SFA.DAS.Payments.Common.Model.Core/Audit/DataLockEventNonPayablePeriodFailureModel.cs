using System;

namespace SFA.DAS.Payments.Common.Model.Core.Audit
{
    public class DataLockEventNonPayablePeriodFailureModel
    {
        public long Id { get; set; }
        public Guid DataLockEventNonPayablePeriodId { get; set; }
        public virtual DataLockEventNonPayablePeriodModel DataLockEventNonPayablePeriod { get; set; }

        public DataLockErrorCode DataLockFailure { get; set; }

        //public virtual ApprenticeshipModel Apprenticeship { get; set; }
        public long? ApprenticeshipId { get; set; }
        public short AcademicYear { get; set; }
        public byte CollectionPeriod { get; set; }
    }
}