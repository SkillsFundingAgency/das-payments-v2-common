using System;

namespace SFA.DAS.Payments.Common.Model.Core.Exceptions
{
    public class ApprenticeshipAlreadyExistsException : Exception
    {
        public ApprenticeshipAlreadyExistsException(long apprenticeshipId) :
            base($"Apprenticeship Id: {apprenticeshipId} already exists")
        {
        }
    }
}