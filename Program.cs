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

                    string ticket = Console.ReadLine();
                    // Summary of ticket
                    Console.WriteLine("Enter a summary for the ticket.");

                    string summary = Console.ReadLine();
                    // Status of ticket
                    Console.WriteLine("What is the status of the ticket?");

                    string status = Console.ReadLine();
                    // Priority of ticket
                    Console.WriteLine("What is the priority of the ticket?");

                    string priority = Console.ReadLine();
                    // Submitted ticket
                    Console.WriteLine("Who submitted the ticket?");

                    string submit = Console.ReadLine();
                    // Ticket assigned
                    Console.WriteLine("Who is the ticket assigned to?");

                    string assigned = Console.ReadLine();
                    
                    // Watching ticket
                    Console.WriteLine("Who is watching the ticket?");

                    string watch = Console.ReadLine();
                    
                    sw.WriteLine("{0},{1},{2},{3},{4},{5},{6}", ticket, summary, status, priority, submit, assigned, watch);
                    
                    sw.Close();
                }  

            } while (option == "1" || option == "2");
        }
    }
}
