namespace AOC.Tests.Data
{
    public class Day1
    {
        private static int TransformData(string line) => int.Parse(line);

        public class Sample : DataFile<int>
        {
            public override string Filename => "AOC.Tests.Data.Day1.Sample.txt";

            public override int Transform(string line) => TransformData(line);
        }

        public class Live : DataFile<int>
        {
            public override string Filename => "AOC.Tests.Data.Day1.Live.txt";

            public override int Transform(string line) => TransformData(line);
        }
    }
}