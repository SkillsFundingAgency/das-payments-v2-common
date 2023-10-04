namespace SFA.DAS.Payments.Common.Messaging.Serialization
{
    public class DefaultApplicationMessageModifier : IApplicationMessageModifier
    {
        public object Modify(object applicationMessage)
        {
            return applicationMessage;
        }
    }
}