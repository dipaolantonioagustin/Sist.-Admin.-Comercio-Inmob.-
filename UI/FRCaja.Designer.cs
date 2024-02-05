namespace UI
{
    partial class FRCaja
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
            this.cmbContrato = new System.Windows.Forms.ComboBox();
            this.txtInquilino = new System.Windows.Forms.TextBox();
            this.txtDueño = new System.Windows.Forms.TextBox();
            this.txtOpInq = new System.Windows.Forms.TextBox();
            this.txtOpDue = new System.Windows.Forms.TextBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCobrar = new System.Windows.Forms.Button();
            this.btnPagar = new System.Windows.Forms.Button();
            this.btnBaja = new System.Windows.Forms.Button();
            this.btnAnular = new System.Windows.Forms.Button();
            this.txtDiasAtraso = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCaja)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCaja
            // 
            this.dataGridViewCaja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCaja.Location = new System.Drawing.Point(232, 27);
            this.dataGridViewCaja.Name = "dataGridViewCaja";
            this.dataGridViewCaja.Size = new System.Drawing.Size(379, 394);
            this.dataGridViewCaja.TabIndex = 0;
            this.dataGridViewCaja.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCaja_CellContentClick);
            // 
            // cmbContrato
            // 
            this.cmbContrato.FormattingEnabled = true;
            this.cmbContrato.Location = new System.Drawing.Point(29, 44);
            this.cmbContrato.Name = "cmbContrato";
            this.cmbContrato.Size = new System.Drawing.Size(167, 21);
            this.cmbContrato.TabIndex = 1;
            this.cmbContrato.SelectedIndexChanged += new System.EventHandler(this.cmbContrato_SelectedIndexChanged);
            // 
            // txtInquilino
            // 
            this.txtInquilino.Location = new System.Drawing.Point(29, 71);
            this.txtInquilino.Name = "txtInquilino";
            this.txtInquilino.Size = new System.Drawing.Size(167, 20);
            this.txtInquilino.TabIndex = 2;
            // 
            // txtDueño
            // 
            this.txtDueño.Location = new System.Drawing.Point(29, 221);
            this.txtDueño.Name = "txtDueño";
            this.txtDueño.Size = new System.Drawing.Size(167, 20);
            this.txtDueño.TabIndex = 3;
            // 
            // txtOpInq
            // 
            this.txtOpInq.Location = new System.Drawing.Point(29, 97);
            this.txtOpInq.Name = "txtOpInq";
            this.txtOpInq.Size = new System.Drawing.Size(167, 20);
            this.txtOpInq.TabIndex = 4;
            // 
            // txtOpDue
            // 
            this.txtOpDue.Location = new System.Drawing.Point(29, 247);
            this.txtOpDue.Name = "txtOpDue";
            this.txtOpDue.Size = new System.Drawing.Size(167, 20);
            this.txtOpDue.TabIndex = 5;
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(29, 333);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(167, 20);
            this.txtSaldo.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 365);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Saldo Cuenta";
            // 
            // btnCobrar
            // 
            this.btnCobrar.Location = new System.Drawing.Point(63, 166);
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.Size = new System.Drawing.Size(91, 35);
            this.btnCobrar.TabIndex = 8;
            this.btnCobrar.Text = "Cobrar";
            this.btnCobrar.UseVisualStyleBackColor = true;
            this.btnCobrar.Click += new System.EventHandler(this.btnCobrar_Click);
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(63, 273);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(91, 35);
            this.btnPagar.TabIndex = 9;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // btnBaja
            // 
            this.btnBaja.Location = new System.Drawing.Point(232, 436);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(124, 44);
            this.btnBaja.TabIndex = 10;
            this.btnBaja.Text = "Baja";
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // btnAnular
            // 
            this.btnAnular.Location = new System.Drawing.Point(375, 436);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(124, 44);
            this.btnAnular.TabIndex = 11;
            this.btnAnular.Text = "Anular";
            this.btnAnular.UseVisualStyleBackColor = true;
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // txtDiasAtraso
            // 
            this.txtDiasAtraso.Location = new System.Drawing.Point(29, 129);
            this.txtDiasAtraso.Name = "txtDiasAtraso";
            this.txtDiasAtraso.Size = new System.Drawing.Size(167, 20);
            this.txtDiasAtraso.TabIndex = 12;
            // 
            // FRCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 514);
            this.Controls.Add(this.txtDiasAtraso);
            this.Controls.Add(this.btnAnular);
            this.Controls.Add(this.btnBaja);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.btnCobrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.txtOpDue);
            this.Controls.Add(this.txtOpInq);
            this.Controls.Add(this.txtDueño);
            this.Controls.Add(this.txtInquilino);
            this.Controls.Add(this.cmbContrato);
            this.Controls.Add(this.dataGridViewCaja);
            this.Name = "FRCaja";
            this.Text = "FRCaja";
            this.Load += new System.EventHandler(this.FRCaja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCaja)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCaja;
        private System.Windows.Forms.ComboBox cmbContrato;
        private System.Windows.Forms.TextBox txtInquilino;
        private System.Windows.Forms.TextBox txtDueño;
        private System.Windows.Forms.TextBox txtOpInq;
        private System.Windows.Forms.TextBox txtOpDue;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCobrar;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.Button btnAnular;
        private System.Windows.Forms.TextBox txtDiasAtraso;
    }
}