using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICalParser;
namespace ICalParser {
    public class v_timeZone
    {
        public v_timeZone(string tzid,string tzn, r_rule rRule,int TZOSF, int TZOST,v_daylightSaving DS)
        {
            TZID = tzid;
            TZName = tzn;
            recursionRule = rRule;
            TZoffSetFrom = TZOSF;
            TZoffSetTo = TZOST;
            daylightSaving = DS;
        }
        public string TZID { get; set; }
        public string TZName { get; set; }
        public r_rule recursionRule;
        public int TZoffSetFrom { get; set; }
        public int TZoffSetTo { get; set; }
        public v_daylightSaving daylightSaving;


    }

}