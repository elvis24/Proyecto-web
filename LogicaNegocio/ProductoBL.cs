using Datos;
using EntidadNegocio;
using System;
using System.Data;


namespace LogicaNegocio
{

    public class ProductoBL
    {
        private ProductosDL productosDL = new ProductosDL();

        public bool InsertarProducto(ProductoBE productoBE)
        {
           return  productosDL.InsertarProducto(productoBE);
        }

        public DataTable ConsultarProductos()
        {
            return productosDL.ConsultarProductos();
        }

        public bool EliminarProducto(int pProductoId)
        {
             
            return productosDL.EliminarProducto(pProductoId);
        }

        public bool ActualizarProducto(ProductoBE productoBE)
        {
            
            return productosDL.ActualizarProducto(productoBE);
        }

    }
}
