using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleMVC.WebApp.Extensions
{
    public static class FormatExtensions
    {
        public static string ToStringFormat(this double number)
        {
            return number.ToString("C");
        }
    }
}
