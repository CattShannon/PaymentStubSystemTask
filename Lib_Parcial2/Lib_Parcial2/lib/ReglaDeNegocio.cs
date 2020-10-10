using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_Parcial2.lib
{
    public class ReglaDeNegocio
    {
        public String programa { set; get; }
        public String estratoColegio { set; get; }
        public String estratoVivienda { set; get; }
        public int numeroCreditos { set; get; }
        public double porcentajeDesuento { set; get; }
        public String error { set; get; }

        public bool obtenerPorcentajeDescuento() {
            porcentajeDesuento = 0.2;
            return true;
        }
    }
}
