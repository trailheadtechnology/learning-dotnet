using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;

namespace session_07
{
    internal class DateTimeExamples
    {
        public void Examples()
        {
            #region Creation

            DateTime start = DateTime.Now;

            // 2015 is year, 12 is month, 25 is day  
            DateTime date = new DateTime(2015, 12, 25);
            Console.WriteLine(date.ToString()); // 12/25/2015 12:00:00 AM    

            // 2015 - year, 12 - month, 25 – day, 10 – hour, 30 – minute, 50 - second  
            DateTime date21 = new DateTime(2012, 12, 25, 10, 30, 50);
            Console.WriteLine(date21.ToString());// 12/25/2015 10:30:50 AM }  

            #endregion

            #region AddParse

            // Adding days to a date  
            DateTime today = DateTime.Now; // 6/15/2022 11:24:?? AM
            DateTime newDate2 = today.AddDays(30); // Adding one month(as 30 days)  
            Console.WriteLine(newDate2); // + 30 days

            // Parsing  
            string dateString = "Wed Dec 30, 2015";
            DateTime dateTime12 = DateTime.Parse(dateString); // 12/30/2015 12:00:00 AM  

            #endregion

            #region DateDiff

            // Date Difference  
            DateTime date1 = new DateTime(2015, 3, 10, 2, 15, 10);
            DateTime date2 = new DateTime(2015, 7, 15, 6, 30, 20);
            DateTime date3 = new DateTime(2015, 12, 28, 10, 45, 30);

            // diff1 gets 127 days, 04 hours, 15 minutes and 10 seconds.  
            TimeSpan diff1 = date2.Subtract(date1); // 127.04:15:10  
                                                    // date4 gets 8/23/2015 6:30:20 AM  
            DateTime date4 = date3.Subtract(diff1);
            // diff2 gets 166 days 4 hours, 15 minutes and 10 seconds.  
            TimeSpan diff2 = date3 - date2; //166.04:15:10  
                                            // date5 gets 3/10/2015 2:15:10 AM  
            DateTime date5 = date2 - diff1; // probably shouldn't do this

            #endregion

            #region UTC

            var x = DateTime.UtcNow;

            // Convert to Universal Time  
            DateTime dateObj = new DateTime(2015, 12, 20, 12, 20, 30); // EDT (-04:00)
            Console.WriteLine("mans" + dateObj.ToUniversalTime()); // 12/20/2015 4:20:30 PM  

            #endregion

            #region Properties

            DateTime myDate = new DateTime(2015, 12, 25, 10, 30, 45);
            DateTime datePart = myDate.Date; // 12/25/2015 12:00:00 AM
            int year = myDate.Year; // 2015  
            int month = myDate.Month; //12  
            int day = myDate.Day; // 25  
            int hour = myDate.Hour; // 10  
            int minute = myDate.Minute; // 30  
            int second = myDate.Second; // 45  
            int weekDay = (int)myDate.DayOfWeek; // 5 due to Friday  

            DateTime dt = new DateTime(2015, 12, 25);
            bool isEqual = (dt.DayOfWeek == DayOfWeek.Thursday); // False  
            bool isEqual2 = (dt.DayOfWeek == DayOfWeek.Friday); // True   

            #endregion

            #region Kind

            DateTime saveNow = DateTime.Now;
            DateTime saveUtcNow = DateTime.UtcNow;
            
            DateTime myDate3 = DateTime.SpecifyKind(saveUtcNow, DateTimeKind.Utc); // 12/20/2015 12:17:18 PM  
            DateTime myDate4 = DateTime.SpecifyKind(saveNow, DateTimeKind.Local); // 12/20/2015 5:47:17 PM  

            Console.WriteLine("Kind: " + myDate3.Kind); // Utc  
            Console.WriteLine("Kind: " + myDate4.Kind); // Local   

            #endregion

            #region Format

            DateTime tempDate = new DateTime(2015, 12, 08); // creating date object with 8th December 2015  
            tempDate.ToString(); // 12/08/2015 12:00:00 AM
            Console.WriteLine(tempDate.ToString("MMMM dd, yyyy")); //December 08, 2105.

            //Code	Description	                    Example
            //d	    Short Date	                    12/8/2015
            //D	    Long Date	                    Tuesday, December 08, 2015
            //t	    Short Time	                    3:15 PM
            //T	    Long Time	                    3:15:19 PM
            //f	    Full date and time	            Tuesday, December 08, 2015 3:15 PM
            //F	    Full date and time (long)	    Tuesday, December 08, 2015 3:15:19 PM
            //g	    Default date and time	        12/8/2015 15:15
            //G	    Default date and time (long)	12/8/2015 15:15
            //M	    Day / Month	                    8-Dec
            //r	    RFC1123 date	                Tue, 08 Dec 2015 15:15:19 GMT
            //s	    Sortable date/time	            2015-12-08T15:15:19
            //u	    Universal time, local timezone	2015-12-08 15:15:19Z
            //Y	    Month / Year	                December, 2015
            //dd	Day	                            8
            //ddd	Short Day Name	                Tue
            //dddd	Full Day Name	                Tuesday
            //hh	2 digit hour	                3
            //HH	2 digit hour (24 hour)	        15
            //mm	2 digit minute	                15
            //MM	Month	                        12
            //MMM	Short Month name	            Dec
            //MMMM	Month name	                    December
            //ss	seconds 	                    19
            //fff	milliseconds	                120
            //FFF	milliseconds w/o trailing zero	12
            //tt	AM/PM	                        PM
            //yy	2 digit year	                15
            //yyyy	4 digit year	                2015
            //:	    separator, e.g. {0:hh:mm:ss}	9:08:59
            //\/	separator, e.g. {0:dd/MM/yyyy}	8/4/2007 
            #endregion

            #region Culture

            // Current culture name  
            string currentCulture = Thread.CurrentThread.CurrentCulture.DisplayName; //en-US

            DateTime currentTime = DateTime.Now; //"1/9/2016 10:22:45 AM"  
                                                 //// Getting DateTime based on culture.  
            string dateInUSA = currentTime.ToString("D", new CultureInfo("en-US")); // USA - Saturday, January 09, 2016  
            string dateInHindi = currentTime.ToString("D", new CultureInfo("hi-IN")); // Hindi - 09 ????? 2016  
            string dateInJapan = currentTime.ToString("D", new CultureInfo("ja-JP")); // Japan - 2016?1?9?  
            string dateInFrench = currentTime.ToString("D", new CultureInfo("fr-FR")); // French - samedi 9 janvier 2016  

            string dateInOriya = currentTime.ToString("D", new CultureInfo("or")); // Oriya - 09 ???????? 2016  
                                                                                   // Convert Hindi Date to French Date  
            DateTime originalResult = new DateTime(2016, 01, 09);
            // Converting Hindi Date to DateTime object  
            bool success = DateTime.TryParse(dateInHindi, new CultureInfo("hi-IN"), DateTimeStyles.None, out originalResult);

            // Next convert current date to French date  
            string frenchTDate = originalResult.ToString("D", new CultureInfo("fr-FR")); // French - samedi 9 janvier 2016  

            // To get DatePattern from Culture  
            CultureInfo fr = new CultureInfo("fr-FR");
            string shortUsDateFormatString = fr.DateTimeFormat.LongDatePattern;
            string shortUsTimeFormatString = fr.DateTimeFormat.ShortTimePattern;

            // To get all installed culture in .Net version  
            foreach (CultureInfo ci in CultureInfo.GetCultures(CultureTypes.AllCultures))
            {
                Console.WriteLine(ci.Name + ", " + ci.EnglishName);
            }
            #endregion

            #region DateTimeOffset

            // Original time: 1/9/2016 2:27:00 PM  
            DateTimeOffset date7 = DateTimeOffset.Now; // 1/9/2016 2:27:00 PM +05:30  

            // You can get Offset value using Offset property  
            DateTimeOffset dateTimeObj = DateTime.Now;
            //dateTimeObj.Offset.Hours // 5  
            //dateTimeObj.Offset.Minutes //30  
            //dateTimeObj.Offset.Seconds // 0  

            // Get only DateTime from DateTimeOffset  
            //dateTimeObj.DateTime // 1/9/2016 2:27:00 PM  

            // Get Utc time from DateTime Offset  
            //dateTimeObj.UtcDateTime.ToString() // 1/9/2016 7:57:00 PM  

            // Get Utc from local time  
            DateTime utcTimeObj = DateTimeOffset.Parse(DateTime.Now.ToString()).UtcDateTime;

            // Another way to get Utc from local time  
            DateTime utcTimeObj2 = DateTime.Now.ToUniversalTime();

            // Get local time from Utc time  
            DateTime localVersion = DateTime.UtcNow.ToLocalTime();

            // Another way to get local(India) time from Utc time  
            localVersion = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, TimeZoneInfo.FindSystemTimeZoneById("India Standard Time"));

            #endregion

            #region Timespan

            TimeSpan ts = new TimeSpan(10, 40, 20); // 10 - hour, 40 - minute, 20 - second  
            TimeSpan ts1 = new TimeSpan(1, 2, 5, 10); // 1 - day, 2 - hour, 5 - minute, 10 – seconds  

            // You can add TimeSpan with DateTime object as well as TimeSpan object.  
            TimeSpan ts2 = new TimeSpan(10, 40, 20); // 10 - hour, 40 - minute, 20 - second  
            TimeSpan ts3 = new TimeSpan(1, 2, 5, 10); // 1 - day, 2 - hour, 5 - minute, 10 – seconds  

            DateTime tt = DateTime.Now + ts2; // Addition with DateTime  
            ts2.Add(ts3); // Addition with TimeSpan Object  


            #endregion
        }
    }
}
