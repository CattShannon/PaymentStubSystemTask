using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_Parcial2.lib
{
    public class libProcesos
    {
        private int valorCredito = 200000;
        public int valorPagarAntesDeDescuento { get; set; }
        public int porcentajeDescuento { get; set; }
        public double valorDescuento { get; set; }

        public void obtenerValorPagarAntesDescuento() {
            ReglaDeNegocio objReglaDeNegocio = new ReglaDeNegocio();
            this.valorPagarAntesDeDescuento = valorCredito * objReglaDeNegocio.numeroCreditos;
            objReglaDeNegocio = null;
        }

        public void obtenerPorcentajeDescuento() {
            ReglaDeNegocio objReglaDeNegocio = new ReglaDeNegocio();
            this.porcentajeDescuento = (int)(objReglaDeNegocio.porcentajeDescuento * 100);
            objReglaDeNegocio = null;
        }

        public void obtenerValorDescuento()
        {
            ReglaDeNegocio objReglaDeNegocio = new ReglaDeNegocio();
            double valorDescuento = this.valorPagarAntesDeDescuento * this.porcentajeDescuento;
            objReglaDeNegocio = null;
        }

        public double obtenerValorTotal()
        {
            ReglaDeNegocio objReglaDeNegocio = new ReglaDeNegocio();
            double valorPagar = this.valorPagarAntesDeDescuento * this.porcentajeDescuento;
            objReglaDeNegocio = null;
            return valorPagar;
        }


    }
}
