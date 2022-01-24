using System;
using System.IO;

namespace TicketingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = "Tickets.csv";
            string option;

            do {
                // ask user questions
                Console.WriteLine("1. Read data from file");
                Console.WriteLine("2. Create file from data");
                Console.WriteLine("Enter any key to exit.");

                // user response
                option = Console.ReadLine();

                //user choosed an option
                if (option == "1")
                {
                    // read data from file
                    if (File.Exists(file))
                    {

                    }
                }
                else if (option == "2")
                {
                    // create file from data
                    StreamWriter sw = new StreamWriter(file);

                    // Ticket ID
                    Console.WriteLine("What is the ticket ID?");

                    // Summary of ticket
                    Console.WriteLine("Enter a summary for the ticket.");

                    // Status of ticket
                    Console.WriteLine("What is the status of the ticket?");

                    // Priority of ticket
                    Console.WriteLine("What is the priority of the ticket?");

                    // Submitted ticket
                    Console.WriteLine("Who submitted the ticket?");

                    // Ticket assigned
                    Console.WriteLine("Who is the ticket assigned to?");

                    // Watching ticket
                    Console.WriteLine("How many people are watching the ticket?");

                    
                    for (int i = 0; i < 7; i++)
                    {
                        Console.WriteLine("Who is watching the ticket?");
                    }
                }

            } while (option == "1" || option == "2");
        }
    }
}
