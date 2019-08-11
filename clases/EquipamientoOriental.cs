using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conquerors_Calculator.modelos
{
  public partial class Equipamiento
    {
        
        public static Equipamiento Espadachin(int cantidad)
        {
            return new Equipamiento(cantidad, 25, "Espadachin",
                new List<Material> {Material.HierroBruto(10),
                                    Material.MaderaSeca(10),
                                    Material.CueroCurtido(15),
                                  },
                Rareza.PocoComun
                );
        }

        public static Equipamiento JabalineroMiliciano(int cantidad)
        {
            return new Equipamiento(cantidad, 25, "jabalinero miliciano",
                new List<Material> {Material.MaderaSeca(10),
                                    Material.CueroCurtido(20),
                                    Material.HierroBruto(15),
                                  },
                Rareza.PocoComun
                );
        }

        public static Equipamiento PiqueroMiliciano(int cantidad)
        {
            return new Equipamiento(cantidad, 25, "piquero miliciano",
                new List<Material> {Material.HierroBruto(10),
                                    Material.CueroCurtido(10),
                                    Material.TelaAspera(10),
                                  },
                Rareza.PocoComun
                );
        }
        public static Equipamiento ArqueroYelmoHierro(int cantidad)
        {
            return new Equipamiento(cantidad, 25, "arquero yelmo hierro",
                new List<Material> {Material.CobreBruto(15),
                                    Material.MaderaSeca(10),
                                    Material.CueroCurtido(5),
                                  },
                Rareza.PocoComun
                );
        }
        public static Equipamiento ArcabuqueroYelmoHierro(int cantidad)
        {
            return new Equipamiento(cantidad, 25, "arcabuquero yelmo hierro",
                new List<Material> {Material.TelaAspera(10),
                                    Material.CobreBruto(15),
                                    Material.CueroCurtido(5),
                                  },
                Rareza.PocoComun
                );
        }
        public static Equipamiento ExploradorYelmoHierro(int cantidad)
        {
            return new Equipamiento(cantidad, 25, "exploradorYelmoHierro",
                new List<Material> {Material.HierroBruto(15),
                                    Material.TelaAspera(30),
                                    Material.CobreBruto(15),
                                  },
                Rareza.PocoComun
                );
        }
        public static Equipamiento ArqueroMontadoHierro(int cantidad)
        {
            return new Equipamiento(cantidad, 25, "arqueroMontadoHierro",
                new List<Material> {Material.MaderaSeca(20),
                                    Material.CobreBruto(20),
                                    Material.TelaAspera(20),
                                  },
                Rareza.PocoComun
                );
        }


        public static Equipamiento GuardaPrefectura(int cantidad)
        {
            return new Equipamiento(cantidad, 50, "guardaPrefectura",
                new List<Material> {Material.MaderaAlisada(8),
                                    Material.CueroTratado(5),
                                    Material.HierroFundido(5),
                                  },
                Rareza.Raro
                );
        }
        public static Equipamiento LanceroYelmoHierro(int cantidad)
        {
            return new Equipamiento(cantidad, 50, "lanceroYelmoHierro",
                new List<Material> {Material.MaderaAlisada(8),
                                    Material.CueroTratado(5),
                                    Material.HierroFundido(5),
                                  },
                Rareza.Raro
                );
        }
        public static Equipamiento PiqueroPrefectura(int cantidad)
        {
            return new Equipamiento(cantidad, 50, "piqueroPrefectura",
                new List<Material> {Material.MaderaAlisada(5),
                                    Material.CueroTratado(5),
                                    Material.HierroFundido(5),
                                  },
                Rareza.Raro
                );
        }


        public static Equipamiento ArqueroVanguardia(int cantidad)
        {
            return new Equipamiento(cantidad, 50, "arqueroVanguardia",
                new List<Material> {Material.MaderaAlisada(3),
                                    Material.TelaBarata(3),
                                    Material.CobreMejorado(3),
                                  },
                Rareza.Raro
                );
        }

        public static Equipamiento ArqueroPrefectura(int cantidad)
        {
            return new Equipamiento(cantidad, 50, "arqueroPrefectura",
                new List<Material> {Material.MaderaAlisada(5),
                                    Material.TelaBarata(2),
                                    Material.CobreMejorado(2),
                                  },
                Rareza.Raro
                );
        }
        public static Equipamiento GuardaPalacio(int cantidad)
        {
            return new Equipamiento(cantidad, 100, "guardaPalacio",
                new List<Material> {Material.CueroHervido(3),
                                    Material.HierroForjado(3),
                                    Material.TelaCalidad(3),
                                      Material.MaderaBarnizada(3),
                                  },
                Rareza.Epico
                );
        }
        public static Equipamiento LanceroGuardaImperial(int cantidad)
        {
            return new Equipamiento(cantidad, 100, "lanceroGuardaImperial",
                new List<Material> {Material.CueroHervido(3),
                                    Material.HierroForjado(3),
                                    Material.TelaCalidad(3),
                                      Material.MaderaBarnizada(3),
                                  },
                Rareza.Epico
                );
        }
        public static Equipamiento JabalineroImperial(int cantidad)
        {
            return new Equipamiento(cantidad, 100, "jabalineroImperial",
                new List<Material> {Material.MaderaBarnizada(3),
                                    Material.CobrePuro(3),
                                    Material.CueroHervido(3),
                                      Material.HierroForjado(3),
                                  },
                Rareza.Epico
                );
        }
        public static Equipamiento PiqueroImperial(int cantidad)
        {
            return new Equipamiento(cantidad, 100, "piqueroImperial",
                new List<Material> {Material.CueroHervido(3),
                                    Material.HierroPuro(3),
                                    Material.TelaCalidad(3),
                                      Material.MaderaBarnizada(3),
                                  },
                Rareza.Epico
                );
        }
        public static Equipamiento ArqueroImperial(int cantidad)
        {
            return new Equipamiento(cantidad, 100, "arqueroImperial",
                new List<Material> {Material.CueroHervido(3),
                                    Material.HierroPuro(3),
                                    Material.TelaCalidad(2),
                                      Material.MaderaBarnizada(3),
                                  },
                Rareza.Epico
                );
        }
        public static Equipamiento CaballeroPrefectura(int cantidad)
        {
            return new Equipamiento(cantidad, 100, "caballeroPrefectura",
                new List<Material> {Material.CueroHervido(5),
                                    Material.HierroPuro(5),
                                    Material.TelaCalidad(4),
                                      Material.CobrePuro(4),
                                  },
                Rareza.Epico
                );
        }
        public static Equipamiento LanceroHachaDaga(int cantidad)
        {
            return new Equipamiento(cantidad, 100, "lanceroHachaDaga",
                new List<Material> {Material.CueroHervido(4),
                                    Material.HierroPuro(4),
                                    Material.TelaCalidad(3),
                                      Material.CobrePuro(3),
                                  },
                Rareza.Epico
                );
        }
    }

}
