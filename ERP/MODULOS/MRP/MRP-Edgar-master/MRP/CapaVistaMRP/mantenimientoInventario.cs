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
    public partial class mantenimientoInventario : Form
    {
        modelo mo = new modelo();
        string tabla = "inventarios_produccion";
        string[] aliasC = new string[100];
        string[] alias = { "cod_inventario", "Nombre_Producto", "Temporada","Cantidad" ,"Unidad_de_Medida ", "costo materia", "Estado" };
        string sql3 = "  SELECT ip.id_inventario,p.nombre_producto,ci.Temporada,ip.cantidad_total ,ip.unidad_medida,ip.costo_mp ,ip.estado  from productos p inner join inventarios_produccion ip on p.id_producto=ip.id_producto INNER join configuraciones_inventarios ci on ip.cod_config=ci.cod_config and  ip.estado=1;";

        public mantenimientoInventario(string user)
        {
            InitializeComponent();
            asignarAlias(alias);
            actualizardatagriew();

            combo1.llenarse("productos","id_producto","nombre_producto");
            combo2.llenarse("configuraciones_inventarios","cod_config","temporada");
            //combo3.llenarse("","","");
        }
        

        public void actualizardatagriew()
        {
            DataTable dt = mo.consultaLogica2(sql3);
            dgb_inventarios.DataSource = dt;
            int head = 0;
            while (head < mo.contarCampos(tabla))
            {
                dgb_inventarios.Columns[head].HeaderText = aliasC[head];
                head++;
            }
        }


        public void asignarAlias(string[] alias)
        {
            alias.CopyTo(aliasC, 0);
        }

        private void Btn_actualizar_Click(object sender, EventArgs e)
        {
            actualizardatagriew();
        }
    }
}
