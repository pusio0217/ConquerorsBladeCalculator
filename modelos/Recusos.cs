using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conqueros_Calculator
{
    public class Recurso
    {
        public Recurso(string nombre, NivelRareza rareza)
        {
            Nombre = nombre;
            Rareza = rareza;
        }

        public string Nombre { get; set; }
        public NivelRareza Rareza { get; set; }
    }
}
