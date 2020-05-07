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
    public partial class ordenesPendientes : Form
    {
        modelo mo = new modelo();
        string tabla = "produccion_procesos";
        string[] aliasC = new string[40];
        string[] alias = { "cod_productosP", "cod_orden", "tiempo", "estado" };
        public ordenesPendientes()
        {
            InitializeComponent();
            asignarAlias(alias);
            actualizardatagriew();

        }
        public void actualizardatagriew()
        {
            DataTable dt = mo.consultaLogica(tabla);
            Dgb_ordenesPendientes.DataSource = dt;
            int head = 0;
            while (head < mo.contarCampos(tabla))
            {
                Dgb_ordenesPendientes.Columns[head].HeaderText = aliasC[head];
                head++;
            }
        }

        public void asignarAlias(string[] alias)
        {
            alias.CopyTo(aliasC, 0);
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Dgb_ordenesPendientes_DoubleClick(object sender, EventArgs e)
        {

            
        }
    }
}
