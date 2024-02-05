using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;
using BLL;

namespace UI
{
    public partial class FRReportes : Form
    {
        public FRReportes()
        {
            InitializeComponent();
        }

        private void FRReportes_Load(object sender, EventArgs e)
        {
            oBLLCaja = new BLLCaja();
            oBLLContrato = new BLLContrato();
            oBLLPropiedad = new BLLPropiedad();
            oBLLLocalidad = new BLLLocalidades();
            oBLLTipo = new BLLFormato();

            CargaCaja();
            CargaPropiedades();
            CargaComboContratos();
            CargaCombosPropiedades();            

        }

        BLLCaja oBLLCaja;
        BLLContrato oBLLContrato;
        BLLPropiedad oBLLPropiedad;
        BLLLocalidades oBLLLocalidad;
        BLLFormato oBLLTipo;


        #region Botones
        private void CargaComboContratos()
        {
            cmbContrato.DataSource = null;
            cmbContrato.DataSource = oBLLContrato.TraerListaTodo();

        }

        private void CargaCombosPropiedades()
        {
            List<int> ambientes = new List<int> { 1, 2, 3, 4, 5, 6 };
            cmbCantAmb.DataSource = ambientes;
            cmblocProp.DataSource = oBLLLocalidad.TraerListaTodo();
            cmbTipoProp.DataSource = oBLLTipo.TraerListaTodo();


        }

        private void CargaPropiedadFiltro(bool condicion)
        {
            dataGridViewPropiedades.DataSource = null;
            List<BEPropiedad> listadoPropiedades = oBLLPropiedad.TraerListarTodo();
            List<BEPropiedad> propiedadesFiltradas = (from x in listadoPropiedades where x.disponible == condicion select x).ToList();

            dataGridViewPropiedades.DataSource = propiedadesFiltradas;
        }

        private void CargaPropiedades()
        {
            dataGridViewPropiedades.DataSource = null;
            dataGridViewPropiedades.DataSource = oBLLPropiedad.TraerListarTodo();
            dataGridViewPropiedades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewPropiedades.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;

        }

        private void CargaCaja()
        {
            dataGridViewCaja.DataSource = null;
            dataGridViewCaja.DataSource = oBLLCaja.TraerListaTodo();
            dataGridViewCaja.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewCaja.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;

        }
        private List<BEOperacion> CajaFiltroContrato(BEContrato contrato)
        {
            List<BEOperacion> listaOperaciones = oBLLCaja.TraerListaTodo();

            List<BEOperacion> cajaOrdenadaContrato = (from x in listaOperaciones where  ( x.idContrato == contrato.codigo) select x).ToList();

            dataGridViewCaja.DataSource = null;
            dataGridViewCaja.DataSource = cajaOrdenadaContrato;

            return cajaOrdenadaContrato;


        }

        private BEResumen armarResuen()
        {
            BEResumen resumen = new BEResumen();
            resumen.ResumenMovimiento = (List<BEOperacion>)(dataGridViewCaja.DataSource);

            resumen.arqueo = float.Parse(txtArqueo.Text);
            resumen.saldoInicio = float.Parse(txtSaldoInicio.Text);

            return resumen;

        }

        private void CajaFiltro(DateTime fecha)
        {
          
            List<BEOperacion> listaOperaciones = oBLLCaja.TraerListaTodo();


            List<BEOperacion> cajaOrdenada = (from x in listaOperaciones where (x.fechaOperacion.Day == fecha.Day) select x).ToList();

            dataGridViewCaja.DataSource = null;
            dataGridViewCaja.DataSource = cajaOrdenada;

        }

        private void InformeGeneralCaja(List<BEOperacion> caja)
        {
            try
            {
                if (caja.Count == 0)
                {
                    MessageBox.Show("El contrato no posee movimientos");
                }
                else
                {
                    BEOperacion operacion = (BEOperacion)(caja.Last());

                    lblFechaUltMov.Text = operacion.fechaOperacion.ToShortDateString();

                    lblUltMovImp.Text = operacion.importe.ToString();

                    lblCantMov.Text = caja.Count.ToString();
                }

            }catch(InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void InformeCombosPropiedades(List<BEPropiedad> listadoPropiedades)
        {
            lblCDTipo.Text = ((from x in listadoPropiedades where x.formato.tipoNombre == ((BEFormato)cmbTipoProp.SelectedItem).ToString() select x).Count()).ToString();
            lblCDLoc.Text = ((from x in listadoPropiedades where x.localidad.nombreLoc == (((BELocalidad)cmblocProp.SelectedItem)).ToString() select x).Count()).ToString();
            lblCDAmb.Text = ((from x in listadoPropiedades where x.cantidadAmbiente == ((int)cmbCantAmb.SelectedItem) select x).Count()).ToString();

            lblTotalCondiciones.Text = ((from x in listadoPropiedades where( x.cantidadAmbiente == ((int)cmbCantAmb.SelectedItem) && x.formato.tipoNombre == ((BEFormato)cmbTipoProp.SelectedItem).ToString() && x.localidad.nombreLoc == (((BELocalidad)cmblocProp.SelectedItem)).ToString()) select x).Count()).ToString();
        }

        private void checkCampos()
        {
            if(txtArqueo.Text == "" || txtSaldoInicio.Text == "")
            {
                throw new ExcepcionCamposVacios("No se puede realizar la operatorioa, uno de los campos se encuentra vacío");
            }
        }



        #endregion


        #region Botones




        private void btnFiltroFecha_Click(object sender, EventArgs e)
        {
            CajaFiltro(dtpCajaFiltro.Value);
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                checkCampos();
                lblBalance.Text = (oBLLCaja.Balance(armarResuen())).ToString();

            }catch(ExcepcionCamposVacios ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void btnFiltroContrato_Click(object sender, EventArgs e)
        {
            InformeGeneralCaja(CajaFiltroContrato((BEContrato)cmbContrato.SelectedItem));

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CargaPropiedadFiltro(true);
        }

        private void btnTodasProp_Click(object sender, EventArgs e)
        {
            CargaPropiedades();
        }

        private void btnNoDispo_Click(object sender, EventArgs e)
        {
            CargaPropiedadFiltro(false);
        }

        private void btnResultadosCombos_Click(object sender, EventArgs e)
        {
            InformeCombosPropiedades((List<BEPropiedad>)dataGridViewPropiedades.DataSource);
        }




        #endregion

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            CargaCaja();
        }
    }
}
