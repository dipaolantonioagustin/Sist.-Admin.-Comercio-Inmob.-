namespace UI
{
    partial class LoguinUsuario
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.btnAlta = new System.Windows.Forms.Button();
            this.btnLoguin = new System.Windows.Forms.Button();
            this.Usuario = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(12, 38);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(196, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(12, 90);
            this.txtClave.Name = "txtClave";
            this.txtClave.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtClave.Size = new System.Drawing.Size(196, 20);
            this.txtClave.TabIndex = 1;
            this.txtClave.UseSystemPasswordChar = true;
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(12, 133);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(94, 38);
            this.btnAlta.TabIndex = 2;
            this.btnAlta.Text = "Alta";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // btnLoguin
            // 
            this.btnLoguin.Location = new System.Drawing.Point(112, 133);
            this.btnLoguin.Name = "btnLoguin";
            this.btnLoguin.Size = new System.Drawing.Size(96, 38);
            this.btnLoguin.TabIndex = 3;
            this.btnLoguin.Text = "Loguin";
            this.btnLoguin.UseVisualStyleBackColor = true;
            this.btnLoguin.Click += new System.EventHandler(this.btnLoguin_Click);
            // 
            // Usuario
            // 
            this.Usuario.AutoSize = true;
            this.Usuario.Location = new System.Drawing.Point(82, 22);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(43, 13);
            this.Usuario.TabIndex = 4;
            this.Usuario.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Contraseña";
            // 
            // LoguinUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 199);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Usuario);
            this.Controls.Add(this.btnLoguin);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.txtNombre);
            this.Name = "LoguinUsuario";
            this.Text = "LoguinUsuario";
            this.Load += new System.EventHandler(this.LoguinUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Button btnLoguin;
        private System.Windows.Forms.Label Usuario;
        private System.Windows.Forms.Label label2;
    }
}