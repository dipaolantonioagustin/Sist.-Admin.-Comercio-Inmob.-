namespace UI
{
    partial class FRReporte2
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
            this.bEOperacionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bEOperacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.chDia = new System.Windows.Forms.CheckBox();
            this.chED = new System.Windows.Forms.CheckBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.bEOperacionBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bEOperacionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bEOperacionBindingSource1
            // 
            this.bEOperacionBindingSource1.DataSource = typeof(BE.BEOperacion);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.bEOperacionBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "UI.FRRepote2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(35, 139);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(712, 350);
            this.reportViewer1.TabIndex = 0;
            // 
            // bEOperacionBindingSource
            // 
            this.bEOperacionBindingSource.DataSource = typeof(BE.BEOperacion);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(131, 26);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(337, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Aplicar Filtro";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(456, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 34);
            this.button2.TabIndex = 3;
            this.button2.Text = "Mostrar Todo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // chDia
            // 
            this.chDia.AutoSize = true;
            this.chDia.Location = new System.Drawing.Point(81, 26);
            this.chDia.Name = "chDia";
            this.chDia.Size = new System.Drawing.Size(44, 17);
            this.chDia.TabIndex = 4;
            this.chDia.Text = "Día";
            this.chDia.UseVisualStyleBackColor = true;
            // 
            // chED
            // 
            this.chED.AutoSize = true;
            this.chED.Location = new System.Drawing.Point(48, 64);
            this.chED.Name = "chED";
            this.chED.Size = new System.Drawing.Size(77, 17);
            this.chED.TabIndex = 5;
            this.chED.Text = "Entre Días";
            this.chED.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(131, 64);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 6;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(131, 99);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker3.TabIndex = 7;
            // 
            // FRReporte2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 501);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.chED);
            this.Controls.Add(this.chDia);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FRReporte2";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FRReporte2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bEOperacionBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bEOperacionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource bEOperacionBindingSource;
        private System.Windows.Forms.BindingSource bEOperacionBindingSource1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox chDia;
        private System.Windows.Forms.CheckBox chED;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
    }
}