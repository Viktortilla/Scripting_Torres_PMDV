using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaUnitarias_JuegoTorres
{
    internal class TorreEnemiga : Torre
    {
        public TorreEnemiga(bool vivo, Dictionary<int, int> valoresTorre) : base(vivo, valoresTorre)
        {
            
        }
    }
}
