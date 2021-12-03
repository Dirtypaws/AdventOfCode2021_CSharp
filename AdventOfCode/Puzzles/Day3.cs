using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventOfCode.Puzzles
{
    public static class Day3
    {
        public static int Question1(string[] input)
        {
            var maxLength = input.Max(_ => _.Length);
            var gamma = string.Empty;
            var epsilon = string.Empty;

            for (int i = 0; i < maxLength; i++)
            {
                var ones = input.Select(_ => _[i]).Count(_ => _ == '1');
                var zeros = input.Select(_ => _[i]).Count(_ => _ == '0');

                gamma += ones > zeros ? "1" : "0";
                epsilon += ones > zeros ? "0" : "1";
            }

            return Convert.ToInt32(gamma, 2) * Convert.ToInt32(epsilon, 2);
        }

        public static int Question2(string[] input)
        {
            var ogen = Resolve(input, true);
            var co2 = Resolve(input, false);
            return Convert.ToInt32(ogen, 2) * Convert.ToInt32(co2, 2);
        }

        private static string Resolve(IEnumerable<string> input, bool searchMax, int position = 0)
        {
            if (input.Count() == 1)
                return input.First();

            var ones = input.Select(_ => _[position]).Count(_ => _ == '1');
            var zeros = input.Select(_ => _[position]).Count(_ => _ == '0');

            if (searchMax)
                return Resolve(
                    ones >= zeros ? input.Where(_ => _[position] == '1') : input.Where(_ => _[position] == '0'),
                    true, position + 1);

            return Resolve(
                ones >= zeros ? input.Where(_ => _[position] == '0') : input.Where(_ => _[position] == '1'),
                false, position + 1);

        }
    }
}