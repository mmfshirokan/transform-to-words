using System;
using System.Text;

namespace TransformToWords
{
    /// <summary>
    /// Provides transformer methods.
    /// </summary>
    public static class Transformer
    {
        /// <summary>
        /// Converts number's digital representation into words.
        /// </summary>
        /// <param name="number">Number to convert.</param>
        /// <returns>Words representation.</returns>
        public static string TransformToWords(double number)
        {
            if (double.IsNaN(number))
            {
                return "NaN";
            }

            if (double.IsNegativeInfinity(number))
            {
                return "Negative Infinity";
            }

            if (double.IsPositiveInfinity(number))
            {
                return "Positive Infinity";
            }

            if (double.IsSubnormal(number))
            {
                return "Double Epsilon";
            }

            string CharToStr(char a) => a switch
            {
                '0' => "zero",
                '1' => "one",
                '2' => "two",
                '3' => "three",
                '4' => "four",
                '5' => "five",
                '6' => "six",
                '7' => "seven",
                '8' => "eight",
                '9' => "nine",
                ',' => "point",
                '-' => "Minus",
                '+' => "plus",
                'E' => "E",
                 _ => "Unexpected error",
            };
            string numberStr = number.ToString();
            StringBuilder result = new StringBuilder();
            uint cunter = 0;
            foreach (char ch in numberStr)
            {
                if (cunter == 0)
                {
                    result.Append(char.ToUpper(CharToStr(ch)[0]) + CharToStr(ch).Substring(1));
                }
                else
                {
                    result.Append(" " + CharToStr(ch));
                }

                cunter++;
            }

            return result.ToString();
        }
    }
}
