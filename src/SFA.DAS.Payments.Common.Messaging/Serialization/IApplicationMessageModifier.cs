namespace SFA.DAS.Payments.Common.Messaging.Serialization
{
    public interface IApplicationMessageModifier
    {
        object Modify(object applicationMessage);
    }
}