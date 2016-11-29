using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library1
{
    public abstract class Input : Componente
    {
        public Input(string Nome, KeyValuePair<string, string>[] Parametros) : base(Nome, Parametros)
        {
            
        }
    }
}
