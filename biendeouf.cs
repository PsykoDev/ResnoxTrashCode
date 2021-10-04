using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResnoxTrashCode {
    internal class biendeouf {
        private static Random r = new Random();
        private static object l = new object();
        private static Random globalRandom = new Random();
        [ThreadStatic]
        private static Random localRandom;
        public static int gravebienjlejure(int min, int max) {
            Random random = biendeouf.localRandom;
            if(random == null) {
                int seed;
                lock(biendeouf.globalRandom) {
                    seed = biendeouf.globalRandom.Next();
                }
                random = (biendeouf.localRandom = new Random(seed));
            }
            return random.Next(min, max);
        }
    }
}
