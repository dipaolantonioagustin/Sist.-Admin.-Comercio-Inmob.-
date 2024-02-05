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
    public partial class FRCuenta : Form
    {
        public FRCuenta()
        {
            InitializeComponent();
        }

        private void FRCuenta_Load(object sender, EventArgs e)
        {

            oBLLCuenta = new BLLCuenta();
            CargaCuentas();


        }
                
        BLLCuenta oBLLCuenta;

        private void CargaCuentas()
        {
            dgvCuentas.DataSource = null;
            dgvCuentas.DataSource = oBLLCuenta.TraerListaTodo();

        }

        private BeCuenta CargarCuenta()
        {
            BeCuenta cuenta = new BeCuenta();
            cuenta.codigo = Convert.ToInt32(txtCodCuenta.Text);
            cuenta.nombre = txtNombreCuenta.Text;

            return cuenta;
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            oBLLCuenta.Guardar(CargarCuenta());
            CargaCuentas();
        }
    }
}
