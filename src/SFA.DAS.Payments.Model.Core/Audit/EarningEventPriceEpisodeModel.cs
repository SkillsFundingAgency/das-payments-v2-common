using System;
using System.ComponentModel.DataAnnotations.Schema;
using static SFA.DAS.Payments.Model.Core.Config.Consts;

namespace SFA.DAS.Payments.Model.Core.Audit
{
    public class EarningEventPriceEpisodeModel
    {
        public long Id { get; set; }
        public Guid EarningEventId { get; set; }
        public string PriceEpisodeIdentifier { get; set; }
        [Column(TypeName = DbDecimalPlaceConfig)]
        public decimal SfaContributionPercentage { get; set; }
        [Column(TypeName = DbDecimalPlaceConfig)]
        public decimal TotalNegotiatedPrice1 { get; set; }
        [Column(TypeName = DbDecimalPlaceConfig)]
        public decimal TotalNegotiatedPrice2 { get; set; }
        [Column(TypeName = DbDecimalPlaceConfig)]
        public decimal TotalNegotiatedPrice3 { get; set; }
        [Column(TypeName = DbDecimalPlaceConfig)]
        public decimal TotalNegotiatedPrice4 { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime PlannedEndDate { get; set; }
        public DateTime? ActualEndDate { get; set; }
        public int NumberOfInstalments { get; set; }
        [Column(TypeName = DbDecimalPlaceConfig)]
        public decimal InstalmentAmount { get; set; }
        [Column(TypeName = DbDecimalPlaceConfig)]
        public decimal CompletionAmount { get; set; }
        public bool Completed { get; set; }
        public DateTime? EffectiveTotalNegotiatedPriceStartDate { get; set; }
        [Column(TypeName = DbDecimalPlaceConfig)]
        public decimal? EmployerContribution { get; set; }
        public int? CompletionHoldBackExemptionCode { get; set; }
        [Column(TypeName = DbDecimalPlaceConfig)]
        public decimal AgreedPrice { get; set; }
        public DateTime CourseStartDate { get; set; }
        public short AcademicYear { get; set; }
        public byte CollectionPeriod { get; set; }
    }
}