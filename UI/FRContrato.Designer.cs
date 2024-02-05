namespace UI
{
    partial class FRContrato
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbPropiedad = new System.Windows.Forms.ComboBox();
            this.cmbInquilino = new System.Windows.Forms.ComboBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.chActivo = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAlta = new System.Windows.Forms.Button();
            this.btnBaja = new System.Windows.Forms.Button();
            this.txtCuenta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(701, 174);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cmbPropiedad
            // 
            this.cmbPropiedad.FormattingEnabled = true;
            this.cmbPropiedad.Location = new System.Drawing.Point(105, 355);
            this.cmbPropiedad.Name = "cmbPropiedad";
            this.cmbPropiedad.Size = new System.Drawing.Size(135, 21);
            this.cmbPropiedad.TabIndex = 1;
            // 
            // cmbInquilino
            // 
            this.cmbInquilino.FormattingEnabled = true;
            this.cmbInquilino.Location = new System.Drawing.Point(105, 397);
            this.cmbInquilino.Name = "cmbInquilino";
            this.cmbInquilino.Size = new System.Drawing.Size(135, 21);
            this.cmbInquilino.TabIndex = 2;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(105, 240);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(135, 20);
            this.txtCodigo.TabIndex = 3;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(105, 279);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(135, 20);
            this.txtValor.TabIndex = 4;
            // 
            // dtpInicio
            // 
            this.dtpInicio.Location = new System.Drawing.Point(105, 318);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(135, 20);
            this.dtpInicio.TabIndex = 5;
            // 
            // chActivo
            // 
            this.chActivo.AutoSize = true;
            this.chActivo.Location = new System.Drawing.Point(172, 207);
            this.chActivo.Name = "chActivo";
            this.chActivo.Size = new System.Drawing.Size(68, 17);
            this.chActivo.TabIndex = 6;
            this.chActivo.Text = "chActivo";
            this.chActivo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Valor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Inicio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 363);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Propiedad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 400);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Inquilino";
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(262, 299);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(104, 39);
            this.btnAlta.TabIndex = 12;
            this.btnAlta.Text = "Alta";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // btnBaja
            // 
            this.btnBaja.Location = new System.Drawing.Point(262, 350);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(104, 39);
            this.btnBaja.TabIndex = 13;
            this.btnBaja.Text = "Baja";
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // txtCuenta
            // 
            this.txtCuenta.Location = new System.Drawing.Point(105, 436);
            this.txtCuenta.Name = "txtCuenta";
            this.txtCuenta.Size = new System.Drawing.Size(135, 20);
            this.txtCuenta.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 443);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Saldo Cuenta";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(262, 240);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(104, 39);
            this.btnNuevo.TabIndex = 16;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(262, 400);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(104, 39);
            this.btnModificar.TabIndex = 17;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // FRContrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 486);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCuenta);
            this.Controls.Add(this.btnBaja);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chActivo);
            this.Controls.Add(this.dtpInicio);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.cmbInquilino);
            this.Controls.Add(this.cmbPropiedad);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FRContrato";
            this.Text = "FRContrato";
            this.Load += new System.EventHandler(this.FRContrato_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbPropiedad;
        private System.Windows.Forms.ComboBox cmbInquilino;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.CheckBox chActivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.TextBox txtCuenta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnModificar;
    }
}