using System;
using System.Collections.Generic;
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

        public DateTime SelectedDay { get; set; }
        public bool IsSelected { get; set; }
    }
}
