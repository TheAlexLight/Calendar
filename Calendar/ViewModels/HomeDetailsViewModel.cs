﻿using Calendar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calendar.ViewModels
{
    public class HomeDetailsViewModel
    {
        public IEnumerable<ChooseDate> CalendarDate { get; set; }
        enum MonthNames
        {
            January = 1,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December
        }
    }
}
