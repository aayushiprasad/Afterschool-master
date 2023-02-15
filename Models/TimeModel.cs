using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Afterschool.Models
{
    public static class TimeModel
    {
        public static List<string> SchoolEndTimes ()
        {
            List<string> t = new List<string>();

            t.Add("2:00 pm");
            t.Add("2:30 pm");
            t.Add("3:00 pm");
            t.Add("3:30 pm");
            t.Add("4:00 pm");
            t.Add("4:30 pm");
            t.Add("5:00 pm");
            t.Add("5:30 pm");
            t.Add("6:00 pm");
            t.Add("6:30 pm");

            return t;
        }

        public static List<string> timeIncrements ()
        {
            List<string> t = new List<string>();

            t.Add("15");
            t.Add("30");
            t.Add("45");
            t.Add("60");
            t.Add("75");
            t.Add("90");

            return t;
        }

        public static List<string> times()
        {
            List<string> t = new List<string>();

            t.Add("2:00");
            t.Add("2:30");
            t.Add("3:00");
            t.Add("3:30");
            t.Add("4:00");
            t.Add("4:30");
            t.Add("5:00");
            t.Add("5:30");
            t.Add("6:00");
            t.Add("6:30");
            t.Add("7:00");
            t.Add("7:30");
            t.Add("8:00");
            t.Add("8:30");
            t.Add("9:00");
            t.Add("9:30");
            t.Add("9:00");
            t.Add("9:30");
            t.Add("10:00");
            t.Add("10:30");
            t.Add("11:00");
            t.Add("11:30");
            t.Add("12:00");
            t.Add("12:30");

            return t;
        }
    }
}
