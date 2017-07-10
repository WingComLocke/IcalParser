using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICalParser;

namespace ICalParser
{
    public class icalSchedule
    {
        //Constructor
        //Reads through the document given by the path and generates the members
        public icalSchedule(string icalPath)
        {
            StreamReader reader(icalPath);
            line = reader.ReadLine();


            while (line != "End:VCALANDER" || line != NULL)
            {
               
                


            }
        }

        //Defult constructor. Empty Schedule
        public icalSchedule(string icalPath) { }
            

        //Members
        string scheduleName { get; set; }
        string productID { get; set; }
        string calScale { get; set; }
        string version { get; set; }
        v_timezone timezone { get; set; }

           private list<vEvent> calEvents;

        //Function which adds an event.
        public void addEvent(t_time Instart_time, t_time Inend_time, t_time Intime_created, t_time Intime_last_modified, string InUID, string Indiscription, string Inlocation, string Instatus, string Insummary, string Intransparenty, int Insequence, vAlarm alarm)
        {
            vEvent temp(Instart_time, Inend_time, Intime_created, Intime_last_modified,  InUID,  Indiscription, Inlocation,  Instatus,  Insummary,  Intransparenty,  Insequence, alarm);
            calEvents.add(temp);
        }

        //Function which removes a event (by name)
        //Removes all events of that name
        public void removeEvent(string eventName)
        {
            for(int i = 0; i < calEvents.Count; i++)
            {
                if (calEvents[i].name == eventName) {
                    calEvents.RemoveAt(i);
                }
            }
        }

     


    }

}