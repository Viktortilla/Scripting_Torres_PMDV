using NUnit.Framework;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaUnitarias_JuegoTorres
{
    public class Tests
    {
        //crear una torre con n niveles 


        Stack<Dictionary<string, int[]>> STorresEnemigas = new Stack<Dictionary<string, int[]>>();
        Dictionary<string, int[]> Torre1 = new Dictionary<string, int[]>();
        Dictionary<string, int[]> Torre2 = new Dictionary<string, int[]>();

        public void LLenarDosTorres()
        {
            int[] torre1Piso1 = new int[3] { 0, 0, 1 };
            int[] torre2Piso1 = new int[3] { 0, 1, 2 };

            Torre1.Add("piso1", torre1Piso1);
            Torre2.Add("piso1", torre2Piso1);

            STorresEnemigas.Push(Torre2);
            STorresEnemigas.Push(Torre1);
        }
        public void llenartorre()
        {
            int[] torre1Piso1 = new int[3] { 0, 0, 9 };
            int[] torre1Piso2 = new int[3] { 0, 0, 2 };
            int[] torre1Piso3 = new int[3] { 0, 0, 5 };
            int[] torre1Piso4 = new int[3] { 0, 0, 10 };
            int[] torre1Piso5 = new int[3] { 0, 0, 3 };

            Torre1.Add("piso1", torre1Piso1);
            Torre1.Add("piso2", torre1Piso2);
            Torre1.Add("piso3", torre1Piso3);
            Torre1.Add("piso4", torre1Piso4);
            Torre1.Add("piso5", torre1Piso5);

            STorresEnemigas.Push(Torre1);

        }

        //crear un personaje con un valor inicial > 0
        //El jugador esta asignado a un nivel de la torre del jugador

        Dictionary<string, int> TorreJugador = new Dictionary<string, int>();
        Jugador player;
        public void CrearJugador()
        {
            player = null;
            player = new Jugador(true, 3, TorreJugador);
            TorreJugador.Add("jugador", 3);
            TorreJugador.Add("bonificacion1", 1);
            TorreJugador.Add("bonificacion2", 2);
        }

        [TearDown]
        public void ClearAllStructures()
        {
            STorresEnemigas.Clear();
            Torre1.Clear();
            TorreJugador.Clear();
        }


        [Test]
        public void LaTorreTieneMasDeUnNivel()
        {
            
            CrearJugador();
            llenartorre();
            //la torre enemiga tiene mas de un nivel?
            Assert.IsTrue(Torre1.Count()>0);          
            
        }
        [Test]
        public void LaPuntuacionDelJugadorEsMayorACero()
        {
            llenartorre();
            CrearJugador();          
            //el jugado tiene una puntacion mayor a 0?
            Assert.IsTrue(TorreJugador["jugador"] > 0);
            
        }
        [Test]
        public void ElJugadorEstaEnUnaTorre()
        {
            llenartorre();
            CrearJugador();
            //El jugador es contenido por su respectiva tore?
            Assert.IsTrue(TorreJugador.ContainsKey("jugador"));
            
        }
        [Test]
        public void Combates()
        {
            llenartorre();
            CrearJugador();
            //pierde al empatar 
            player.AtacarTorreEnemiga(STorresEnemigas, "piso5");
            Assert.IsTrue(player.NumeroVidas == 2);//si el jugador pierde el combate entoces pierde una de sus tres vidas 
            //gana el jugador con mayor puntaje 
            player.AtacarTorreEnemiga(STorresEnemigas, "piso2");
            Assert.IsTrue(player.NumeroVidas == 2);
            //JugadorVsObstaculo
            player.AtacarTorrePropia("bonificacion2");
            Assert.IsTrue(TorreJugador["jugador"]==7);//2 puntos iniciale + mas 2 puntos de bonificacion2 + 2 puntos por derrotar al al enemigo del piso 2
            //el personaje obtiene los puntos del enemigo derrotado 
            player.AtacarTorreEnemiga(STorresEnemigas, "piso3");
            Assert.IsTrue(TorreJugador["jugador"] == 12);

            

        }
        
        [Test]
        public void AumentoYPerdidaDeNiveles()
        {
            llenartorre();
            CrearJugador();

            //la torre enemiga pierde un piso lo que significa que el diccionario borrara el piso 
            player.AtacarTorreEnemiga(STorresEnemigas, "piso2");
            Assert.IsFalse(STorresEnemigas.Peek().ContainsKey("piso2"));//el piso 2 ya no tiene enemigos y por lo tanto es eliminado 
            Assert.IsTrue(player.nivelTorre == 4);//el jugador comienza con 3 pisos y se le aumente uno cada que vense a todos los enemigos de un piso(nivel)

            
           
            
        }

        [Test]
        public void VencerTorre()
        {
            llenartorre();
            CrearJugador();

            player.AtacarTorreEnemiga(STorresEnemigas, "piso2");
            player.AtacarTorreEnemiga(STorresEnemigas, "piso5");
            player.AtacarTorreEnemiga(STorresEnemigas, "piso3");
            player.AtacarTorreEnemiga(STorresEnemigas, "piso1");
            player.AtacarTorreEnemiga(STorresEnemigas, "piso4");

            //el jugador obtiene los niveles = empiesa con 3 niveles y se le suman lo de los pisos derrotados 
            Assert.IsTrue(player.nivelTorre == 8);
            //la torre es destruida al quedarse sin enemigos 
            Assert.IsFalse(STorresEnemigas.Contains(Torre1));

            
        }
        [Test]
        public void PerdidaDeVidas()
        {
            llenartorre();
            CrearJugador();

            //pierde ante un enemigo con mayor puntuacion
            player.AtacarTorreEnemiga(STorresEnemigas, "piso1");
            Assert.IsTrue(player.NumeroVidas == 2);//si el jugador pierde el combate entoces pierde una de sus tres vidas 


            
        }
        [Test]
        public void DerrotarTorres()
        {
            LLenarDosTorres();
            CrearJugador();

            player.AtacarTorreEnemiga(STorresEnemigas, "piso1");
            player.AtacarTorreEnemiga(STorresEnemigas, "piso1");//al desaparecer la torre 1 pasara a atacar al piso1 de la torre 2 
            player.AtacarTorreEnemiga(STorresEnemigas, "piso1");//debe vencer a los dos enemigos para poder destruir la torre 

            Assert.IsFalse(STorresEnemigas.Contains(Torre1));
            Assert.IsFalse(STorresEnemigas.Contains(Torre2));//las dos torres han desaparecido 
            Assert.IsTrue(STorresEnemigas.Count()==0);//no hay mas torres
            Assert.IsTrue(player.JuegoGanado);
            
            
        }
        

    }
}
