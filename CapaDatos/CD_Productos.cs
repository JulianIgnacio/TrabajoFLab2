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

        public void Insertar(string Nombre,float Precio,int Cantidad)
        {
            comandoSql.Connection = conexionDB.AbrirConexion();
            comandoSql.CommandText = "INSERT INTO Producto VALUES (@nombre,@precio,@cantidad)";
            comandoSql.Parameters.AddWithValue("@nombre", Nombre);
            comandoSql.Parameters.AddWithValue("@precio",Precio);
            comandoSql.Parameters.AddWithValue("@cantidad",Cantidad);
            comandoSql.ExecuteNonQuery();
            conexionDB.CerrarConexion();
        }

    }
}
