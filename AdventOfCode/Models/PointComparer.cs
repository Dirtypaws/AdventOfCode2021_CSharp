using System;
using System.Linq;

namespace AdventOfCode.Models
{
    public class VolcanicPoint : IEquatable<VolcanicPoint>
    {
        public readonly int X;
        public readonly int Y;

        public VolcanicPoint(int x, int y)
        {
            X = x;
            Y = y;

        }

        public bool Equals(VolcanicPoint other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return X == other.X && Y == other.Y;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((VolcanicPoint)obj);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(X, Y);
        }
    }


}