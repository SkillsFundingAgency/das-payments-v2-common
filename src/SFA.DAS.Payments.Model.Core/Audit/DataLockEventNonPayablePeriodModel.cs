using SFA.DAS.Payments.Model.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using static SFA.DAS.Payments.Model.Core.Config.Consts;

namespace SFA.DAS.Payments.Model.Core.Audit
{
    public class DataLockEventNonPayablePeriodModel
    {
        public long Id { get; set; }
        public virtual DataLockEventModel DataLockEvent { get; set; }
        public Guid DataLockEventId { get; set; }
        public Guid DataLockEventNonPayablePeriodId { get; set; }
        public string PriceEpisodeIdentifier { get; set; }
        public TransactionType TransactionType { get; set; }
        public short AcademicYear { get; set; }
        public byte CollectionPeriod { get; set; }
        public byte DeliveryPeriod { get; set; }

        [Column(TypeName = DbDecimalPlaceConfig)]
        public decimal Amount { get; set; }

        [Column(TypeName = DbDecimalPlaceConfig)]
        public decimal? SfaContributionPercentage { get; set; }
        public DateTime? LearningStartDate { get; set; }
        public virtual List<DataLockEventNonPayablePeriodFailureModel> Failures { get; set; } = new List<DataLockEventNonPayablePeriodFailureModel>();
    }
}