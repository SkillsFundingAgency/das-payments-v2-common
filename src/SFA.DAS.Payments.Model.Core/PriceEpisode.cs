using System;
using System.ComponentModel.DataAnnotations.Schema;
using static SFA.DAS.Payments.Model.Core.Config.Consts;

namespace SFA.DAS.Payments.Model.Core
{
    public class PriceEpisode
    {
        public string Identifier { get; set; }
        /// <summary>
        /// Training price
        /// </summary>
        [Column(TypeName = DbDecimalPlaceConfig)]
        public decimal TotalNegotiatedPrice1 { get; set; }
        /// <summary>
        /// Assessment price
        /// </summary>
        [Column(TypeName = DbDecimalPlaceConfig)]
        public decimal? TotalNegotiatedPrice2 { get; set; }
        /// <summary>
        /// Residual training price
        /// </summary>
        [Column(TypeName = DbDecimalPlaceConfig)]
        public decimal? TotalNegotiatedPrice3 { get; set; }
        /// <summary>
        /// Residual assessment price
        /// </summary>
        [Column(TypeName = DbDecimalPlaceConfig)]
        public decimal? TotalNegotiatedPrice4 { get; set; }
        [Column(TypeName = DbDecimalPlaceConfig)]
        public decimal AgreedPrice { get; set; }
        public DateTime CourseStartDate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EffectiveTotalNegotiatedPriceStartDate { get; set; }
        public DateTime PlannedEndDate { get; set; }
        public DateTime? ActualEndDate { get; set; }
        public int NumberOfInstalments { get; set; }

        [Column(TypeName = DbDecimalPlaceConfig)]
        public decimal InstalmentAmount { get; set; }

        [Column(TypeName = DbDecimalPlaceConfig)]
        public decimal CompletionAmount { get; set; }
        public bool Completed { get; set; }

        [Column(TypeName = DbDecimalPlaceConfig)]
        public decimal? EmployerContribution { get; set; }
        public int? CompletionHoldBackExemptionCode { get; set; }
        public string FundingLineType { get; set; }
        public long? LearningAimSequenceNumber { get; set; }

        public override bool Equals(object obj)
        {
            return 
                obj != null &&
                obj is PriceEpisode e 
                && e.Identifier == Identifier;
        }

        public override int GetHashCode() => Identifier.GetHashCode();
    }
}