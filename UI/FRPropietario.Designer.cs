namespace UI
{
    partial class FRPropietario
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
            this.dataGridViewPropietarios = new System.Windows.Forms.DataGridView();
            this.dataGridViewPropiedades = new System.Windows.Forms.DataGridView();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.cmbLocalidad = new System.Windows.Forms.ComboBox();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.btnAlta = new System.Windows.Forms.Button();
            this.btnModificacion = new System.Windows.Forms.Button();
            this.btnBaja = new System.Windows.Forms.Button();
            this.chActivo = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.txtDNI = new UI.DNI();
            this.txtNombre = new UI.Nombre();
            this.txtApellido = new UI.Nombre();
            this.txtDomicilio = new UI.Direccion();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPropietarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPropiedades)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPropietarios
            // 
            this.dataGridViewPropietarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPropietarios.Location = new System.Drawing.Point(38, 12);
            this.dataGridViewPropietarios.Name = "dataGridViewPropietarios";
            this.dataGridViewPropietarios.Size = new System.Drawing.Size(449, 215);
            this.dataGridViewPropietarios.TabIndex = 0;
            this.dataGridViewPropietarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPropietarios_CellContentClick);
            // 
            // dataGridViewPropiedades
            // 
            this.dataGridViewPropiedades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPropiedades.Location = new System.Drawing.Point(493, 12);
            this.dataGridViewPropiedades.Name = "dataGridViewPropiedades";
            this.dataGridViewPropiedades.Size = new System.Drawing.Size(281, 215);
            this.dataGridViewPropiedades.TabIndex = 1;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(187, 266);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(172, 20);
            this.txtCodigo.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(187, 408);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.ReadOnly = true;
            this.txtEdad.Size = new System.Drawing.Size(172, 20);
            this.txtEdad.TabIndex = 5;
            // 
            // cmbLocalidad
            // 
            this.cmbLocalidad.FormattingEnabled = true;
            this.cmbLocalidad.Location = new System.Drawing.Point(187, 466);
            this.cmbLocalidad.Name = "cmbLocalidad";
            this.cmbLocalidad.Size = new System.Drawing.Size(172, 21);
            this.cmbLocalidad.TabIndex = 9;
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Location = new System.Drawing.Point(188, 382);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(172, 20);
            this.dtpFechaNac.TabIndex = 10;
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(366, 310);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(121, 38);
            this.btnAlta.TabIndex = 11;
            this.btnAlta.Text = "Alta";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // btnModificacion
            // 
            this.btnModificacion.Location = new System.Drawing.Point(366, 357);
            this.btnModificacion.Name = "btnModificacion";
            this.btnModificacion.Size = new System.Drawing.Size(121, 38);
            this.btnModificacion.TabIndex = 12;
            this.btnModificacion.Text = "Modificacion";
            this.btnModificacion.UseVisualStyleBackColor = true;
            this.btnModificacion.Click += new System.EventHandler(this.btnModificacion_Click);
            // 
            // btnBaja
            // 
            this.btnBaja.Location = new System.Drawing.Point(366, 401);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(121, 38);
            this.btnBaja.TabIndex = 13;
            this.btnBaja.Text = "Baja";
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // chActivo
            // 
            this.chActivo.AutoSize = true;
            this.chActivo.Location = new System.Drawing.Point(304, 243);
            this.chActivo.Name = "chActivo";
            this.chActivo.Size = new System.Drawing.Size(56, 17);
            this.chActivo.TabIndex = 14;
            this.chActivo.Text = "Activo";
            this.chActivo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nombre";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(149, 357);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "DNI";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(118, 382);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Fecha Nac.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(141, 408);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Edad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(124, 434);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Domicilio";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(124, 468);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Localidad";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(366, 266);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(121, 38);
            this.btnNuevo.TabIndex = 23;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(188, 357);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(174, 21);
            this.txtDNI.TabIndex = 24;
            this.txtDNI.Load += new System.EventHandler(this.txtDNI_Load);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(187, 292);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(174, 27);
            this.txtNombre.TabIndex = 25;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(188, 325);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(174, 27);
            this.txtApellido.TabIndex = 26;
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Location = new System.Drawing.Point(187, 434);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(175, 26);
            this.txtDomicilio.TabIndex = 27;
            // 
            // FRPropietario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 511);
            this.Controls.Add(this.txtDomicilio);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chActivo);
            this.Controls.Add(this.btnBaja);
            this.Controls.Add(this.btnModificacion);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.dtpFechaNac);
            this.Controls.Add(this.cmbLocalidad);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.dataGridViewPropiedades);
            this.Controls.Add(this.dataGridViewPropietarios);
            this.Name = "FRPropietario";
            this.Text = "FRPropietario";
            this.Load += new System.EventHandler(this.FRPropietario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPropietarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPropiedades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPropietarios;
        private System.Windows.Forms.DataGridView dataGridViewPropiedades;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.ComboBox cmbLocalidad;
        private System.Windows.Forms.DateTimePicker dtpFechaNac;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Button btnModificacion;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.CheckBox chActivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnNuevo;
        private DNI txtDNI;
        private Nombre txtNombre;
        private Nombre txtApellido;
        private Direccion txtDomicilio;
    }
}