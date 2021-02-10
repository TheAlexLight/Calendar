using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Calendar.Models
{
    public class ChooseDate
    {
        //public int Id { get; set; }
        //public DateTime Start { get; set; }
        //public DateTime End { get; set; }
        //public string Text { get; set; }
        //public string Color { get; set; }

        [Key]
        public DateTime SelectedDate { get; set; }
        //public List<ChooseDate> listOfDates { get; set; }
        public bool IsSelected { get; set; }
    }
}
