using CapaDatos.BaseDatos;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Productos
    {
        ConexionDB conexionDB = new ConexionDB();

        SqlCommand comandoSql = new SqlCommand();

        public DataTable ObtenerProductos()
        {
            var tabla = new DataTable();

            comandoSql.Connection = conexionDB.AbrirConexion();
            comandoSql.CommandText = "SELECT * FROM Producto";
            SqlDataReader leer = comandoSql.ExecuteReader();
            tabla.Load(leer);
            conexionDB.CerrarConexion();

            return tabla;
        }
    }
}
