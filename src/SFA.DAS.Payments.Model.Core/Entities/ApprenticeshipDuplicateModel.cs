﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SFA.DAS.Payments.Model.Core.Entities
{
    public class ApprenticeshipDuplicateModel
    {
        public int Id { get; set; }
        public ApprenticeshipModel Apprenticeship { get; set; }
        public long Ukprn { get; set; }
        public long Uln { get; set; }
    }
}
