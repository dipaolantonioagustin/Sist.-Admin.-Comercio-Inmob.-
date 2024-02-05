using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using BE;

namespace UI
{
    public partial class FRCaja : Form
    {
        public FRCaja()
        {
            InitializeComponent();
            
            oBLLCaja = new BLLCaja();
            oBLLContrato = new BLLContrato();
            oBLLInquilino = new BLLInquilino();
            oBLLPropietario = new BLLPropietario();


        }



        private void dataGridViewCaja_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }


        BLLCaja oBLLCaja;
        BLLContrato oBLLContrato;
        BLLInquilino oBLLInquilino;
        BLLPropietario oBLLPropietario;

        private void CargaCaja()
        {
            dataGridViewCaja.DataSource = null;
            
            List<BEOperacion> listaOperaciones = oBLLCaja.TraerListaTodo();
            List<BEOperacion> cajaOrdenada = listaOperaciones.OrderBy(x => x.fechaOperacion).ToList();
            dataGridViewCaja.DataSource = cajaOrdenada;
            dataGridViewCaja.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewCaja.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;

        }



        #region Metodos
        private void CargaComboContrato()
        {
            cmbContrato.DataSource = null;
            cmbContrato.DataSource = oBLLContrato.TraerListaTodo().ToArray();

        }

        private void CargarTxtInqDue(BEContrato contrato)
        {
            txtInquilino.Text = (contrato.inquilino).ToString();
            txtDueño.Text = (contrato.propietario).ToString();

        }

        private void CargarSaldo(BEContrato contrato)
        {
            txtSaldo.Text = (contrato.cuenta).ToString();
        }

        #endregion



        #region Botones

        private void FRCaja_Load(object sender, EventArgs e)
        {
            CargaCaja();
            CargaComboContrato();
        }

        private void cmbContrato_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarTxtInqDue((BEContrato)(cmbContrato.SelectedItem));
            CargarSaldo((BEContrato)(cmbContrato.SelectedItem));

        }
        private void VerificarTBCobro()
        {
            if(txtDiasAtraso.Text == string.Empty || txtOpInq.Text == string.Empty)
            {
                throw new ExcepcionCamposVacios("Campos Vacíos, favor de completarlos");
            }
        }

        private void VerificarTBPago()
        {
            if(txtOpDue.Text == string.Empty)
            {
                throw new ExcepcionCamposVacios("Campos vacíos, favor de completar los campos");
            }
        }
        private void btnCobrar_Click(object sender, EventArgs e)
        {
            try
            {
                VerificarTBCobro();

                if (Convert.ToInt32(txtDiasAtraso.Text) > 0)
                {
                    if (oBLLCaja.EscribirCaja(oBLLInquilino.Operar((BEContrato)cmbContrato.SelectedItem, float.Parse(txtOpInq.Text)), (BEContrato)cmbContrato.SelectedItem) == true)
                    {
                        CargaCaja();
                        oBLLCaja.EscribirCaja(oBLLInquilino.CalcularMulta((BEContrato)cmbContrato.SelectedItem, float.Parse(txtOpInq.Text), Convert.ToInt32(txtDiasAtraso.Text)), (BEContrato)cmbContrato.SelectedItem);
                    }

                }
                else
                {
                    oBLLCaja.EscribirCaja(oBLLInquilino.Operar((BEContrato)cmbContrato.SelectedItem, float.Parse(txtOpInq.Text)), (BEContrato)cmbContrato.SelectedItem);
                }
                CargarSaldo((BEContrato)cmbContrato.SelectedItem);
                CargaCaja();
           
            
            }catch(ExcepcionCamposVacios ex)
            {
                MessageBox.Show(ex.Message);
            
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            try
            {
                VerificarTBPago();

                if (oBLLCaja.EscribirCaja(oBLLPropietario.Operar((BEContrato)cmbContrato.SelectedItem, float.Parse(txtOpDue.Text)), (BEContrato)cmbContrato.SelectedItem) == true)
                {
                    oBLLCaja.EscribiCajaHonorarios(oBLLPropietario.CalcularHonorariosAdministracion(float.Parse(txtOpDue.Text)));
                    CargarSaldo((BEContrato)cmbContrato.SelectedItem);
                     CargaCaja();
                }

            }catch(ExcepcionCamposVacios ex)
            {
                MessageBox.Show(ex.Message);

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            oBLLCaja.Baja((BEOperacion)dataGridViewCaja.CurrentRow.DataBoundItem);
            CargaCaja();
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            oBLLCaja.Anular((BEOperacion)dataGridViewCaja.CurrentRow.DataBoundItem);
            CargaCaja();
        }

        #endregion
    }
}
