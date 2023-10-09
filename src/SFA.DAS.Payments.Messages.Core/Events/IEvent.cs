using System;

namespace SFA.DAS.Payments.Common.Messages.Core.Events
{
    public interface IEvent: IPaymentsMessage
    {
        Guid EventId { get; }
        DateTimeOffset EventTime { get; }
    }
}