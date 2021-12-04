using System.Collections.Generic;
using System.Linq;
using AdventOfCode;
using AdventOfCode.Models;
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
        public void Puzzle1(int[] data)
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
        public void Puzzle2(int[] data)
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
        public void Puzzle3(KeyValuePair<Direction, int>[] data)
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
        public void Puzzle4(KeyValuePair<Direction, int>[] data)
        { 
            _output.WriteLine($"Records to process: {data.Length}");
            var result = Day2.Question2(data);

            if (data.Length == 6)
                result.Should().Be(900);

            _output.WriteLine(result.ToString());
        }

        [Theory]
        [ClassData(typeof(Data.Day3.Sample))]
        [ClassData(typeof(Data.Day3.Live))]
        public void Puzzle5(string[] data)
        { 
            _output.WriteLine($"Records to process: {data.Length}");
            var result = Day3.Question1(data);

            if (data.Length == 12)
                result.Should().Be(198);

            _output.WriteLine(result.ToString());
        }

        [Theory]
        [ClassData(typeof(Data.Day3.Sample))]
        [ClassData(typeof(Data.Day3.Live))]
        public void Puzzle6(string[] data)
        { 
            _output.WriteLine($"Records to process: {data.Length}");
            var result = Day3.Question2(data);

            if (data.Length == 12)
                result.Should().Be(230);

            _output.WriteLine(result.ToString());
        }

        [Theory]
        [ClassData(typeof(Data.Day4.Sample))]
        [ClassData(typeof(Data.Day4.Live))]
        public void Puzzle7(KeyValuePair<int[], List<BingoCard>>[] data)
        { 
            _output.WriteLine($"Records to process: {data.First().Value.Count}");
            var result = Day4.Question1(data.First());

            result.Should().Be(data.First().Value.Count == 3 ? 4512 : 87456);

            _output.WriteLine(result.ToString());
        }

        [Theory]
        [ClassData(typeof(Data.Day4.Sample))]
        [ClassData(typeof(Data.Day4.Live))]
        public void Puzzle8(KeyValuePair<int[], List<BingoCard>>[] data)
        { 
            _output.WriteLine($"Records to process: {data.First().Value.Count}");
            var result = Day4.Question2(data.First());

            result.Should().Be(data.First().Value.Count == 3 ? 1924 : 15561);

            _output.WriteLine(result.ToString());
        }
    }
}
