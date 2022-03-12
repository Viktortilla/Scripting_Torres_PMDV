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
        
        int [] ValoresTorre = null;
        
        protected Torre(bool vivo, Dictionary<string, int> valoresTorre)
        {
            Vivo1 = vivo;
            ValoresTorre1 = valoresTorre;
            
        }

        public bool Vivo1 { get => Vivo; set => Vivo = value; }
        public Dictionary<string, int> ValoresTorre1 { get => ValoresTorre; set => ValoresTorre = value; }
        
    }
}
