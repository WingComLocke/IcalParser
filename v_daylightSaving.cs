using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICalParser;

namespace ICalParser
{
    public class v_daylightSaving
    {
        public v_daylightSaving()
        {

        }
        public string TZID { get; set; }
        public t_time switchForward;
        public t_time switchBackward;
        public int timeDifference { get; set; }

        public v_daylightSaving(string ID, t_time SF, t_time SB, int TD)
        {
            TZID = ID;
            switchForward = SF;
            switchBackward = SB;
            timeDifference = TD;
        }


    }
}

