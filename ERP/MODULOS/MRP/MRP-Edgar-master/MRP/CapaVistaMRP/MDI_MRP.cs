using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDiseno;
using CapaDatos;

namespace CapaVistaMRP
{
    public partial class MDI_MRP : Form
    {
        private int childFormNumber = 0;
        sentencia sn = new sentencia();
        string usuarioact;
        
        public MDI_MRP()
        {
            InitializeComponent();
          
           
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

       

  

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void OrdenesDeProduccionToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ordenProduccion frm = new ordenProduccion();
            frm.MdiParent = this;
            frm.Show();
        }

        private void SolicitudDeSuministrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            solicitudSuministro frm = new solicitudSuministro();
            frm.MdiParent = this;
            frm.Show();
        }

        private void MantenimientoEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mantenimientoRegistroEmpleados frm = new mantenimientoRegistroEmpleados(lblUsuario.Text);
            frm.MdiParent = this;
            frm.Show();

        }

        private void MantenimientoRecetasToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            mantenimientoRecetas frm = new mantenimientoRecetas(lblUsuario.Text);
            frm.MdiParent = this;
            frm.Show();
        }

        private void MantenimientoProcesosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           procesoProduccion frm = new procesoProduccion();
            frm.MdiParent = this;
            frm.Show();
        }

        private void OrdenesPendientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void MantenimientoConfiguracionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mantenimientoInvConfg frm = new mantenimientoInvConfg(lblUsuario.Text);
            frm.MdiParent = this;
            frm.Show();
        }

        private void ProductosEnProcesoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void GestionDeProduccionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void PedidosEspecialesCRMToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void MantenimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void OrdenesPendientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ordenesPendientes frm = new ordenesPendientes();
            frm.MdiParent = this;
            frm.Show();
        }

        private void ProductosEnProcesoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            productosProceso frm = new productosProceso();
            frm.MdiParent = this;
            frm.Show();
        }

        private void PedidosEspecialesCRMToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pedidosEspeciales frm = new pedidosEspeciales("Cliente1");
            frm.MdiParent = this;
            frm.Show();
        }

        private void MDI_MRP_Load(object sender, EventArgs e)
        {
            frm_login login = new frm_login();
            login.ShowDialog();

            lblUsuario.Text = login.obtenerNombreUsuario();
            usuarioact = lblUsuario.Text;



        }

        private void SeguridadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MDI_Seguridad seguridad = new MDI_Seguridad(lblUsuario.Text);
            seguridad.lbl_nombreUsuario.Text = lblUsuario.Text;
            seguridad.ShowDialog();
            sn.insertarBitacora(lblUsuario.Text, "Ingreso ", "Usuarios");
        }

        private void ToolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void MantenimientoInvetarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mantenimientoInventario frm = new mantenimientoInventario(lblUsuario.Text);
            frm.MdiParent = this;
            frm.Show();
        }

        private void OrdenDeProduccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ordenProduccion frm = new ordenProduccion();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
