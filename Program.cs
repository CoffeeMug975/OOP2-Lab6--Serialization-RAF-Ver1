using System;
using System.IO;
using System.Xml.Serialization;
using System.Text.Json;
using System.Collections.Generic;
namespace OOP2_Lab6__Serialization_RAF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lab 6 : Using Serialization and Random Access Files\n" +
                "CPRG-211-F\n" + "Daniel Asefa\n\n");
            

            // Question 1 & 2
            Console.WriteLine("Press Enter to initalize the creation of the Event object:");
            Console.ReadLine();

            Event newEvent = new Event() {EventNumber = 1, Location = "Calgary"};


            // Question 3
            Console.WriteLine("Press Enter to serialize the object to a JSON file named: \"event.json\"");
            Console.ReadLine();

            JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(newEvent, options);
            File.WriteAllText("event.json", jsonString);


            // Question 4
            Console.WriteLine("Press Enter to deserialize JSON file and display object values to console");
            Console.ReadLine();

            string filePath = "event.json";
            
            string newJsonString = File.ReadAllText(filePath);
            Event e = JsonSerializer.Deserialize<Event>(jsonString);

            Console.WriteLine(e.ToString());


            // Question 5
            Console.WriteLine("Press Enter to write \"Hackathon\" to JSON file & display first, middle and last characters");
            Console.ReadLine();

            

        }
    }
}
