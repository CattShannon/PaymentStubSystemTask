using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_Parcial2.lib
{

    public class LibProcesos
    {
        #region Constructor
        public LibProcesos()
        {
            ValorCredito = 200000;
            ValorPagarAntesDeDescuento = -1;

        }
        #endregion

        #region Atributos/Propiedades
        private int ValorCredito; 
        public int EstratoColegio { get; set; }
        public int EstratoVivienda { get; set; }
        public int NumeroCreditos { get; set; }
        public string Programa { get; set; }
        public double ValorPagarAntesDeDescuento { get; private set; }
        public double PorcentajeDescuento { get; private set; }
        public double ValorDescuento { get; private set; }
        public double ValorTotal { get; private set; }
        public string Error {get; private set; }
        #endregion

        #region Metodos
        public bool obtenerValorTotal()
        {
            if (!Validar() || !ObtenerPorcentajeDescuento())
            {
                return false;
            }

            ObtenerValorPagarAntesDescuento();
            ObtenerValorDescuento();
            
            ValorTotal = this.valorPagarAntesDeDescuento - this.ValorDescuento;
        return true;
        }

        private bool Validar()
        {
            if (Programa.Equals(string.Empty))
            {
                Error = "No ha seleccionado ningun programa";
                return false;
            }

            if (NumeroCreditos < 2 || NumeroCreditos > 7)
            {
                Error = "Cantidad de creditos seleccionada no válida. Deben ser minimo 2 o maximo 7";
                return false;
            }

            if (this.EstratoColegio < 1 || this.EstratoColegio > 6)
            {
                Error = "El valor ingresado para estrato de colegio no es valido";
                return false;
            }

            if (this.EstratoVivienda < 1 || this.EstratoVivienda > 6)
            {
                Error = "El valor ingresado para estrato de colegio no es valido";
                return false;
            }

            return true;
        } 

        private bool ObtenerPorcentajeDescuento() {
            ReglaDeNegocio objReglaDeNegocio = new ReglaDeNegocio();

            objReglaDeNegocio.Programa = this.Programa;
            objReglaDeNegocio.EstratoColegio = this.EstratoColegio;
            objReglaDeNegocio.EstratoVivienda = this.EstratoVivienda;


            if (!objReglaDeNegocio.ObtenerPorcentajeDescuento())
            {
                Error = objReglaDeNegocio.Error;
                objReglaDeNegocio = null;
                return false;
            }
           
           this.PorcentajeDescuento = objReglaDeNegocio.PorcentajeDescuento;
           objReglaDeNegocio = null;
           return true;
           

        }

        private void ObtenerValorPagarAntesDescuento()
        {
            ValorPagarAntesDeDescuento = ValorCredito * NumeroCreditos;
        }

        private void ObtenerValorDescuento()
        {
            ValorDescuento = this.ValorPagarAntesDeDescuento * this.PorcentajeDescuento;
        }
        #endregion
    }
}