using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using minimarket.entidades;
using minimarket.negocio;

namespace minimarket_presentacion
{
    public partial class Frm_categorias : Form
    {
        public Frm_categorias()
        {
            InitializeComponent();
        }

        #region "Variables"
            int opcionG = 0;
            int id = 0;
            string nombreG = "";
        #endregion

        #region "Funciones propias"

        private void Formato()
        {
            datosVista.Columns[0].Width = 100;
            datosVista.Columns[0].HeaderText = "Código";
            datosVista.Columns[1].Width = 300;
            datosVista.Columns[1].HeaderText = "Nombre";
        }

        private void Listar(string busqueda)
        {
            try
            {
                datosVista.DataSource = Categoria_N.listado_categorias(busqueda);
                this.Formato();
            }
            catch(Exception ex) 
            { 
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Frm_categorias_Load(object sender, EventArgs e)
        {
            this.Listar("%");
            this.Botones_principales(true);
            this.Botones_segundarios(false);
            edicion_cajas(true);
        }

        private void Botones_principales(bool estado)
        {
            btn_nuevo.Enabled = estado;
            btn_actualizar.Enabled = estado;
            btn_eliminar.Enabled = estado;
            btn_reporte.Enabled = estado;
            btn_salir.Enabled = estado;
        }

        private void Botones_segundarios(bool estado)
        {
            btn_guardar.Enabled = estado;
        }

        private void limpiar_cajas()
        {
            txt_buscar.Text = "";
            txt_nombreCat.Text = "";
        }

        private void edicion_cajas(bool estado)
        {
            txt_nombreCat.ReadOnly = estado;
        }

        private void cargar_datos()
        {
            if (string.IsNullOrEmpty(Convert.ToString(datosVista.CurrentRow.Cells["id"].Value)))
            {
                MessageBox.Show("No hay información para visualizar", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txt_nombreCat.Text = Convert.ToString(datosVista.CurrentRow.Cells["nombre"].Value);
                id = (int)(datosVista.CurrentRow.Cells["id"].Value);
            }
        }

        private void cargar_dato_eliminar()
        {
            if (string.IsNullOrEmpty(Convert.ToString(datosVista.CurrentRow.Cells["id"].Value)))
            {
                MessageBox.Show("No hay información para visualizar", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                nombreG = Convert.ToString(datosVista.CurrentRow.Cells["nombre"].Value);
                id = (int)(datosVista.CurrentRow.Cells["id"].Value);
            }
        }
        #endregion

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            tab_principal.SelectedIndex = 1;
            opcionG = 1;
            Botones_principales(false);
            Botones_segundarios(true);
            edicion_cajas(false);
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            tab_principal.SelectedIndex = 0;
            Botones_principales(true);
            Botones_segundarios(false);
            opcionG = 0;
            limpiar_cajas();
            edicion_cajas(true);
            id = 0;
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                if (txt_nombreCat.Text == String.Empty)
                {
                    MessageBox.Show("Falta datos por completar, ingresa los datos requeridos (*)", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    opcionG = 2;
                    Categoria_E categoria = new Categoria_E();
                    string result = "";
                    categoria.Id = id;
                    categoria.Nombre = txt_nombreCat.Text.Trim();
                    result = Categoria_N.actualizar(opcionG, categoria);

                    if (result == "OK")
                    {
                        MessageBox.Show("Los datos fueron actualizados con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Botones_principales(true);
                        Botones_segundarios(false);
                        limpiar_cajas();
                        edicion_cajas(true);
                        this.Listar("%");
                        tab_principal.SelectedIndex = 0;
                        id=0;
                    }
                    else
                    {
                        MessageBox.Show(result, "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }                
            }
            else
            {
                MessageBox.Show("Selecciona un dato para actualizar", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            cargar_dato_eliminar();
            Console.WriteLine(id);
            if (id != 0)
            {
                DialogResult resultado = MessageBox.Show("¿Está seguro de que desea eliminar "+ nombreG +"?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(resultado == DialogResult.Yes)
                {
                    opcionG = 3;
                    Categoria_E categoria = new Categoria_E();
                    string result = "";
                    categoria.Id = id;
                    categoria.Nombre = "";
                    result = Categoria_N.eliminar(opcionG, categoria);

                    if (result == "OK")
                    {
                        MessageBox.Show("Los datos fueron eliminados con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Botones_principales(true);
                        Botones_segundarios(false);
                        limpiar_cajas();
                        edicion_cajas(true);
                        this.Listar("%");
                        tab_principal.SelectedIndex = 0;
                        id = 0;
                    }
                    else
                    {
                        MessageBox.Show(result, "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecciona un dato para eliminar", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            opcionG = 3;
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (txt_nombreCat.Text == String.Empty)
            {
                MessageBox.Show("Falta datos por completar, ingresa los datos requeridos (*)", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Categoria_E categoria = new Categoria_E();
                string result = "";
                categoria.Id = 0;
                categoria.Nombre=txt_nombreCat.Text.Trim();
                result = Categoria_N.guardar(opcionG, categoria);

                if(result == "OK")
                {
                    MessageBox.Show("Los datos fueron guardados con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Botones_principales(true);
                    Botones_segundarios(false);
                    limpiar_cajas();
                    edicion_cajas(true);
                    this.Listar("%");
                    tab_principal.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show(result, "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void datosVista_DoubleClick(object sender, EventArgs e)
        {
            cargar_datos();
            tab_principal.SelectedIndex = 1;
            Botones_principales(false);
            Botones_segundarios(true);
            edicion_cajas(false);
            btn_actualizar.Enabled = true;
            btn_guardar.Enabled = false;
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            Listar(txt_buscar.Text);
        }

        private void btn_reporte_Click(object sender, EventArgs e)
        {
            Reportes.Frm_rpt_categorias R1 = new Reportes.Frm_rpt_categorias();
            R1.txt_busqueda.Text = txt_buscar.Text;
            R1.ShowDialog();
        }
    }
}
