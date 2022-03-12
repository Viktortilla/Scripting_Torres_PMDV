using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaUnitarias_JuegoTorres
{
    class Enemigo
    {
        Stack<Dictionary<string, Array>> STorresEnemigas = new Stack<Dictionary<string, Array>>();

        public Enemigo(Stack<Dictionary<string, Array>> sTorresEnemigas)
        {
            STorresEnemigas = sTorresEnemigas;
        }

        public Stack<Dictionary<string, Array>> STorresEnemigas1 { get => STorresEnemigas; set => STorresEnemigas = value; }

        public void LLenarStackDeTorres()
        {
            Dictionary<string, Array> Torre1 = new Dictionary<string, Array>();
            Dictionary<string, Array> Torre2 = new Dictionary<string, Array>();
            Dictionary<string, Array> Torre3 = new Dictionary<string, Array>();
            Dictionary<string, Array> Torre4 = new Dictionary<string, Array>();

            int[] torre1Piso1 = new int[3] { 0, 0, 9 };
            int[] torre1Piso2 = new int[3] { 0, 0, 2 };
            int[] torre1Piso3 = new int[3] { 0, 0, 5 };
            int[] torre1Piso4 = new int[3] { 0, 0, 10 };
            int[] torre1Piso5 = new int[3] { 0, 0, 3 };

            int[] torre2Piso1 = new int[3] { 0, 6, 15 };
            int[] torre2Piso2 = new int[3] { 0, 0, 14 };
            int[] torre2Piso3 = new int[3] { 0, 0, 42 };
            int[] torre2Piso4 = new int[3] { 0, 0, 23 };
            int[] torre2Piso5 = new int[3] { 0, 14, 5 };
            int[] torre2Piso6 = new int[3] { 0, 0, 47 };
            int[] torre2Piso7 = new int[3] { 0, 99, 75 };

            int[] torre3Piso1 = new int[3] { 0, 0, 666 };
            int[] torre3Piso2 = new int[3] { 0, 25, 85 };
            int[] torre3Piso3 = new int[3] { 9, 12, 34 };
            int[] torre3Piso4 = new int[3] { 0, 0, 99 };
            int[] torre3Piso5 = new int[3] { 0, 14, 215 };
            int[] torre3Piso6 = new int[3] { 0, 0, 69 };
            int[] torre3Piso7 = new int[3] { 0, 0, 452 };
            int[] torre3Piso8 = new int[3] { 1, 2, 334 };
            int[] torre3Piso9 = new int[3] { 0, 228, 420 };

            int[] torre4Piso1 = new int[3] { 1, 2, 334 };
            int[] torre4Piso2 = new int[3] { 0, 0, 452 };
            int[] torre4Piso3 = new int[3] { 0, 0, 215 };
            int[] torre4Piso4 = new int[3] { 0, 0, 69 };
            int[] torre4Piso5 = new int[3] { 0, 25, 85 };
            int[] torre4Piso6 = new int[3] { 9, 12, 34 };
            int[] torre4Piso7 = new int[3] { 0, 0, 99 };
            int[] torre4Piso8 = new int[3] { 0, 0, 999 };
            int[] torre4Piso9 = new int[3] { 0, 0, 9999 };
          
            Torre1.Add("piso1", torre1Piso1);
            Torre1.Add("piso2", torre1Piso2);
            Torre1.Add("piso3", torre1Piso3);
            Torre1.Add("piso4", torre1Piso4);
            Torre1.Add("piso5", torre1Piso5);

            Torre2.Add("piso1", torre2Piso1);
            Torre2.Add("piso2", torre2Piso2);
            Torre2.Add("piso3", torre2Piso3);
            Torre2.Add("piso4", torre2Piso4);
            Torre2.Add("piso5", torre2Piso5);
            Torre2.Add("piso6", torre2Piso6);
            Torre2.Add("piso7", torre2Piso7);

            Torre3.Add("piso1", torre3Piso1);
            Torre3.Add("piso2", torre3Piso2);
            Torre3.Add("piso3", torre3Piso3);
            Torre3.Add("piso4", torre3Piso4);
            Torre3.Add("piso5", torre3Piso5);
            Torre3.Add("piso6", torre3Piso6);
            Torre3.Add("piso7", torre3Piso7);
            Torre3.Add("piso8", torre3Piso8);
            Torre3.Add("piso9", torre3Piso9);

            Torre4.Add("piso1", torre4Piso1);
            Torre4.Add("piso2", torre4Piso2);
            Torre4.Add("piso3", torre4Piso3);
            Torre4.Add("piso4", torre4Piso4);
            Torre4.Add("piso5", torre4Piso5);
            Torre4.Add("piso6", torre4Piso6);
            Torre4.Add("piso7", torre4Piso7);
            Torre4.Add("piso8", torre4Piso8);
            Torre4.Add("piso9", torre4Piso9);

            STorresEnemigas.Push(Torre4);
            STorresEnemigas.Push(Torre3);
            STorresEnemigas.Push(Torre2);
            STorresEnemigas.Push(Torre1);
        }
    }
}
