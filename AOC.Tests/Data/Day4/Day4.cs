using System;

namespace AOC.Tests.Data
{
    public class Day4 
    {
        public class Sample : DataFile<int>
        {
            public override string Filename => "AOC.Tests.Data.Day4.Sample.txt";
            public override int Transform(string line)
            {
                throw new NotImplementedException();
            }
        }

        public class Live : DataFile<int>
        {
            public override string Filename => "AOC.Tests.Data.Day4.Live.txt";
            public override int Transform(string line)
            {
                throw new NotImplementedException();
            }
        }
    }
}