﻿using System;
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
 
    public partial class pedidosEspeciales : Form
    {
        modelo mo = new modelo();
        
        public pedidosEspeciales(string cliente)
        {
            InitializeComponent();

            cmb_productos.llenarse2("productos","id_producto","nombre_producto","id_tipo_producto","1");
            grb_detalle.Enabled = false;
            lbl_noOrden.Text = mo.idmax("produccion_encabezados", "cod_orden");
           
            lbl_cliente.Text = cliente;
            string fecha = DateTime.Now.ToString("yyyy-MM-dd");
            Dtp_fechalim.Format = DateTimePickerFormat.Custom;
            Dtp_fechalim.CustomFormat = "yyyy-MM-dd";
            Lbl_date.Text = fecha;

        }
   
        private void Button1_Click(object sender, EventArgs e)
        {
            string fecha1 = DateTime.Now.ToString("yyyy-MM-dd");
            string fecha2 = Dtp_fechalim.Text;

            grb_detalle.Enabled = true;
            grb_encabezado.Enabled=false;
            string cantidad = Nud_cantidad.Value.ToString();


                string cadena = "INSERT INTO produccion_encabezados (cod_orden, fecha_orden, fecha_limite, tipo_produccion, estado) VALUES(NULL,'" + fecha1+ "','" + fecha2 + "', 'Especial',1);";
                mo.insertar(cadena);
              


        }

        private void Btn_agregar_Click(object sender, EventArgs e )
        {
            string buscar = cmb_productos.texto2();
            int existe = cmb_productos.existe(buscar);
            decimal num = Nud_cantidad.Value;

            if (existe != -1 && buscar != "" && num != 0)
            {
                string primero = cmb_productos.ObtenerIndif();
                string cantidad = Nud_cantidad.Value.ToString();
                string fecha = Lbl_date.Text;
                string fechalim = Dtp_fechalim.Text;

                Dgb_pedidosEspeciales.Rows.Add(primero, cantidad, fecha, fechalim);

            }
            else {

                MessageBox.Show("Ingrese un producto valido y cantidades mayores a 0 ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
        
                if (Dgb_pedidosEspeciales.SelectedRows.Count == 1)
                {
                if (Dgb_pedidosEspeciales.Rows.Count > 1)
                {

                    Dgb_pedidosEspeciales.Rows.RemoveAt(Dgb_pedidosEspeciales.CurrentRow.Index);
                }
                else {

                    MessageBox.Show("No se puede ingresar una orden sin productos ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }
                }
            
          
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            string idmax = lbl_noOrden.Text;
            if (Dgb_pedidosEspeciales.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in Dgb_pedidosEspeciales.Rows)
                {
                    string cadena = "INSERT INTO produccion_detalles (id_detalle, cod_orden, id_producto, cantidad_producto, estado) VALUES(NULL," + idmax + ",'" + row.Cells[0].Value.ToString() + "'," + row.Cells[1].Value.ToString() + ",1);";
                    mo.insertar(cadena);
                }

                MessageBox.Show("Orden Generada");
                this.Close();
            }
            else {

                MessageBox.Show("Agregue los productos a la orden ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
        }

        private void Grb_detalle_Enter(object sender, EventArgs e)
        {
            
        }

        private void Grb_encabezado_Enter(object sender, EventArgs e)
        {

        }

        private void PedidosEspeciales_Load(object sender, EventArgs e)
        {
            Dtp_fechalim.MinDate = DateTime.Now.AddDays(7);
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "ayuda-MRP/AyudaMRP.chm", "AyudaPedidosEspeciales.html"); 
        }
    }
}
