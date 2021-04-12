using System;

namespace bug_collector
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            int total = 0;
            int days = 0;
            
            //Nested Loop
            for (days = 1; days <= 6; days++)
            { 
                int bugsCollected = 0;
              
                //Input
                Console.Write("Day {0}: ", days);
                Console.Write("How Many Bugs Collected This Day: ");
                bugsCollected = int.Parse(Console.ReadLine());

                //Calculate the total of Bugs
                 total += bugsCollected;
            }//End For

            //Output
            Console.WriteLine("In {0} day(s) you have collected {1}\n", days, total);

            Console.ReadKey();

        }//End Main

    }//End Class

}//End namespace
