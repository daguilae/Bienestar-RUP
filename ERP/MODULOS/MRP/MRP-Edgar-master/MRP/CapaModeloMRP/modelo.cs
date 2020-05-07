using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaControladorMRP;
using System.Data.Odbc;




namespace CapaModeloMRP
{       
       
    public class modelo
    {
        Sentencias sn = new Sentencias();

        public DataTable consultaLogica(string tabla)  //obtener datos de la consulta
        {
            OdbcDataAdapter dt = sn.llenaTbl(tabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
        public int contarCampos(string tabla)
        {
            return sn.contarAlias(tabla);
        }

        public DataTable consultaLogica2(string sql)  //obtener datos de la consulta
        {
            OdbcDataAdapter dt = sn.llenaTbl2(sql);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
        public DataTable consultaLogica3( string where)  //obtener datos de la consulta
        {
            
            OdbcDataAdapter dt = sn.llenaTbl3( where);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
        public DataTable consultaLogica4( string where)  //obtener datos de la consulta
        {

            OdbcDataAdapter dt = sn.llenaTbl4(where);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public string idmax(string tabla, string dato) {



            string idmax = sn.obteneridmax(tabla,dato);
            if (idmax == "")
            {

                idmax = "1";
            }
           
            return idmax;
        }

        public void insertar(string sql) {

            sn.insertar(sql);

        }
    }
}
