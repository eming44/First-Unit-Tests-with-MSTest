using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTests.UnitTesting
{
    public class MathUtils
    {
        public int Sum(IEnumerable<int> numbers)
        {
            if (numbers == null)
            {
                throw new ArgumentException();
            }
            var sum = numbers.Sum(x => x);
            return sum;
        }
    }
}
