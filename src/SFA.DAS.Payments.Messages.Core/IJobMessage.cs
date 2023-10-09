namespace SFA.DAS.Payments.Common.Messages.Core
{
    public interface IJobMessage: IPaymentsMessage
    {
        long JobId { get; }
    }
}