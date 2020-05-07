using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace CapaControladorMRP
{


    public class Sentencias
    {
        string cmb;
        string tbl;
        string camp;

        conexionMRP con = new conexionMRP();

        public OdbcDataAdapter llenaTbl(string tabla)// metodo  que obtinene el contenio de una tabla
        {
            string[] camposDesc = obtenerCampos(tabla); //string para almacenar los campos de OBTENERCAMPOS y utilizar el 1ro
            string sql = "SELECT * FROM " + tabla + " WHERE estado=0 || estado=1 ORDER BY " + camposDesc[0] + " DESC ;";
            //SELECT * FROM tbl_bodega WHERE estado=1 ORDER BY kbodega DESC
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con.conexion());
            return dataTable;
        }
        public OdbcDataAdapter llenaTbl2(string sql)// metodo  que obtinene el contenio de una tabla
        {
          
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con.conexion());

            return dataTable;
        }

        public OdbcDataAdapter llenaTbl3( string where)// metodo  que obtinene el contenio de una tabla
        {
            
            string sql = "SELECT * FROM produccion_encabezados WHERE estado=1 and cod_orden = "+where+";";
            //SELECT * FROM tbl_bodega WHERE estado=1 ORDER BY kbodega DESC
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con.conexion());
            return dataTable;
        }
        public OdbcDataAdapter llenaTbl4( string where)// metodo  que obtinene el contenio de una tabla
        {

            string sql = "SELECT dp.id_detalle, dp.cod_orden, p.nombre_producto, dp.cantidad_producto,dp.estado FROM produccion_detalles dp inner join productos p on dp.id_producto= p.id_producto inner join produccion_encabezados pe on dp.cod_orden=pe.cod_orden  WHERE dp.estado=1 and pe.cod_orden="+where  + " ;";
            //SELECT * FROM tbl_bodega WHERE estado=1 ORDER BY kbodega DESC
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con.conexion());
            return dataTable;
        }

        public string obteneridmax(string tabla, string dato)// metodo  que obtinene el contenio de una tabla
        {
            string id = "";
            string sql = "SELECT MAX("+dato+"+1) FROM "+tabla+";";
            //SELECT * FROM tbl_bodega WHERE estado=1 ORDER BY kbodega DESC
            OdbcCommand command = new OdbcCommand(sql, con.conexion());
            OdbcDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {

                id = reader.GetValue(0).ToString();
            }
            return id;
        }


        public void insertar(string sql) {

          

            OdbcCommand consulta = new OdbcCommand(sql, con.conexion());
            consulta.ExecuteNonQuery();




        }
        public string[] obtenerCampos(string tabla)//metodo que obtiene la lista de los campos que requiere una tabla
        {
            string[] Campos = new string[30];
            int i = 0;
            try
            {
                OdbcCommand command = new OdbcCommand("DESCRIBE " + tabla + "", con.conexion());
                OdbcDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Campos[i] = reader.GetValue(0).ToString();
                    i++;

                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nError en asignarCombo, revise los parámetros \n -" + tabla); }
            return Campos;// devuelve un arrgeglo con los campos
        }


        public int contarAlias(string tabla)// metodo  que obtinene el contenio de una tabla
        {
            int Campos = 0;

            try
            {
                OdbcCommand command = new OdbcCommand("DESCRIBE " + tabla + "", con.conexion());
                OdbcDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Campos++;

                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nError en obtenerTipo, revise los parámetros de la tabla  \n -" + tabla.ToUpper() + "\n -"); }
            return Campos;// devuelve un arreglo con los tiposlos campos
        }

       






    }
   








    
}
