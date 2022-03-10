using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaUnitarias_JuegoTorres
{
    internal class Jugador : Torre
    {
        private byte vida = new byte();
        int puntos = new int();
        public byte Vida { get => Vida;  set => Vida = value; }       
        public int Puntos { get => puntos; set => puntos = value; }

        public Jugador(bool vivo, Dictionary<int, int> valoresTorre, byte vida, int puntos) : base(vivo, valoresTorre)
        {
            Puntos = puntos;
            Vida = vida;
        }

        /*public void AsignarValor(Jugador jugador)
        {
            jugador.Vida = 3;
            jugador.Puntos = 20;
            jugador.Vivo
        }
        */
    }
}
