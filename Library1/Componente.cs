using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library1
{
    public abstract class Componente
    {
        string Tipo;
        string Nome;
        string ID;
        string Classe;
        KeyValuePair<string, string>[] Parametros;
        public Componente(string Nome)
        {
            this.Nome = Nome;
        }
        public Componente(string Nome, KeyValuePair<string, string>[] Parametros)
        {
            this.Nome = Nome;
            this.Parametros = Parametros;
        }
    }
}
