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
    public partial class productosProceso : Form
    {
        modelo mo = new modelo();
        string tabla = "productos_proceso";
        string[] aliasC = new string[40];
        string[] alias = { "cod_produccion", "Numero de orden", "fecha", "estado"};

        public productosProceso()
        {
            InitializeComponent();
            asignarAlias(alias);
            actualizardatagriew();
           
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (dgb_productosProceso.SelectedRows.Count == 1)
            {

                string where = dgb_productosProceso.CurrentRow.Cells[1].Value.ToString();
             

                enProcesoDetalle frm = new enProcesoDetalle(where);//pasarle el id del encabezado que se esta consultando
            frm.MdiParent = this.MdiParent;   
            frm.Show();
            }

            
        }


        public void actualizardatagriew()
        {
            DataTable dt = mo.consultaLogica(tabla);
            dgb_productosProceso.DataSource = dt;
            int head = 0;
            while (head < mo.contarCampos(tabla))
            {
                dgb_productosProceso.Columns[head].HeaderText = aliasC[head];
                head++;
            }
        }

        public void asignarAlias(string[] alias)
        {
            alias.CopyTo(aliasC, 0);
        }
    }
}
