using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICalParser;
/// <summary>
/// Summary description for Class1
/// </summary>
namespace ICalParser
{
    public class r_rule
    {
        public r_rule()
        { }

        public string rFrequency;
        public string dayInRoutine;
        public List<t_time> ExceptionDate;
      
        

        public r_rule(string rF, string DIR, List<t_time> ED)
        {
            rFrequency = rF;
            dayInRoutine = DIR;
            for (int i = 0; i < ED.Count; i++)
            {
                ExceptionDate.Add(ED[i]);
            }
        }

    }

}

