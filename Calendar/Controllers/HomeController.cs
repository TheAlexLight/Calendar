using Calendar.Models;
using Calendar.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calendar.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICalendar _calendar;
        public HomeController(ICalendar calendar)
        {
            _calendar = calendar;
        }
        public ViewResult Index()
        {
            return View();
        }

        public ViewResult Details() 
        {
            //ChooseDate model = _calendar.CheckIn(new DateTime(2020, 06, 25));
            var model = new List<ChooseDate>(); 
            _calendar.AddMonth(new ChooseDate() { IsSelected = true, SelectedDate = new DateTime(2021, 2, 5) });
            ViewBag.PageTitle = "Calendar details page";
             return View(model);
        }
        public ViewResult Details2()
        {
            //ChooseDate model = _calendar.CheckIn(new DateTime(2020, 06, 25));
            //var model = _calendar.GetMonthDate(new DateTime(2020, 02, 7));
            //var model = _calendar.CheckAllDates(new ChooseDate() { IsSelected = true, SelectedDate = new DateTime(2021, 2, 5) }.SelectedDate);
            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel()
            {
                CalendarDate = _calendar.CheckAllDates(new ChooseDate() { IsSelected = true, SelectedDate = new DateTime(2021, 2, 5) }.SelectedDate)
            };
            ViewBag.PageTitle = "Calendar details2 page";
            return View(homeDetailsViewModel);
        }
    }
}
