using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstVariable = 27;
            int secondVariable = 45;
            float bodyTemp = 98.6f;
            double weight = 53.356d;
            string name = "Dipak";
            char input = 'y';
            bool isHoliday = true;

            Console.WriteLine("Hello " + name + "! your age is " + firstVariable + 
                ", you're expecting the score of " + secondVariable + 
                ", seems your body temparature is " + bodyTemp + " but your weight " + weight + 
                " your input for holiday is " + isHoliday + " which is equal to " + input);

            Console.ReadKey();
        }
    }
}
