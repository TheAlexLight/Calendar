using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calendar.Models
{
    public class CalendarImplementation /*: ICalendar*/
    {
        private readonly List<ChooseDate> _dataList;

        public CalendarImplementation()
        {
            _dataList = new List<ChooseDate>
            {
                new ChooseDate{SelectedDate = new DateTime(2020, 06, 26), IsSelected = false},
                new ChooseDate{SelectedDate = new DateTime(2020, 06, 25), IsSelected = true},
                new ChooseDate{SelectedDate = new DateTime(2020, 06, 24), IsSelected = false}
            };
        }

        public IEnumerable<ChooseDate> CheckAllDates()
        {
            return _dataList;
        }

        public ChooseDate CheckIn(/*DateTime*/ChooseDate date)
        {
            //_dataList.FirstOrDefault(d => DateTime.Compare(date, d.SelectedDate) == 0).IsSelected = true;
            //return _dataList.FirstOrDefault(d => DateTime.Compare(date, d.SelectedDate) == 0);
            throw new NotImplementedException();
        }

        public int GetMonthDate(DateTime date)
        {
            return DateTime.DaysInMonth(date.Year, date.Month);
        }
    }
}
