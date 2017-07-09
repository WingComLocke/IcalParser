using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICalParser;

namespace ICalParser {
    public class t_time
    {
        // Field
        int year { get; set; }
        int month { get; set; }
        int day { get; set; }
        int weekday { get; set; }
        int hour { get; set; }
        int min { get; set; }
        int sec { get; set; }


        // Constructor including weekday
        public t_time(int Inyear, int Inmonth, int Inday, int Inweekday, int Inhour, int Inmin, int Insec)
        {
            year = Inyear;
            month = Inmonth;
            day = Inday;
            weekday = Inweekday;
            hour = Inhour;
            min = Inmin;
            sec = Insec;

        }

        // Constructor excluding weekday
        public t_time(int Inyear, int Inmonth, int Inday, int Inhour, int Inmin, int Insec)
        {
            year = Inyear;
            month = Inmonth;
            day = Inday;

            hour = Inhour;
            min = Inmin;
            sec = Insec;

            weekday = calculate_Weekday(Inyear, Inmonth, Inday);

        }

        // Copy Constructor
        public t_time(t_time source)
        {
            year = source.year;
            month = source.month;
            day = source.day;

            hour = source.hour;
            min = source.min;
            sec = source.sec;

            weekday = source.weekday;

        }

        // Internal use functions
        public int calculate_Weekday(int year, int month. int day)
        {
            int calculatedWeekday;
            int century;

            century = year / 100;

            calculatedWeekday = (day + (2.6 * month - 0.2) - 2 * century + year + (year / 4) + (century / 4) % 7);
        }

    }

}