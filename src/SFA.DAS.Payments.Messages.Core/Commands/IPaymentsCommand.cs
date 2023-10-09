using System;

namespace SFA.DAS.Payments.Common.Messages.Core.Commands
{
    public interface IPaymentsCommand: IJobMessage, ICommand
    {
        DateTimeOffset RequestTime { get; }
    }
}