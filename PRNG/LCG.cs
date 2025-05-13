using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRNG
{
    public class LCG
    {
        private int state;

        private int a = 17;
        private int c = 3;
        private int m = 23;

        public LCG() {
            state = (DateTime.Now.Microsecond) % m;
        }

        public int Next()
        {
            state = ((a * state) + c) % m;
            return state;
        }

        /// <summary>
        /// Return a random number between min and max (exclusive)
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public int Next(int min, int max)
        {
            // TODO: Possible improvement:
            // Add rejection sampling
            int diff = max - min;
            int next = Next();
            return ((next * diff) / m) + min;

            // inferior!
            // return (next % (diff + 1)) + min;
        }
    }
}
