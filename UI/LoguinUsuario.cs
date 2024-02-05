using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;
using SeguridadLoguin;

namespace UI
{
    public partial class LoguinUsuario : Form
    {
        public LoguinUsuario()
        {
            InitializeComponent();
        }



        private void LoguinUsuario_Load(object sender, EventArgs e)
        {
            loguin = new SLoguin();
           
        }


        SLoguin loguin;
        

        private BEUsuario CargaUsuario()
        {
            BEUsuario usuario = new BEUsuario();
            usuario.nombre = txtNombre.Text;
            usuario.clave = txtClave.Text;
            return usuario;
        }

        private void verificarCampos()
        {
            if(txtClave.Text == "" || txtClave.Text == "")
            {
                throw new ExcepcionCamposVacios("Favor de completar todos los campos para realizar la operación");

            }
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            try
            {
                verificarCampos();
                loguin.CargarUsuario(CargaUsuario());
                

            }
            catch(ExcepcionCamposVacios ex)
            {
                MessageBox.Show(ex.Message);
               
            }

            limpiar();

        }

        private void limpiar()
        {
            txtClave.Text = string.Empty;
            txtNombre.Text = string.Empty;
        }

        private void btnLoguin_Click(object sender, EventArgs e)
        {
            try
            {
                verificarCampos();
               
                
                if (loguin.Verificar(CargaUsuario()) == true)
                {
                    MessageBox.Show("Verificación Correcta");
                    FRPrincipal principal = new FRPrincipal();
                    principal.Show();
                    



                }
                else
                {
                    MessageBox.Show("Usuario o clave Incorrecto, por favor vuelva a intentarlo");
                   
                }

            }catch(ExcepcionCamposVacios ex)
            {
                MessageBox.Show(ex.Message);
            }

            limpiar();

        }
    }
}
