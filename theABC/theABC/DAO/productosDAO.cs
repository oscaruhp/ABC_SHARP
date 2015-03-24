using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using theABC.BO;
using theABC.DAO;

namespace theABC.DAO
{
    class productosDAO
    {
        Conexion MiConexion;
        public productosDAO()
        {
            MiConexion = new Conexion();
        }

       public int Agregar(productosBO oProductosBO) {
            String ComandoSQL = string.Format("INSERT INTO  productos (id,Clave,Nombre,Descripcion,Precio)VALUES (NULL ,'{0}','{1}','{2}','{3}');",oProductosBO.Clave,oProductosBO.Nombre,oProductosBO.Descripcion,oProductosBO.Precio);
            return MiConexion.EjecutarComando(ComandoSQL);
       }
       public int Modificar(productosBO oProductosBO) {
           String ComandoSQL = string.Format("UPDATE productos SET Clave='{1}',Nombre='{2}',Descripcion='{3}',Precio='{4}' WHERE id={0}",oProductosBO.id,oProductosBO.Clave, oProductosBO.Nombre, oProductosBO.Descripcion, oProductosBO.Precio);
           return MiConexion.EjecutarComando(ComandoSQL);
       }
       public int Borrar(productosBO oProductosBO){
           String ComandoSQL = string.Format("DELETE FROM productos WHERE id={0}", oProductosBO.id);
           return MiConexion.EjecutarComando(ComandoSQL);
       }
       public DataTable Buscar()
       {
           String ComandoSQL = string.Format("SELECT * FROM productos");
           return MiConexion.EjercutarSentecia(ComandoSQL);
       }
    }
}
