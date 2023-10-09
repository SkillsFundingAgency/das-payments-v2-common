using System.Linq;
using ESFA.DC.Logging.Config.Interfaces;
using ESFA.DC.Logging.Enums;

namespace SFA.DAS.Payments.Common.Application.Infrastructure.Logging
{
    public static class IApplicationLoggerSettingsExtensions
    {
        public static LogLevel MinimumLogLevel(this IApplicationLoggerSettings settings)
            => settings.ApplicationLoggerOutputSettingsCollection.Min(x => x.MinimumLogLevel);
    }
}