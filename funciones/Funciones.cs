using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Conquerors_Calculator.modelos
{
    public class Funciones
    {
        public static SolidColorBrush ColorFromRareza(Rareza rareza)
        {
            switch (rareza)
            {
                case Rareza.Comun:
                    return new SolidColorBrush(Colors.White);
                case Rareza.PocoComun:
                    return new SolidColorBrush(Colors.LightGreen);
                case Rareza.Raro:
                    return new SolidColorBrush(Colors.DeepSkyBlue);
                case Rareza.Epico:
                    return new SolidColorBrush(Colors.MediumOrchid);
                default:
                    return new SolidColorBrush(Colors.White);
            }


        }
    }

}
