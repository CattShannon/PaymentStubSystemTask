using System;
using System.Xml;

namespace Lib_Parcial2.lib
{ 
    public class ReglaDeNegocio
    {

        #region Constructor
        public ReglaDeNegocio()
        {
            this.Programa = string.Empty;
            this.EstratoColegio = 0;
            this.EstratoVivienda = 0;
            this.Error = string.Empty;
        }
        #endregion

        #region Atributos/Propiedades
        public string Programa { set; get; }
        public int EstratoColegio { set; get; }
        public int EstratoVivienda { set; get; }
        public double PorcentajeDescuento { private set; get; }
        public string Error { private set; get; }
        #endregion


        #region Metodos
        public bool ObtenerPorcentajeDescuento()
        {
            if (!Validar())
            {
                return false;
            }

            try
            {
                XmlDocument oDocument = new XmlDocument();
                oDocument.Load(@"C:\Users\sebastian.aguirre\Desktop\PaymentStubSystemTask\Lib_Parcial2\Lib_Parcial2\xml\Descuentos.xml");

                string Consulta = "/DESCUENTOS/MATRICULA/PORCENTAJE_DESCUENTO[@PROGRAMA='" + this.Programa 
                    + "' and @MIN_COLEGIO<=" + EstratoColegio + " and @MAX_COLEGIO>=" + EstratoColegio 
                    + " and @MIN_VIVIENDA<=" + EstratoVivienda + " and @MAX_VIVIENDA>=" + EstratoVivienda +"]";

                XmlNodeList oNodos = oDocument.SelectNodes(Consulta);

                if (oNodos.Count == 0)
                {
                    Error = "La consulta no ha devuelto datos";
                    oNodos = null;
                    oDocument = null;
                    return false;
                }
                else
                {
                    if (oNodos.Count > 1)
                    {
                        Error = "La consulta devolvio mas datos de los esperados. No se puede procesar";
                        oNodos = null;
                        oDocument = null;
                        return false;
                    }
                    else
                    {
                        this.PorcentajeDescuento = Convert.ToDouble(oNodos[0].InnerText) / 100;
                        oNodos = null;
                        oDocument = null;
                        return true;
                    }
                }
            }catch(Exception ex)
            {
                Error = "Error. " + ex.Message;
                return false;
            }

        }

        public bool Validar()
        {
            if (this.Programa.Equals(string.Empty))
            {
                Error = "Error. No ha ingresado ningún programa";
                return false;
            }

            if(this.EstratoColegio < 1 || this.EstratoColegio > 6)
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
        #endregion

    }
}
