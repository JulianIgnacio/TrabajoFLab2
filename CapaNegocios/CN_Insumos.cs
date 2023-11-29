using CapaDatos;
using System.Data;

namespace CapaNegocios
{
    public class CN_Insumos
    {
        CD_Insumos cdinsumos = new CD_Insumos();
        
        public DataTable MostrarInsumos()
        {
            DataTable dtInsumos = new DataTable();
            dtInsumos = cdinsumos.ObtenerInsumos();
            return dtInsumos;
        }
    }
}
