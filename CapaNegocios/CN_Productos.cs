using CapaDatos;
using System.Data;

namespace CapaNegocios
{
    public class CN_Productos
    {
        CD_Productos cdproductos = new CD_Productos();

        public DataTable MostrarProductos()
        {
            DataTable dtProductos = new DataTable();
            dtProductos = cdproductos.ObtenerProductos();
            return dtProductos;
        }
    }
}
