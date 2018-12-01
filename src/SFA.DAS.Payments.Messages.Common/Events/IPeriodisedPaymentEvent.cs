﻿using SFA.DAS.Payments.Model.Core;

namespace SFA.DAS.Payments.Messages.Core.Events
{
    public interface IPeriodisedPaymentEvent: IPaymentsEvent
    {
        string PriceEpisodeIdentifier { get; }
        decimal AmountDue { get; }
        CalendarPeriod DeliveryPeriod { get; }
    }
}