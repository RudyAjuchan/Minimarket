namespace minimarket_presentacion.Reportes
{
    partial class Frm_rpt_categorias
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSet_minimarket = new minimarket_presentacion.Reportes.DataSet_minimarket();
            this.listadocategoriasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listado_categoriasTableAdapter = new minimarket_presentacion.Reportes.DataSet_minimarketTableAdapters.Listado_categoriasTableAdapter();
            this.txt_busqueda = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_minimarket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadocategoriasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.listadocategoriasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "minimarket_presentacion.Reportes.Rpt_categorias.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataSet_minimarket
            // 
            this.dataSet_minimarket.DataSetName = "DataSet_minimarket";
            this.dataSet_minimarket.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listadocategoriasBindingSource
            // 
            this.listadocategoriasBindingSource.DataMember = "Listado_categorias";
            this.listadocategoriasBindingSource.DataSource = this.dataSet_minimarket;
            // 
            // listado_categoriasTableAdapter
            // 
            this.listado_categoriasTableAdapter.ClearBeforeFill = true;
            // 
            // txt_busqueda
            // 
            this.txt_busqueda.Location = new System.Drawing.Point(26, 39);
            this.txt_busqueda.Name = "txt_busqueda";
            this.txt_busqueda.Size = new System.Drawing.Size(83, 22);
            this.txt_busqueda.TabIndex = 1;
            this.txt_busqueda.Visible = false;
            // 
            // Frm_rpt_categorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_busqueda);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Frm_rpt_categorias";
            this.Text = "Reporte de Categorías";
            this.Load += new System.EventHandler(this.Frm_rpt_categorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_minimarket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadocategoriasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource listadocategoriasBindingSource;
        private DataSet_minimarket dataSet_minimarket;
        private DataSet_minimarketTableAdapters.Listado_categoriasTableAdapter listado_categoriasTableAdapter;
        public System.Windows.Forms.TextBox txt_busqueda;
    }
}