using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace minimarket_presentacion.Reportes
{
    public partial class Frm_rpt_categorias : Form
    {
        public Frm_rpt_categorias()
        {
            InitializeComponent();
        }

        private void Frm_rpt_categorias_Load(object sender, EventArgs e)
        {
            this.listado_categoriasTableAdapter.Fill(this.dataSet_minimarket.Listado_categorias, busqueda: txt_busqueda.Text);
            this.reportViewer1.RefreshReport();
        }
    }
}
