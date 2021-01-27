using Calendar.Models;
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
            var model = _calendar.CheckAllDates();
            ViewBag.PageTitle = "Calendar details page";
             return View(model);
        }
    }
}
