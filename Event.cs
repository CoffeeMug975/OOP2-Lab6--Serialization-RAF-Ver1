using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Xml.Serialization;

namespace OOP2_Lab6__Serialization_RAF
{
    [Serializable]
    public class Event
    {
        // Set the properties for the class

        public int EventNumber { get; set; }
        public string Location { get; set; }

        //public Event(int eventNumber, string location)
        //{
        //    EventNumber = eventNumber;
        //    Location = location;
        //}
        public override string ToString()
        {
            string info = ($"Event Number: {EventNumber}\nLocation: {Location}\n");
            return info;
        }
    }
}
