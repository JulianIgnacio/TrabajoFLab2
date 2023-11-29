using CapaDatos.BaseDatos;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Insumos
    {
        ConexionDB conexionDB = new ConexionDB();

        SqlCommand comandoSql = new SqlCommand();

        public DataTable ObtenerInsumos()
        {
            var tabla = new DataTable();

            comandoSql.Connection = conexionDB.AbrirConexion();
            comandoSql.CommandText = "SELECT * FROM Insumos";
            SqlDataReader leer = comandoSql.ExecuteReader();
            tabla.Load(leer);
            conexionDB.CerrarConexion();

            return tabla;
        }
    }
}
