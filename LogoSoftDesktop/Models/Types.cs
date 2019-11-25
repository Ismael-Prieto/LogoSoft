using System;
using System.Collections.Generic;

namespace LogoSoftDesktop
{
    public class typeFactura
    {        
        public DateTime Fecha { get; set; }
        public string Cedula { get; set; }
        public string Cliente { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Descuento { get; set; }
        public decimal Total { get; set; }
        public List<typeDetalles> Detalles { get; set; }
    }

    public class typeProducto
    {
        public int Producto_ID { get; set; }        
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }        
    }

    public class typeDetalles
    {
        public int Producto_ID { get; set; }        
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public decimal Importe { get; set; }
    }

    public class typeReporteVentas
    {
        public DateTime Fecha { get; set; }
        public string Numero_Comprobante { get; set; }
        public string Nombre_Cliente { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Descuento { get; set; }
        public decimal Total { get; set; }        
    }

    public class typeResponse
    {
        public string Message { get; set; }        
    }
}
