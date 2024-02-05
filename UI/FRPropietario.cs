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
    public partial class FRPropietario : Form
    {
        public FRPropietario()
        {
            InitializeComponent();
        }

        private void FRPropietario_Load(object sender, EventArgs e)
        {
            oBLLPropietario = new BLLPropietario();
            oBLLocalidad = new BLLLocalidades();


            CargaDataGrid(oBLLPropietario);
            CargaCombo(oBLLocalidad);
                        

        }

        BLLPropietario oBLLPropietario;
        BLLLocalidades oBLLocalidad;


        #region Métodos 
        private void CargaDataGrid(BLLPropietario propietario)
        {
            dataGridViewPropietarios.DataSource = null;
            dataGridViewPropietarios.DataSource = propietario.TraerListaTodo();
            dataGridViewPropietarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewPropietarios.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;

        }

        private void CargaCombo(BLLLocalidades localidades)
        {
            cmbLocalidad.DataSource = null;
            cmbLocalidad.DataSource = localidades.TraerListaTodo().ToArray();

        }

        private void checkCampos()
        {
            if (txtApellido.Text == "" || txtNombre.Text == "" || txtCodigo.Text == "" || txtDNI.Text == "" || txtDomicilio.Text == "")
            {
                throw new ExcepcionCamposVacios("No se puede continar con la operacion, se encuentran campos vacíos");
            }

        }


        private int DNI(DNI textBox)
        {
            if (textBox.validar() == true)
            {
                return Convert.ToInt32(textBox.Text);
            }
            else { throw new Exception("Error DNI Carga"); }

        }

        private string Nombre(Nombre textbox)
        {
            if (textbox.checkSoloLetras() == true)
            {
                return textbox.Text;
            }
            else { throw new Exception("Error de Carga Nombre"); }

        }




        private BEPropietario PropietarioCarga()
        {
            BEPropietario propietarioCarga = new BEPropietario();

            propietarioCarga.codigo = Convert.ToInt32(txtCodigo.Text);
            propietarioCarga.apellido = Nombre(txtApellido);
            propietarioCarga.nombre = Nombre(txtNombre);
            propietarioCarga.localidad = (BELocalidad)cmbLocalidad.SelectedItem;
            propietarioCarga.fechaNac = dtpFechaNac.Value;
            propietarioCarga.activo = chActivo.Checked;
            propietarioCarga.propiedadesPropietario = ((BEPropietario)dataGridViewPropietarios.CurrentRow.DataBoundItem).propiedadesPropietario;
            propietarioCarga.dni = DNI(txtDNI);
            propietarioCarga.direccion = txtDomicilio.Text;

            return propietarioCarga;

        }

        private void TextBoxCargas(BEPropietario propietario)
        {

            txtApellido.Text = propietario.apellido;
            txtNombre.Text = propietario.nombre;
            txtCodigo.Text = (propietario.codigo).ToString();
            cmbLocalidad.Text = (propietario.localidad).ToString();
            dtpFechaNac.Value = propietario.fechaNac;
            txtEdad.Text = propietario.CalcuEdad().ToString();
            cmbLocalidad.Text = propietario.localidad.nombreLoc;
            chActivo.Checked = propietario.activo;
            txtDNI.Text = (propietario.dni).ToString();
            txtDomicilio.Text = (propietario.direccion).ToString();

        }


        private void LimpiarTextBox()
        {
            txtApellido.Text = String.Empty;
            txtNombre.Text = String.Empty;
            txtCodigo.Text = "0";
            cmbLocalidad.Text = String.Empty;
            txtEdad.Text = String.Empty;
            
            chActivo.Checked = false;
            txtDNI.Text = String.Empty;
            txtDomicilio.Text = String.Empty;

        }


      

       

        #endregion

        #region Botones



        private void dataGridViewPropietarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewPropiedades.DataSource = null;
            dataGridViewPropiedades.DataSource = ((BEPropietario)(dataGridViewPropietarios.CurrentRow.DataBoundItem)).propiedadesPropietario;
            TextBoxCargas((BEPropietario)(dataGridViewPropietarios.CurrentRow.DataBoundItem));
            dataGridViewPropiedades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewPropiedades.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;


        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            try
            {
                checkCampos();
                oBLLPropietario.Guardar(PropietarioCarga());
                CargaDataGrid(oBLLPropietario);
                LimpiarTextBox();
            }catch(ExcepcionCamposVacios ex)
            {
                MessageBox.Show(ex.Message);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }

        private void btnModificacion_Click(object sender, EventArgs e)
        {
            try
            {
                checkCampos();
                oBLLPropietario.Guardar(PropietarioCarga());
                CargaDataGrid(oBLLPropietario);
                LimpiarTextBox();
            }
            catch (ExcepcionCamposVacios ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            if(oBLLPropietario.ExistenciaPropietarioDominio(PropietarioCarga()) == false)
            {
                oBLLPropietario.Baja(PropietarioCarga());
                CargaDataGrid(oBLLPropietario);
                LimpiarTextBox();

                MessageBox.Show("Se ha dado de baja correctamente el propietario");
            }
            else
            {
                MessageBox.Show("No se puede dar de Baja al propietario, tiene dominios asignados");
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarTextBox();
           
        }


        #endregion

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtDNI_Load(object sender, EventArgs e)
        {

        }
    }
}
