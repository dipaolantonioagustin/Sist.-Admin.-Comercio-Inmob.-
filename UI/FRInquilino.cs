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

namespace UI
{
    public partial class FRInquilino : Form
    {
        public FRInquilino()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            oBLLInquilino = new BLLInquilino();
            oBLLTesteoConec = new BLLTesteoConexion();
            oBLLLoc = new BLLLocalidades();
            oBLLGarantia = new BLLGarantia();


            CargarTabla();
            CargaComboLoc();
            CargaComboGarantia();
        }

        BLLTesteoConexion oBLLTesteoConec;
        BLLInquilino oBLLInquilino;
        BLLLocalidades oBLLLoc;
        BLLGarantia oBLLGarantia;
        
        #region Metodos
        private void CargaComboLoc()
        {
            cmbLocalidad.DataSource = null;
            cmbLocalidad.DataSource = oBLLLoc.TraerListaTodo().ToArray();
            cmbLocalidad.DisplayMember = "nombreLoc";
            cmbLocalidad.ValueMember = "codigo";

        }

        private void CargaComboGarantia()
        {
            cmbGarantia.DataSource = null;
            cmbGarantia.DataSource = oBLLGarantia.TraerListaTodo().ToArray();
            cmbGarantia.DisplayMember = "nombreGarantia";
            cmbGarantia.ValueMember = "codigo";

        }





        private void limpiar()
        {
            txtApellido.Text = String.Empty;
            txtNombre.Text = String.Empty;
            txtEdad.Text = String.Empty;
            txtdireccion.Text = String.Empty;
            txtCodigo.Text = "0";
            txtDni.Text = String.Empty;
            chActivo.Checked = false;
            cmbLocalidad.Text = null;
            cmbGarantia.Text = null;


        }


        private void CargarTabla()

        {
            dataGridViewInquilinos.DataSource = null;
            dataGridViewInquilinos.DataSource = oBLLInquilino.TraerListarTodo();
            dataGridViewInquilinos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewInquilinos.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;


        }

       // private void TesteCone()
        //{
          //  MessageBox.Show(oBLLTesteoConec.TestingConexion());

        //}
        private int DNI()
        {
            if(txtDni.validar() == true)
            {
                return Convert.ToInt32(txtDni.Text);
            }
            else { throw new Exception("Error DNI Carga"); }
            
        }

        private string Nombre(Nombre textbox)
        {
            if(textbox.checkSoloLetras() == true)
            {
                return textbox.Text;
            }
            else { throw new Exception("Error de Carga Nombre"); }

        }


        private BEInquilino InquilinCarga()
        {
            BEInquilino inquilinoCarga = new BEInquilino();
           
                inquilinoCarga.codigo = Convert.ToInt32(txtCodigo.Text);
                inquilinoCarga.apellido = Nombre(txtApellido);
                inquilinoCarga.nombre = Nombre(txtNombre);
                inquilinoCarga.localidad = (BELocalidad)cmbLocalidad.SelectedItem;
                inquilinoCarga.fechaNac = dateTimePicker1.Value;
                inquilinoCarga.activo = chActivo.Checked;
                inquilinoCarga.listadoAlquileresInquilino = ((BEInquilino)dataGridViewInquilinos.CurrentRow.DataBoundItem).listadoAlquileresInquilino;
                inquilinoCarga.dni = DNI();
                inquilinoCarga.direccion = txtdireccion.Text;
                inquilinoCarga.garantia = (BEGarantia)cmbGarantia.SelectedItem;

                return inquilinoCarga;
           
        }
      

        private void TextBoxCargas(BEInquilino inquilino)
        {

            txtApellido.Text = inquilino.apellido;
            txtNombre.Text = inquilino.nombre;
            txtCodigo.Text = (inquilino.codigo).ToString();
            txtdireccion.Text = (inquilino.localidad).ToString();
            dateTimePicker1.Value = inquilino.fechaNac;
            txtEdad.Text = inquilino.CalcuEdad().ToString();
            cmbLocalidad.Text = inquilino.localidad.nombreLoc;
            chActivo.Checked = inquilino.activo;
            txtDni.Text = (inquilino.dni).ToString();
            txtdireccion.Text =(inquilino.direccion).ToString();
            cmbGarantia.Text = inquilino.garantia.nombreGarantia;

        }

        private void CargarTablaAlquileresInquilino()

        {
            dataGridViewListaAlquileresInquilinos.DataSource = null;
            dataGridViewListaAlquileresInquilinos.DataSource = oBLLInquilino.TraerListarTodo();

        }

        
        private void checkCampos()
        {
        if(txtApellido.Text == "" || txtNombre.Text == "" || txtCodigo.Text == "" || txtdireccion.Text == "" ||  txtDni.Text == "" || cmbGarantia.SelectedItem == null || cmbLocalidad.SelectedItem == null )
            {
                throw new ExcepcionCamposVacios("No es posible continuar con la operacion, alguno de los campos se encuentra vacíos");
            }

           
                
        }

        #endregion

        #region Botones

        private void btnCargaInquilinos_Click(object sender, EventArgs e)
        {
            CargarTabla();
        }

        

        private void dataGridViewInquilinos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            dataGridViewListaAlquileresInquilinos.DataSource=null;
            dataGridViewListaAlquileresInquilinos.DataSource = ((BEInquilino)dataGridViewInquilinos.CurrentRow.DataBoundItem).listadoAlquileresInquilino;
            TextBoxCargas((BEInquilino)dataGridViewInquilinos.CurrentRow.DataBoundItem);
            dataGridViewListaAlquileresInquilinos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewListaAlquileresInquilinos.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
        }

        private void btbTesteo_Click(object sender, EventArgs e)
        {

           // TesteCone();
        }

        private void btbAlta_Click(object sender, EventArgs e)
        {
            try
            {
                checkCampos();
                oBLLInquilino.Guardar(InquilinCarga());
                CargarTabla();

            }catch(ExcepcionCamposVacios ex)
            {
                MessageBox.Show(ex.Message);

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            

        }

        private void label2_Click(object sender, EventArgs e)
        {
           
            

        }

        private void btnModificarInquilino_Click(object sender, EventArgs e)
        {
            try
            {
                checkCampos();
                oBLLInquilino.Guardar(InquilinCarga());
                CargarTabla();

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
            
            if (oBLLInquilino.Baja(InquilinCarga())== true)
            {
                MessageBox.Show("La Baja se ha realizado con éxito");
                CargarTabla();
            }
            else
            {
                MessageBox.Show("NO ha sido posible realizar la baja");
            }
            

        }

        private void dataGridViewListaAlquileresInquilinos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiar();
            
        }

        #endregion
    }
}
