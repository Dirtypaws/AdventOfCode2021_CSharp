using System;

namespace AOC.Tests.Data
{
    public class Day3
    {
        public static string Serialize(string line) => line;
        

        public class Sample : DataFile<string>
        {
            public override string Filename => "AOC.Tests.Data.Day3.Sample.txt";
            public override string Transform(string line) => Serialize(line);
        }

        public class Live : DataFile<string>
        {
            public override string Filename => "AOC.Tests.Data.Day3.Live.txt";
            public override string Transform(string line) => Serialize(line);
        }
    }
}