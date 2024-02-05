namespace UI
{
    partial class FRCuenta
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
            this.dgvCuentas = new System.Windows.Forms.DataGridView();
            this.txtCodCuenta = new System.Windows.Forms.TextBox();
            this.lblcod = new System.Windows.Forms.Label();
            this.txtNombreCuenta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAlta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuentas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCuentas
            // 
            this.dgvCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCuentas.Location = new System.Drawing.Point(282, 26);
            this.dgvCuentas.Name = "dgvCuentas";
            this.dgvCuentas.Size = new System.Drawing.Size(258, 263);
            this.dgvCuentas.TabIndex = 0;
            // 
            // txtCodCuenta
            // 
            this.txtCodCuenta.Location = new System.Drawing.Point(95, 26);
            this.txtCodCuenta.Name = "txtCodCuenta";
            this.txtCodCuenta.Size = new System.Drawing.Size(168, 20);
            this.txtCodCuenta.TabIndex = 1;
            // 
            // lblcod
            // 
            this.lblcod.AutoSize = true;
            this.lblcod.Location = new System.Drawing.Point(26, 29);
            this.lblcod.Name = "lblcod";
            this.lblcod.Size = new System.Drawing.Size(40, 13);
            this.lblcod.TabIndex = 2;
            this.lblcod.Text = "Código";
            // 
            // txtNombreCuenta
            // 
            this.txtNombreCuenta.Location = new System.Drawing.Point(95, 72);
            this.txtNombreCuenta.Name = "txtNombreCuenta";
            this.txtNombreCuenta.Size = new System.Drawing.Size(168, 20);
            this.txtNombreCuenta.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre Cuenta";
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(171, 115);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(92, 40);
            this.btnAlta.TabIndex = 5;
            this.btnAlta.Text = "Alta";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // FRCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 301);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombreCuenta);
            this.Controls.Add(this.lblcod);
            this.Controls.Add(this.txtCodCuenta);
            this.Controls.Add(this.dgvCuentas);
            this.Name = "FRCuenta";
            this.Text = "FRCuenta";
            this.Load += new System.EventHandler(this.FRCuenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCuentas;
        private System.Windows.Forms.TextBox txtCodCuenta;
        private System.Windows.Forms.Label lblcod;
        private System.Windows.Forms.TextBox txtNombreCuenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAlta;
    }
}