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
    public class Day4
    {
        public class Sample : IEnumerable<object[]>
        {
            public const string Filename = "AOC.Tests.Data.Day4.Sample.txt";

            public IEnumerable<object[]> Data
            {
                get
                {
                    using var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(Filename);
                    if (stream == null)
                        throw new ArgumentOutOfRangeException(nameof(stream), $"Could not find embedded resource");

                    using var reader = new StreamReader(stream, Encoding.UTF8);
                    var result = new List<KeyValuePair<int[], List<BingoCard>>>();

                    BingoCard currentCard = null;
                    var calledNumbers = Array.Empty<int>();
                    var cards = new List<BingoCard>();
                    var y = 0;

                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        if(line == null) continue;
                        var split = line.Split(',');
                        if (split.Length > 1)
                        {
                            calledNumbers = split.Select(int.Parse).ToArray();
                            continue;
                        }

                        if (string.IsNullOrEmpty(line))
                        {
                            if (currentCard != null)
                            {
                                cards.Add(currentCard);
                                currentCard = null;
                                y = 0;
                            }

                            continue;
                        }

                        split = line.Split(' ');
                        var x = 0;
                        foreach (var value in split)
                        {
                            if (string.IsNullOrEmpty(value)) continue;
                            currentCard ??= new BingoCard();
                            currentCard.Numbers.Add(new BingoCard.Number(x, y, int.Parse(value)));
                            x++;
                        }

                        y++;

                    }

                    if(currentCard != null)
                        cards.Add(currentCard);

                    result.Add(new KeyValuePair<int[], List<BingoCard>>(calledNumbers, cards));

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
            public const string Filename = "AOC.Tests.Data.Day4.Live.txt";

            public IEnumerable<object[]> Data
            {
                get
                {
                    using var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(Filename);
                    if (stream == null)
                        throw new ArgumentOutOfRangeException(nameof(stream), $"Could not find embedded resource");

                    using var reader = new StreamReader(stream, Encoding.UTF8);
                    var result = new List<KeyValuePair<int[], List<BingoCard>>>();

                    BingoCard currentCard = null;
                    var calledNumbers = Array.Empty<int>();
                    var cards = new List<BingoCard>();
                    var y = 0;

                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        if(line == null) continue;
                        var split = line.Split(',');
                        if (split.Length > 1)
                        {
                            calledNumbers = split.Select(int.Parse).ToArray();
                            continue;
                        }

                        if (string.IsNullOrEmpty(line))
                        {
                            if (currentCard != null)
                            {
                                cards.Add(currentCard);
                                currentCard = null;
                                y = 0;
                            }

                            continue;
                        }

                        split = line.Split(' ');
                        var x = 0;
                        foreach (var value in split)
                        {
                            if (string.IsNullOrEmpty(value)) continue;
                            currentCard ??= new BingoCard();
                            currentCard.Numbers.Add(new BingoCard.Number(x, y, int.Parse(value)));
                            x++;
                        }

                        y++;

                    }

                    if(currentCard != null)
                        cards.Add(currentCard);

                    result.Add(new KeyValuePair<int[], List<BingoCard>>(calledNumbers, cards));

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