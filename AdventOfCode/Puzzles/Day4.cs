using System.Collections.Generic;
using System.Linq;
using AdventOfCode.Models;

namespace AdventOfCode.Puzzles
{
    public static class Day4
    {
        public static int Question1(KeyValuePair<int[], List<BingoCard>> data)
        {
            var calledNumbers = new List<int>();

            var (numbersToCall, cards) = data;
            foreach (var calledNumber in numbersToCall)
            {
                calledNumbers.Add(calledNumber);
                var winner = cards.FirstOrDefault(_ => _.Mark(calledNumber));
                if(winner == null) continue;

                return winner.Numbers.Where(_ => !calledNumbers.Contains(_.Value))
                    .Sum(_ => _.Value) * calledNumber;
            }

            return 0;
        }

        public static int Question2(KeyValuePair<int[], List<BingoCard>> data)
        {
            var calledNumbers = new List<int>();
            var lastWinner = 0;

            var (numbersToCall, cards) = data;
            foreach (var calledNumber in numbersToCall)
            {
                calledNumbers.Add(calledNumber);
                foreach (var bingoCard in cards.Where(_ => !_.HasWon))
                {
                    bingoCard.Mark(calledNumber);
                    if (bingoCard.HasWon)
                        lastWinner = bingoCard.Numbers.Where(_ => !calledNumbers.Contains(_.Value))
                            .Sum(_ => _.Value) * calledNumber;

                }
            }

            return lastWinner;
        }
    }
}