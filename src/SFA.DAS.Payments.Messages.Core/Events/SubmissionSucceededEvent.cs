﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SFA.DAS.Payments.Messages.Core.Events
{
    public class SubmissionSucceededEvent : IPaymentsMessage
    {
        public long JobId { get; set; }
        public DateTimeOffset EventTime { get; set; }
        public long Ukprn { get; set; }
        public DateTime IlrSubmissionDateTime { get; set; }
        public byte CollectionPeriod { get; set; }
        public short AcademicYear { get; set; }
    }
}
