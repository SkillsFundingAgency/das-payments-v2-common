﻿using System.Transactions;

namespace SFA.DAS.Payments.Application.Data
{
    public static class TransactionScopeFactory
    {
        public static TransactionScope CreateWriteOnlyTransaction()
        {
            return new TransactionScope(TransactionScopeOption.Required, new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadUncommitted,
            }, TransactionScopeAsyncFlowOption.Enabled);
        }
    }
}
