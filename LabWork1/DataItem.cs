using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Runtime.Intrinsics;

namespace LabWork1
{
    struct DataItem
    {
        public float x { get; set; }
        public Vector2 Vector { get; set; }
        public DataItem(float x, float v1, float v2) { this.x = x; Vector = new Vector2(v1, v2); }
        public DataItem(float x, Vector2 field) { this.x = x; Vector = field; }
        public string ToLongString(string format)
        {
            return $"x - {x.ToString(format)} Vector - {Vector.ToString(format)}";
        }
        public override string ToString()
        {
            return $"x - {x}, V2 - {Vector}";
        }
    }
}
