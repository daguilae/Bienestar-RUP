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
    public partial class Solicitudes : Form
    {
        modelo mo = new modelo();
        string donde;
        string tabla = "solicitudes_encabezados";
        string tabla2 = "solicitudes_detalles";
        string[] aliasC = new string[120];
        string[] alias2 = { "Numero de detalle", "Numero de Solicitud", "Producto", "Cantidad", "Estado" };
        string[] alias = { "Numero de Solicitud", "Fecha", "Prioridad", "Estado" };
        public Solicitudes()
        {
            InitializeComponent();
            asignarAlias(alias);
            actualizardatagriew(tabla);
            asignarAlias2(alias2);
            actualizardatagriew2(tabla2);

        }

        private void Solicitudes_Load(object sender, EventArgs e)
        {

        }
        public void actualizardatagriew(string algo)
        {

            DataTable dt = mo.consultaLogica12(algo);
            Dgb_solicitudesencab.DataSource = dt;
            int head = 0;
            while (head < mo.contarCampos(tabla))
            {
                Dgb_solicitudesencab.Columns[head].HeaderText = aliasC[head];
                head++;
            }
        }

        public void asignarAlias(string[] alias)
        {
            alias.CopyTo(aliasC, 0);
        }

        public void actualizardatagriew2(string algo)
        {

            DataTable dt = mo.consultaLogica12(algo);
            Dgb_solicitudesDetalle.DataSource = dt;
            int head = 0;
            while (head < mo.contarCampos(tabla))
            {
                Dgb_solicitudesDetalle.Columns[head].HeaderText = aliasC[head];
                head++;
            }
        }

        public void asignarAlias2(string[] alias)
        {
            alias.CopyTo(aliasC, 0);
        }




    }
}
