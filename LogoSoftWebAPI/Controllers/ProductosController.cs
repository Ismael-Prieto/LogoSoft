using LogoSoftWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LogoSoftWebAPI.Controllers
{
    [AllowAnonymous]
    [RoutePrefix("api/productos")]
    public class ProductosController : ApiController
    {
        /// <summary>
        /// Agrega un nuevo producto
        /// </summary>
        /// <param name="producto">typeProducto del registro</param>
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
        ///         <description>23/Noviembre/2019 6:30pm</description>
        ///         <description>Release Inicial</description>
        ///     </item>
        /// </list>
        [HttpPost]
        [Route("agregaproducto")]
        public IHttpActionResult Agrega_Producto(typeProducto producto)
        {
            var Producto = new Cat_Productos();

            try
            {
                Producto.Codigo = producto.Codigo;
                Producto.Nombre = producto.Nombre.ToUpper();
                Producto.Precio = producto.Precio;
                
                //Realiza el registro
                using (var conexion = new dboEntities())
                {
                    conexion.Configuration.ProxyCreationEnabled = false;

                    //Valida que no exista el nombre o código
                    var validaNombre = conexion.Cat_Productos.SingleOrDefault(Consulta => Consulta.Nombre == producto.Nombre.ToUpper() || Consulta.Codigo == producto.Codigo);
                    if (validaNombre == null)
                    {                        
                        conexion.Cat_Productos.Add(Producto);

                        conexion.SaveChanges();
                        
                        return Ok();
                    }
                    else
                    {
                        throw new Exception("Ya existe un registro con este nombre o código, favor de verificarlo.");
                    }
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
        /// Edita un producto existente
        /// </summary>
        /// <param name="producto">typeProducto del registro</param>
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
        ///         <description>23/Noviembre/2019 6:30pm</description>
        ///         <description>Release Inicial</description>
        ///     </item>
        /// </list>
        [HttpPost]
        [Route("editaproducto")]
        public IHttpActionResult Edita_Producto(typeProducto producto)
        {            
            try
            {
                //Realiza el registro
                using (var conexion = new dboEntities())
                {
                    conexion.Configuration.ProxyCreationEnabled = false;

                    var Producto = conexion.Cat_Productos.SingleOrDefault(consulta => consulta.Producto_ID == producto.Producto_ID);
                    if (Producto != null)
                    {
                        //Valida que no exista el nombre o código
                        if (Producto.Nombre != producto.Nombre)
                        {
                            var validaNombre = conexion.Cat_Productos.SingleOrDefault(Consulta => Consulta.Nombre == producto.Nombre.ToUpper());
                            if (validaNombre != null)
                            {
                                throw new Exception("Ya existe un registro con este nombre, favor de verificarlo.");
                            }
                        }
                        if (Producto.Codigo != producto.Codigo)
                        {
                            var validaNombre = conexion.Cat_Productos.SingleOrDefault(Consulta => Consulta.Codigo == producto.Codigo);
                            if (validaNombre != null)
                            {
                                throw new Exception("Ya existe un registro con este código, favor de verificarlo.");
                            }
                        }

                        Producto.Codigo = producto.Codigo;
                        Producto.Nombre = producto.Nombre.ToUpper();
                        Producto.Precio = producto.Precio;

                        conexion.SaveChanges();

                        return Ok();
                    }
                    else
                    {
                        return ResponseMessage(Request.CreateErrorResponse(HttpStatusCode.NotFound, "No existe el producto"));
                    }
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
        /// Elimina un producto existente
        /// </summary>
        /// <param name="ID">Producto_ID del registro</param>        
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
        ///         <description>23/Noviembre/2019 7:00pm</description>
        ///         <description>Release Inicial</description>
        ///     </item>
        /// </list>
        [HttpPost]
        [Route("eliminaproducto/{ID}")]
        public IHttpActionResult Elimina_Producto(int ID)
        {
            try
            {
                //Realiza el registro
                using (var conexion = new dboEntities())
                {
                    conexion.Configuration.ProxyCreationEnabled = false;
                    
                    var Producto = (from consulta in conexion.Cat_Productos
                                    where consulta.Producto_ID == ID
                                    select consulta).FirstOrDefault<Cat_Productos>();
                    if (Producto != null)
                    {
                        conexion.Cat_Productos.Remove(Producto);

                        conexion.SaveChanges();

                        return Ok();                        
                    }
                    else
                    {
                        return ResponseMessage(Request.CreateErrorResponse(HttpStatusCode.NotFound, "No existe el producto"));
                    }
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
        /// Consulta los productos de acuerdo al filtro
        /// </summary>
        /// <param name="Filtrar">Cadena de búsqueda por aproximación</param>        
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
        ///         <description>23/Noviembre/2019 6:50pm</description>
        ///         <description>Release Inicial</description>
        ///     </item>
        /// </list>
        [HttpGet]
        [Route("consultaproductos/{Filtrar}")]
        public IHttpActionResult Consulta_Productos(string Filtrar)
        {
            try
            {
                if (string.IsNullOrEmpty(Filtrar) || Filtrar.ToUpper().Trim() == "NULL")
                    Filtrar = "";

                //Realiza la consulta de los registros
                using (var conexion = new dboEntities())
                {
                    conexion.Configuration.ProxyCreationEnabled = false;

                    var Consulta = (from consulta in conexion.Cat_Productos
                                    where consulta.Nombre.Contains(Filtrar)
                                    select new
                                    {
                                        consulta.Producto_ID,
                                        consulta.Codigo,
                                        consulta.Nombre,
                                        consulta.Precio
                                    });

                    //Valida la consulta
                    if (Consulta != null)
                    {
                        return Ok(Consulta.ToList());
                    }
                    else
                    {
                        return BadRequest();
                    }
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

        /// <summary>
        /// Consulta los productos de acuerdo al filtro
        /// </summary>
        /// <param name="ID">Producto_ID de búsqueda</param>        
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
        ///         <description>23/Noviembre/2019 8:30pm</description>
        ///         <description>Release Inicial</description>
        ///     </item>
        /// </list>
        [HttpGet]
        [Route("consultaproductoid/{ID}")]
        public IHttpActionResult Consulta_Producto_ID(int ID)
        {
            try
            {                
                //Realiza la consulta de los registros
                using (var conexion = new dboEntities())
                {
                    conexion.Configuration.ProxyCreationEnabled = false;

                    var Consulta = (from consulta in conexion.Cat_Productos
                                    where consulta.Producto_ID == ID
                                    select new
                                    {
                                        consulta.Producto_ID,
                                        consulta.Codigo,
                                        consulta.Nombre,
                                        consulta.Precio
                                    });

                    //Valida la consulta
                    if (Consulta != null)
                    {
                        return Ok(Consulta.ToList());
                    }
                    else
                    {
                        return BadRequest();
                    }
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

        /// <summary>
        /// Consulta los productos de acuerdo al filtro
        /// </summary>
        /// <param name="Codigo">Código de búsqueda</param>        
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
        ///         <description>23/Noviembre/2019 8:35pm</description>
        ///         <description>Release Inicial</description>
        ///     </item>
        /// </list>
        [HttpGet]
        [Route("consultaproductocodigo/{Codigo}")]
        public IHttpActionResult Consulta_Producto_Codigo(string Codigo)
        {
            try
            {
                //Realiza la consulta de los registros
                using (var conexion = new dboEntities())
                {
                    conexion.Configuration.ProxyCreationEnabled = false;

                    var Consulta = (from consulta in conexion.Cat_Productos
                                    where consulta.Codigo == Codigo
                                    select new
                                    {
                                        consulta.Producto_ID,
                                        consulta.Codigo,
                                        consulta.Nombre,
                                        consulta.Precio
                                    });

                    //Valida la consulta
                    if (Consulta != null)
                    {
                        return Ok(Consulta.ToList());
                    }
                    else
                    {
                        return BadRequest();
                    }
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
