using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICalParser;
using System.IO;

namespace ICalParser
{
    public class icalSchedule
    {
        //Constructor
        //Reads through the document given by the path and generates the members
        public icalSchedule(string icalPath)
        {
            StreamReader reader = new StreamReader(icalPath);
            string line = reader.ReadLine();

            while (line != "END:VCALENDAR")
            {
                

                line = reader.ReadLine();
            }
        }

        //Defult constructor. Empty Schedule
        public icalSchedule() { }
            

        //Members
        string scheduleName { get; set; }
        string productID { get; set; }
        string calScale { get; set; }
        string version { get; set; }
        v_timeZone timezone { get; set; }
        List<string> exeptionsUsed;

        private List<vEvent> calEvents;

        //Function which adds an event.
        public void addEvent(t_time Instart_time, t_time Inend_time, t_time Intime_created, t_time Intime_last_modified, string InUID, string Indiscription, string Inlocation, string Instatus, string Insummary, string Intransparenty, int Insequence, v_alarm alarm)
        {
            vEvent temp = new vEvent(Instart_time, Inend_time, Intime_created, Intime_last_modified,  InUID,  Indiscription, Inlocation,  Instatus,  Insummary,  Intransparenty,  Insequence, alarm);
            calEvents.Add(temp);
        }

        //Function which removes a event (by name)
        //Removes all events of that name
        public void removeEvent(string eventName)
        {
            int count = calEvents.Count();
            for (int i = 0; i < count; i++)
            {
                if (calEvents[i].name == eventName) {
                    calEvents.RemoveAt(i);
                }
            }
        }

     


    }

}