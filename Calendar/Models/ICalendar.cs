using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calendar.Models
{
    public interface ICalendar
    {
        ChooseDate CheckIn(/*DateTime date*/ChooseDate date);
        IEnumerable<ChooseDate> CheckAllDates(DateTime? date);
        int GetMonthDate(DateTime date);
        public void AddMonth(ChooseDate date);

    }
}
