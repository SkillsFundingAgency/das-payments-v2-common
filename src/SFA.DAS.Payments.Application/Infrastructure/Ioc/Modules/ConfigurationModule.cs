using System;
using Autofac;
using SFA.DAS.Payments.Common.Application.Infrastructure.Configuration;
using SFA.DAS.Payments.Common.Core.Configuration;

namespace SFA.DAS.Payments.Common.Application.Infrastructure.Ioc.Modules
{
    public class ConfigurationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.Register((c, p) =>
                {
                    var configHelper = c.Resolve<IConfigurationHelper>();
                    bool.TryParse(configHelper.GetSettingOrDefault("ProcessMessageSequentially", "false"), out bool processMessageSequentially);

                    if (!TimeSpan.TryParse(configHelper.GetSettingOrDefault("DelayedMessageRetryDelay", "00:00:10"), out var delayedRetryDelay))
                        delayedRetryDelay = new TimeSpan(0, 0, 10);

                    return new ApplicationConfiguration
                    {
                        EndpointName = configHelper.GetSetting("EndpointName"),
                        StorageConnectionString = configHelper.GetConnectionString("StorageConnectionString"),
                        ServiceBusConnectionString = configHelper.GetConnectionString("ServiceBusConnectionString"),
                        FailedMessagesQueue = configHelper.GetSetting("FailedMessagesQueue"),
                        ProcessMessageSequentially = processMessageSequentially,
                        NServiceBusLicense = configHelper.GetSetting("DasNServiceBusLicenseKey"),
                        ImmediateMessageRetries = configHelper.GetSettingOrDefault("ImmediateMessageRetries", 1),
                        DelayedMessageRetries = configHelper.GetSettingOrDefault("DelayedMessageRetries", 3),
                        DelayedMessageRetryDelay = delayedRetryDelay,
                    };

                })
                .As<IApplicationConfiguration>()
                .SingleInstance();
        }
    }
}