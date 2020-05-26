using EntidadNegocio;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace Datos
{
    public class ProductosDL
    {
        public DataTable ConsultarProductos()
        {
            DataTable wConsulta = new DataTable();

            try
            {
                using (SqlConnection cnx = new SqlConnection(ConexionDL.Conexion(ConexionDL.EConexion.north)))
                {
                    using (SqlCommand cmd = new SqlCommand("uspProductListar", cnx) { CommandType = CommandType.StoredProcedure })
                    {

                        cnx.Open();
                        wConsulta.Load(cmd.ExecuteReader());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return wConsulta;
        }

        public bool InsertarProducto(ProductoBE productoBE)
        {
            bool wSuccess = default;

            try
            {
                using (SqlConnection cnx = new SqlConnection())
                {
                    using (SqlCommand cmd = new SqlCommand("uspProductoInserta", cnx) { CommandType=CommandType.StoredProcedure })
                    {

                        cmd.Parameters.Add(new SqlParameter("@pNombreProducto", SqlDbType.NVarChar, 40)).Value = productoBE.NombeProducto1;
                        cmd.Parameters.Add(new SqlParameter("@pSupplierId", SqlDbType.Int)).Value = productoBE.SupplierId1;
                        cmd.Parameters.Add(new SqlParameter("@pCategoriaId", SqlDbType.Int)).Value = productoBE.CategoriaId1;
                        cmd.Parameters.Add(new SqlParameter("@pQuantityPre", SqlDbType.NVarChar)).Value = productoBE.CantidadPrecioUnitario1;
                        cmd.Parameters.Add(new SqlParameter("@pPrecioUni", SqlDbType.Money)).Value = productoBE.PrecioUnitario1;
                        cmd.Parameters.Add(new SqlParameter("@pUnidadEnStock", SqlDbType.SmallInt)).Value = productoBE.UnidadStock1;
                        cmd.Parameters.Add(new SqlParameter("@pUnidadEnOrden", SqlDbType.SmallInt)).Value = productoBE.UnidadOrden1;
                        cmd.Parameters.Add(new SqlParameter("@pReordeLevel", SqlDbType.SmallInt)).Value = productoBE.ReorderLevel1;
                        cmd.Parameters.Add(new SqlParameter("@pDiscontinuidad", SqlDbType.Bit)).Value = productoBE.Discontinuidad1;

                        cnx.Open();
                        wSuccess = Convert.ToBoolean(cmd.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return wSuccess;
        }

        public bool EliminarProducto(int pProductoId)
        {
            bool wSuccess = false;
            try
            {
                using (SqlConnection cnx = new SqlConnection())
                {
                    using (SqlCommand cmd = new SqlCommand("uspProductEliminar", cnx) { CommandType=CommandType.StoredProcedure})
                    {
                        cmd.Parameters.Add("@pProductoId", SqlDbType.Int).Value = pProductoId;

                        cnx.Open();
                        cmd.ExecuteReader();

                        wSuccess = true;
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return wSuccess;
        }

        public bool ActualizarProducto(ProductoBE productoBE)
        {
            bool wSuccess = default;

            try
            {
                using (SqlConnection cnx = new SqlConnection())
                {
                    using (SqlCommand cmd = new SqlCommand("uspProductoInserta", cnx) { CommandType = CommandType.StoredProcedure })
                    {

                        cmd.Parameters.Add(new SqlParameter("@pNombreProducto", SqlDbType.NVarChar, 40)).Value = productoBE.NombeProducto1;
                        cmd.Parameters.Add(new SqlParameter("@pSupplierId", SqlDbType.Int)).Value = productoBE.SupplierId1;
                        cmd.Parameters.Add(new SqlParameter("@pCategoriaId", SqlDbType.Int)).Value = productoBE.CategoriaId1;
                        cmd.Parameters.Add(new SqlParameter("@pQuantityPre", SqlDbType.NVarChar)).Value = productoBE.CantidadPrecioUnitario1;
                        cmd.Parameters.Add(new SqlParameter("@pPrecioUni", SqlDbType.Money)).Value = productoBE.PrecioUnitario1;
                        cmd.Parameters.Add(new SqlParameter("@pUnidadEnStock", SqlDbType.SmallInt)).Value = productoBE.UnidadStock1;
                        cmd.Parameters.Add(new SqlParameter("@pUnidadEnOrden", SqlDbType.SmallInt)).Value = productoBE.UnidadOrden1;
                        cmd.Parameters.Add(new SqlParameter("@pReordeLevel", SqlDbType.SmallInt)).Value = productoBE.ReorderLevel1;
                        cmd.Parameters.Add(new SqlParameter("@pDiscontinuidad", SqlDbType.Bit)).Value = productoBE.Discontinuidad1;

                        cnx.Open();
                        wSuccess = Convert.ToBoolean(cmd.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return wSuccess;
        }

    }
}
