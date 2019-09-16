using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conquerors_Calculator.modelos
{
  public partial class Equipamiento
  {
    public int cantidad;
    public int costePlata;
    public string nombre;
    public List<Material> materiales;
    public Rareza rareza;


    //Necesario para los removeall
    public static bool operator ==(Equipamiento e1, Equipamiento e2)
    {
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

    public static Equipamiento LanceroSeñorio(int cantidad)
    {
      return new Equipamiento(cantidad, 30, "Lancero de señorío",
          new List<Material> {Material.CueroCurtido(15),
                                    Material.TelaAspera(15),
                                    Material.HierroBruto(5)  },
          Rareza.PocoComun
          );
    }
    public static Equipamiento JabalineroSeñorio(int cantidad)
    {
      return new Equipamiento(cantidad, 30, "Jabalinero de señorío",
          new List<Material> {Material.HierroBruto(15),
                                    Material.MaderaSeca(15),
                                    Material.CueroCurtido(10)  },
          Rareza.PocoComun
          );
    }
    public static Equipamiento ArqueroSeñorio(int cantidad)
    {
      return new Equipamiento(cantidad, 30, "Arqueros de señorío",
          new List<Material> {Material.MaderaSeca(15),
                                    Material.CobreBruto(10),
                                    Material.TelaAspera(10)  },
          Rareza.PocoComun
          );
    }

    public static Equipamiento BallesteroSeñorio(int cantidad)
    {
      return new Equipamiento(cantidad, 30, "Ballestero de señorio",
          new List<Material> {Material.MaderaSeca(15),
                                    Material.TelaAspera(15),
                                    Material.CobreBruto(15)  },
          Rareza.PocoComun
          );
    }

    public static Equipamiento Costilleux(int cantidad)
    {
      return new Equipamiento(cantidad, 30, "Costilleux",
          new List<Material> {Material.HierroBruto(30),
                                    Material.MaderaSeca(20),
                                    Material.CueroCurtido(20)  },
          Rareza.PocoComun
          );
    }

    public static Equipamiento Escudero(int cantidad)
    {
      return new Equipamiento(cantidad, 60, "Escudero",
          new List<Material> {Material.HierroFundido(10),
                                    Material.CueroTratado(5),
                                    Material.CobreMejorado(5)  },
          Rareza.Raro
          );
    }



    public static Equipamiento Alabardero(int cantidad)
    {
      return new Equipamiento(cantidad, 60, "Alabardero",
          new List<Material> {Material.MaderaAlisada(5),
                                    Material.HierroFundido(5),
                                    Material.TelaBarata(15)  },
          Rareza.Raro
          );
    }
    public static Equipamiento ArqueroDeFuego(int cantidad)
    {
      return new Equipamiento(cantidad, 60, "Arquero de fuego mercenario",
          new List<Material> {Material.MaderaAlisada(10),
                                    Material.CueroTratado(5),
                                    Material.CobreMejorado(5)  },
          Rareza.Raro
          );
    }

    public static Equipamiento ArbalesteroSeñorio(int cantidad)
    {
      return new Equipamiento(cantidad, 60, "Arbalestero Señorio",
          new List<Material> {Material.MaderaAlisada(10),
                                    Material.HierroFundido(8),
                                    Material.CueroTratado(10)  },
          Rareza.Raro
          );
    }
    public static Equipamiento ArcabuceroMercenario(int cantidad)
    {
      return new Equipamiento(cantidad, 60, "Arcabucero mercenario",
          new List<Material> {Material.CobreMejorado(15),
                                    Material.HierroFundido(10),
                                    Material.TelaBarata(10)  },
          Rareza.Raro
          );
    }

    public static Equipamiento HombreDeArmas(int cantidad)
    {
      return new Equipamiento(cantidad, 120, "Hombre de armas",
          new List<Material> {Material.HierroPuro(4),
                                    Material.CobreRefinado(4),
                                    Material.CueroPerfeccionado(3),
                           },
          Rareza.Epico
          );
    }

    public static Equipamiento SargentoLancero(int cantidad)
    {
      return new Equipamiento(cantidad, 120, "Sargento lancero",
          new List<Material> {Material.HierroPuro(4),
                                    Material.MaderaCompuesta(3),
                                    Material.CueroPerfeccionado(3),
                         },
          Rareza.Epico
          );
    }

    public static Equipamiento SargentoJabalinero(int cantidad)
    {
      return new Equipamiento(cantidad, 120, "Sargento jabalinero",
          new List<Material> {Material.HierroPuro(4),
                                    Material.CobrePuro(4),
                                    Material.CueroPerfeccionado(4),
                              },
          Rareza.Epico
          );
    }

    public static Equipamiento SargentoAlabardero(int cantidad)
    {
      return new Equipamiento(cantidad, 120, "Sargento alabardero",
          new List<Material> {Material.HierroPuro(5),
                                    Material.CobrePuro(5),
                                    Material.CueroHervido(5),
                             },
          Rareza.Epico
          );
    }

    public static Equipamiento ArqueroVasallo(int cantidad)
    {
      return new Equipamiento(cantidad, 120, "Arquero Vasallo",
          new List<Material> {Material.HierroPuro(3),
                                    Material.CobrePuro(3),
                                    Material.CueroPerfeccionado(2),
                              },
          Rareza.Epico
          );
    }


    public static Equipamiento FusileroKriegsrat(int cantidad)
    {
      return new Equipamiento(cantidad, 120, "Fusilero Kriegsrat",
          new List<Material> {Material.HierroPuro(5),
                                    Material.CobrePuro(4),
                                    Material.CueroHervido(4),
                               },
          Rareza.Epico
          );
    }

    public static Equipamiento LanceroYeoman(int cantidad)
    {
      return new Equipamiento(cantidad, 120, "Lancero Yeoman",
          new List<Material> {Material.HierroPuro(5),
                                    Material.CobrePuro(5),
                                    Material.CueroHervido(5),
                                     Material.TelaExcelente(3)},
          Rareza.Epico
          );
    }


    public static Equipamiento ArcabuceroTercio(int cantidad)
    {
      return new Equipamiento(cantidad, 240, "Arcabucero tercio",
          new List<Material> {Material.TelaCalidad(10),
                                    Material.HierroForjado(5),
                                    Material.CueroHervido(10),
                                     Material.CobreRefinado(20)},
          Rareza.Legendario
            );

    }

    public static Equipamiento HusarAlado(int cantidad)
    {
      return new Equipamiento(cantidad, 240, "Husar alado",
          new List<Material> {Material.TelaCalidad(10),
                                    Material.HierroForjado(15),
                                    Material.CueroPerfeccionado(10),
                                     Material.CobrePuro(10)},
          Rareza.Legendario
            );

    }
    public static Equipamiento CaballeroMonastico(int cantidad)
    {
      return new Equipamiento(cantidad, 240, "Caballero monástico",
          new List<Material> {Material.TelaCalidad(10),
                                    Material.HierroForjado(15),
                                    Material.CueroPerfeccionado(10),
                                     Material.CobrePuro(10)},
          Rareza.Legendario
            );

    }

    public static Equipamiento SoldadoCatafracto(int cantidad)
    {
      return new Equipamiento(cantidad, 240, "Soldado catafracto",
          new List<Material> {Material.TelaCalidad(5),
                                    Material.HierroForjado(8),
                                    Material.CueroHervido(5),
                                     Material.CobreRefinado(8)},
          Rareza.Legendario
            );

    }
  }
}
