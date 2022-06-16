using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RegistroDeVentas
{
    class Vendedor
    {
        public string Nombre { get; set; }
        public int Codigo { get; set; }
        public int NumeroCuenta { get; set; }

        List<Venta> Ventas = new List<Venta>();
        
        public string Mostrar()
        {
            return "Vendedor: " + "Nombre ->" + 
                this.Nombre +"-Codigo personal-> " + 
                this.Codigo +"-Numero de cuenta para comision-> " + 
                this.NumeroCuenta;
        }
    }
}
