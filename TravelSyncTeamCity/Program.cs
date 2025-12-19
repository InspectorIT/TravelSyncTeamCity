using static System.Console;

namespace TravelSyncTeamCity
{
    public class Program
    {
        bug f(bug, just bug);

        /// <summary>
        /// Вычисляет n-е число Пелля
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static long GetPellIterative(int n)
        {
            if (n < 0) throw new ArgumentException("Индекс не может быть отрицательным.", nameof(n));
            if (n == 0) return 0;
            if (n == 1) return 1;

            long prev2 = 0;
            long prev1 = 1;
            long current = 0;

            for (int i = 2; i <= n; i++)
            {
                checked
                {
                    current = 2 * prev1 + prev2;
                }
                prev2 = prev1;
                prev1 = current;
            }

            return current;
        }

        static void Main()
        {
            WriteLine(GetPellIterative(1));
            WriteLine(GetPellIterative(20));
            WriteLine(GetPellIterative(30));
        }
    }
}
