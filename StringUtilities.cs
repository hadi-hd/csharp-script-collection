using System;
using System.Text.RegularExpressions;

namespace HadiHD
{
    public static class StringUtilities
    {
        public static bool isValidPhoneNumber(this string str)
        {
            return Regex.IsMatch(str, @"^(\+?98|0)?9\d{9}$");
        }
        public static bool isValidJson(this string str)
        {
            return Regex.IsMatch(str, @"^(?=\[).+(?=\])|(?={).+(?=})$");
        }
        public static bool isValidUrl(this string str)
        {
            return Uri.TryCreate(str, UriKind.Absolute, out _);
        }
        public static bool isValidUsername(this string str)
        {
            return Regex.IsMatch(str, @"^(?=[a-zA-Z])[-\w.]{0,23}([a-zA-Z\d]|(?<![-.])_)$");
        }
        public static bool isValidEmail(this string str)
        {
            return Regex.IsMatch(str, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }
        public static bool isValidPath(this string str)
        {
            return Regex.IsMatch(str, @"^(?:[a-zA-Z]\:|\\\\[\w\.]+(\\|\/)[\w.$]+)(\\|\/)(?:[\w]+(\\|\/))*\w([\w.])+(\\|\/)?$");
        }
        public static bool isValidIPAddress(this string str)
        {
            return Regex.IsMatch(str, @"^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])(\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])){3}$");
        }
        public static bool isValidDateTime(this string str)
        {
            return DateTime.TryParse(str, out _);
        }
    }
}
