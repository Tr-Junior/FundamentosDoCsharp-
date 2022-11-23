using System;
using System.Globalization;


namespace datas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var data = DateTime.Now;

            // var data = new DateTime(2020, 10, 12, 13, 23, 14);

            // Console.WriteLine(data);
            // Console.WriteLine(data.Year);
            // Console.WriteLine(data.Month);
            // Console.WriteLine(data.Day);
            // Console.WriteLine(data.Hour);
            // Console.WriteLine(data.Minute);
            // Console.WriteLine(data.Second);

            // Console.WriteLine(data.DayOfWeek);
            // Console.WriteLine(data.DayOfYear);
            // Console.WriteLine((int)data.DayOfWeek);

            //var formato = String.Format("{0:dd.MM.yyyy hh:mm:ss ff z}", data);
            //var formato = String.Format("{0:yy}", data);
            var formato = String.Format("{0:t}", data);
            var formato1 = String.Format("{0:d}", data);
            var formato2 = String.Format("{0:T}", data);
            var formato3 = String.Format("{0:D}", data);
            var formato4 = String.Format("{0:r}", data);
            var formato5 = String.Format("{0:s}", data);
            var formato6 = String.Format("{0:u}", data);


            Console.WriteLine(formato);
            Console.WriteLine(formato1);
            Console.WriteLine(formato2);
            Console.WriteLine(formato3);
            Console.WriteLine("--------------------------------");
            Console.WriteLine(formato4);
            Console.WriteLine(formato5);
            Console.WriteLine(formato6);
            Console.WriteLine("--------------------------------");


            var data2 = new DateTime();
            Console.WriteLine(data2);
            Console.WriteLine(data2.AddDays(12));
            Console.WriteLine(data2.AddMonths(1));
            Console.WriteLine(data2.AddYears(1));

            Console.WriteLine("--------------------------------");

            var data3 = DateTime.Now;

            if (data3.Date >= DateTime.Now.Date)
            {
                Console.WriteLine($"a data de hoje {data3} é igual a {data3}");
            }
            Console.WriteLine(data3);


            Console.WriteLine("--------------------------------");


            var pt = new CultureInfo("pt-PT");
            var br = new CultureInfo("pt-BR");
            var en = new CultureInfo("en-EN");
            var de = new CultureInfo("de-DE");

            var atual = CultureInfo.CurrentCulture;

            Console.WriteLine(DateTime.Now.ToString("D", de));
            Console.WriteLine(DateTime.Now.ToString("D", atual));

            Console.WriteLine("--------------------------------");

            var utcDate = DateTime.UtcNow;

            Console.WriteLine(utcDate);
            Console.WriteLine(DateTime.Now);


            Console.WriteLine(utcDate.ToLocalTime());

            var timezoneAustralia = TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland");
            Console.WriteLine(timezoneAustralia);

            var timeAustralia = TimeZoneInfo.ConvertTimeFromUtc(utcDate, timezoneAustralia);
            Console.WriteLine(timeAustralia);

            Console.WriteLine("--------------------------------");

            var timezones = TimeZoneInfo.GetSystemTimeZones();
            foreach (var timezone in timezones)
            {
                Console.WriteLine(timezone.Id);
                Console.WriteLine(timezone.Id);
                Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(utcDate, timezone));

            }

            Console.WriteLine("--------------------------------");

            var timeSpan = new TimeSpan();
            Console.WriteLine(timeSpan);

            var timeSpanNanoSegundos = new TimeSpan(1);
            Console.WriteLine(timeSpanNanoSegundos);

            var timeSpanHoraMinutoSegundo = new TimeSpan(5, 12, 8);
            Console.WriteLine(timeSpanHoraMinutoSegundo);

            var timeSpanDiaHoraMinutoSegundo = new TimeSpan(3, 5, 50, 10);
            Console.WriteLine(timeSpanDiaHoraMinutoSegundo);

            var timeSpanDiaHoraMinutoSegundoMiliSegundo = new TimeSpan(15, 12, 55, 10, 100);
            Console.WriteLine(timeSpanDiaHoraMinutoSegundoMiliSegundo);

            Console.WriteLine(DateTime.DaysInMonth(2022, 2));
            Console.WriteLine(IsWeekend(DateTime.Now.DayOfWeek));
            Console.WriteLine(DateTime.Now.IsDaylightSavingTime());
        }

        static bool IsWeekend(DayOfWeek today)
        {
            return today == DayOfWeek.Saturday || today == DayOfWeek.Sunday;
        }

    }
}
