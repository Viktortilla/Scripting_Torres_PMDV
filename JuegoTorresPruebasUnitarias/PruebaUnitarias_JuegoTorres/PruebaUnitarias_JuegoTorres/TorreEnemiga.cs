using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaUnitarias_JuegoTorres
{
    internal class TorreEnemiga : Torre
    {
        public TorreEnemiga(bool vivo, Dictionary<string, int> valoresTorre) : base(vivo, valoresTorre)
        {

        }
        
        public Stack<Dictionary<string , int>> InicializarTorresEnemigas()
        {
            Stack<Dictionary<string , int>> StackTemporal = new Stack<Dictionary<string , int>>();
            Dictionary<string , int> Torre1 = new Dictionary<string , int>();
            
           
            return ;
        }
    }
}
