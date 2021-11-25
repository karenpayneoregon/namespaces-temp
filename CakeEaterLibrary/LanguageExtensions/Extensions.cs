using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeEaterLibrary.LanguageExtensions
{
    /// <summary>
    /// Common string extensions 
    /// </summary>
    public static class Extensions
    {
        /// <summary>
        /// Determine if string is empty
        /// </summary>
        /// <param name="source">String to test if null or whitespace</param>
        /// <returns>true if empty or false if not empty</returns>
        [DebuggerStepThrough]
        public static bool IsNullOrWhiteSpace(this string source) 
            => string.IsNullOrWhiteSpace(source);

        /// <summary>
        /// Determine if a string can be represented as a numeric.
        /// </summary>
        /// <param name="source">value to determine if can be converted to a string</param>
        /// <returns></returns>
        [DebuggerStepThrough]
        public static bool IsNumeric(this string source) 
            => double.TryParse(source, out _ );


        #region Reverse Func logic 

        [DebuggerStepThrough]
        public static IEnumerable<T> WhereNot<T>(this IEnumerable<T> source, Func<T, bool> predicate) 
            => source.Where(element => !predicate(element));

        [DebuggerStepThrough]
        public static bool NotAll<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            foreach (T element in source)
            {
                if (!predicate(element))
                {
                    return false;
                }
            }

            return true;
        }

        #endregion

        public static bool IsEven(this int sender) => sender % 2 == 0;
    }
}
