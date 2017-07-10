using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICalParser;

namespace ICalParser
{
    public class ScheduleManager
    {

        //The list of schedules this file contains
        private list<icalSchedule> schedules;

        //Stores the current number of schedules to be used internally
        private int numberOfSchedules;

        //Stores enumerated current order of schedule sorting
        //0 - Unsorted
        //1 - By time created(Most recent first) (To be written later)
        //2 - By time created(Oldest first) (To be written later)
        //3 - By Name Alphabetically (To be written later)
        // add more as needed
        private int sortingOrder;

    //Default (and only) constructor
    //Reads from the a file further already stored schedules.
    public ScheduleManager(string storagePath) {

            StreamReader reader(storagePath);
            string line = reader.ReadLine();

            while (line != NULL)
            {
                icalSchedule tempSchedule = new icalSchedule(line);
                schedules.add(tempSchedule);

                line = reader.ReadLine();
            }


        }


    }

    //Default (and only) destructor (AKA Finalizer)
    //Deletes all schedules and exports a storagePathFile (To be written, currently just deletes everything)
     ~ ScheduleManager()
    {
    
    }


    //Method for adding a new schedule (Empty)
    public void addschedule()
    {

    }

    //Method for adding a new imported schedule
    public void addschedule(string icalPath)
    {

    }

}



}