namespace AOC.Tests.Data.Day4
{
    public class Sample : DataFile<int>
    {
        public override string Filename => "AOC.Tests.Data.Day4.Sample.txt";
        public override int Transform(string line)
        {
            return int.Parse(line);
        }
    }

    public class Live : DataFile<int>
    {
        public override string Filename => "AOC.Tests.Data.Day4.Live.txt";
        public override int Transform(string line)
        {
            return int.Parse(line);
        }
    }
}