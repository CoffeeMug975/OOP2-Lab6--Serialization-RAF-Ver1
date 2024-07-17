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
                "CPRG-211-F\n" + "Daniel Asefa\n\n\nEXPECTED OUTPUT");
            

            // Question 1 & 2 ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            // This section of code creates the Event object useing the Event class


            Event newEvent = new Event() {EventNumber = 1, Location = "Calgary"};

            //Console.WriteLine("Event Creation Test:\n" + newEvent.ToString()); // Used for testing event creation


            // Question 3 ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            // This section of code serializes the Event object to a JSON file named "event.json"
            

            JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(newEvent, options);
            File.WriteAllText("event.json", jsonString);


            // Question 4 ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            // This section of code deserializes the JSON file and displays the object contents to console
            

            string filePath = "event.json";
            
            string newJsonString = File.ReadAllText(filePath);
            Event e = JsonSerializer.Deserialize<Event>(jsonString);

            Console.WriteLine(e.ToString());

            // Question 5 ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            // This section of code writes the word "Hackathon" to JSON file & display first, middle and last characters

            string textExample = JsonSerializer.Serialize("Hackathon");
            File.WriteAllText("event.json", textExample);

            string readInfo = File.ReadAllText("event.json");


            string[] charsToRemove = new string[] { "\"" };
            foreach(var c  in charsToRemove)
            {
                readInfo = readInfo.Replace(c, string.Empty);
            }
            int readInfoLength = readInfo.Length;


            Console.WriteLine($"In Word: {readInfo}\n");

            Console.WriteLine($"The First Charactor is: {readInfo[0]}\n");
            Console.WriteLine($"The Middle Charactor is: {readInfo[readInfoLength / 2]}\n");
            Console.WriteLine($"The Last Charactor is {readInfo[readInfoLength - 1]}");
            
        }
    }
}
