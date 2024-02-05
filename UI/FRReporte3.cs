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
    public partial class FRReporte3 : Form
    {
        public FRReporte3()
        {
            InitializeComponent();
        }

        private void FRReporte3_Load(object sender, EventArgs e)
        {
            oBLLOpCajaChica = new BLLOperacionCajaChica();
            oBLLCuenta = new BLLCuenta();
            this.reportViewer1.RefreshReport();
            CargaCajaChica();
            CargaCombo();
        }

        BLLOperacionCajaChica oBLLOpCajaChica;
        BLLCuenta oBLLCuenta;
        private void CargaCajaChica()
        {
            List<BEOperacionCajaChica> listado = oBLLOpCajaChica.TraerListaTodo();
            reportViewer1.LocalReport.DataSources[0].Value = null;
            reportViewer1.LocalReport.DataSources[0].Value = listado;
            this.reportViewer1.RefreshReport();
        }

        private void CargaGenerica(List<BEOperacionCajaChica> listado)
        {
            reportViewer1.LocalReport.DataSources[0].Value = null;
            reportViewer1.LocalReport.DataSources[0].Value = listado;
            this.reportViewer1.RefreshReport();
        }
        private List<BEOperacionCajaChica> FiltrarFecha()
        {
            List<BEOperacionCajaChica> resultado;
            List<BEOperacionCajaChica> lista = oBLLOpCajaChica.TraerListaTodo();
            DateTime fecha = dateTimePicker1.Value;
            resultado = (from op in lista where op.fechaOperacion.Date == fecha.Date select op).ToList();

            return resultado;

        }
        private void CargaCombo()
        {
            cmbCuenta.DataSource = null;
            cmbCuenta.DataSource = oBLLCuenta.TraerListaTodo();
            cmbCuenta.DisplayMember = "nombre";
            cmbCuenta.ValueMember = "codigo";

        }

        private List<BEOperacionCajaChica> FiltrarCuenta(List<BEOperacionCajaChica> listado)
        {
            List<BEOperacionCajaChica> resultado;
            BeCuenta cuenta = (BeCuenta)cmbCuenta.SelectedItem;
            resultado = (from op in listado where op.cuenta == cuenta.nombre select op).ToList();

            return resultado;

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if(chFecha.Checked == true && chCuenta.Checked == false)
            {
                CargaGenerica(FiltrarFecha());

            }else if (chFecha.Checked == false && chCuenta.Checked == true)
            {
               CargaGenerica(FiltrarCuenta(oBLLOpCajaChica.TraerListaTodo()));

            }else if(chFecha.Checked == true && chCuenta.Checked == true)
            {
                CargaGenerica(FiltrarCuenta(FiltrarFecha()));
            }else if(chFecha.Checked == false && chCuenta.Checked == false)
            {
                MessageBox.Show("Debe seleccionar algún parametro de filtro");
            }
        }

        private void btnMostrarTodo_Click(object sender, EventArgs e)
        {
            CargaCajaChica();
        }
    }
}
