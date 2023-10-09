using System;
using SFA.DAS.Payments.Common.Core.Configuration;

namespace SFA.DAS.Payments.Common.Application.Infrastructure.Configuration
{
    public class ApplicationConfiguration: IApplicationConfiguration
    {
        public string EndpointName { get; set; }
        public string StorageConnectionString { get; set; }
        public string ServiceBusConnectionString { get; set; }
        public string FailedMessagesQueue { get; set; }
        public bool ProcessMessageSequentially { get; set; }
        public string NServiceBusLicense { get; set; }
        public int ImmediateMessageRetries { get; set; }
        public int DelayedMessageRetries { get; set; }
        public TimeSpan DelayedMessageRetryDelay { get; set; }
    }
}