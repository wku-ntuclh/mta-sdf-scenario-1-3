using System;

namespace Scenario_1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input x: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Input y: ");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine(Divide(x, y));
        }

        static int Divide(int x, int y)
        {
            int result = 0;
            try
            {
                result = x / y;
            } catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            } finally
            {
                result = 0;
            }

            return result;
        }
    }
}
