using System;

namespace SFA.DAS.Payments.Common.Messages.Core.Commands
{
    public interface ICommand: IPaymentsMessage
    {
        Guid CommandId { get; }
    }
}