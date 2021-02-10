using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calendar.Models
{
    public class SQLCalendarRepository : ICalendar
    {
        private readonly CalendarDbContext context;

        public SQLCalendarRepository(CalendarDbContext context)
        {
            this.context = context;
        }
        public IEnumerable<ChooseDate> CheckAllDates(DateTime? date)
        {
            AddMonth(new ChooseDate(){SelectedDate = (DateTime)date });
            if (date == null)
            {
                DateTime dateNow = DateTime.Today;
                return context.Calendars.Where(d => d.SelectedDate.Year == dateNow.Year && 
                                                  d.SelectedDate.Month == dateNow.Month && 
                                                 d.SelectedDate.Day <= DateTime.DaysInMonth(dateNow.Year, dateNow.Month));
            }
            else
            {
                DateTime d2 = (DateTime)date;
                return context.Calendars.Where(d => d.SelectedDate.Year == d2.Year &&
                                                    d.SelectedDate.Month == d2.Month &&
                                                    d.SelectedDate.Day <= DateTime.DaysInMonth(d2.Year, d2.Month));
            }
            
        }

        public ChooseDate CheckIn(ChooseDate date)
        {
            AddMonth(date);
            var dateAttach = context.Calendars.Attach(date);
                dateAttach.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return date;
        }

        public int GetMonthDate(DateTime date)
        {
            throw new NotImplementedException();
        }

        public void AddMonth(ChooseDate date)
        {
            var findDate = context.Calendars.FirstOrDefault(d => d.SelectedDate == date.SelectedDate);
            if (findDate == null)
            {
                List<ChooseDate> dateRange = new List<ChooseDate>();
                for (int i = 1; i <= DateTime.DaysInMonth(date.SelectedDate.Year, date.SelectedDate.Month); i++)
                {
                    dateRange.Add(new ChooseDate() { IsSelected = false, SelectedDate = new DateTime(date.SelectedDate.Year, date.SelectedDate.Month, i) });
                }
                context.Calendars.AddRange(dateRange);
                context.SaveChanges();
                if (findDate != null)
                {
                    context.Entry(findDate).State = EntityState.Detached;
                }
            }
            else
            {
                context.Entry(findDate).State = EntityState.Detached;
            }
        }
    }
}
