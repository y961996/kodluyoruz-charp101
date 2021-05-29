﻿using System;

namespace hazir_metotlar_datetime_math
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.Date);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);

            Console.WriteLine(DateTime.Now.DayOfWeek);
            Console.WriteLine(DateTime.Now.DayOfYear);

            Console.WriteLine(DateTime.Now.ToLongDateString());
            Console.WriteLine(DateTime.Now.ToShortDateString());
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.WriteLine(DateTime.Now.ToShortTimeString());

            Console.WriteLine(DateTime.Now.AddDays(2));
            Console.WriteLine(DateTime.Now.AddHours(3));
            Console.WriteLine(DateTime.Now.AddSeconds(23));
            Console.WriteLine(DateTime.Now.AddMonths(4));
            Console.WriteLine(DateTime.Now.AddYears(72));
            Console.WriteLine(DateTime.Now.AddMilliseconds(50));

            // DateTime Format
            Console.WriteLine(DateTime.Now.ToString("dd"));   // 12
            Console.WriteLine(DateTime.Now.ToString("ddd"));  // Sat
            Console.WriteLine(DateTime.Now.ToString("dddd")); // Saturday

            Console.WriteLine(DateTime.Now.ToString("MM"));   // 04
            Console.WriteLine(DateTime.Now.ToString("MMM"));  // Apr
            Console.WriteLine(DateTime.Now.ToString("MMM"));  // April

            Console.WriteLine(DateTime.Now.ToString("yy"));   // 21
            Console.WriteLine(DateTime.Now.ToString("yyyy")); // 2021

            // Math
            Console.WriteLine(Math.Abs(-72));
            Console.WriteLine(Math.Sin(90));
            Console.WriteLine(Math.Cos(90));
            Console.WriteLine(Math.Tan(180));

            Console.WriteLine(Math.Ceiling(72.2));
            Console.WriteLine(Math.Round(72.2));
            Console.WriteLine(Math.Round(72.7));
            Console.WriteLine(Math.Floor(72.2));

            Console.WriteLine(Math.Max(72, 1));
            Console.WriteLine(Math.Min(72, 2));
            
            Console.WriteLine(Math.Pow(4, 3));
            Console.WriteLine(Math.Sqrt(9));
            Console.WriteLine(Math.Log(9));
            Console.WriteLine(Math.Exp(3));
            Console.WriteLine(Math.Log10(100));
        }
    }
}
