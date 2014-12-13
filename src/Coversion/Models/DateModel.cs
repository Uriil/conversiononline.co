using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Conversion.Models
{
    public class DateModel
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
        public int Hour { get; set; }
        public int Minute { get; set; }
        public int Second { get; set; }

        public DateTime ToDateTime()
        {
            try
            {
                return new DateTime(Year, Month, Day, Hour, Minute, Second);
            }
            catch (ArgumentOutOfRangeException)
            {
                return DateTime.UtcNow;
            }
        }
    }
}