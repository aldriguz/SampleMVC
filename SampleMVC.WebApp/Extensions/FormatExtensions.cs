using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleMVC.WebApp.Extensions
{
    public static class FormatExtensions
    {
        public static string ToStringCurrency(this double number)
        {
            return number.ToString("C");
        }

        public static string ToStringPercent(this double number)
        {
            return number.ToString("P");
        }
    }
}
