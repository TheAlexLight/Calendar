﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calendar.Models
{
    public interface ICalendar
    {
        ChooseDate CheckIn(DateTime date);
        IEnumerable<ChooseDate> CheckAllDates();
    }
}
