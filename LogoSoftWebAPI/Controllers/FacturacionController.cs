using LogoSoftWebAPI.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.SqlServer;
using System.Data.Entity.Validation;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LogoSoftWebAPI.Controllers
{
    [AllowAnonymous]
    [RoutePrefix("api/facturacion")]
    public class FacturacionController : ApiController
    {
        /// <summary>
        /// Agrega una nueva factura
        /// </summary>
        /// <param name="factura">typeFactura del registro</param>
        /// <returns>
        /// Regresa éxito o error en formato json
        /// </returns>
        /// <list type="table">    
        ///     <listheader>
        ///         <description>Autor</description>
        ///         <description>Fecha</description>
        ///         <description>Cambio</description>
        ///     </listheader>
        ///     <item>           
        ///         <description>Ismael Prieto</description>
        ///         <description>23/Noviembre/2019 7:10pm</description>
        ///         <description>Release Inicial</description>
        ///     </item>
        /// </list>
        [HttpPost]
        [Route("agregafactura")]
        public IHttpActionResult Agrega_Factura(typeFactura factura)
        {
            var Factura = new Ope_Facturas();

            try
            {                

                //Realiza el registro
                using (var conexion = new dboEntities())
                {
                    conexion.Configuration.ProxyCreationEnabled = false;

                    int No_Documento = conexion.Ope_Facturas.Count() + 1;

                    Factura.Numero_Comprobante = No_Documento.ToString("000000000000");
                    Factura.Nombre_Cliente = factura.Cliente;
                    Factura.Cedula = factura.Cedula;
                    Factura.Fecha = factura.Fecha;
                    Factura.Subtotal = factura.Subtotal;
                    Factura.Descuento = factura.Descuento;
                    Factura.Total = factura.Total;
                    
                    foreach (var detalle in factura.Detalles)
                    {
                        var Detalle = new Ope_Facturas_Detalles();

                        Detalle.Producto_ID = detalle.Producto_ID;
                        Detalle.Cantidad = detalle.Cantidad;
                        Detalle.Precio = detalle.Precio;
                        Detalle.Importe = detalle.Importe;
                        Factura.Ope_Facturas_Detalles.Add(Detalle);
                    }

                    conexion.Ope_Facturas.Add(Factura);

                    conexion.SaveChanges();

                    var Resultado = new { Message = Factura.Numero_Comprobante };

                    return Ok(Resultado);

                }
            }
            catch (DbEntityValidationException ex)
            {
                // Retrieve the error messages as a list of strings.
                var errorMessages = ex.EntityValidationErrors
                        .SelectMany(x => x.ValidationErrors)
                        .Select(x => x.ErrorMessage);

                // Join the list to a single string.
                var fullErrorMessage = string.Join("; ", errorMessages);

                // Combine the original exception message with the new one.
                var exceptionMessage = string.Concat(ex.Message, " Errores de validación: ", fullErrorMessage);

                return ResponseMessage(Request.CreateErrorResponse(HttpStatusCode.InternalServerError, exceptionMessage));
            }
            catch (DbUpdateException ex)
            {
                return ResponseMessage(Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message));
            }
            catch (Exception ex)
            {
                return ResponseMessage(Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message));
            }
        }

        /// <summary>
        /// Consulta las ventas de acuerdo a los filtros
        /// </summary>
        /// <param name="No_Documento_Inicial">Número de documento rango inicial</param>        
        /// <param name="No_Documento_Final">Número de documento rango final</param>        
        /// <param name="Nombre_Cliente">Nombre del cliente</param>        
        /// <returns>
        /// Resultado de la consulta de los registros en formato json
        /// </returns>
        /// <list type="table">    
        ///     <listheader>
        ///         <description>Autor</description>
        ///         <description>Fecha</description>
        ///         <description>Cambio</description>
        ///     </listheader>
        ///     <item>           
        ///         <description>Ismael Prieto</description>
        ///         <description>23/Noviembre/2019 7:20pm</description>
        ///         <description>Release Inicial</description>
        ///     </item>
        /// </list>
        [HttpGet]
        [Route("consultaventas/{No_Documento_Inicial}/{No_Documento_Final}/{Nombre_Cliente}")]
        public IHttpActionResult Consulta_Ventas(string No_Documento_Inicial, string No_Documento_Final, string Nombre_Cliente)
        {
            try
            {
                if (string.IsNullOrEmpty(No_Documento_Inicial.Trim()) || No_Documento_Inicial.Trim() == "NULL")
                    No_Documento_Inicial = "";

                if (string.IsNullOrEmpty(No_Documento_Final.Trim()) || No_Documento_Final.Trim() == "NULL")
                    No_Documento_Final = "";

                if (string.IsNullOrEmpty(Nombre_Cliente.Trim()) || Nombre_Cliente.Trim() == "NULL")
                    Nombre_Cliente = "";

                //Realiza la consulta de los registros
                using (var conexion = new dboEntities())
                {
                    conexion.Configuration.ProxyCreationEnabled = false;

                    var Consulta = conexion.spConsultaVentas(No_Documento_Inicial == "" ? null : No_Documento_Inicial, 
                                                                No_Documento_Final == "" ? null : No_Documento_Final, 
                                                                Nombre_Cliente == "" ? null : Nombre_Cliente).
                                                                Select( c=> new
                                                                        {
                                                                            c.Nombre_Cliente,
                                                                            c.Numero_Comprobante,
                                                                            c.Fecha,
                                                                            c.SubTotal,
                                                                            c.Descuento,
                                                                            c.Total
                                                                        }).ToList();

                    return Ok(Consulta);
                                        
                }
            }
            catch (DbUpdateException ex)
            {
                return ResponseMessage(Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message));
            }
            catch (Exception ex)
            {
                return ResponseMessage(Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message));
            }
        }
    }
}
