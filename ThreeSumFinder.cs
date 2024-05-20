using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4
{
    public class ThreeSumFinder
    {
        private readonly int[] _numbers;
        private readonly int _target;

        internal ThreeSumFinder(int[] numbers, int target)
        {
            _numbers = numbers;
            _target = target;
        }

        public IEnumerable<int[]> FindTriplets()
        {
            var seenCombinations = new HashSet<string>();
            var result = _numbers
                .SelectMany(i => _numbers.SkipWhile(j => j <= i).Select(j => (i, j)))
                .SelectMany(pair => _numbers.SkipWhile(k => k <= pair.j).Select(k => (pair.i, pair.j, k)))
                .Where(trio => trio.i + trio.j + trio.k == _target && trio.i < trio.j && trio.j < trio.k)
                .Select(trio => $"{trio.i} + {trio.j} + {trio.k}")
                .ToHashSet();

            if (result.Count == 0)
            {
                yield break;
            }

            foreach (var combination in result)
            {
                var triplet = Array.ConvertAll(combination.Split('+'), int.Parse);
                yield return triplet;
            }
        }
    }
}
