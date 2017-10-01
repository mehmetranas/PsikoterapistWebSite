using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PsychotherapistWebSite.Helper_Methods
{
    public class Helper
    {
        public static string Truncate(string text, byte value)
        {
            return text.Length > value ? text.Substring(0, value) : text;
        }
    }
}