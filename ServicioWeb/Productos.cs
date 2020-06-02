using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicioWeb
{
    public class Productos
    {
        public String CodPro { get; set; }

        public String Descripcion { get; set; }

        public String Detalle { get; set; }

        public int Stock { get; set; }

        public decimal Precio { get; set; }

        public String Imagen { get; set; }

        public Productos()
        {
            this.CodPro = "";
            this.Descripcion = "";
            this.Detalle = "";
            this.Stock = 0;
            this.Precio = 0;
            this.Imagen = "";
        }

        public Productos(String cod, String des, String dt, int existencia, decimal pre, String img)
        {
            this.CodPro = cod;
            this.Descripcion = des;
            this.Detalle = dt;
            this.Stock = existencia;
            this.Precio = pre;
            this.Imagen = img;
        }
    }
}