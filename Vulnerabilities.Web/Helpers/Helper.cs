using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Vulnerabilities.Web.Helpers
{
    public class Helper
    {
        public static int SetCurrentMonth()
        {
            int currentMonth = DateTime.Now.Day <= 26 ? DateTime.Now.Month - 1 : DateTime.Now.Month;
            return currentMonth;
        }

        public static string[] SetMonthsNames()
        {
            int currentMonth = DateTime.Now.Day <= 26 ? DateTime.Now.Month - 1 : DateTime.Now.Month;
            DateTimeFormatInfo mfi = new DateTimeFormatInfo();
            //string firstMonth = mfi.GetMonthName(currentMonth);
            
            string secondMonth = mfi.GetMonthName(new DateTime(DateTime.Now.Year, currentMonth, 1).AddMonths(-1).Month);
            string thirdMonth = mfi.GetMonthName(new DateTime(DateTime.Now.Year, currentMonth, 1).AddMonths(-2).Month);
            string forthMonth = mfi.GetMonthName(new DateTime(DateTime.Now.Year, currentMonth, 1).AddMonths(-3).Month);
            string fifthMonth = mfi.GetMonthName(new DateTime(DateTime.Now.Year, currentMonth, 1).AddMonths(-4).Month);
            string sixthMonth = mfi.GetMonthName(new DateTime(DateTime.Now.Year, currentMonth, 1).AddMonths(-5).Month);
            string[] months = new string[] { secondMonth, thirdMonth, forthMonth, fifthMonth, sixthMonth };

            return months;
        }

        public static string[] SetLastSixMonthsNames()
        {
            int currentMonth = DateTime.Now.Day <= 26 ? DateTime.Now.Month - 1 : DateTime.Now.Month;
            DateTimeFormatInfo mfi = new DateTimeFormatInfo();
            string firstMonth = mfi.GetMonthName(currentMonth);
            string secondMonth = mfi.GetMonthName(new DateTime(DateTime.Now.Year, currentMonth, 1).AddMonths(-1).Month);
            string thirdMonth = mfi.GetMonthName(new DateTime(DateTime.Now.Year, currentMonth, 1).AddMonths(-2).Month);
            string forthMonth = mfi.GetMonthName(new DateTime(DateTime.Now.Year, currentMonth, 1).AddMonths(-3).Month);
            string fifthMonth = mfi.GetMonthName(new DateTime(DateTime.Now.Year, currentMonth, 1).AddMonths(-4).Month);
            string sixthMonth = mfi.GetMonthName(new DateTime(DateTime.Now.Year, currentMonth, 1).AddMonths(-5).Month);
            string[] months = new string[] { firstMonth,secondMonth, thirdMonth, forthMonth, fifthMonth, sixthMonth };

            return months;
        }

        public static string[] setActionValuesSeverityFive()
        {
            string[] months = SetMonthsNames();

            string[] values = new string[] { string.Concat("SeverityFive", months[0], DateTime.Now.Year.ToString()),
                                     string.Concat("SeverityFive", months[1], DateTime.Now.Year.ToString()),
                                     string.Concat("SeverityFive", months[2], (DateTime.Now.Year - 1).ToString()),
                                     string.Concat("SeverityFive", months[3], (DateTime.Now.Year-1).ToString()),
                                     string.Concat("SeverityFive", months[4], (DateTime.Now.Year-1).ToString()) };

            return values;
        }

        public static string[] setActionValuesSeverityFour()
        {
            string[] months = SetMonthsNames();

            string[] values = new string[] { string.Concat("SeverityFour", months[0], DateTime.Now.Year.ToString()),
                                     string.Concat("SeverityFour", months[1], DateTime.Now.Year.ToString()),
                                     string.Concat("SeverityFour", months[2], (DateTime.Now.Year - 1).ToString()),
                                     string.Concat("SeverityFour", months[3], (DateTime.Now.Year-1).ToString()),
                                     string.Concat("SeverityFour", months[4], (DateTime.Now.Year-1).ToString()) };

            return values;
        }

        public static string[] setActionValuesSeverityFiveMpcConfig()
        {
            string[] months = SetMonthsNames();

            string[] values = new string[] { string.Concat("SeverityFiveMpcConfig", months[0], DateTime.Now.Year.ToString()),
                                     string.Concat("SeverityFiveMpcConfig", months[1], DateTime.Now.Year.ToString()),
                                     string.Concat("SeverityFiveMpcConfig", months[2], (DateTime.Now.Year - 1).ToString()),
                                     string.Concat("SeverityFiveMpcConfig", months[3], (DateTime.Now.Year-1).ToString()),
                                     string.Concat("SeverityFiveMpcConfig", months[4], (DateTime.Now.Year-1).ToString()) };

            return values;
        }

        public static string[] setActionValuesSeverityFourMpcConfig()
        {
            string[] months = SetMonthsNames();

            string[] values = new string[] 
                                   { string.Concat("SeverityFourMpcConfig", months[0], DateTime.Now.Year.ToString()),
                                     string.Concat("SeverityFourMpcConfig", months[1], DateTime.Now.Year.ToString()),
                                     string.Concat("SeverityFourMpcConfig", months[2], (DateTime.Now.Year - 1).ToString()),
                                     string.Concat("SeverityFourMpcConfig", months[3], (DateTime.Now.Year-1).ToString()),
                                     string.Concat("SeverityFourMpcConfig", months[4], (DateTime.Now.Year-1).ToString())
                                   };

            return values;
        }

        public static string[] setActionValuesSeverityFiveMpcMissingPatch()
        {
            string[] months = SetMonthsNames();

            string[] values = new string[] { string.Concat("SeverityFiveMpcPatch", months[0], DateTime.Now.Year.ToString()),
                                     string.Concat("SeverityFiveMpcPatch", months[1], DateTime.Now.Year.ToString()),
                                     string.Concat("SeverityFiveMpcPatch", months[2], (DateTime.Now.Year - 1).ToString()),
                                     string.Concat("SeverityFiveMpcPatch", months[3], (DateTime.Now.Year-1).ToString()),
                                     string.Concat("SeverityFiveMpcPatch", months[4], (DateTime.Now.Year-1).ToString()) };

            return values;
        }

        public static string[] setActionValuesSeverityFourMpcMissingPatch()
        {
            string[] months = SetMonthsNames();

            string[] values = new string[] { string.Concat("SeverityFourMpcPatch", months[0], DateTime.Now.Year.ToString()),
                                     string.Concat("SeverityFourMpcPatch", months[1], DateTime.Now.Year.ToString()),
                                     string.Concat("SeverityFourMpcPatch", months[2], (DateTime.Now.Year - 1).ToString()),
                                     string.Concat("SeverityFourMpcPatch", months[3], (DateTime.Now.Year-1).ToString()),
                                     string.Concat("SeverityFourMpcPatch", months[4], (DateTime.Now.Year-1).ToString()) };

            return values;
        }

    }
}
