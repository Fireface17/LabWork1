using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LabWork1
{
    struct UniformGrid
    {
        public float LSide { get; set; }
        public float Step { get; set; }
        public int Count { get; set; }
        public UniformGrid(float LSide, float Step, int Count) { this.LSide = LSide; this.Step = Step; this.Count = Count; }
        public float MaxNode
        {
            get
            {
                return this.LSide + this.Step * this.Count;
            }
        }
        public string ToLongString(string format)
        {
            return $"LSide - {LSide.ToString(format)} Step - {Step.ToString(format)} Count - {Count.ToString(format)}";
        }
        public override string ToString()
        {
            return $"LSide - {LSide}, Step - {Step}, Count - {Count}";
        }
    }
}
