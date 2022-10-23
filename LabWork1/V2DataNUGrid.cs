using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LabWork1
{
    class V2DataNUGrid : V2Data
    {
        public float[] Nodes { get; set; }
        public Vector2[] Values { get; set; }
        public V2DataNUGrid(string String1, DateTime Datetime1) : base(String1, Datetime1)
        {
            Nodes = Array.Empty<float>();
            Values = Array.Empty<Vector2>();
        }
        int[] StepValue = Array.Empty<int>();
        public V2DataNUGrid(string String1, DateTime Datetime1, float[] Nodes, FVector2 F) : base(String1, Datetime1)
        {
            this.Nodes = Nodes;
            StepValue = new int[Nodes.Length];
            Values = new Vector2[Nodes.Length];
            Random rnd = new();
            int LSide = rnd.Next(1, 10);
            for (int i = 0; i < Nodes.Length; i++)
            {
                int step = rnd.Next(1, 10);
                StepValue[i] = step;
                Values[i] = F(i * step + LSide);
            }
        }
        public override float MinDistance
        {
            get
            {
                float min = float.MaxValue;
                for (int i = 0; i < Nodes.Length; i++)
                {
                    for (int j = 0; j < Nodes.Length; j++)
                    {

                        if (i != j && min > Math.Abs(Nodes[i] - Nodes[j]))
                        {
                            min = Math.Abs(Nodes[i] - Nodes[j]);
                        }
                    }
                }
                return min;
            }
        }
        public override string ToLongString(string format)
        {
            string str = "V2DataNUGrid\n" + base.ToString();
            for (int i = 0; i < Nodes.Length; i++)
            {
                str += $"\n Node - {Nodes[i].ToString(format)} Values - {Values[i].ToString(format)} Step - {StepValue[i]}";
            }
            return str;
        }
    }
}
