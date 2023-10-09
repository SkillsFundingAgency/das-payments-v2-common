namespace SFA.DAS.Payments.Common.Messages.Core.Events
{
    public interface IContractType1EarningEvent : IContractTypeEarningEvent
    {
        string AgreementId { get; }
    }
}