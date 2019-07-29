using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conqueros_Calculator
{
    public enum NivelRareza
    {
       [Display(Name="Común")] Comun,
       [Display(Name ="Poco común")] PocoComun,
        [Display(Name ="Raro")]Raro,
        [Display(Name ="Épico")]Epico
    }

 
}
