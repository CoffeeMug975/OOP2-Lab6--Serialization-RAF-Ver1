namespace OOP2_Lab6__Serialization_RAF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lab 6 : Using Serialization and Random Access Files\n" +
                "CPRG-211-F\n" + "Daniel Asefa\n\n");
            
            Console.WriteLine("Press Enter to initalize the creation of the Event object:");
            Console.ReadLine();

            Console.WriteLine("Press Enter to serialize the object to a JSON file named: \"event.json\"");
            Console.ReadLine();

            Console.WriteLine("Press Enter to deserialize JSON file and display object values to console");
            Console.ReadLine();

            Console.WriteLine("Press Enter to write \"Hackathon\" to JSON file & display first, middle and last characters");
            Console.ReadLine();
        }
    }
}
