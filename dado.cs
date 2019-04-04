using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serpientes_Y_escaleras
{
    class dado
    {
        private static Random gen = new Random();
        public int tirar()
        {
            int x = gen.Next(1, 7);
            return x;
        }
    }
}
