using System;

class Program {
  public static void Main (string[] args) {

            double[] temperatures = new double[5];
            bool gettingWarmer = true;
            bool gettingCooler = true;
            double sum = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.Write($" Please enter temperature {i + 1} = ");
                temperatures[i] = double.Parse(Console.ReadLine());
                while(temperatures[i] < -30 || temperatures[i] > 130)
                {
                        Console.Write("Temperature is invalid, please enter a valid temperature.  ");
                        Console.Write($"Please enter temperature {i + 1} = ");
                        temperatures[i] = double.Parse(Console.ReadLine());
                }
                if (i > 0)
                {
                    if (temperatures[i] >= temperatures[i - 1])
                    {
                        gettingCooler = false;
                    }
                    if (temperatures[i] <= temperatures[i - 1])
                    { 
                        gettingWarmer = false;
                    }
                }
                sum += temperatures[i];
            }
            double average = sum / 5.0;
            if (gettingCooler)
            {
                Console.WriteLine($"Getting cooler:   {string.Join(" ", temperatures)}");
            }
            else if (gettingWarmer)
            {
                Console.WriteLine($"Getting warmer:   {string.Join(" ", temperatures)}");
            }
            else
            {
                Console.WriteLine($"It's a mixed bag: {string.Join(" ", temperatures)}");
            }
            Console.WriteLine($"Average: {average}");
        }
    }
