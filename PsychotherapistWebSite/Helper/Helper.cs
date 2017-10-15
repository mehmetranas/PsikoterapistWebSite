using System.Runtime.CompilerServices;
using System.Web.Mvc;
using AutoMapper.QueryableExtensions;

namespace PsychotherapistWebSite.Helper
{
    public class Helper
    {
        public static string TruncateContent(string content, int maxLength)
        {
            return content.Length <= maxLength ? content : content.Substring(0, maxLength);
        }
    }
}