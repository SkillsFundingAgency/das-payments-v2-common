using SFA.DAS.Payments.Model.Core.Entities;
using System;
using System.Collections.Generic;

namespace SFA.DAS.Payments.Model.Core.Audit
{
    public class EarningEventModel : PaymentsEventModel
    {
        public long Id { get; set; }
        public ContractType ContractType { get; set; }
        public string AgreementId { get; set; }
        public List<EarningEventPeriodModel> Periods { get; set; } 
        public List<EarningEventPriceEpisodeModel> PriceEpisodes { get; set; }
        public int? AgeAtStartOfLearning { get; set; }
        public string IlrFileName { get; set; }
        public decimal? SfaContributionPercentage { get; set; }
        public string EventType { get; set; }
        public Guid? ExternalEarningsId { get; set; }
    }
}