using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVistaMRP
{
    public partial class mantenimientoRecetas : Form
    {
        string usuario = "";
        public mantenimientoRecetas(string user)
        {
            InitializeComponent();
            usuario = user;
            string[] alias = { "cod_detalle","cod_proceso","Materia_prima","cantidad","unidad_medida","estado" };
            navegador1.asignarAlias(alias);
            navegador1.asignarSalida(this);
            Color Hotel = Color.FromArgb(253, 254, 254);
            navegador1.asignarColorFondo(Hotel);
            navegador1.asignarColorFuente(Color.Black);
            navegador1.asignarAyuda("1");
            navegador1.asignarComboConTabla("produccion_procesos", "nombre", 2);
            navegador1.asignarComboConTabla("productos", "nombre_producto", 4);
            navegador1.asignarTabla("detalles_recetas");
            navegador1.asignarNombreForm("");
        }

        private void MantenimientoRecetas_Load(object sender, EventArgs e)
        {
            string aplicacionActiva = "1";
            navegador1.ObtenerIdUsuario(usuario);
            navegador1.botonesYPermisosInicial(usuario, aplicacionActiva);
            navegador1.ObtenerIdAplicacion(aplicacionActiva);
        }
    }
}
