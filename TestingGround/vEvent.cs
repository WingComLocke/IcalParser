using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICalParser;
namespace ICalParser
{

    public class vEvent
    {
        // Field
        t_time start_time { get; set; }
        t_time end_time { get; set; }
        t_time time_created { get; set; }
        t_time time_last_modified { get; set; }

        string UID { get; set; }
        string discription { get; set; }
        string location { get; set; }
        string status { get; set; }
        string summary { get; set; }
        string transparenty { get; set; }

        int sequence { get; set; }

        v_alarm alarm { get; set; }



        // Constructor including everything
        public vEvent(t_time Instart_time, t_time Inend_time, t_time Intime_created, t_time Intime_last_modified, string InUID, string Indiscription, string Inlocation, string Instatus, string Insummary, string Intransparenty, int Insequence, v_alarm Inalarm)
        {
            start_time = Instart_time;
            end_time = Inend_time;
            time_created = Intime_created;
            time_last_modified = Intime_last_modified;

            UID = InUID;
            discription = Indiscription;
            location = Inlocation;
            status = Instatus;
            summary = Insummary;
            transparenty = Intransparenty;

            sequence = Insequence;

            alarm = Inalarm;
        }

        // Copy Constructor
        public vEvent(vEvent source)
        {
            start_time = source.start_time;
            end_time = source.end_time;
            time_created = source.time_created;
            time_last_modified = source.time_last_modified;

            UID = source.UID;
            discription = source.discription;
            location = source.location;
            status = source.status;
            summary = source.summary;
            transparenty = source.transparenty;

            sequence = source.sequence;

            alarm = source.alarm;
        }


        

    }

}