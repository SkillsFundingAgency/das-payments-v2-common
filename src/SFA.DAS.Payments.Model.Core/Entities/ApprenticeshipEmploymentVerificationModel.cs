using System;

namespace SFA.DAS.Payments.Model.Core.Entities
{
    public class ApprenticeshipEmploymentVerificationModel
    {
        public long Id { get; set; }
        public long ApprenticeshipId { get; set; }
        public byte PreEmploymentStatus { get; set; }
        public Guid? PreEmploymentCorrelationId { get; set; }
        public byte FirstHiringGrantStatus { get; set; }
        public Guid? FirstHiringGrantCorrelationId { get; set; }
        public byte SecondHiringGrantStatus { get; set; }
        public Guid? SecondHiringGrantCorrelationId { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}