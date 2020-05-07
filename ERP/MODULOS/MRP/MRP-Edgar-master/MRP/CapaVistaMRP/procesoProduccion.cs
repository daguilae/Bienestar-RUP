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
    public partial class procesoProduccion : Form
    {

        modelo mo = new modelo();
        string tabla = "produccion_procesos";
        string[] aliasC = new string[40];
        string[] alias = { "cod_proceso", "cod_producto","nombre_producto", "descripcion", "tiempo", "estado"};
        string sql3 = "  SELECT pp.id_proceso,pp.id_producto,p.nombre_producto, pp.descripcion_proceso,pp.tiempo_pp,pp.estado from  productos p inner join produccion_procesos pp on p.id_producto=pp.id_producto and  pp.estado=1";

        public procesoProduccion()
        {
            InitializeComponent();
            asignarAlias(alias);
            actualizardatagriew();
         

        }




        public void actualizardatagriew()
        {
            DataTable dt = mo.consultaLogica2(sql3);
            dgb_produccionProceso.DataSource = dt;
            int head = 0;
            while (head < mo.contarCampos(tabla))
            {
                dgb_produccionProceso.Columns[head].HeaderText = aliasC[head];
                head++;
            }
        }


        public void asignarAlias(string[] alias)
        {
            alias.CopyTo(aliasC, 0);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
          

        }

        private void TableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btn_actualizar_Click(object sender, EventArgs e)
        {
            actualizardatagriew();
        }
    }
}
