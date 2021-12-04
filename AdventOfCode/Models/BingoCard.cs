using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode.Models
{
    public class BingoCard
    {
        public readonly IList<Number> Marked = new List<Number>();
        public List<Number> Numbers = new();
        public bool HasWon { get; set; }

        public bool Mark(int number)
        {
            var space = Numbers.FirstOrDefault(_ => _.Value == number);
            if (space == null) return false;

            Marked.Add(space);

            //Check for winners on the x axis
            if (Marked.Count(_ => _.X == space.X) != 5 && Marked.Count(_ => _.Y == space.Y) != 5) return false;

            HasWon = true;
            return true;

        }

        public class Number
        {
            public readonly int X;
            public readonly int Y;
            public readonly int Value;

            public Number(int x, int y, int value)
            {
                X = x;
                Y = y;
                Value = value;
            }
        }
    }
}