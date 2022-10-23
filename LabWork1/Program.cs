
//Fireface17
using System;
using System.Numerics;

namespace LabWork1
{
    public delegate Vector2 FVector2(float x);
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = DateTime.Now;
            UniformGrid side = new UniformGrid(3.34f, 1, 10);
            DataItem Vector = new DataItem(10, 12.43435f, 8.13523f);
            Console.WriteLine(side.ToLongString("f2"));
            Console.WriteLine(Vector.ToLongString("f2"));
            Console.WriteLine(side.MaxNode);
            V2DataList list = new V2DataList("Privet", dateTime);
            list.AddDefaults(3, F);
            Console.WriteLine(list.ToLongString("f2"));
            V2DataList Listok = new V2DataList("Poka", dateTime);
            Listok.AddDefaults(34, F);
            Console.WriteLine(Listok.ToString());
            UniformGrid test = new(0, 1, 10);
            Console.WriteLine(test.ToString());
            V2DataUGrid Gridd = new("privetttt", dateTime, test, F);
            float min = Gridd.MinDistance;
            Console.WriteLine(Gridd.ToString());
            Console.WriteLine(Gridd.ToLongString("f2"));
            UniformGrid Vova = new(0, 1, 250);
            V2DataUGrid Vovanstrr = new("haha", dateTime, Vova, F);
            Console.WriteLine(Vovanstrr.ToLongString("f4"));
            float[] Nudes = new float[10] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            V2DataNUGrid NGrid = new("haha", dateTime, Nudes, F);
            Console.WriteLine(NGrid.ToLongString("f4"));
            Console.WriteLine(NGrid.ToString());
        }
        public static Vector2 F(float x)
        {
            return new Vector2(x, (float) Math.Sin(x));
        }
    }
}
