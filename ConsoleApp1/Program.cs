using System;
using System.Globalization;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            System.Globalization.CultureInfo customCulture = new System.Globalization.CultureInfo("en-US", true);

            customCulture.DateTimeFormat.ShortDatePattern = "yyyy-MM-dd h:mm tt";

            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
            System.Threading.Thread.CurrentThread.CurrentUICulture = customCulture;

            DateTime newDate = System.Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd h:mm tt"));


            DateTime myDate = DateTime.Now;
            string us = myDate.Date.ToString("yyyy/MM/dd", new CultureInfo("en-US"));

            CultureInfo.CurrentCulture = new CultureInfo("en-US", false);
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");

            var dd = DateTime.Now;

            var dd1 = new DateTime(dd.Year, dd.Month, dd.Day);
            var dd2 = Convert.ToDateTime(dd1, new CultureInfo("en-US"));
            var date1 = TimeZone.CurrentTimeZone.ToUniversalTime(DateTime.Now);
            System.Globalization.DateTimeFormatInfo dateInfoBr = new System.Globalization.DateTimeFormatInfo();
            dateInfoBr.ShortDatePattern = "yyyy/MM/dd";

            DateTime _myDate = Convert.ToDateTime(dd, dateInfoBr);

            //Console.WriteLine("Hello World!");
        }
    }
}
