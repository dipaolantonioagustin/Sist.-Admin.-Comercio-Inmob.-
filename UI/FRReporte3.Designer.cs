namespace UI
{
    partial class FRReporte3
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
            this.bEOperacionCajaChicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbCuenta = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.chCuenta = new System.Windows.Forms.CheckBox();
            this.chFecha = new System.Windows.Forms.CheckBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnMostrarTodo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bEOperacionCajaChicaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.bEOperacionCajaChicaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "UI.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(21, 93);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(655, 445);
            this.reportViewer1.TabIndex = 0;
            // 
            // bEOperacionCajaChicaBindingSource
            // 
            this.bEOperacionCajaChicaBindingSource.DataSource = typeof(BE.BEOperacionCajaChica);
            // 
            // cmbCuenta
            // 
            this.cmbCuenta.FormattingEnabled = true;
            this.cmbCuenta.Location = new System.Drawing.Point(124, 12);
            this.cmbCuenta.Name = "cmbCuenta";
            this.cmbCuenta.Size = new System.Drawing.Size(200, 21);
            this.cmbCuenta.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(124, 52);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // chCuenta
            // 
            this.chCuenta.AutoSize = true;
            this.chCuenta.Location = new System.Drawing.Point(44, 12);
            this.chCuenta.Name = "chCuenta";
            this.chCuenta.Size = new System.Drawing.Size(60, 17);
            this.chCuenta.TabIndex = 3;
            this.chCuenta.Text = "Cuenta";
            this.chCuenta.UseVisualStyleBackColor = true;
            // 
            // chFecha
            // 
            this.chFecha.AutoSize = true;
            this.chFecha.Location = new System.Drawing.Point(44, 57);
            this.chFecha.Name = "chFecha";
            this.chFecha.Size = new System.Drawing.Size(56, 17);
            this.chFecha.TabIndex = 4;
            this.chFecha.Text = "Fecha";
            this.chFecha.UseVisualStyleBackColor = true;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(344, 12);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(117, 38);
            this.btnFiltrar.TabIndex = 5;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnMostrarTodo
            // 
            this.btnMostrarTodo.Location = new System.Drawing.Point(484, 12);
            this.btnMostrarTodo.Name = "btnMostrarTodo";
            this.btnMostrarTodo.Size = new System.Drawing.Size(117, 38);
            this.btnMostrarTodo.TabIndex = 6;
            this.btnMostrarTodo.Text = "MostrarTodo";
            this.btnMostrarTodo.UseVisualStyleBackColor = true;
            this.btnMostrarTodo.Click += new System.EventHandler(this.btnMostrarTodo_Click);
            // 
            // FRReporte3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 596);
            this.Controls.Add(this.btnMostrarTodo);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.chFecha);
            this.Controls.Add(this.chCuenta);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cmbCuenta);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FRReporte3";
            this.Text = "FRReporte3";
            this.Load += new System.EventHandler(this.FRReporte3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bEOperacionCajaChicaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource bEOperacionCajaChicaBindingSource;
        private System.Windows.Forms.ComboBox cmbCuenta;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox chCuenta;
        private System.Windows.Forms.CheckBox chFecha;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnMostrarTodo;
    }
}