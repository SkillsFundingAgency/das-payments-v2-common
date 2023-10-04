using System;
using System.Collections.ObjectModel;

namespace SFA.DAS.Payments.Common.Model.Core.OnProgramme
{
    public class Earning
    {
        public ReadOnlyCollection<EarningPeriod> Periods { get; set; }
        public DateTime CensusDate { get; set; }
    }
}