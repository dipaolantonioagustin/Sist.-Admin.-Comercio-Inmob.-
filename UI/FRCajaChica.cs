using BE;
using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class FRCajaChica : Form
    {
        public FRCajaChica()
        {
            InitializeComponent();
        }

        private void FRCajaChica_Load(object sender, EventArgs e)
        {            
            oBLLOperacionCajaChica = new BLLOperacionCajaChica();
            oBLLCuentas = new BLLCuenta();
            CargaDataGridCajaChica();
            CargaComboCuentas();
            LimpiarCampos();
        }

        BLLOperacionCajaChica oBLLOperacionCajaChica;
        BLLCuenta oBLLCuentas;

        private void CargaDataGridCajaChica()
        {
            dgvCajaChica.DataSource = null;
            dgvCajaChica.DataSource = oBLLOperacionCajaChica.TraerListaTodo();
        }

        private void CargaComboCuentas()
        {
            cmbCuentas.DataSource = null;
            cmbCuentas.DataSource = oBLLCuentas.TraerListaTodo();
            cmbCuentas.DisplayMember = "nombre";
            cmbCuentas.ValueMember = "codigo";
        }



        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }


        private BEOperacionCajaChica CargarOperacion()
        {
            BEOperacionCajaChica op = new BEOperacionCajaChica();

            op.codigo = Convert.ToInt32(txtCodigo.Text);
            op.cuenta = cmbCuentas.Text;
            op.fechaOperacion = DateTime.Now;
            op.descripcion = txtDescripcion.Text;
            op.importe = float.Parse(txtImporte.Text);

            return op;


        }


        private void btnAlta_Click(object sender, EventArgs e)
        {
            oBLLOperacionCajaChica.Guardar(CargarOperacion());
            CargaDataGridCajaChica();
            LimpiarCampos();
        }


        private void CargaTextBox()
        {
            BEOperacionCajaChica op = (BEOperacionCajaChica)dgvCajaChica.CurrentRow.DataBoundItem;
            txtCodigo.Text = op.codigo.ToString();
            txtDescripcion.Text = op.descripcion;
            txtImporte.Text = op.importe.ToString();
            cmbCuentas.Text = op.cuenta.ToString();            


        }

        

        private void btnBaja_Click(object sender, EventArgs e)
        {
            oBLLOperacionCajaChica.Baja(CargarOperacion());
            CargaDataGridCajaChica();
            LimpiarCampos();
        }

        private void dgvCajaChica_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CargaTextBox();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            oBLLOperacionCajaChica.Guardar(CargarOperacion());
            CargaDataGridCajaChica();
            LimpiarCampos();
        }


        private void LimpiarCampos()
        {
            txtCodigo.Text = "0";
            txtDescripcion.Text = string.Empty;
            txtImporte.Text = string.Empty;
            cmbCuentas.Text = string.Empty;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}
