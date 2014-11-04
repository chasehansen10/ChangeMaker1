using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            //calling the function
            ChangeMaker(3.18);
            Console.WriteLine();
            ChangeMaker(0.99);
            Console.WriteLine();
            ChangeMaker(12.93);
            Console.ReadKey();
        }
        //Creating Variable ChangeMaker
        static void ChangeMaker(Double thatPaper)
        {
            //Making all my counters
            int numberOfHunits = 0;
            int numberOfFidys = 0;
            int numOfTwenties = 0;
            int numOfTens = 0;
            int numOfFives = 0;
            int numOfOnes = 0;
            int numOfQuarters = 0;
            int numOfDimes = 0;
            int numOfNickles = 0;
            int numOfPennys = 0;
            //Rounding thatPaper to the nearest hundreth
            Double rolledUpPaper = Math.Round(thatPaper,2);
            //Counting Hunnits
            while(thatPaper>100)
            {
                numberOfHunits++;
                thatPaper= thatPaper-100;
            }
            //Counting Fidys
            while(thatPaper>50)
            {
                numberOfFidys++;
                thatPaper = thatPaper - 50;
            }
            //Counting twenties
            while(thatPaper>20)
            {
                numOfTwenties++;
                thatPaper = thatPaper - 20;
            }
            //Counting Tens
            while(thatPaper>10)
            {
                numOfTens++;
                thatPaper = thatPaper - 10;
            }
            //Counting Fives
            while(thatPaper>5)
            {
                numOfFives++;
                thatPaper = thatPaper - 5;
            }
            //Counting ones
            while(thatPaper>1)
            {
                numOfOnes++;
                thatPaper = thatPaper - 1;
            }
            //Counting Quarters
            while(thatPaper>.25)
            {
                numOfQuarters++;
                thatPaper = thatPaper - .25;
            }
            //Counting Dimes
            while(thatPaper>.1)
            {
                numOfDimes++;
                thatPaper = thatPaper - .1;
            }
            //Counting nickles
            while(thatPaper>.05)
            {
                numOfNickles++;
                thatPaper = thatPaper - .05;
            }
            //Counting pennys
            while (thatPaper > 0)
            {
                numOfPennys++;
                thatPaper = thatPaper - .01;
            }
            //Write all of the Values to the console.

            Console.WriteLine("Amount: $" + rolledUpPaper);
            Console.WriteLine("Hundreds: "+numberOfHunits);
            Console.WriteLine("Fiftys: "+numberOfFidys);
            Console.WriteLine("Twenties: "+numOfTwenties);
            Console.WriteLine("Tens: "+numOfTens);
            Console.WriteLine("Fives: "+numOfFives);
            Console.WriteLine("Ones: "+numOfOnes);
            Console.WriteLine("Quarters: "+numOfQuarters);
            Console.WriteLine("Dimes: "+numOfDimes);
            Console.WriteLine("Nickles: "+numOfNickles);
            Console.WriteLine("Pennys: "+numOfPennys);
        }
    }
}
