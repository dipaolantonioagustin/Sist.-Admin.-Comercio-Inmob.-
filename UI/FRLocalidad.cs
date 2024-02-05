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
using BE;

namespace UI
{
    public partial class FRLocalidad : Form
    {
        public FRLocalidad()
        {
            InitializeComponent();
        }

        private void FRLocalidad_Load(object sender, EventArgs e)
        {
            oBLLLocalidad = new BLLLocalidades();
            oBELocalidad = new BELocalidad();

            CargarDataGridLocalidad();


            cmbLocalidades.DataSource = (oBLLLocalidad.TraerListaTodo()).ToArray();
            cmbLocalidades.DisplayMember = "nombreLoc";
            cmbLocalidades.ValueMember = "codigo";
        }


        BLLLocalidades oBLLLocalidad;
        BELocalidad oBELocalidad;


        #region Metodos
        private void CargarDataGridLocalidad()
        {
            dataGridViewLocalidades.DataSource = null;
            dataGridViewLocalidades.DataSource = oBLLLocalidad.TraerListaTodo();
            dataGridViewLocalidades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewLocalidades.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
        }
        private void CargarTextBox(BELocalidad localidad)
        {
            txtLocCod.Text = (localidad.codigo).ToString();
            txtLocNom.Text = (localidad.nombreLoc);
            cmbLocalidades.Text = localidad.nombreLoc.ToString();

        }

        private BELocalidad CargarObjeto()
        {   
            BELocalidad localidad = new BELocalidad();

            localidad.nombreLoc = txtLocNom.Text;
            localidad.codigo = Convert.ToInt32(txtLocCod.Text);

            return localidad;

        }

        private void LimpiarCampos()
        {
            txtLocCod.Text = "0";
            txtLocNom.Text = String.Empty;
        }

        private void checkCampos()
        {
            if(txtLocCod.Text == "" || txtLocCod.Text == "")
            {
                throw new ExcepcionCamposVacios("No es posible continuar con la operacion, alguno de los campos se encuentran vacíos");
            }
        }


        #endregion

        #region Botones
        private void dataGridViewLocalidades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CargarTextBox((BELocalidad)dataGridViewLocalidades.CurrentRow.DataBoundItem);
        }

        private void cmbLocalidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarTextBox((BELocalidad)cmbLocalidades.SelectedItem);
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            try 
            {   
                checkCampos();
                oBLLLocalidad.Guardar(CargarObjeto());
                LimpiarCampos();
                CargarDataGridLocalidad();

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
                oBLLLocalidad.Guardar(CargarObjeto());
                LimpiarCampos();
                CargarDataGridLocalidad();

            }
            catch (ExcepcionCamposVacios ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            
        }

        #endregion
    }
}
