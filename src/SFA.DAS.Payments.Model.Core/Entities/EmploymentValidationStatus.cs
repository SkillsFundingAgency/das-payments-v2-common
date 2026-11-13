namespace SFA.DAS.Payments.Model.Core.Entities
{
    public enum EmploymentValidationStatus : byte
    {
        NotChecked = 1,
        Pending = 2,
        Employed = 3,
        NotEmployed = 4,
        Failed = 5
    }
}