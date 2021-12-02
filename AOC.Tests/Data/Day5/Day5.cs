using System;

namespace AOC.Tests.Data.Day5
{
    public class Sample : DataFile<int>
    {
        public override string Filename => "AOC.Tests.Data.Day5.Sample.txt";
        public override int Transform(string line)
        {
            throw new NotImplementedException();
        }
    }

    public class Live : DataFile<int>
    {
        public override string Filename => "AOC.Tests.Data.Day5.Live.txt";
        public override int Transform(string line)
        {
            throw new NotImplementedException();
        }
    }
}