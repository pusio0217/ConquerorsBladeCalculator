using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conqueros_Calculator.modelos
{
  public  class Equipamiento
    {
        public int cantidad;
        public int costePlata;
        public string nombre;
        public List<Material> materiales;
        public Rareza rareza;

        public Equipamiento(int cantidad, int costePlata, string nombre, List<Material> materiales, Rareza rareza)
        {
            this.cantidad = cantidad;
            this.costePlata = costePlata;
            this.nombre = nombre;
            this.materiales = materiales;
            this.rareza = rareza;
        }

        public static Equipamiento LanceroSeñorio(int cantidad) {
            return new Equipamiento(cantidad, 25, "Lancero de señorío",
                new List<Material> {Material.CueroCurtido(15),
                                    Material.TelaAspera(15),
                                    Material.HierroBruto(5)  },
                Rareza.PocoComun
                );
        }
        public static Equipamiento JabalineroSeñorio(int cantidad)
        {
            return new Equipamiento(cantidad, 25, "Jabalinero de señorío",
                new List<Material> {Material.HierroBruto(15),
                                    Material.MaderaSeca(15),
                                    Material.CueroCurtido(5)  },
                Rareza.PocoComun
                );
        }

    }

}
