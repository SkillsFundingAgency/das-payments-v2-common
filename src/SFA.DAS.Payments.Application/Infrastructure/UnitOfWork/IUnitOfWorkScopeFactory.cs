namespace SFA.DAS.Payments.Common.Application.Infrastructure.UnitOfWork
{
    public interface IUnitOfWorkScopeFactory
    {
        IUnitOfWorkScope Create(string operationName);
    }
}