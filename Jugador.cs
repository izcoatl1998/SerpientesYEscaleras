using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serpientes_Y_escaleras
{
    class Jugador : Tablero
    {
        private int _posicion;
        private int _numero;
        public Jugador (int numero)
        {
            _numero = numero;
            _posicion = 0;
        }
        public int Posicion
        {
            get { return _posicion; }
        }
        public int Numero
        {
            get { return _numero; }
        }
        public void Avanzar(int x)
        {
            _posicion += x;
            if (_posicion > 100)
            {
                _posicion = 100;
            }
            else
            {
                _posicion += _tablero[_posicion];
            }
        }
        public override string ToString()
        {
            return "El jugador " + _numero.ToString() + "Esta en la casilla: " + _posicion.ToString();
        }
    }
}
