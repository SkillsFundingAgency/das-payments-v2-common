using SFA.DAS.Payments.Model.Core.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using static SFA.DAS.Payments.Model.Core.Config.Consts;

namespace SFA.DAS.Payments.Messages.Common.Events
{
    public abstract class PeriodisedPaymentEvent : PaymentsEvent, IPeriodisedPaymentEvent
    {
        public Guid EarningEventId { get; set; }
        public Guid? ClawbackSourcePaymentEventId { get; set; }
        public string PriceEpisodeIdentifier { get; set; }

        [Column(TypeName = DbDecimalPlaceConfig)]
        public decimal AmountDue { get; set; }
        public byte DeliveryPeriod { get; set; }
        public long? AccountId { get; set; }
        public long? TransferSenderAccountId { get; set; }
        public ContractType ContractType { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? PlannedEndDate { get; set; }
        public DateTime? ActualEndDate { get; set; }
        public byte CompletionStatus { get; set; }

        [Column(TypeName = DbDecimalPlaceConfig)]
        public decimal CompletionAmount { get; set; }

        [Column(TypeName = DbDecimalPlaceConfig)]
        public decimal InstalmentAmount { get; set; }
        public short NumberOfInstalments { get; set; }
        public DateTime? LearningStartDate { get; set; }
        public long? ApprenticeshipId { get; set; }
        public long? ApprenticeshipPriceEpisodeId { get; set; }
        public ApprenticeshipEmployerType ApprenticeshipEmployerType { get; set; }
        public string ReportingAimFundingLineType { get; set; }
        public virtual TransactionType TransactionType { get; protected set; }
        public long? LearningAimSequenceNumber { get; set; }
    }
}