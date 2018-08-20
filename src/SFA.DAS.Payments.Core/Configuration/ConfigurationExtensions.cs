﻿namespace SFA.DAS.Payments.Core.Configuration
{
    public static class ConfigurationExtensions
    {

        public static string GetConnectionString(this IConfigurationHelper helper, string connectionStringName)
        {
            return helper.GetSetting("ConnectionStrings", connectionStringName);
        }

        public static string GetSetting(this IConfigurationHelper helper, string settingName)
        {
            return helper.GetSetting("Settings", settingName);
        }
    }
}