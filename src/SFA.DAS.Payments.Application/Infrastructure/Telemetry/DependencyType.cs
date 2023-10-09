namespace SFA.DAS.Payments.Common.Application.Infrastructure.Telemetry
{
    public enum DependencyType
    {
        SqlDatabaseQuery,
        SqlDatabaseUpdate,
        SqlDatabaseInsert,
        SqlDatabaseDelete,
        SqlDatabaseMerge,
        CosmosDbQuery,
        CosmosDbUpdate,
        ApiCall,
        QueueRead,
        QueueSend
    }
}