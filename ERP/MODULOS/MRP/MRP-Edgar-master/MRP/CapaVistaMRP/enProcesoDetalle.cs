using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaModeloMRP;

namespace CapaVistaMRP
{
    public partial class enProcesoDetalle : Form
    {
        modelo mo = new modelo();
        string donde;
        string tabla = "produccion_encabezados";
        string tabla2 = "produccion_detalles";
        string[] aliasC = new string[40];
        string[] alias = { "cod_orden", "fecha orden", "fecha limite","tipo de produccion", "Estado" };
        string[] alias2 = { "cod_detalle", "cod_orden","Producto", "Cantidad a Producir", "Estado" };
        public enProcesoDetalle(string dato)
        {
            InitializeComponent();
            asignarAlias(alias);          
            actualizardatagriew(dato);
            asignarAlias2(alias2);
            actualizardatagriew2(dato);
          

        }




        public void actualizardatagriew(string algo)
        {
            
            DataTable dt = mo.consultaLogica3(algo);
            Dgb_encabezadoProductosP.DataSource = dt;
            int head = 0;
            while (head < mo.contarCampos(tabla))
            {
                Dgb_encabezadoProductosP.Columns[head].HeaderText = aliasC[head];
                head++;
            }
        }

        public void asignarAlias(string[] alias)
        {
            alias.CopyTo(aliasC, 0);
        }

        public void actualizardatagriew2(string encab)
        {
            DataTable dt = mo.consultaLogica4(encab);
            Dgb_detalleProductosP.DataSource = dt;  
            int head = 0;
            while (head < mo.contarCampos(tabla2))
            {
                Dgb_detalleProductosP.Columns[head].HeaderText = aliasC[head];
                head++;
            }
        }

        public void asignarAlias2(string[] alias)
        {
            alias.CopyTo(aliasC, 0);
        }



    }
}
