using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using AdventOfCode.Models;

namespace AdventOfCode.Puzzles
{
    public static class Day5
    {
        public static int Question1(KeyValuePair<int, int>[] lines) => lines.GroupBy(_ => new VolcanicPoint(_.Key, _.Value)).Count(_ => _.Count() > 1);
    }
}