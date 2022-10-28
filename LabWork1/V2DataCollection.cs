using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LabWork1
{
    class V2DataCollection : System.Collections.ObjectModel.ObservableCollection<V2Data>
    {
        public new V2Data this[int index]
        {
            get { return this[index]; }
        }
        public bool Contains(string ID)
        {
            foreach(V2Data v in this)
            {
                if (v.String1 == ID) return true; 
            }
            return false;
        }
        public bool Remove(string ID)
        {   for(int i = 0; i < this.Count; i++)
            {
                if(Contains(ID)) { base.RemoveAt(Count); return true; }
            }
            return false;
        }
        public new bool Add(V2Data v2data)
        {
            foreach (V2Data v in this)
            {
                if (v.String1 == v2data.String1) {  return false; }
            }
            base.Add(v2data);
            return true;
        }
        public void AddDefaults()
        {
            V2DataList taskList = new("task1", DateTime.Now);
            Add(taskList);
            UniformGrid taskParam = new(1, 2, 3);
            V2DataUGrid taskUGrid = new("task2", DateTime.Now, taskParam, F);
            Add(taskUGrid);
            float[] taskNodes = new float[5] { 1, 2, 3, 4, 5 };
            V2DataNUGrid taskNUGrid = new("task3", DateTime.Now, taskNodes, F);
            Add(taskNUGrid);
        }
        public override string ToString()
        {
            string str = "V2DataCollection";
            foreach (V2Data v2data in this)
            {
                str += "\n" + v2data.ToString();
            }
            return str;
        }
        public string ToLongString(string format)
        {
            string str = "V2DataCollection";
            foreach (V2Data v2data in this)
            {
                str += "\n" + v2data.ToLongString(format);
            }
            return str;
        }
        public static Vector2 F(float x)
        {
            return new Vector2(x, (float)Math.Sin(x));
        }
    }
}
