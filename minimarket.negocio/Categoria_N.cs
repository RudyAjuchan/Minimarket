using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using minimarket.entidades;
using minimarket.datos;

namespace minimarket.negocio
{
    public class Categoria_N
    {
        public static DataTable listado_categorias(string busqueda)
        {
            Categoria_D Datos = new Categoria_D();
            return Datos.Listado_categorias(busqueda);
        }

        public static string guardar(int opcion, Categoria_E categoria)
        {
            Categoria_D Datos = new Categoria_D();
            return Datos.guardar(opcion, categoria);
        }

        public static string actualizar(int opcion, Categoria_E categoria)
        {
            Categoria_D Datos = new Categoria_D();
            return Datos.actualizar(opcion, categoria);
        }

        public static string eliminar(int opcion, Categoria_E categoria)
        {
            Categoria_D Datos = new Categoria_D();
            return Datos.eliminar(opcion, categoria);
        }
    }
}
