using System;

namespace GasMileage
{
    class Program
    {
        static void Main(string[] args)
        {
            float miles = 0;
            float gallons = 0;
            int counter = 0;
            float mpg = 0;
            float totalMpg = 0;

            //perform sentinal controlled conditional loop to take input and calculate mileage
            while (true)
            {
                Console.Write("Enter the number of miles you drove or enter -1 to stop: ");
                miles = float.Parse(Console.ReadLine());

                if (miles == -1)
                {
                    break;
                }

                Console.Write("Enter the number of gallons used: ");
                gallons = float.Parse(Console.ReadLine());

                mpg = miles / gallons;
                Console.WriteLine("Current MPG: {0:N}", mpg);

                totalMpg += mpg;
                counter++;

                if (counter != 0) //get average MPG
                {
                    float average = totalMpg / counter;
                    Console.WriteLine("Combined MPG: {0:N}", average);
                }
            } 

            Console.ReadKey();
        }
    }
}
