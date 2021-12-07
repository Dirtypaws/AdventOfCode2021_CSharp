using System.Resources;

namespace AdventOfCode.Models
{
    public class Lanternfish
    {
        public int IncubationPeriod { get; }

        public Lanternfish() : this(8) { }

        public Lanternfish(int initialValue)
        {
            IncubationPeriod = initialValue;
        }


    }
}