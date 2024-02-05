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
    public partial class FRPropiedad : Form
    {
        public FRPropiedad()
        {
            InitializeComponent();
        }

        private void FRPropiedad_Load(object sender, EventArgs e)
        {
            oBLLPropiedad = new BLLPropiedad();
            oBLLocalidad = new BLLLocalidades();
            oBLTipo = new BLLFormato();
            oBLLPropietario = new BLLPropietario();


            CargarDataGrid();
            CargarCombo(oBLLocalidad);
            CargarComboTipo(oBLTipo);
            CargarComboPropietarios(oBLLPropietario);
            limpiar();

        }

        BLLPropiedad oBLLPropiedad;
        BLLLocalidades oBLLocalidad;
        BLLFormato oBLTipo;
        BLLPropietario oBLLPropietario;


        #region Metodos
        public void CargarDataGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = oBLLPropiedad.TraerListarTodo();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;

        }



        public void CargarTextBox(BEPropiedad propiedad)
        {
            txtCodigo.Text = propiedad.codigo.ToString();
            txtDomicilio.Text = propiedad.direccion.ToString();
            txtCantAmb.Text = (propiedad.cantidadAmbiente).ToString();
            cmbLoc.Text = propiedad.localidad.nombreLoc;
            cmbTipo.Text = propiedad.formato.tipoNombre;
            chDisponible.Checked = propiedad.disponible;
          //  cmbPropietarios.Text = propiedad.propietario.ToString();
        }
        private void LimpiarCampos()
        {
            txtCantAmb.Text = string.Empty;
            txtCodigo.Text = "0";
            cmbLoc.Text = string.Empty;
            cmbTipo.Text = String.Empty;
            chDisponible.Checked = false;
            txtDomicilio.Text = String.Empty;
            cmbPropietarios.Text = null;
        }
        private void CargarCombo(BLLLocalidades localidades)
        {
           cmbLoc.DataSource = null;
           cmbLoc.DataSource = localidades.TraerListaTodo().ToArray();
           cmbLoc.ValueMember = "codigo";
           cmbLoc.DisplayMember = "nombreLoc";
            
        }
        private BEPropietario CargarPropietario()
        {
            BEPropietario oBEPropietarioCarga = new BEPropietario();

            oBEPropietarioCarga.codigo = ((BEPropietario)cmbPropietarios.SelectedItem).codigo;


            return oBEPropietarioCarga;
        }
        private BEPropiedad CargarPropiedad()
        {
            BEPropiedad oBEPropiedadCarga = new BEPropiedad();

            oBEPropiedadCarga.codigo = Convert.ToInt32(txtCodigo.Text);
            oBEPropiedadCarga.direccion = txtDomicilio.Text;
            oBEPropiedadCarga.localidad = (BELocalidad)cmbLoc.SelectedItem;
            oBEPropiedadCarga.formato = (BEFormato)cmbTipo.SelectedItem;
            oBEPropiedadCarga.cantidadAmbiente = Convert.ToInt32(txtCantAmb.Text);
            oBEPropiedadCarga.disponible = chDisponible.Checked;
           // oBEPropiedadCarga.propietario = (BEPropietario)cmbPropietarios.SelectedItem;
                                  
            return oBEPropiedadCarga;
        }


        private void CargarComboTipo(BLLFormato tipos)
        {
            cmbTipo.DataSource = null;
            cmbTipo.DataSource = tipos.TraerListaTodo().ToArray();
            cmbTipo.ValueMember = "codigo";
            cmbTipo.DisplayMember = "TipoNombre";
        }

        private void limpiar()
        {
            txtCodigo.Text = String.Empty;
            txtDomicilio.Text = String.Empty;
            txtCantAmb.Text = String.Empty;
            cmbLoc.Text = String.Empty;
            cmbTipo.Text = String.Empty;
            chDisponible.Checked = false;
           
        }

        private void checkCampos()
        {
            if(txtCodigo.Text == "" || txtDomicilio.Text == "" ||txtCantAmb.Text  == "" || cmbLoc.Text == ""|| cmbTipo.Text == "" || cmbPropietarios.Text == "")
            {
                throw new ExcepcionCamposVacios(" No es posible continuar con la operacion, se encuentran campos vacíos");
            }
        }
       

         private void CargarComboPropietarios(BLLPropietario propietarios)
        {
            cmbPropietarios.DataSource = null;
            cmbPropietarios.DataSource = propietarios.TraerListaTodo();
        }



        #endregion

        #region Botones

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
            CargarTextBox((BEPropiedad)dataGridView1.CurrentRow.DataBoundItem);
         
        }

        private void txtAlta_Click(object sender, EventArgs e)
        {
            try
            {
                checkCampos();
                oBLLPropiedad.Guardad(CargarPropiedad(), CargarPropietario());
                CargarDataGrid();
                limpiar();

            }catch(ExcepcionCamposVacios ex)
            {                
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                checkCampos();
                oBLLPropiedad.Guardad(CargarPropiedad(), CargarPropietario());
                CargarDataGrid();
                limpiar();

            }
            catch (ExcepcionCamposVacios ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            if (oBLLPropiedad.VerificarAsociadoInquilino(CargarPropiedad()) == false)
            { 
                oBLLPropiedad.Baja(CargarPropiedad());
                CargarDataGrid();
                limpiar();
            }
            else
            {
                MessageBox.Show("No se puede dar de baja la propiedad posee contratos asociados.");
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            
        }
        #endregion

    }
}
