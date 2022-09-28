using System.Text.RegularExpressions;

namespace Regexes
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Завтрак в 09:00";
            Time(text);
        }

        public static void Time(string text)
        {
            Regex regex = new Regex("([0-1][0-9]|2[0-3]):[0-5][0-9]");
            MatchCollection match = regex.Matches(text);

            if (match.Count > 0)
            {
                foreach (Match m in match)
                    Console.WriteLine(m);
            }
            else
            {
                Console.WriteLine("Задано неправильное время");
            }
        }
    }
}