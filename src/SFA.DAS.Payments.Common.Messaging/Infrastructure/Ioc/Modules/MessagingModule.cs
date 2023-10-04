using Autofac;
using SFA.DAS.Payments.Common.Messaging.Serialization;
using SFA.DAS.Payments.Common.Messaging.Serialization.NServiceBus;

namespace SFA.DAS.Payments.Common.Messaging.Infrastructure.Ioc.Modules
{
    public class MessagingModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<MessageDeserializer>()
                .As<IMessageDeserializer>();

            builder.RegisterType<DefaultApplicationMessageModifier>()
                .As<IApplicationMessageModifier>()
                .IfNotRegistered(typeof(IApplicationMessageModifier));
        }
    }
}