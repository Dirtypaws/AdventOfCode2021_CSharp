using System.Collections.Generic;
using System.Threading.Tasks;
using AdventOfCode;
using AdventOfCode.Puzzles;
using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

namespace AOC.Tests
{
    
    public class PuzzleTests
    {
        private readonly ITestOutputHelper _output;

        public PuzzleTests(ITestOutputHelper output)
        {
            _output = output;
        }

        [Theory]
        [ClassData(typeof(Data.Day1.Sample))]
        [ClassData(typeof(Data.Day1.Live))]
        public async Task Puzzle1(int[] data)
        {
            _output.WriteLine($"Records to process: {data.Length}");
            var result = Day1.Question1(data);

            if (data.Length == 10)
                result.Should().Be(7);

            _output.WriteLine(result.ToString());

        }

        [Theory]
        [ClassData(typeof(Data.Day1.Sample))]
        [ClassData(typeof(Data.Day1.Live))]
        public async Task Puzzle2(int[] data)
        {
            _output.WriteLine($"Records to process: {data.Length}");
            var result = Day1.Question2(data);

            if (data.Length == 10)
                result.Should().Be(5);

            _output.WriteLine(result.ToString());
        }

        [Theory]
        [ClassData(typeof(Data.Day2.Sample))]
        [ClassData(typeof(Data.Day2.Live))]
        public async Task Puzzle3(KeyValuePair<Direction, int>[] data)
        {
            _output.WriteLine($"Records to process: {data.Length}");
            var result = Day2.Question1(data);

            if (data.Length == 6)
                result.Should().Be(150);

            _output.WriteLine(result.ToString());

        }

        [Theory]
        [ClassData(typeof(Data.Day2.Sample))]
        [ClassData(typeof(Data.Day2.Live))]
        public async Task Puzzle4(KeyValuePair<Direction, int>[] data)
        { 
            _output.WriteLine($"Records to process: {data.Length}");
            var result = Day2.Question2(data);

            if (data.Length == 6)
                result.Should().Be(900);

            _output.WriteLine(result.ToString());
        }
    }
}
