using System;
using static System.Console;
namespace SwimmingWaterTemp
{
    class Program
    {
        static void Main(string[] args)
        {
            double temp;
            double lowTemp = 32;
            double highTemp = 250;   
            bool isComfterable;
            double answer = 0;           
            int waterTemp = 85;
            int lowWaterTemp = 70;
            const int EXIT = 999;
            
            


            while (answer != EXIT)
            {
                Write("Enter the temperature of the water: ");
                answer = Convert.ToInt32(ReadLine());
                IsWaterComfterable(answer);
            }

        }
        private static bool IsWaterComfterable(double temp)
        {
            bool isComfterable = true;
            try
            {
                if (temp >= 70 && temp <= 85)
                {
                    WriteLine("{0} degrees is comfterable for swimming.", temp);
                    isComfterable = true;
                }

                else if (temp > 32 && temp < 70)
                {
                    WriteLine("{0} degrees is not comfterable for swimming.", temp);
                    isComfterable = false;
                }
                else if (temp > 85 && temp < 250)
                {
                    WriteLine("{0} degrees is not comfterable for swimming.", temp);
                    isComfterable = false;
                }

                else

                    throw (new ArgumentException());
                
            }
            catch(ArgumentException e)
            {
                isComfterable = false;
                WriteLine("Value does not fall between the expected range.");
                //WriteLine("Enter another temperature or {0} to quit.", 999);

                
            }
            return isComfterable;
            

        }
    }
}
