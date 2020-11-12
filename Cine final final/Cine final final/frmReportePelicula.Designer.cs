namespace Cine_final_final
{
    partial class frmReportePelicula
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
            this.PeliculasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cinejnDataSet1 = new Cine_final_final.cinejnDataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PeliculasTableAdapter = new Cine_final_final.cinejnDataSet1TableAdapters.PeliculasTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cboGeneros2 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PeliculasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinejnDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // PeliculasBindingSource
            // 
            this.PeliculasBindingSource.DataMember = "Peliculas";
            this.PeliculasBindingSource.DataSource = this.cinejnDataSet1;
            // 
            // cinejnDataSet1
            // 
            this.cinejnDataSet1.DataSetName = "cinejnDataSet1";
            this.cinejnDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackgroundImage = global::Cine_final_final.Properties.Resources._11;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.PeliculasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Cine_final_final.rptPelicula.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1063, 384);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // PeliculasTableAdapter
            // 
            this.PeliculasTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 414);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ingrese el Titulo ";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(157, 411);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(125, 20);
            this.txtBuscar.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(300, 409);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Imprimir con Filtro";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(913, 408);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 21);
            this.button1.TabIndex = 9;
            this.button1.Text = "Imprimir todo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cboGeneros2
            // 
            this.cboGeneros2.FormattingEnabled = true;
            this.cboGeneros2.Location = new System.Drawing.Point(650, 409);
            this.cboGeneros2.Name = "cboGeneros2";
            this.cboGeneros2.Size = new System.Drawing.Size(107, 21);
            this.cboGeneros2.TabIndex = 10;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(776, 407);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(74, 26);
            this.button3.TabIndex = 11;
            this.button3.Text = "Buscar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(486, 412);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Seleccione el Genero";
            // 
            // frmReportePelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cine_final_final.Properties.Resources._1;
            this.ClientSize = new System.Drawing.Size(1087, 466);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.cboGeneros2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReportePelicula";
            this.Text = "Informes";
            this.Load += new System.EventHandler(this.frmReportePelicula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PeliculasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinejnDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PeliculasBindingSource;
        private cinejnDataSet1 cinejnDataSet1;
        private cinejnDataSet1TableAdapters.PeliculasTableAdapter PeliculasTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cboGeneros2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
    }
}