
//Fireface17
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace LabWork1
{
    class V2DataList : V2Data
    {
        public List<DataItem> Data { get; set; }
        public V2DataList(string String1, DateTime DateTime1) : base(String1, DateTime1)
        {
            Data = new List<DataItem>();    
        }
        public bool Add(float x, Vector2 field)
        {
            for(int i = 0; i < Data.Count; i++)
            {
                if (Data[i].x == x) return false;
            }
            Data.Add(new DataItem(x, field));
            return true;
        }
        public int AddDefaults(int nItems, FVector2 F)
        {
            for(int i = 0; i < nItems; i++)
            {
                float x = i * i + 2;
                Vector2 V2 = F(x);
                DataItem item = new(x, V2.X, V2.Y);
                Data.Add(item);
            }
            return Data.Count;
        }
        public override float MinDistance
        {
            get
            {
                float min = float.MaxValue;
                for(int i = 0; i < Data.Count; i++)
                {
                    for(int j = 0; j < Data.Count; j++)
                    {
                        
                        if(i != j && min > Math.Abs(Data[i].x - Data[j].x))
                        {
                            min = Math.Abs(Data[i].x - Data[j].x);
                        }
                    }
                }
                return min;
            }
        }
        public override string ToString()
        {
            string str = "V2DataList\n" + base.ToString();
            for(int i = 0; i < Data.Count; i++)
            {
                str += "\n" + Data[i].ToString();
            }
            return str;
        }
        public override string ToLongString(string format)
        {
            string str = "V2DataList\n" + base.ToString();
            for(int i = 0; i < Data.Count; i++)
            {
                str += "\n" + Data[i].ToLongString(format);
            }
            return str;
        }
    }
}
