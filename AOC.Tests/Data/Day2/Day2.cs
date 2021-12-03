using System;
using System.Collections.Generic;
using System.Linq;
using AdventOfCode;

namespace AOC.Tests.Data
{
    public class Day2
    {
        private static KeyValuePair<Direction, int> Serialize(string line)
        {
            var row = line.Split(' ');

            return new(Enum.Parse<Direction>(row.First(), true),
                int.Parse(row.Last()));
        }

        public class Sample : DataFile<KeyValuePair<Direction, int>>
        {
            public override string Filename => "AOC.Tests.Data.Day2.Sample.txt";
            public override KeyValuePair<Direction, int> Transform(string line) => Serialize(line);
        }

        public class Live : DataFile<KeyValuePair<Direction, int>>
        {
            public override string Filename => "AOC.Tests.Data.Day2.Live.txt";
            public override KeyValuePair<Direction, int> Transform(string line) => Serialize(line);
        }
    }
}