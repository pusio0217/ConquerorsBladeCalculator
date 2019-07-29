using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conqueros_Calculator
{
   public class Equipamiento
    {
        public string nombre;
        public List<MaterialGasto> materiales;
    }

    public class MaterialGasto {
        public int cantidad;
            public Material material;
    }
}
