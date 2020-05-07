﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDiseno;

namespace CapaVistaHRM
{
    public partial class MDI_HRM : Form
    {
        private int childFormNumber = 0;
        
        string usuarioact;
        public MDI_HRM()
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

        private void MDI_HRM_Load(object sender, EventArgs e)
        {
            
            progres();
            ProgressBar1.Style = ProgressBarStyle.Marquee;
            frm_login login = new frm_login();
            login.ShowDialog();
            LblUsuario.Text = login.obtenerNombreUsuario();
            usuarioact = LblUsuario.Text;
            ProgressBar1.Style = ProgressBarStyle.Continuous;
            progres();
        }

        void progres()
        {
            for (int i = 0; i <= 100; i++)
            {
                ProgressBar1.Value = i;
                i++;
               
            }

        }
        private void areasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Area nuevo = new Area(usuarioact);
            nuevo.MdiParent = this.MdiParent;
           nuevo.Show();
        }

        private void empleadosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Empleados nuevo = new Empleados(usuarioact);
            nuevo.MdiParent = this.MdiParent;
            nuevo.Show();
        }

        private void tipoDeConceptosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TipoConcepto nuevo = new TipoConcepto(usuarioact);
            nuevo.MdiParent = this.MdiParent;
            nuevo.Show();
        }

        private void sueldoToolStripMenuItem_Click(object sender, EventArgs e)
        {
          Sueldos nuevo = new Sueldos(usuarioact);
            nuevo.MdiParent = this.MdiParent;
            nuevo.Show();
        }

        private void puestosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Puestos nuevo = new Puestos(usuarioact);
            nuevo.MdiParent = this.MdiParent;
            nuevo.Show();
        }

        private void planillasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenimientoPlanilla nuevo = new MantenimientoPlanilla(usuarioact);
            nuevo.MdiParent = this.MdiParent;
            nuevo.Show();
        }

        private void generarPlanillaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Planilla nuevo = new Planilla(usuarioact);
            nuevo.MdiParent = this.MdiParent;
            nuevo.Show();
        }

        private void conceptosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Conceptos nuevo = new Conceptos(usuarioact);
            nuevo.MdiParent = this.MdiParent;
            nuevo.Show();
        }

        private void seguridadToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MDI_Seguridad seguridad = new MDI_Seguridad(LblUsuario.Text);
            seguridad.lbl_nombreUsuario.Text = LblUsuario.Text;
            seguridad.ShowDialog();

        }

        private void horasExtrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HorasExtra nuevo = new HorasExtra(usuarioact);
            nuevo.MdiParent = this.MdiParent;
            nuevo.Show();
        }

        private void perfilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Perfiles nuevo = new Perfiles(usuarioact);
            nuevo.MdiParent = this.MdiParent;
            nuevo.Show();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void contratacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void empleadosToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void candidatosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void despidosToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void despidosToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Despidos nuevo = new Despidos(usuarioact);
            nuevo.MdiParent = this.MdiParent;
            nuevo.Show();
        }

        private void recontratacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            REContrataciones nuevo = new REContrataciones(usuarioact);
            nuevo.MdiParent = this.MdiParent;
            nuevo.Show();
        }

        private void solicitudesToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void asistenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tipoDeComicionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tipocomiciones nuevo = new Tipocomiciones(usuarioact);
            nuevo.MdiParent = this.MdiParent;
            nuevo.Show();
        }

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Comiciones nuevo = new Comiciones(usuarioact);
            nuevo.MdiParent = this.MdiParent;
            nuevo.Show();
        }

        private void agregarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmpleadosCon nuevo = new EmpleadosCon(usuarioact);
            nuevo.MdiParent = this.MdiParent;
            nuevo.Show();
        }

        private void despidosToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Mantenimientodes nuevo = new Mantenimientodes(usuarioact);
            nuevo.MdiParent = this.MdiParent;
            nuevo.Show();
        }

        private void finiquitosToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}