using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme16Pr3
{
    class DateClass
    {
        /// <summary>
        /// initialize field data 
        /// </summary>
        DateTime data;
        /// <summary>
        /// property of DateTime
        /// </summary>
        public DateTime Data { get => data; set => data = value; }
        /// <summary>
        /// Const without param
        /// </summary>
        public DateClass() { }
        /// <summary>
        /// Const with param 
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// 
        
        public DateClass(int year, int month, int day)
        {
            data = new DateTime(year, month, day);
        }
        /// <summary>
        /// Method to output the day before day
        /// </summary>
        public void DayBeforeDay()
        {
            Console.WriteLine($"{data.AddDays(-1):d}");
        }
        /// <summary>
        /// otput adfter 
        /// </summary>
        public void DayAfterDay()
        {
            Console.WriteLine($"{data.AddDays(1):d}");
        }
        /// <summary>
        /// otput days till month end
        /// </summary>

        public void DaysSum()
        {
            Console.WriteLine($"{DateTime.DaysInMonth(data.Year,data.Month)-data.Day}");
        }



    }
}
