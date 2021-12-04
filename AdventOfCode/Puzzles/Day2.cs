using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode.Puzzles
{
    public static class Day2
    {
        public static int Question1(KeyValuePair<Direction, int>[] data)
        {
            var horizontal = data.Where(_ => _.Key == Direction.Forward).Sum(_ => _.Value);
            var depth = data.Where(_ => _.Key != Direction.Forward)
                .Sum(_ => _.Key == Direction.Up ? _.Value * -1 : _.Value);

            return horizontal * depth;
        }

        public static int Question2(KeyValuePair<Direction, int>[] data)
        {
            int horizontal = 0, depth = 0, aim = 0;
            
            foreach (var (dir, value) in data)
            {
                switch (dir)
                {
                    case Direction.Forward:
                        {
                            horizontal += value;
                            depth += aim * value;
                            break;
                        }
                    case Direction.Down:
                        {
                            aim += value;
                            break;
                        }
                    case Direction.Up:
                        {
                            aim += (value * -1);
                            break;
                        }
                }
            }

            return horizontal * depth;
        }
    }
}