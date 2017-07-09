using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICalParser;

/// <summary>
/// Summary description for Class1
/// </summary>
namespace ICalParser
{
    public class v_alarm
    {
        public v_alarm(v_alarm alarm)
        {
            this.display = alarm.display;
            this.trigger = alarm.trigger;
            this.description = alarm.description;
        }

        public v_alarm(string Display, string Trigger, string Description)
        {
            display = Display;
            trigger = Trigger;
            description = Description;
        }

        public string display { get; set; }
        public string trigger { get; set; }
        public string description { get; set; }

    }
}