using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_Parcial2.lib
{ 
    public class ReglaDeNegocio
    {

        #region Constructor
        public ReglaDeNegocio()
        {

        }
        #endregion

        #region Atributos/Propiedades
        public string programa { set; get; }
        public int estratoColegio { set; get; }
        public int estratoVivienda { set; get; }
        public double porcentajeDescuento { private set; get; }
        public string error { private set; get; }
        #endregion


        #region Metodos
        public bool obtenerPorcentajeDescuento()
        {
            porcentajeDesuento = 0.2;
            return true;
        }
        #endregion

    }
}
