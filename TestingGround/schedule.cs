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
            //intializing the reader
            StreamReader reader = new StreamReader(icalPath);

            //Reads a line from the stream
            string line = reader.ReadLine();

            //Basically weather or not we are reading the write format check
            if (line != "BEGIN:VCALENDAR") valid = false;

            line = reader.ReadLine();

            //while the file is not exhusted (or bad formating)
            while (line != "END:VCALENDAR")
            {

                //temp strings where the number indicates number of digits
                string tempTwo = null;
                string tempThree = null;
                string tempFour = null;
                string tempFive = null;
                string tempSix = null;
                string tempSeven = null;
                string tempEight = null;

                //Parsing the headers
                for (int counter = 0; counter < 8 || counter < line.Length-1; counter++)
                {
                    tempEight = tempEight + line[counter];
                    if (counter < 7)
                    {
                        tempSeven = tempSeven + line[counter];                   
                    }

                    if (counter < 6)
                    {
                        tempSix = tempSix + line[counter];
                    }

                    if (counter < 5)
                    {
                        tempFive = tempFive + line[counter];
                    }

                    if (counter < 4)
                    {
                        tempFour = tempFour + line[counter];
                    }

                    if (counter < 3)
                    {
                        tempThree = tempThree + line[counter];
                    }
                    
                    if (counter < 2)
                    {
                        tempTwo = tempTwo + line[counter];
                    }
                }

                //For extentions
                if (tempTwo == "X-")
                {
                    extentionsUsed.Add(line);
                }

                //for ProductID
                //remember to fix getting rid of header
                else if (tempSix == "PRODID")
                {
                    productID = line;
                }

                //For version
                //remember to fix the header
                else if (tempSeven == "VERSION")
                {
                    version = line;
                }

                //Nothing else to deal with for now
                else if (tempEight == "CALSCALE" && line != "CALSCALE:GREGORIAN")
                {
                    valid = false;
                }

                else if (line == "BEGIN:VTIMEZONE")
                {
                    while (line != "END:VTIMEZONE")
                    {
                        line = reader.ReadLine();

                        string vtimeTemp4 = null;
                        
                        for (int timeCounter = 0; timeCounter < 4 || timeCounter < line.Length-1; timeCounter++)
                        {
                            vtimeTemp4 = vtimeTemp4 + line[timeCounter];

                        }

                        //REMEMBER TO CLEAN THE HEADER
                        if (vtimeTemp4 == "TZID")
                        {
                            timezone.TZID = line;
                        }

                        if (line == "BEGIN:DAYLIGHT")
                        {
                            while (line != "END:DAYLIGNT")
                            {
                                line = reader.ReadLine();

                                string DaylightTemp12 = null;
                                string DaylightTemp10 = null;
                                string DaylightTemp8 = null;
                                string DaylightTemp6 = null;
                                string DaylightTemp5 = null;
                                
                                for (int dayCounter = 0; dayCounter < 12 || dayCounter < line.Length-1; dayCounter++)
                                {
                                    DaylightTemp12 = DaylightTemp12 + line[dayCounter];
                                    if (dayCounter < 10) DaylightTemp10 = DaylightTemp10 + line[dayCounter];
                                    if (dayCounter < 8) DaylightTemp8 = DaylightTemp8 + line[dayCounter];
                                    if (dayCounter < 6) DaylightTemp6 = DaylightTemp6 + line[dayCounter];
                                    if (dayCounter < 5) DaylightTemp5 = DaylightTemp5 + line[dayCounter];

                                }

                                if (DaylightTemp6 == "TZOFFSETFROM")
                                {

                                }

                                //Catch for exceptions
                                else
                                {
                                    unhandledExeptions.Add(line);
                                    line = reader.ReadLine();
                                }





                            }

                            
                        }

                        //Catch for exceptions
                        else
                        {
                            unhandledExeptions.Add(line);
                            line = reader.ReadLine();
                        }


                    }
                }

                //Catch for exceptions
                else
                {
                    unhandledExeptions.Add(line);
                    line = reader.ReadLine();
                }
                
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
        List<string> extentionsUsed;
        List<string> unhandledExeptions;

        //If the schedule is valid
        bool valid;

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