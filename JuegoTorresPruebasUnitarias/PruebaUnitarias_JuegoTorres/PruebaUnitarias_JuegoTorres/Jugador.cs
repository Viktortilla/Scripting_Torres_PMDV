using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaUnitarias_JuegoTorres
{
    internal class Jugador : Torre
    {
        private byte NumeroVidas = 3;
        Stack<Dictionary<string, int>> sTorres = new Stack<Dictionary<string, int>>();

        public Jugador(bool vivo, Dictionary<string, int> valoresTorre, byte numeroVidas, Stack<Dictionary<string, int>> STorres) : base(vivo, valoresTorre)
        {
            STorres = sTorres;
            NumeroVidas1 = numeroVidas;
        }

        public byte NumeroVidas1 { get => NumeroVidas; set => NumeroVidas = value; }
        public Stack<Dictionary<string, int>> STorres { get => sTorres; set => sTorres = value; }

        public Jugador InicializarJugador(Stack<Dictionary<string, int>> STorresEnemigas)
        {
            Dictionary<string, int> TorreJugador = new Dictionary<string, int>();
            Jugador Player = new Jugador(true, TorreJugador, NumeroVidas,STorresEnemigas);

            TorreJugador.Add("jugador",2);
            TorreJugador.Add("bonificacion1", 1);
            TorreJugador.Add("bonificacion2", 2);

            return Player;
        }
        public void Atacar(Jugador Player,string Objetivo)
        {
            if(Player.Vivo1 == true)
            {
                if (Player.STorres.Peek().ContainsKey(Objetivo))
                {
                    if (Objetivo == "bonificacion1")
                    {
                        Player.ValoresTorre1["jugador"] = Player.ValoresTorre1["jugador"] + Player.ValoresTorre1["bonificacion1"];
                    }
                    else if (Objetivo == "bonificacion2")
                    {
                        Player.ValoresTorre1["jugador"] = Player.ValoresTorre1["jugador"] + Player.ValoresTorre1["bonificacion2"];
                    }
                    else
                    {
                        if (Player.ValoresTorre1["jugador"] > Player.STorres.Peek()[Objetivo])
                        {
                            Player.ValoresTorre1["jugador"] = Player.ValoresTorre1["jugador"] + Player.STorres.Peek()[Objetivo];
                            Player.STorres.Pop();
                        }
                        else
                        {
                            Player.NumeroVidas = Player.NumeroVidas--;
                            if (Player.NumeroVidas == 0)
                            {
                                Player.Vivo1 = false;
                            }
                        }
                    }
                }
            }
            
        }
    }
    
}
