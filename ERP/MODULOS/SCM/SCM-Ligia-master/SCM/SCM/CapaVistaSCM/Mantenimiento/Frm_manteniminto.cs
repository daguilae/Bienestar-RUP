﻿using CapaModeloSCM.Mantenimientos;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CapaVistaSCM.Mantenimiento
{
    public partial class Frm_manteniminto : Form
    {
        string usuario;
        int noTabla;

        //llaves foraneas
        int noForaneas;

        public Frm_manteniminto(string user, int tbl)
        {
            InitializeComponent();


            Text = "1001 - " + Text;
            noTabla = tbl;
            usuario = user;

            Cls_matenimiento Mant = new Cls_matenimiento();

            // Arreglo de nombres para campos
            Nav_Mantenimiento.asignarAlias(Mant.datos(tbl).Item1); // Asignar nombres
            Nav_Mantenimiento.asignarSalida(this); // Asignar form de salida

            Nav_Mantenimiento.asignarColorFuente(Color.Black);
            Nav_Mantenimiento.asignarAyuda(Mant.datos(tbl).Item2); // asignar 1 por defecto 
                                                                   // LOS COMBOS SE ASIGNAN SEGUN EL ORDEN EN QUE SE DECLAREN
                                                                   //navegador1.asignarComboConTabla("tabla", "campo", 0); // 0 o 1 en modo, 0 pone el id y 1 coloca el nombre y consulta el id

            noForaneas = Mant.datos(tbl).Item6;
            if (noForaneas != 0)
            {
                int i = 1;
                while (i <= noForaneas)
                {
                    Mant.foraneas(tbl, i);
                    Nav_Mantenimiento.asignarComboConTabla(
                        Mant.foraneas(tbl, i).Item1,
                        Mant.foraneas(tbl, i).Item2,
                        Mant.foraneas(tbl, i).Item3
                        );
                    i++;
                }
            }

            Nav_Mantenimiento.asignarTabla(Mant.datos(tbl).Item3); // tabla principal
            Nav_Mantenimiento.asignarNombreForm(" "); // Titulo y nombre del form

            //establecer nombre del form y lable
            Text = Text + Mant.datos(tbl).Item4;
            Lbl_titulo.Text = Mant.datos(tbl).Item5;
        }

        private void Nav_Mantenimiento_Load(object sender, EventArgs e)
        {
            string aplicacionActiva = "1001";
            Nav_Mantenimiento.ObtenerIdUsuario(usuario); // Pasa el parametro del usuario
            Nav_Mantenimiento.botonesYPermisosInicial(usuario, aplicacionActiva); // Consulta permisos al iniciar
            Nav_Mantenimiento.ObtenerIdAplicacion(aplicacionActiva);// Pasa el id de la aplicacion actual
        }

        private void Btn_ayuda_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"Ayudas\ayudaMant.chm");
        }
    }
}
