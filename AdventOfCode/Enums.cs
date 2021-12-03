using System;

namespace AdventOfCode
{
    [Flags]
    public enum Direction
    {
        Forward = 1, // 1
        Down = 1<<2, // 10
        Up = 1<<3 // 100
    }
}