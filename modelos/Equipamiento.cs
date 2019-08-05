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

        public static bool operator==(Equipamiento e1, Equipamiento e2) {
            return e1.nombre == e2.nombre;
        }
        public static bool operator !=(Equipamiento e1, Equipamiento e2)
        {
            return e1.nombre != e2.nombre;
        }


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
                                    Material.CueroCurtido(10)  },
                Rareza.PocoComun
                );
        }
        public static Equipamiento ArqueroSeñorio(int cantidad)
        {
            return new Equipamiento(cantidad, 25, "Arqueros de señorío",
                new List<Material> {Material.MaderaSeca(15),
                                    Material.CobreBruto(10),
                                    Material.TelaAspera(10)  },
                Rareza.PocoComun
                );
        }

        public static Equipamiento BallesteroSeñorio(int cantidad)
        {
            return new Equipamiento(cantidad, 25, "Ballestero de señorio",
                new List<Material> {Material.MaderaSeca(15),
                                    Material.TelaAspera(10),
                                    Material.CobreBruto(15)  },
                Rareza.PocoComun
                );
        }

        public static Equipamiento Costilleux(int cantidad)
        {
            return new Equipamiento(cantidad, 25, "Costilleux",
                new List<Material> {Material.HierroBruto(30),
                                    Material.MaderaSeca(20),
                                    Material.CueroCurtido(20)  },
                Rareza.PocoComun
                );
        }

        public static Equipamiento Escudero(int cantidad)
        {
            return new Equipamiento(cantidad, 50, "Escudero",
                new List<Material> {Material.HierroFundido(10),
                                    Material.CueroTratado(5),
                                    Material.CobreMejorado(5)  },
                Rareza.Raro
                );
        }



        public static Equipamiento Alabardero(int cantidad)
        {
            return new Equipamiento(cantidad, 50, "Alabardero",
                new List<Material> {Material.MaderaAlisada(5),
                                    Material.HierroFundido(5),
                                    Material.TelaBarata(15)  },
                Rareza.Raro
                );
        }
        public static Equipamiento ArqueroDeFuego(int cantidad)
        {
            return new Equipamiento(cantidad, 50, "Arquero de fuego mercenario",
                new List<Material> {Material.MaderaAlisada(10),
                                    Material.CueroTratado(5),
                                    Material.CobreMejorado(5)  },
                Rareza.Raro
                );
        }

        public static Equipamiento BallesteroMercenario(int cantidad)
        {
            return new Equipamiento(cantidad, 50, "Ballestero Mercenario",
                new List<Material> {Material.MaderaAlisada(10),
                                    Material.HierroFundido(8),
                                    Material.CueroTratado(10)  },
                Rareza.Raro
                );
        }
        public static Equipamiento ArcabuceroMercenario(int cantidad)
        {
            return new Equipamiento(cantidad, 50, "Arcabucero mercenario",
                new List<Material> {Material.CobreMejorado(15),
                                    Material.HierroFundido(10),
                                    Material.TelaBarata(10)  },
                Rareza.Raro
                );
        }

      
    }

}
