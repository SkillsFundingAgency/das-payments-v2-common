using System;
using System.ComponentModel.DataAnnotations.Schema;
using SFA.DAS.Payments.Model.Core.Entities;
using static SFA.DAS.Payments.Model.Core.Config.Consts;

namespace SFA.DAS.Payments.Model.Core.Audit
{
    public class EarningEventPeriodModel
    {
        public long Id { get; set; }
        public virtual EarningEventModel EarningEvent { get; set; }
        public Guid EarningEventId { get; set; }
        public string PriceEpisodeIdentifier { get; set; }
        public TransactionType TransactionType { get; set; }
        public short AcademicYear { get; set; }
        public byte CollectionPeriod { get; set; }
        public byte DeliveryPeriod { get; set; }
        [Column(TypeName = DbDecimalPlaceConfig)]
        public decimal Amount { get; set; }
        [Column(TypeName = DbDecimalPlaceConfig)]
        public decimal? SfaContributionPercentage { get; set; }
        public DateTime? CensusDate { get; set; }
    }
}