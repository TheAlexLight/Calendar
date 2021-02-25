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
            //var model = _calendar.CheckAllDates(new ChooseDate() { IsSelected = true, SelectedDate = new DateTime(2021, 2, 1) }.SelectedDate);
            ViewBag.PageTitle = "Calendar index page";
            //return View(model);
            return View();
        }
        public ViewResult Details() 
        {
            var model = _calendar.CheckAllDates(new ChooseDate() { IsSelected = true, SelectedDate = new DateTime(2021, 2, 1) }.SelectedDate);
            ViewBag.PageTitle = "Calendar details page";
             return View(model);
        }
        [HttpPost]
        public ViewResult ChangeMonth(DateTime ch_month)
        {
            var model = _calendar.CheckAllDates(new ChooseDate() { IsSelected = true, SelectedDate = new DateTime(ch_month.Year, ch_month.Month, ch_month.Day) }.SelectedDate);
            ViewBag.PageTitle = "Calendar Details page";

            return View("~/Views/Home/Details.cshtml", model);
            //return View();
        }
        public IActionResult CheckDay()
        {
           /* var model = */_calendar.CheckIn(new ChooseDate {SelectedDate = DateTime.Today , IsSelected = true});
            ViewBag.PageTitle = "Calendar Details page";

            return RedirectToAction("Details");
            //return View("~/Views/Home/Details.cshtml", model);
            //return View();
        }



        public ViewResult Details2()
        {
            return View();
        }
    }
}
