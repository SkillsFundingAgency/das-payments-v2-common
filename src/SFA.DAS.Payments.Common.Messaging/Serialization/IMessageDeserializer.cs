using Microsoft.Azure.ServiceBus;

namespace SFA.DAS.Payments.Common.Messaging.Serialization
{
    public interface IMessageDeserializer
    {
        object DeserializeMessage(Message message);
    }
}