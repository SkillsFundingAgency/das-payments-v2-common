using System.Linq;
using System.Net;
using Autofac;
using NServiceBus;
using NServiceBus.Features;
using NServiceBus.Logging;
using SFA.DAS.Payments.Application.Infrastructure.Logging;
using SFA.DAS.Payments.Application.Messaging;
using SFA.DAS.Payments.Core.Configuration;

namespace SFA.DAS.Payments.Application.Infrastructure.Ioc.Modules
{
    public class MessagingModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<EndpointInstanceFactory>()
                .As<IEndpointInstanceFactory>()
                .SingleInstance();
            builder.RegisterType<ExceptionHandlingBehavior>()
                .SingleInstance();
        }
    }

    public class EndpointName
    {
        public EndpointName(string endpointName)
        {
            Name = endpointName;
        }

        public string Name { get; set; }
    }
}