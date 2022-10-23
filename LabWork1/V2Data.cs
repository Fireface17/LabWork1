using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork1
{
    abstract class V2Data
    {
        public string String1 { get; set; }
        public DateTime Datetime1 { get; set; }
        public V2Data(string String1, DateTime Datetime1) { this.String1 = String1; this.Datetime1 = Datetime1; }
        public abstract float MinDistance
        {
            get;
        }
        public abstract string ToLongString(string format);
        public override string ToString() => $"{String1}, {Datetime1}"; //return
       
    }
}
