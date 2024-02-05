namespace UI
{
    partial class FRLocalidad
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
            this.cmbLocalidades = new System.Windows.Forms.ComboBox();
            this.dataGridViewLocalidades = new System.Windows.Forms.DataGridView();
            this.txtLocNom = new System.Windows.Forms.TextBox();
            this.txtLocCod = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAlta = new System.Windows.Forms.Button();
            this.Localidad = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLocalidades)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbLocalidades
            // 
            this.cmbLocalidades.FormattingEnabled = true;
            this.cmbLocalidades.Location = new System.Drawing.Point(90, 45);
            this.cmbLocalidades.Name = "cmbLocalidades";
            this.cmbLocalidades.Size = new System.Drawing.Size(150, 21);
            this.cmbLocalidades.TabIndex = 0;
            this.cmbLocalidades.SelectedIndexChanged += new System.EventHandler(this.cmbLocalidades_SelectedIndexChanged);
            // 
            // dataGridViewLocalidades
            // 
            this.dataGridViewLocalidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLocalidades.Location = new System.Drawing.Point(255, 45);
            this.dataGridViewLocalidades.Name = "dataGridViewLocalidades";
            this.dataGridViewLocalidades.Size = new System.Drawing.Size(240, 246);
            this.dataGridViewLocalidades.TabIndex = 1;
            this.dataGridViewLocalidades.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLocalidades_CellContentClick);
            // 
            // txtLocNom
            // 
            this.txtLocNom.Location = new System.Drawing.Point(90, 114);
            this.txtLocNom.Name = "txtLocNom";
            this.txtLocNom.Size = new System.Drawing.Size(150, 20);
            this.txtLocNom.TabIndex = 2;
            // 
            // txtLocCod
            // 
            this.txtLocCod.Location = new System.Drawing.Point(90, 88);
            this.txtLocCod.Name = "txtLocCod";
            this.txtLocCod.ReadOnly = true;
            this.txtLocCod.Size = new System.Drawing.Size(150, 20);
            this.txtLocCod.TabIndex = 3;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(129, 205);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(111, 36);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(129, 150);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(111, 37);
            this.btnAlta.TabIndex = 5;
            this.btnAlta.Text = "Alta";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // Localidad
            // 
            this.Localidad.AutoSize = true;
            this.Localidad.Location = new System.Drawing.Point(36, 48);
            this.Localidad.Name = "Localidad";
            this.Localidad.Size = new System.Drawing.Size(53, 13);
            this.Localidad.TabIndex = 6;
            this.Localidad.Text = "Localidad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nombre";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 37);
            this.button1.TabIndex = 9;
            this.button1.Text = "Nuevo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FRLocalidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 315);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Localidad);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.txtLocCod);
            this.Controls.Add(this.txtLocNom);
            this.Controls.Add(this.dataGridViewLocalidades);
            this.Controls.Add(this.cmbLocalidades);
            this.Name = "FRLocalidad";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FRLocalidad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLocalidades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbLocalidades;
        private System.Windows.Forms.DataGridView dataGridViewLocalidades;
        private System.Windows.Forms.TextBox txtLocNom;
        private System.Windows.Forms.TextBox txtLocCod;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Label Localidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}