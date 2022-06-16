using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RegistroDeVentas
{
    class Venta
    {
        public string NombreProducto { get; set; }
        public int Precio { get; set; }

        public string Datos()
        {
            return "Ventas: " + "Nombre del producto " +this.NombreProducto + "--precio: " + this.Precio;
        }
    }
}
