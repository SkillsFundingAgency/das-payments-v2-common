﻿using System;
using System.Collections.Generic;
using Microsoft.ApplicationInsights;
using Newtonsoft.Json;
using SFA.DAS.Payments.Core;

namespace SFA.DAS.Payments.Application.Infrastructure.Telemetry
{
    public class ApplicationInsightsTelemetry : ITelemetry, IDisposable
    {
        private TelemetryClient telemetry;
        private readonly Dictionary<string, string> properties;
        public ApplicationInsightsTelemetry(TelemetryClient telemetry)
        {
            this.telemetry = telemetry ?? throw new ArgumentNullException(nameof(telemetry));
            properties = new Dictionary<string, string>();
        }

        public void AddProperty(string propertyName, string value)
        {
            properties.Add(propertyName, value);
        }

        public void TrackEvent(string eventName)
        {
            telemetry.TrackEvent($"Event: {eventName}", properties);
        }

        public void TrackDuration(string durationName, TimeSpan duration)
        {
            //telemetry.TrackMetric($"Forecasting {durationName} Duration", duration.TotalMilliseconds, properties);
            telemetry.GetMetric($"Duration: {durationName}").TrackValue(duration.TotalMilliseconds);
        }

        public void TrackDependency(string dependencyType, string dependencyName, DateTimeOffset startTime, TimeSpan duration, bool success)
        {
            telemetry.TrackDependency(dependencyType, $"Dependency: {dependencyName}", JsonConvert.SerializeObject(properties), startTime, duration, success);
        }

        private void ReleaseUnmanagedResources()
        {
            telemetry?.Flush();
            telemetry = null;
        }

        public void Dispose()
        {
            ReleaseUnmanagedResources();
            GC.SuppressFinalize(this);
        }

        ~ApplicationInsightsTelemetry()
        {
            ReleaseUnmanagedResources();
        }
    }
}