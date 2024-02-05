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
using BLL;
using Microsoft.Win32;

namespace UI
{
    public partial class FRContrato : Form
    {
        public FRContrato()
        {
            InitializeComponent();
        }

        private void FRContrato_Load(object sender, EventArgs e)
        {
             oBLLContrato = new BLLContrato();
             oBLLPropiedad = new BLLPropiedad();
             oBLLInquilino = new BLLInquilino();


            CargaComboInquilino(oBLLInquilino);
            CargaComboPropiedad(oBLLPropiedad);
            CargarDataGrid();
            LimpiarTextBox();
        }

        BLLContrato oBLLContrato;
        BLLInquilino oBLLInquilino;
        BLLPropiedad oBLLPropiedad;


        #region metodos
        private void CargarDataGrid()
        {

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = oBLLContrato.TraerListaTodo();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
        }


        private void CargaComboInquilino(BLLInquilino inquilino)
        {
            cmbInquilino.DataSource = null;
            cmbInquilino.DataSource = inquilino.TraerListarTodo();
            cmbInquilino.DisplayMember = "apellido";
            cmbInquilino.ValueMember = "codigo";
        }

        private void CargaComboPropiedad(BLLPropiedad propiedad)
        {
            cmbPropiedad.DataSource = null;
            cmbPropiedad.DataSource = propiedad.TraerListaSoloDisponibles();
            cmbPropiedad.DisplayMember = "direccion";
            cmbPropiedad.ValueMember = "codigo";

        }

        private void CargarTextBox(BEContrato contrato)
        {
            txtCodigo.Text = (contrato.codigo).ToString();
            txtValor.Text  = (contrato.valor).ToString();   
            chActivo.Checked = (bool)(contrato.activo);
            dtpInicio.Value = (contrato.fechaInicio);
            txtCuenta.Text = (contrato.cuenta).ToString();
            cmbInquilino.Text = (contrato.inquilino.apellido).ToString();
            cmbPropiedad.Text = (contrato.propiedad.direccion).ToString();
           

        }


        private void LimpiarTextBox()
        {
            txtCodigo.Text = "0";
            txtValor.Text = string.Empty;
            cmbInquilino.Text =null;
            cmbPropiedad.Text = null;
            chActivo.Checked = false;
            txtCuenta.Text = string.Empty; 

        }

        private BEContrato CargarContrato()
        {
            BEContrato oBEContratoCarga = new BEContrato(float.Parse(txtCuenta.Text));

            oBEContratoCarga.propiedad = (BEPropiedad)cmbPropiedad.SelectedItem;
            if(oBEContratoCarga.propiedad == null) { oBEContratoCarga.propiedad = ((BEContrato)dataGridView1.CurrentRow.DataBoundItem).propiedad; }
            oBEContratoCarga.inquilino = (BEInquilino)cmbInquilino.SelectedItem;
            oBEContratoCarga.fechaInicio = (DateTime)dtpInicio.Value;
            oBEContratoCarga.codigo = Convert.ToInt32(txtCodigo.Text);
            oBEContratoCarga.valor = Convert.ToInt32(txtValor.Text);
            oBEContratoCarga.activo = chActivo.Checked; 

            return oBEContratoCarga;

        }


        private void checkCampos()
        {
            if(txtCodigo.Text == "" || txtCuenta.Text == "" || txtValor.Text == ""|| cmbInquilino.Text == "" || cmbPropiedad.Text == "" )
            {
                throw new ExcepcionCamposVacios("No es posible proseguir con la operacion, alguno de los campos se encuentran vacíos");
            }

        }

        #endregion

        #region Botones
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CargarTextBox((BEContrato)dataGridView1.CurrentRow.DataBoundItem);
        }

        private bool CambioDisponibilidadPropiedad(BEPropiedad prop, bool dispo)
        {
            if(dispo == true) // En una baja  la propiedad vuelve a estar disponible
            {
                return oBLLPropiedad.HabilitarDispo(prop);
            }
            else  // Alta Contrato
            {
                return oBLLPropiedad.DeshabilitarDispo(prop);
            }


        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            BEPropiedad prop = (CargarContrato()).propiedad;
            try
            {
                checkCampos();

                if (oBLLContrato.Guardar(CargarContrato()) == true)
                {

                    CambioDisponibilidadPropiedad(prop, false);
                    MessageBox.Show("Se ha cargado correctamente el contrato");
                    CargaComboPropiedad(oBLLPropiedad);
                    CargarDataGrid();
                    LimpiarTextBox();
                }
                else
                {
                    MessageBox.Show("Ha habido un error de carga");
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
            try
            {
                BEPropiedad prop = (CargarContrato()).propiedad;
                if (oBLLContrato.Baja(CargarContrato()) == true)
                {
                    CambioDisponibilidadPropiedad(prop, true);
                    MessageBox.Show("Se ha dado de baja correctamente el contrato");
                    CargaComboPropiedad(oBLLPropiedad);
                    CargarDataGrid();
                    LimpiarTextBox();
                }
                else
                {
                    MessageBox.Show("Ha habido un error en el proceso de baja de contrato");
                }
            }catch(ExcepcionCamposVacios ex)
            {
                MessageBox.Show(ex.Message);

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarTextBox();
           
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                checkCampos();
                if (oBLLContrato.Guardar(CargarContrato()) == true)
                {
                    MessageBox.Show("Se ha Modificado correctamente el contrato");
                    CargaComboPropiedad(oBLLPropiedad);
                    CargarDataGrid();
                    LimpiarTextBox();
                }
                else
                {
                    MessageBox.Show("Ha habido un error de Modificacion");
                }
            }catch(ExcepcionCamposVacios ex)
            {
                MessageBox.Show(ex.Message);

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        #endregion
    
    
    
    }
}
