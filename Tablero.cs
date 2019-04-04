using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serpientes_Y_escaleras
{
    class Tablero
    {
        private Tablero[] tablero = new Tablero[101];
        public int[] _tablero;
        public Tablero(){
            _tablero = new int[101];           
            }
        public int[] Tablerro
        {
            get { return _tablero; }
        }
       public void SyE()
        {
            _tablero[0] = 1;
            _tablero[4] = 25;
            _tablero[13] = 46;
            _tablero[27] = 5;
            _tablero[33] = 49;
            _tablero[42] = 63;
            _tablero[50] = 69;
            _tablero[62] = 81;
            _tablero[66] = 45;
            _tablero[76] = 58;
            _tablero[89] = 53;
        }

        
    }

}
