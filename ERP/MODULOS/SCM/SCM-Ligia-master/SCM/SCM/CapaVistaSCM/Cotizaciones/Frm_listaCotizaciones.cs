﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVistaSCM
{
    public partial class Frm_listaCotizaciones : Form
    {
        public Frm_listaCotizaciones()
        {
            InitializeComponent();
        }

        private void Btn_nuevo_Click(object sender, EventArgs e)
        {
            Frm_cotizacionProveedores cotizacion = new Frm_cotizacionProveedores();
            cotizacion.Show();
        }
    }
}
