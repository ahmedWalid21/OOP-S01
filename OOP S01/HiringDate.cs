using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_S01
{
    public class HiringDate
    {
        private int day;
        private int month;
        private int year;

        public int Day
        {
            set
            {
                day = value;
            }
            get
            {
                return day;
            }
        }
        public int Month
        {
            set
            {
               month = value;
            }
            get
            {
                return month;
            }
        }

        public int Year
        {
            set
            {
                year = value;
            }
            get
            {
                return year;
            }
        }

        public HiringDate(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }

        public override string ToString()
        {
            return $"{Day:D2}/{Month:D2}/{Year}";
        }




    }
}
