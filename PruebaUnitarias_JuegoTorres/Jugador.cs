using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaUnitarias_JuegoTorres
{
    class Jugador
    {
        private bool vida;
        private byte numeroVidas;
        private int nivelTorre;
        private Dictionary<string, int> torreJugador = new Dictionary<string, int>();

        public Jugador(bool vida, byte numeroVidas, Dictionary<string, int> torreJugador)
        {
            this.vida = vida;
            NumeroVidas = numeroVidas;
            TorreJugador = torreJugador;
        }

        public bool Vida { get => vida; set => vida = value; }
        public byte NumeroVidas { get => numeroVidas; set => numeroVidas = value; }
        public Dictionary<string, int> TorreJugador { get => torreJugador; set => torreJugador = value; }

        public void CrearTorreDelJugador()
        {
            TorreJugador.Add("jugador", 2);
            TorreJugador.Add("bonificacion1", 1);
            TorreJugador.Add("bonificacion2", 2);
        }

        public void AtacarTorrePropia(string Objetivo)
        {

            if (NumeroVidas == 0)
            {
                vida = false;
            }
            if (vida == true)
            {
                if (TorreJugador.ContainsKey(Objetivo))
                {
                    TorreJugador["jugador"] = TorreJugador["jugador"] + TorreJugador[Objetivo];
                    TorreJugador[Objetivo] = 0;
                }
            }
        }
        public void AtacarTorreEnemiga(Stack<Dictionary<string, int[]>> STorresObjetivo, string Objetivo)
        {
            if (NumeroVidas == 0)
            {
                vida = false;
            }
            if (vida == true)
            {
                if (STorresObjetivo.Peek().ContainsKey(Objetivo))
                {
                    if (STorresObjetivo.Peek()[Objetivo][0] > 0)
                    {
                        if (TorreJugador["jugador"] > STorresObjetivo.Peek()[Objetivo][0])
                        {
                            TorreJugador["jugador"] = TorreJugador["jugador"] + STorresObjetivo.Peek()[Objetivo][0];
                            STorresObjetivo.Peek()[Objetivo][0] = 0;

                        }
                        if (TorreJugador["jugador"] <= STorresObjetivo.Peek()[Objetivo][0])
                        {
                            NumeroVidas--;
                        }
                    }
                    else if (STorresObjetivo.Peek()[Objetivo][1] > 0)
                    {
                        if (TorreJugador["jugador"] > STorresObjetivo.Peek()[Objetivo][1])
                        {
                            TorreJugador["jugador"] = TorreJugador["jugador"] + STorresObjetivo.Peek()[Objetivo][1];
                            STorresObjetivo.Peek()[Objetivo][1] = 0;

                        }
                        if (TorreJugador["jugador"] <= STorresObjetivo.Peek()[Objetivo][1])
                        {
                            NumeroVidas--;
                        }
                    }
                    else if (STorresObjetivo.Peek()[Objetivo][2] > 0)
                    {
                        if (TorreJugador["jugador"] > STorresObjetivo.Peek()[Objetivo][2])
                        {
                            TorreJugador["jugador"] = TorreJugador["jugador"] + STorresObjetivo.Peek()[Objetivo][2];
                            STorresObjetivo.Peek()[Objetivo][2] = 0;

                        }
                        if (TorreJugador["jugador"] <= STorresObjetivo.Peek()[Objetivo][2])
                        {
                            NumeroVidas--;
                        }
                    }

                    if (STorresObjetivo.Peek()[Objetivo][0] + STorresObjetivo.Peek()[Objetivo][1] + STorresObjetivo.Peek()[Objetivo][2] == 0)
                    {
                        STorresObjetivo.Peek().Remove(Objetivo);
                        nivelTorre++;
                    }
                    if (STorresObjetivo.Peek().Count() == 0)
                    {
                        STorresObjetivo.Pop();
                    }
                    if (numeroVidas == 0)
                    {
                        vida = false;
                    }
                }
            }
        }
    }

}


