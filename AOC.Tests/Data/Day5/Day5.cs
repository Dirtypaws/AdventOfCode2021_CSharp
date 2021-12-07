using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using AdventOfCode.Models;

namespace AOC.Tests.Data
{
    public class Day5
    {
        public class Sample : IEnumerable<object[]>
        {
            public const string Filename = "AOC.Tests.Data.Day5.Sample.txt";

            public IEnumerable<object[]> Data
            {
                get
                {
                    using var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(Filename);
                    if (stream == null)
                        throw new ArgumentOutOfRangeException(nameof(stream), $"Could not find embedded resource");

                    using var reader = new StreamReader(stream, Encoding.UTF8);
                    var result = new List<KeyValuePair<int, int>>();

                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        if(line == null) continue;
                        var startEndSplit = line.Split(" -> ");
                        var startPoint = startEndSplit[0].Split(',');
                        var endPoint = startEndSplit[1].Split(',');

                        var startX = int.Parse(startPoint[0]);
                        var startY = int.Parse(startPoint[1]);

                        var endX = int.Parse(endPoint[0]);
                        var endY = int.Parse(endPoint[1]);

                        if(startX == endX) // Vertical Line
                            result.AddRange(Enumerable.Range(startY > endY ? endY : startY, Math.Abs(startY - endY) + 1).Select(_ => new KeyValuePair<int, int>(startX, _)).ToArray());
                        else if(startY == endY) // Horizontal Line
                            result.AddRange(Enumerable.Range(startX > endX ? endX : startX, Math.Abs(startX - endX) + 1).Select(_ => new KeyValuePair<int, int>(_, startY)).ToArray());
                        else // Diagonal Line
                        {
                            var start = new KeyValuePair<int, int>(startX, startY);
                            var end = new KeyValuePair<int, int>(endX, endY);
                            var x = start.Key;
                            var y = start.Value;

                            do
                            {
                                result.Add(new KeyValuePair<int, int>(x,y));
                                x = x > end.Key ? x - 1 : x + 1;
                                y = y > end.Value ? y - 1 : y + 1;
                            } while (x != end.Key && y != end.Value);

                            result.Add(end);
                        }
                        
                    }

                    yield return new object[]
                    {
                        result.ToArray()
                    };
                }
            } 

            //public override KeyValuePair<int[], BingoCard[]> Transform(string line) => line;
            public IEnumerator<object[]> GetEnumerator() => Data.GetEnumerator();
            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }

        public class Live : IEnumerable<object[]>
        {
            public const string Filename = "AOC.Tests.Data.Day5.Live.txt";

            public IEnumerable<object[]> Data
            {
                get
                {
                    using var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(Filename);
                    if (stream == null)
                        throw new ArgumentOutOfRangeException(nameof(stream), $"Could not find embedded resource");

                    using var reader = new StreamReader(stream, Encoding.UTF8);
                    var result = new List<KeyValuePair<int, int>>();

                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        if(line == null) continue;
                        var startEndSplit = line.Split(" -> ");
                        var startPoint = startEndSplit[0].Split(',');
                        var endPoint = startEndSplit[1].Split(',');

                        var startX = int.Parse(startPoint[0]);
                        var startY = int.Parse(startPoint[1]);

                        var endX = int.Parse(endPoint[0]);
                        var endY = int.Parse(endPoint[1]);

                        if(startX == endX) // Vertical Line
                            result.AddRange(Enumerable.Range(startY > endY ? endY : startY, Math.Abs(startY - endY) + 1).Select(_ => new KeyValuePair<int, int>(startX, _)).ToArray());
                        else if(startY == endY) // Horizontal Line
                            result.AddRange(Enumerable.Range(startX > endX ? endX : startX, Math.Abs(startX - endX) + 1).Select(_ => new KeyValuePair<int, int>(_, startY)).ToArray());
                        else // Diagonal Line
                        {
                            var start = new KeyValuePair<int, int>(startX, startY);
                            var end = new KeyValuePair<int, int>(endX, endY);
                            var x = start.Key;
                            var y = start.Value;

                            do
                            {
                                result.Add(new KeyValuePair<int, int>(x,y));
                                x = x > end.Key ? x - 1 : x + 1;
                                y = y > end.Value ? y - 1 : y + 1;
                            } while (x != end.Key && y != end.Value);

                            result.Add(end);
                        }
                        
                    }

                    yield return new object[]
                    {
                        result.ToArray()
                    };
                }
            } 

            //public override KeyValuePair<int[], BingoCard[]> Transform(string line) => line;
            public IEnumerator<object[]> GetEnumerator() => Data.GetEnumerator();
            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }
    }
}