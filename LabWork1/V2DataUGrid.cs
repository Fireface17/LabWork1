
//Fireface17
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LabWork1
{
    class V2DataUGrid : V2Data
    {
        public UniformGrid Parameters { get; set; }
        public Vector2[] Values { get; set; }
        public V2DataUGrid(string String1, DateTime Datetime1) : base(String1, Datetime1)
        {
            Values = Array.Empty<Vector2>();
        }
        public V2DataUGrid(string String1, DateTime Datetime1, UniformGrid Parameters, FVector2 F) : base(String1, Datetime1)
        {
            this.Parameters = Parameters;
            Values = new Vector2[Parameters.Count];
            for (int i = 0; i < Parameters.Count; i++)
            {
                Values[i] = F(i * Parameters.Step + Parameters.LSide);
            }

        }
        public override float MinDistance => Vector2.Distance(Values[1], Values[0]);
        public static explicit operator V2DataList(V2DataUGrid source)
        {
            V2DataList v2datalist = new(source.String1, source.Datetime1);
            {
                for (int i = 0; i < source.Parameters.Count; i++)
                {
                    v2datalist.Add(source.Parameters.LSide + i * source.Parameters.Step, source.Values[i]);
                }
            }
            return v2datalist;
        }
        public override string ToString()
        {
            return $"V2DataUGrid \n {String1}\n {Datetime1}\n Values - {Values} \n Parameters {Parameters} ";
        }
        public override string ToLongString(string format)
        { 
            string str = "V2DataUGrid\n" + base.ToString();
            for (int i = 0; i < Parameters.Count; i++)
            {
                str += $"\n x[{i}] = {(Parameters.LSide + Parameters.Step * i).ToString(format)} {Values[i].ToString(format)}";
            }
            str += "\n" + Parameters.ToString();
            return str;
        }
    }
    

}
