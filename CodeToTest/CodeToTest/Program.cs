using System;

namespace CodeToTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Greeting(21);

        }

        private static string Greeting(int timeOfDay)
        {
            string greeting;
            if (timeOfDay >= 5 && timeOfDay <= 12)
            {
                greeting = "Good Morning!";
            }
            else if (timeOfDay > 12 && timeOfDay <= 18)
            {
                greeting = "Good Afternoon!";
            }
            else
            {
                greeting = "Good Evening!";
            }
            return greeting;
        }
    }
}
