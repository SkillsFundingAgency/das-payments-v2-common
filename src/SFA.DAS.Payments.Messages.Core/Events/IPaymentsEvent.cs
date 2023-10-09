using System;
using SFA.DAS.Payments.Common.Model.Core;

namespace SFA.DAS.Payments.Common.Messages.Core.Events
{
    public interface IPaymentsEvent : IJobMessage, IEvent
    {
        long Ukprn { get; }
        Learner Learner { get; }
        LearningAim LearningAim { get; }
        DateTime IlrSubmissionDateTime { get; }
        CollectionPeriod CollectionPeriod { get; }
    }
}