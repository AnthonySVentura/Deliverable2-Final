using System;

namespace Buffet
{
    class Lab1
    { 
        public static void Main(string[] args)
        {
            Console.WriteLine("Good morning and welcome to Tony's buffet! We offer a buffet for $9.99 and charge for water and coffee. We can sit up to six people per party.How many of you will be dining with us?");
            string guest = Console.ReadLine();
            int g = int.Parse(guest);
            
            if (g > 6 == true)
            {
                Console.WriteLine("I apoligize but we can sit only up to 6 guest and no more. Have a wonderful day!");
            }
            else
            {
                Console.WriteLine($"Table for {guest}! Sounds great, you can follow me to your table. Our options to drink again were water and coffee.");

                for (int person = 1; person <= g; person++)
                {
                    Console.WriteLine($"What could I get person {person} to drink?");
                    
                    
                }
            }

                









            










        }
    }
}


