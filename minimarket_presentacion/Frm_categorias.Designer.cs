namespace minimarket_presentacion
{
    partial class Frm_categorias
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tab_principal = new System.Windows.Forms.TabControl();
            this.tab_nuevo = new System.Windows.Forms.TabPage();
            this.datosVista = new System.Windows.Forms.DataGridView();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txt_nombreCat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_reporte = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.tab_principal.SuspendLayout();
            this.tab_nuevo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datosVista)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_principal
            // 
            this.tab_principal.Controls.Add(this.tab_nuevo);
            this.tab_principal.Controls.Add(this.tabPage2);
            this.tab_principal.Location = new System.Drawing.Point(12, 12);
            this.tab_principal.Name = "tab_principal";
            this.tab_principal.SelectedIndex = 0;
            this.tab_principal.Size = new System.Drawing.Size(750, 320);
            this.tab_principal.TabIndex = 0;
            // 
            // tab_nuevo
            // 
            this.tab_nuevo.Controls.Add(this.datosVista);
            this.tab_nuevo.Controls.Add(this.btn_buscar);
            this.tab_nuevo.Controls.Add(this.txt_buscar);
            this.tab_nuevo.Controls.Add(this.label1);
            this.tab_nuevo.Location = new System.Drawing.Point(4, 25);
            this.tab_nuevo.Name = "tab_nuevo";
            this.tab_nuevo.Padding = new System.Windows.Forms.Padding(3);
            this.tab_nuevo.Size = new System.Drawing.Size(742, 291);
            this.tab_nuevo.TabIndex = 0;
            this.tab_nuevo.Text = "Listar";
            this.tab_nuevo.UseVisualStyleBackColor = true;
            // 
            // datosVista
            // 
            this.datosVista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datosVista.Location = new System.Drawing.Point(67, 67);
            this.datosVista.Name = "datosVista";
            this.datosVista.RowHeadersWidth = 51;
            this.datosVista.RowTemplate.Height = 24;
            this.datosVista.Size = new System.Drawing.Size(626, 190);
            this.datosVista.TabIndex = 3;
            this.datosVista.DoubleClick += new System.EventHandler(this.datosVista_DoubleClick);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(399, 20);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 2;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // txt_buscar
            // 
            this.txt_buscar.Location = new System.Drawing.Point(130, 22);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(253, 22);
            this.txt_buscar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txt_nombreCat);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(742, 291);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Gestionar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txt_nombreCat
            // 
            this.txt_nombreCat.Location = new System.Drawing.Point(134, 53);
            this.txt_nombreCat.Name = "txt_nombreCat";
            this.txt_nombreCat.Size = new System.Drawing.Size(339, 22);
            this.txt_nombreCat.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Categoría (*):";
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(389, 350);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(82, 71);
            this.btn_guardar.TabIndex = 3;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(477, 350);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(84, 71);
            this.btn_cancelar.TabIndex = 2;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.Location = new System.Drawing.Point(33, 350);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(83, 71);
            this.btn_nuevo.TabIndex = 1;
            this.btn_nuevo.Text = "Nuevo";
            this.btn_nuevo.UseVisualStyleBackColor = true;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Location = new System.Drawing.Point(122, 350);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(83, 71);
            this.btn_actualizar.TabIndex = 2;
            this.btn_actualizar.Text = "Actualizar";
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(211, 350);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(83, 71);
            this.btn_eliminar.TabIndex = 3;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_reporte
            // 
            this.btn_reporte.Location = new System.Drawing.Point(300, 350);
            this.btn_reporte.Name = "btn_reporte";
            this.btn_reporte.Size = new System.Drawing.Size(83, 71);
            this.btn_reporte.TabIndex = 4;
            this.btn_reporte.Text = "Reporte";
            this.btn_reporte.UseVisualStyleBackColor = true;
            this.btn_reporte.Click += new System.EventHandler(this.btn_reporte_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(567, 350);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(83, 71);
            this.btn_salir.TabIndex = 5;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            // 
            // Frm_categorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 443);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_reporte);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_actualizar);
            this.Controls.Add(this.btn_nuevo);
            this.Controls.Add(this.tab_principal);
            this.Name = "Frm_categorias";
            this.Text = "Categorias";
            this.Load += new System.EventHandler(this.Frm_categorias_Load);
            this.tab_principal.ResumeLayout(false);
            this.tab_nuevo.ResumeLayout(false);
            this.tab_nuevo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datosVista)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_principal;
        private System.Windows.Forms.TabPage tab_nuevo;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView datosVista;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_reporte;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.TextBox txt_nombreCat;
    }
}