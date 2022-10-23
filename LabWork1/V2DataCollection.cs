using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork1
{
    class V2DataCollection : System.Collections.ObjectModel.ObservableCollection<V2Data>
    {
        public Collection Coll = new();
        public new V2Data this[int index]
        {
            get { return (V2Data)this[index]; }
        }
        public bool Contains(string ID)
        {
            if(Coll.Contains(ID))
                return true;
            return false;
        }
        public bool Remove(string ID)
        {
            if(Coll.Contains(ID)) { Coll.Remove(ID); return true; }
            else { return false; }
        }
        public bool Add (V2Data v2data)
        {
            if (Coll.Contains(v2data.String1) == false)
            {
                Coll.Add(v2data);
                return true;
            }
            else return false;
        }
        public void AddDefaults()
        {
            Coll.Add
        }
    }
}
