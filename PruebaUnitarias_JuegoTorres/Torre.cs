using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaUnitarias_JuegoTorres
{
    abstract class Torre
    {
        bool Vivo = true;
        Dictionary<int, int> ValoresTorre = new Dictionary<int, int>();

        public Torre(bool vivo, Dictionary<int, int> valoresTorre)
        {
            Vivo = vivo;
            ValoresTorre = valoresTorre;
        }
        
    }
}
