using SFA.DAS.Payments.Model.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using static SFA.DAS.Payments.Model.Core.Config.Consts;
namespace SFA.DAS.Payments.Model.Core.Audit
{
    public class DataLockEventModel : PaymentsEventModel
    {
        public long Id { get; set; }
        public Guid EarningEventId { get; set; }
        public ContractType ContractType { get; set; }
        public string AgreementId { get; set; }
        public List<DataLockEventPriceEpisodeModel> PriceEpisodes { get; set; }
        public virtual List<DataLockEventNonPayablePeriodModel> NonPayablePeriods { get; set; } = new List<DataLockEventNonPayablePeriodModel>();
        public virtual List<DataLockEventPayablePeriodModel> PayablePeriods { get; set; } = new List<DataLockEventPayablePeriodModel>();
        public string IlrFileName { get; set; }

        [Column(TypeName = DbDecimalPlaceConfig)]
        public decimal? SfaContributionPercentage { get; set; }
        public string EventType { get; set; }
        public bool IsPayable { get; set; }
        public DataLockSource DataLockSource { get; set; }
        public int? AgeAtStartOfLearning { get; set; }
    }
}