﻿using System;

namespace AOC.Tests.Data
{
    public class Day3
    {
        public class Sample : DataFile<int>
        {
            public override string Filename => "AOC.Tests.Data.Day3.Sample.txt";
            public override int Transform(string line)
            {
                throw new NotImplementedException();
            }
        }

        public class Live : DataFile<int>
        {
            public override string Filename => "AOC.Tests.Data.Day3.Live.txt";
            public override int Transform(string line)
            {
                throw new NotImplementedException();
            }
        }
    }
}