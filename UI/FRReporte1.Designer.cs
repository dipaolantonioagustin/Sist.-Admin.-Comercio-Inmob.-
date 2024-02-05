namespace UI
{
    partial class FRReporte1
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.cmbCantAmb = new System.Windows.Forms.ComboBox();
            this.btnMostrarTodas = new System.Windows.Forms.Button();
            this.cmbFormato = new System.Windows.Forms.ComboBox();
            this.chartPropDispo = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chCantAmb = new System.Windows.Forms.CheckBox();
            this.chFormato = new System.Windows.Forms.CheckBox();
            this.bEPropiedadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chartPropDispo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bEPropiedadBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.bEPropiedadBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.bEPropiedadBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "UI.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(9, 71);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(861, 281);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // btnAplicar
            // 
            this.btnAplicar.Location = new System.Drawing.Point(234, 10);
            this.btnAplicar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(90, 31);
            this.btnAplicar.TabIndex = 1;
            this.btnAplicar.Text = "Aplicar";
            this.btnAplicar.UseVisualStyleBackColor = true;
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // cmbCantAmb
            // 
            this.cmbCantAmb.FormattingEnabled = true;
            this.cmbCantAmb.Location = new System.Drawing.Point(119, 10);
            this.cmbCantAmb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbCantAmb.Name = "cmbCantAmb";
            this.cmbCantAmb.Size = new System.Drawing.Size(103, 21);
            this.cmbCantAmb.TabIndex = 2;
            // 
            // btnMostrarTodas
            // 
            this.btnMostrarTodas.Location = new System.Drawing.Point(338, 10);
            this.btnMostrarTodas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMostrarTodas.Name = "btnMostrarTodas";
            this.btnMostrarTodas.Size = new System.Drawing.Size(90, 31);
            this.btnMostrarTodas.TabIndex = 4;
            this.btnMostrarTodas.Text = "Mostrar Todas";
            this.btnMostrarTodas.UseVisualStyleBackColor = true;
            this.btnMostrarTodas.Click += new System.EventHandler(this.btnMostrarTodas_Click);
            // 
            // cmbFormato
            // 
            this.cmbFormato.FormattingEnabled = true;
            this.cmbFormato.Location = new System.Drawing.Point(119, 39);
            this.cmbFormato.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbFormato.Name = "cmbFormato";
            this.cmbFormato.Size = new System.Drawing.Size(103, 21);
            this.cmbFormato.TabIndex = 5;
            // 
            // chartPropDispo
            // 
            chartArea1.Name = "ChartArea1";
            this.chartPropDispo.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartPropDispo.Legends.Add(legend1);
            this.chartPropDispo.Location = new System.Drawing.Point(883, 71);
            this.chartPropDispo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chartPropDispo.Name = "chartPropDispo";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartPropDispo.Series.Add(series1);
            this.chartPropDispo.Size = new System.Drawing.Size(336, 281);
            this.chartPropDispo.TabIndex = 7;
            this.chartPropDispo.Text = "chart1";
            // 
            // chCantAmb
            // 
            this.chCantAmb.AutoSize = true;
            this.chCantAmb.Location = new System.Drawing.Point(9, 12);
            this.chCantAmb.Name = "chCantAmb";
            this.chCantAmb.Size = new System.Drawing.Size(103, 17);
            this.chCantAmb.TabIndex = 8;
            this.chCantAmb.Text = "Cant. Ambientes";
            this.chCantAmb.UseVisualStyleBackColor = true;
            // 
            // chFormato
            // 
            this.chFormato.AutoSize = true;
            this.chFormato.Location = new System.Drawing.Point(9, 39);
            this.chFormato.Name = "chFormato";
            this.chFormato.Size = new System.Drawing.Size(64, 17);
            this.chFormato.TabIndex = 9;
            this.chFormato.Text = "Formato";
            this.chFormato.UseVisualStyleBackColor = true;
            // 
            // bEPropiedadBindingSource
            // 
            this.bEPropiedadBindingSource.DataSource = typeof(BE.BEPropiedad);
            // 
            // FRReporte1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 383);
            this.Controls.Add(this.chFormato);
            this.Controls.Add(this.chCantAmb);
            this.Controls.Add(this.chartPropDispo);
            this.Controls.Add(this.cmbFormato);
            this.Controls.Add(this.btnMostrarTodas);
            this.Controls.Add(this.cmbCantAmb);
            this.Controls.Add(this.btnAplicar);
            this.Controls.Add(this.reportViewer1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FRReporte1";
            this.Text = "FRReporte1";
            this.Load += new System.EventHandler(this.FRReporte1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartPropDispo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bEPropiedadBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource bEPropiedadBindingSource;
        private System.Windows.Forms.Button btnAplicar;
        private System.Windows.Forms.ComboBox cmbCantAmb;
        private System.Windows.Forms.Button btnMostrarTodas;
        private System.Windows.Forms.ComboBox cmbFormato;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPropDispo;
        private System.Windows.Forms.CheckBox chCantAmb;
        private System.Windows.Forms.CheckBox chFormato;
    }
}