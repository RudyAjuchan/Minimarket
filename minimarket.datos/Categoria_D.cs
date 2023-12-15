using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using minimarket.entidades;

namespace minimarket.datos
{
    public class Categoria_D
    {
        public DataTable Listado_categorias(string busqueda)
        {
            SqlDataReader Resultado;
            DataTable Dt = new DataTable();
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("Listado_categorias", SqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@busqueda", SqlDbType.NVarChar).Value = busqueda;
                SqlCon.Open();
                Resultado = cmd.ExecuteReader();
                Dt.Load(Resultado);
                return Dt;
            }catch (Exception ex)
            {
                throw ex;
            }
            finally 
            { 
                if (SqlCon.State==ConnectionState.Open) SqlCon.Close(); 
            }

        }

        public string guardar(int opcion, Categoria_E categoria)
        {
            string result = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("Gestion_categoria", SqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@opcion", SqlDbType.Int).Value = opcion;
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = categoria.Id;
                cmd.Parameters.Add("@nombre", SqlDbType.NVarChar).Value = categoria.Nombre;
                SqlCon.Open();
                result = cmd.ExecuteNonQuery() == 1 ? "OK" : "Hubo un problema al guardar";
                return result;
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }

            return result;
        }

        public string actualizar(int opcion, Categoria_E categoria)
        {
            string result = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("Gestion_categoria", SqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@opcion", SqlDbType.Int).Value = opcion;
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = categoria.Id;
                cmd.Parameters.Add("@nombre", SqlDbType.NVarChar).Value = categoria.Nombre;
                SqlCon.Open();
                result = cmd.ExecuteNonQuery() == 1 ? "OK" : "Hubo un problema al actualizar";
                return result;
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }

            return result;
        }

        public string eliminar(int opcion, Categoria_E categoria)
        {
            string result = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("Gestion_categoria", SqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@opcion", SqlDbType.Int).Value = opcion;
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = categoria.Id;
                cmd.Parameters.Add("@nombre", SqlDbType.NVarChar).Value = categoria.Nombre;
                SqlCon.Open();
                result = cmd.ExecuteNonQuery() == 1 ? "OK" : "Hubo un problema al eliminar";
                return result;
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }

            return result;
        }
    }
}
