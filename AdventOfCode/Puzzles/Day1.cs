using System.Linq;

namespace AdventOfCode.Puzzles
{
    public static class Day1
    {
        public static int Question1(int[] data)
        {
            var last = data.First();
            var cnt = 0;

            foreach (var i in data)
            {
                if (i > last)
                    cnt += 1;

                last = i;
            }

            return cnt;
        }

        public static int Question2(int[] data)
        {
            var position = 0;
            var cnt = 0;

            do
            {
                var first = data.Skip(position).Take(3).ToArray();
                if (first.Length == 3)
                {
                    var second = data.Skip(position + 1).Take(3);
                    if (second.Sum() > first.Sum())
                        cnt++;
                    position++;
                }
                else return cnt;
            } while (position <= data.Length - 3);

            return cnt;
        }
    }
}