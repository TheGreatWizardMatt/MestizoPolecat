using System;
using System.Collections.Generic;
using System.Text;

namespace ModelingSandbox
{
    public class Location
    {
        public static int GetDistance(Location FromHere, Location ToHere)
        {
            double x = Math.Abs(FromHere.X - ToHere.X);
            double y = Math.Abs(FromHere.Y - ToHere.Y);
            double distance = Math.Sqrt((x * x) + (y * y));
            return (int)distance;
        }
        public int X;
        public int Y;

        public override string ToString()
        {
            return $"X:{X} Y:{Y}";
        }
    }
}
