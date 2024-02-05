namespace UI
{
    partial class FRPropiedad
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
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtCantAmb = new System.Windows.Forms.TextBox();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.cmbLoc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAlta = new System.Windows.Forms.Button();
            this.btnBaja = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.chDisponible = new System.Windows.Forms.CheckBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.cmbPropietarios = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(605, 184);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(80, 215);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(183, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // txtCantAmb
            // 
            this.txtCantAmb.Location = new System.Drawing.Point(80, 382);
            this.txtCantAmb.Name = "txtCantAmb";
            this.txtCantAmb.Size = new System.Drawing.Size(183, 20);
            this.txtCantAmb.TabIndex = 2;
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Location = new System.Drawing.Point(80, 254);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(183, 20);
            this.txtDomicilio.TabIndex = 3;
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(80, 336);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(183, 21);
            this.cmbTipo.TabIndex = 4;
            // 
            // cmbLoc
            // 
            this.cmbLoc.FormattingEnabled = true;
            this.cmbLoc.Location = new System.Drawing.Point(80, 295);
            this.cmbLoc.Name = "cmbLoc";
            this.cmbLoc.Size = new System.Drawing.Size(183, 21);
            this.cmbLoc.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Domicilio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 385);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cant. Amb.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tipo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Localidad";
            // 
            // txtAlta
            // 
            this.txtAlta.Location = new System.Drawing.Point(278, 257);
            this.txtAlta.Name = "txtAlta";
            this.txtAlta.Size = new System.Drawing.Size(125, 39);
            this.txtAlta.TabIndex = 11;
            this.txtAlta.Text = "Alta";
            this.txtAlta.UseVisualStyleBackColor = true;
            this.txtAlta.Click += new System.EventHandler(this.txtAlta_Click);
            // 
            // btnBaja
            // 
            this.btnBaja.Location = new System.Drawing.Point(278, 302);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(125, 38);
            this.btnBaja.TabIndex = 12;
            this.btnBaja.Text = "Baja";
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(278, 346);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(125, 41);
            this.btnModificar.TabIndex = 13;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // chDisponible
            // 
            this.chDisponible.AutoSize = true;
            this.chDisponible.Location = new System.Drawing.Point(188, 459);
            this.chDisponible.Name = "chDisponible";
            this.chDisponible.Size = new System.Drawing.Size(75, 17);
            this.chDisponible.TabIndex = 15;
            this.chDisponible.Text = "Disponible";
            this.chDisponible.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(278, 215);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(125, 36);
            this.btnNuevo.TabIndex = 16;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // cmbPropietarios
            // 
            this.cmbPropietarios.FormattingEnabled = true;
            this.cmbPropietarios.Location = new System.Drawing.Point(80, 420);
            this.cmbPropietarios.Name = "cmbPropietarios";
            this.cmbPropietarios.Size = new System.Drawing.Size(183, 21);
            this.cmbPropietarios.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 423);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Propietario";
            // 
            // FRPropiedad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 491);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbPropietarios);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.chDisponible);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnBaja);
            this.Controls.Add(this.txtAlta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbLoc);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.txtDomicilio);
            this.Controls.Add(this.txtCantAmb);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FRPropiedad";
            this.Text = "FRPropiedad";
            this.Load += new System.EventHandler(this.FRPropiedad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtCantAmb;
        private System.Windows.Forms.TextBox txtDomicilio;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.ComboBox cmbLoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button txtAlta;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.CheckBox chDisponible;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.ComboBox cmbPropietarios;
        private System.Windows.Forms.Label label6;
    }
}