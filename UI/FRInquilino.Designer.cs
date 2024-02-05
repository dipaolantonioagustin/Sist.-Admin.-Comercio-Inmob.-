namespace UI
{
    partial class FRInquilino
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
            this.dataGridViewInquilinos = new System.Windows.Forms.DataGridView();
            this.dataGridViewListaAlquileresInquilinos = new System.Windows.Forms.DataGridView();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btbAlta = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.Código = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbLocalidad = new System.Windows.Forms.ComboBox();
            this.chActivo = new System.Windows.Forms.CheckBox();
            this.btnModificarInquilino = new System.Windows.Forms.Button();
            this.btnBaja = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.cmbGarantia = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtApellido = new UI.Nombre();
            this.txtNombre = new UI.Nombre();
            this.txtDni = new UI.DNI();
            this.txtdireccion = new UI.Direccion();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInquilinos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaAlquileresInquilinos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewInquilinos
            // 
            this.dataGridViewInquilinos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInquilinos.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewInquilinos.Name = "dataGridViewInquilinos";
            this.dataGridViewInquilinos.Size = new System.Drawing.Size(626, 189);
            this.dataGridViewInquilinos.TabIndex = 0;
            this.dataGridViewInquilinos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewInquilinos_CellContentClick);
            // 
            // dataGridViewListaAlquileresInquilinos
            // 
            this.dataGridViewListaAlquileresInquilinos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListaAlquileresInquilinos.Location = new System.Drawing.Point(399, 236);
            this.dataGridViewListaAlquileresInquilinos.Name = "dataGridViewListaAlquileresInquilinos";
            this.dataGridViewListaAlquileresInquilinos.Size = new System.Drawing.Size(237, 301);
            this.dataGridViewListaAlquileresInquilinos.TabIndex = 3;
            this.dataGridViewListaAlquileresInquilinos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewListaAlquileresInquilinos_CellContentClick);
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(83, 476);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.ReadOnly = true;
            this.txtEdad.Size = new System.Drawing.Size(172, 20);
            this.txtEdad.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(83, 517);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(172, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // btbAlta
            // 
            this.btbAlta.Location = new System.Drawing.Point(261, 282);
            this.btbAlta.Name = "btbAlta";
            this.btbAlta.Size = new System.Drawing.Size(116, 40);
            this.btbAlta.TabIndex = 9;
            this.btbAlta.Text = "Alta Inquilino";
            this.btbAlta.UseVisualStyleBackColor = true;
            this.btbAlta.Click += new System.EventHandler(this.btbAlta_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(83, 236);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(172, 20);
            this.txtCodigo.TabIndex = 10;
            // 
            // Código
            // 
            this.Código.AutoSize = true;
            this.Código.Location = new System.Drawing.Point(37, 236);
            this.Código.Name = "Código";
            this.Código.Size = new System.Drawing.Size(40, 13);
            this.Código.TabIndex = 12;
            this.Código.Text = "Codigo";
            this.Código.Click += new System.EventHandler(this.label2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 517);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Fecha Nac.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 435);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Localidad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 479);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Edad";
            // 
            // cmbLocalidad
            // 
            this.cmbLocalidad.FormattingEnabled = true;
            this.cmbLocalidad.Location = new System.Drawing.Point(80, 435);
            this.cmbLocalidad.Name = "cmbLocalidad";
            this.cmbLocalidad.Size = new System.Drawing.Size(172, 21);
            this.cmbLocalidad.TabIndex = 18;
            // 
            // chActivo
            // 
            this.chActivo.AutoSize = true;
            this.chActivo.Location = new System.Drawing.Point(199, 212);
            this.chActivo.Name = "chActivo";
            this.chActivo.Size = new System.Drawing.Size(56, 17);
            this.chActivo.TabIndex = 19;
            this.chActivo.Text = "Activo";
            this.chActivo.UseVisualStyleBackColor = true;
            // 
            // btnModificarInquilino
            // 
            this.btnModificarInquilino.Location = new System.Drawing.Point(261, 332);
            this.btnModificarInquilino.Name = "btnModificarInquilino";
            this.btnModificarInquilino.Size = new System.Drawing.Size(116, 40);
            this.btnModificarInquilino.TabIndex = 20;
            this.btnModificarInquilino.Text = "Modificar Inquilino";
            this.btnModificarInquilino.UseVisualStyleBackColor = true;
            this.btnModificarInquilino.Click += new System.EventHandler(this.btnModificarInquilino_Click);
            // 
            // btnBaja
            // 
            this.btnBaja.Location = new System.Drawing.Point(261, 381);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(116, 40);
            this.btnBaja.TabIndex = 21;
            this.btnBaja.Text = "Baja Inquilino";
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 358);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "DNI";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 395);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Dirección";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(261, 236);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(116, 40);
            this.btnNuevo.TabIndex = 25;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // cmbGarantia
            // 
            this.cmbGarantia.FormattingEnabled = true;
            this.cmbGarantia.Location = new System.Drawing.Point(83, 561);
            this.cmbGarantia.Name = "cmbGarantia";
            this.cmbGarantia.Size = new System.Drawing.Size(172, 21);
            this.cmbGarantia.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 564);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Garantía";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(81, 313);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(178, 26);
            this.txtApellido.TabIndex = 30;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(81, 278);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(178, 26);
            this.txtNombre.TabIndex = 29;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(81, 358);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(174, 25);
            this.txtDni.TabIndex = 28;
            // 
            // txtdireccion
            // 
            this.txtdireccion.Location = new System.Drawing.Point(80, 395);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(175, 26);
            this.txtdireccion.TabIndex = 31;
            // 
            // FRInquilino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 617);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbGarantia);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBaja);
            this.Controls.Add(this.btnModificarInquilino);
            this.Controls.Add(this.chActivo);
            this.Controls.Add(this.cmbLocalidad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Código);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.btbAlta);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.dataGridViewListaAlquileresInquilinos);
            this.Controls.Add(this.dataGridViewInquilinos);
            this.Name = "FRInquilino";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInquilinos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaAlquileresInquilinos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewInquilinos;
        private System.Windows.Forms.DataGridView dataGridViewListaAlquileresInquilinos;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btbAlta;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label Código;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbLocalidad;
        private System.Windows.Forms.CheckBox chActivo;
        private System.Windows.Forms.Button btnModificarInquilino;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.ComboBox cmbGarantia;
        private System.Windows.Forms.Label label8;
        private DNI txtDni;
        private Nombre txtNombre;
        private Nombre txtApellido;
        private Direccion txtdireccion;
    }
}

