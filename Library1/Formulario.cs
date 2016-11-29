using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library1
{
    public class Formulario
    {
        #region variaveis
        string ID;
        string Metodo;
        string Action; 
        #endregion
        public Formulario(string ID, string Metodo, string Action)
        {
            this.ID = ID;
            this.Metodo = Metodo;
            this.Action = Action;
        }
    }
}
