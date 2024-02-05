namespace UI
{
    partial class FRReportes
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
            this.dataGridViewCaja = new System.Windows.Forms.DataGridView();
            this.dtpCajaFiltro = new System.Windows.Forms.DateTimePicker();
            this.btnFiltroFecha = new System.Windows.Forms.Button();
            this.cmbContrato = new System.Windows.Forms.ComboBox();
            this.txtSaldoInicio = new System.Windows.Forms.TextBox();
            this.txtArqueo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblBalance = new System.Windows.Forms.Label();
            this.btnFiltroContrato = new System.Windows.Forms.Button();
            this.lblCantMov = new System.Windows.Forms.Label();
            this.lblFechaUltMov = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUltMovImp = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridViewPropiedades = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.cmbTipoProp = new System.Windows.Forms.ComboBox();
            this.cmbCantAmb = new System.Windows.Forms.ComboBox();
            this.cmblocProp = new System.Windows.Forms.ComboBox();
            this.lblCDLoc = new System.Windows.Forms.Label();
            this.lblCDAmb = new System.Windows.Forms.Label();
            this.lblCDTipo = new System.Windows.Forms.Label();
            this.btnNoDispo = new System.Windows.Forms.Button();
            this.btnTodasProp = new System.Windows.Forms.Button();
            this.btnResultadosCombos = new System.Windows.Forms.Button();
            this.lblTotalCondiciones = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnMostrarTodos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCaja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPropiedades)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCaja
            // 
            this.dataGridViewCaja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCaja.Location = new System.Drawing.Point(386, 12);
            this.dataGridViewCaja.Name = "dataGridViewCaja";
            this.dataGridViewCaja.Size = new System.Drawing.Size(461, 247);
            this.dataGridViewCaja.TabIndex = 0;
            // 
            // dtpCajaFiltro
            // 
            this.dtpCajaFiltro.Location = new System.Drawing.Point(386, 282);
            this.dtpCajaFiltro.Name = "dtpCajaFiltro";
            this.dtpCajaFiltro.Size = new System.Drawing.Size(131, 20);
            this.dtpCajaFiltro.TabIndex = 1;
            // 
            // btnFiltroFecha
            // 
            this.btnFiltroFecha.Location = new System.Drawing.Point(386, 308);
            this.btnFiltroFecha.Name = "btnFiltroFecha";
            this.btnFiltroFecha.Size = new System.Drawing.Size(131, 34);
            this.btnFiltroFecha.TabIndex = 2;
            this.btnFiltroFecha.Text = "Filtrar Fecha";
            this.btnFiltroFecha.UseVisualStyleBackColor = true;
            this.btnFiltroFecha.Click += new System.EventHandler(this.btnFiltroFecha_Click);
            // 
            // cmbContrato
            // 
            this.cmbContrato.FormattingEnabled = true;
            this.cmbContrato.Location = new System.Drawing.Point(386, 393);
            this.cmbContrato.Name = "cmbContrato";
            this.cmbContrato.Size = new System.Drawing.Size(131, 21);
            this.cmbContrato.TabIndex = 3;
            // 
            // txtSaldoInicio
            // 
            this.txtSaldoInicio.Location = new System.Drawing.Point(747, 282);
            this.txtSaldoInicio.Name = "txtSaldoInicio";
            this.txtSaldoInicio.Size = new System.Drawing.Size(100, 20);
            this.txtSaldoInicio.TabIndex = 4;
            // 
            // txtArqueo
            // 
            this.txtArqueo.Location = new System.Drawing.Point(747, 308);
            this.txtArqueo.Name = "txtArqueo";
            this.txtArqueo.Size = new System.Drawing.Size(100, 20);
            this.txtArqueo.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(570, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "Balance";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(741, 341);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(35, 13);
            this.lblBalance.TabIndex = 7;
            this.lblBalance.Text = "label1";
            // 
            // btnFiltroContrato
            // 
            this.btnFiltroContrato.Location = new System.Drawing.Point(386, 420);
            this.btnFiltroContrato.Name = "btnFiltroContrato";
            this.btnFiltroContrato.Size = new System.Drawing.Size(131, 34);
            this.btnFiltroContrato.TabIndex = 8;
            this.btnFiltroContrato.Text = "Filtrar Contrato";
            this.btnFiltroContrato.UseVisualStyleBackColor = true;
            this.btnFiltroContrato.Click += new System.EventHandler(this.btnFiltroContrato_Click);
            // 
            // lblCantMov
            // 
            this.lblCantMov.AutoSize = true;
            this.lblCantMov.Location = new System.Drawing.Point(673, 393);
            this.lblCantMov.Name = "lblCantMov";
            this.lblCantMov.Size = new System.Drawing.Size(35, 13);
            this.lblCantMov.TabIndex = 9;
            this.lblCantMov.Text = "label1";
            // 
            // lblFechaUltMov
            // 
            this.lblFechaUltMov.AutoSize = true;
            this.lblFechaUltMov.Location = new System.Drawing.Point(673, 420);
            this.lblFechaUltMov.Name = "lblFechaUltMov";
            this.lblFechaUltMov.Size = new System.Drawing.Size(35, 13);
            this.lblFechaUltMov.TabIndex = 10;
            this.lblFechaUltMov.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(538, 393);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Cantidad Movimientos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(538, 420);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Último Movimiento Fecha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(538, 450);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Último Movimiento importe";
            // 
            // lblUltMovImp
            // 
            this.lblUltMovImp.AutoSize = true;
            this.lblUltMovImp.Location = new System.Drawing.Point(673, 450);
            this.lblUltMovImp.Name = "lblUltMovImp";
            this.lblUltMovImp.Size = new System.Drawing.Size(35, 13);
            this.lblUltMovImp.TabIndex = 14;
            this.lblUltMovImp.Text = "label1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(690, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Balance:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(676, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Saldo Inicio:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(697, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Arqueo:";
            // 
            // dataGridViewPropiedades
            // 
            this.dataGridViewPropiedades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPropiedades.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewPropiedades.Name = "dataGridViewPropiedades";
            this.dataGridViewPropiedades.Size = new System.Drawing.Size(350, 247);
            this.dataGridViewPropiedades.TabIndex = 18;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 282);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 34);
            this.button2.TabIndex = 19;
            this.button2.Text = "Filtrar Disponibles";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmbTipoProp
            // 
            this.cmbTipoProp.FormattingEnabled = true;
            this.cmbTipoProp.Location = new System.Drawing.Point(12, 341);
            this.cmbTipoProp.Name = "cmbTipoProp";
            this.cmbTipoProp.Size = new System.Drawing.Size(131, 21);
            this.cmbTipoProp.TabIndex = 20;
            // 
            // cmbCantAmb
            // 
            this.cmbCantAmb.FormattingEnabled = true;
            this.cmbCantAmb.Location = new System.Drawing.Point(12, 385);
            this.cmbCantAmb.Name = "cmbCantAmb";
            this.cmbCantAmb.Size = new System.Drawing.Size(131, 21);
            this.cmbCantAmb.TabIndex = 21;
            // 
            // cmblocProp
            // 
            this.cmblocProp.FormattingEnabled = true;
            this.cmblocProp.Location = new System.Drawing.Point(12, 428);
            this.cmblocProp.Name = "cmblocProp";
            this.cmblocProp.Size = new System.Drawing.Size(131, 21);
            this.cmblocProp.TabIndex = 22;
            // 
            // lblCDLoc
            // 
            this.lblCDLoc.AutoSize = true;
            this.lblCDLoc.Location = new System.Drawing.Point(184, 436);
            this.lblCDLoc.Name = "lblCDLoc";
            this.lblCDLoc.Size = new System.Drawing.Size(35, 13);
            this.lblCDLoc.TabIndex = 23;
            this.lblCDLoc.Text = "label1";
            // 
            // lblCDAmb
            // 
            this.lblCDAmb.AutoSize = true;
            this.lblCDAmb.Location = new System.Drawing.Point(184, 388);
            this.lblCDAmb.Name = "lblCDAmb";
            this.lblCDAmb.Size = new System.Drawing.Size(35, 13);
            this.lblCDAmb.TabIndex = 24;
            this.lblCDAmb.Text = "label1";
            // 
            // lblCDTipo
            // 
            this.lblCDTipo.AutoSize = true;
            this.lblCDTipo.Location = new System.Drawing.Point(184, 344);
            this.lblCDTipo.Name = "lblCDTipo";
            this.lblCDTipo.Size = new System.Drawing.Size(35, 13);
            this.lblCDTipo.TabIndex = 25;
            this.lblCDTipo.Text = "label1";
            // 
            // btnNoDispo
            // 
            this.btnNoDispo.Location = new System.Drawing.Point(133, 282);
            this.btnNoDispo.Name = "btnNoDispo";
            this.btnNoDispo.Size = new System.Drawing.Size(105, 34);
            this.btnNoDispo.TabIndex = 26;
            this.btnNoDispo.Text = "Filtrar No Disponibles";
            this.btnNoDispo.UseVisualStyleBackColor = true;
            this.btnNoDispo.Click += new System.EventHandler(this.btnNoDispo_Click);
            // 
            // btnTodasProp
            // 
            this.btnTodasProp.Location = new System.Drawing.Point(257, 282);
            this.btnTodasProp.Name = "btnTodasProp";
            this.btnTodasProp.Size = new System.Drawing.Size(105, 34);
            this.btnTodasProp.TabIndex = 27;
            this.btnTodasProp.Text = "Todas";
            this.btnTodasProp.UseVisualStyleBackColor = true;
            this.btnTodasProp.Click += new System.EventHandler(this.btnTodasProp_Click);
            // 
            // btnResultadosCombos
            // 
            this.btnResultadosCombos.Location = new System.Drawing.Point(12, 468);
            this.btnResultadosCombos.Name = "btnResultadosCombos";
            this.btnResultadosCombos.Size = new System.Drawing.Size(131, 34);
            this.btnResultadosCombos.TabIndex = 28;
            this.btnResultadosCombos.Text = "Resumen";
            this.btnResultadosCombos.UseVisualStyleBackColor = true;
            this.btnResultadosCombos.Click += new System.EventHandler(this.btnResultadosCombos_Click);
            // 
            // lblTotalCondiciones
            // 
            this.lblTotalCondiciones.AutoSize = true;
            this.lblTotalCondiciones.Location = new System.Drawing.Point(305, 393);
            this.lblTotalCondiciones.Name = "lblTotalCondiciones";
            this.lblTotalCondiciones.Size = new System.Drawing.Size(35, 13);
            this.lblTotalCondiciones.TabIndex = 29;
            this.lblTotalCondiciones.Text = "label1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(149, 479);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Resultado Individuales";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(269, 479);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Resultado General";
            // 
            // btnMostrarTodos
            // 
            this.btnMostrarTodos.Location = new System.Drawing.Point(386, 348);
            this.btnMostrarTodos.Name = "btnMostrarTodos";
            this.btnMostrarTodos.Size = new System.Drawing.Size(131, 34);
            this.btnMostrarTodos.TabIndex = 32;
            this.btnMostrarTodos.Text = "Mostrar Todos Movimientos";
            this.btnMostrarTodos.UseVisualStyleBackColor = true;
            this.btnMostrarTodos.Click += new System.EventHandler(this.btnMostrarTodos_Click);
            // 
            // FRReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 514);
            this.Controls.Add(this.btnMostrarTodos);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblTotalCondiciones);
            this.Controls.Add(this.btnResultadosCombos);
            this.Controls.Add(this.btnTodasProp);
            this.Controls.Add(this.btnNoDispo);
            this.Controls.Add(this.lblCDTipo);
            this.Controls.Add(this.lblCDAmb);
            this.Controls.Add(this.lblCDLoc);
            this.Controls.Add(this.cmblocProp);
            this.Controls.Add(this.cmbCantAmb);
            this.Controls.Add(this.cmbTipoProp);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridViewPropiedades);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblUltMovImp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblFechaUltMov);
            this.Controls.Add(this.lblCantMov);
            this.Controls.Add(this.btnFiltroContrato);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtArqueo);
            this.Controls.Add(this.txtSaldoInicio);
            this.Controls.Add(this.cmbContrato);
            this.Controls.Add(this.btnFiltroFecha);
            this.Controls.Add(this.dtpCajaFiltro);
            this.Controls.Add(this.dataGridViewCaja);
            this.Name = "FRReportes";
            this.Text = "FRReportes";
            this.Load += new System.EventHandler(this.FRReportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCaja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPropiedades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCaja;
        private System.Windows.Forms.DateTimePicker dtpCajaFiltro;
        private System.Windows.Forms.Button btnFiltroFecha;
        private System.Windows.Forms.ComboBox cmbContrato;
        private System.Windows.Forms.TextBox txtSaldoInicio;
        private System.Windows.Forms.TextBox txtArqueo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Button btnFiltroContrato;
        private System.Windows.Forms.Label lblCantMov;
        private System.Windows.Forms.Label lblFechaUltMov;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUltMovImp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridViewPropiedades;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cmbTipoProp;
        private System.Windows.Forms.ComboBox cmbCantAmb;
        private System.Windows.Forms.ComboBox cmblocProp;
        private System.Windows.Forms.Label lblCDLoc;
        private System.Windows.Forms.Label lblCDAmb;
        private System.Windows.Forms.Label lblCDTipo;
        private System.Windows.Forms.Button btnNoDispo;
        private System.Windows.Forms.Button btnTodasProp;
        private System.Windows.Forms.Button btnResultadosCombos;
        private System.Windows.Forms.Label lblTotalCondiciones;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnMostrarTodos;
    }
}