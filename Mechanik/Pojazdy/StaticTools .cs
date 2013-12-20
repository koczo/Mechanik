using System;
using System.Collections.Generic;
using System.Text;


namespace Mechanik.Pojazdy
{
    public static class StaticTools
    {
        public static T ConvertToEnum<T>(this string value)
        {
            if (typeof(T).BaseType != typeof(Enum))
            {
                throw new InvalidCastException();
            }

            if (Enum.IsDefined(typeof(T), value) == false)
            {
                throw new InvalidCastException();
            }

            try
            {
                return (T)Enum.Parse(typeof(T), value);
            }
            catch
            {
                throw;
            }
        }

        public static string ConvertToLower(this string value)
        {

            return value.Replace(" ", "").ToLower();
        }

        public static string FirstToUpper(this string value)
        {
            // Check for empty string.
            if (string.IsNullOrEmpty(value))
            {
                return string.Empty;
            }
            // Return char and concat substring.
            return char.ToUpper(value[0]) + value.Substring(1);
        }

    }
}