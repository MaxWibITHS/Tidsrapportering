using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tidsrapportering
{
    internal class ArbetsInfo
    {
       public string Name { get; set; }
       public string Date { get; set; }
       public string WorkStart {get; set;}  
       public string WorkEnd {get; set;} 
       public string WorkType { get; set; }
        public string Comment { get; set; }

        public ArbetsInfo(string name, string date, string workStart, string workEnd, string workType, string comment)
        {
            this.Name = name;
            this.Date = date;
            this.WorkStart = workStart;
            this.WorkEnd = workEnd;
            this.WorkType = workType;
            this.Comment = comment;
        }   
    }
}
