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
using System.Windows.Forms.DataVisualization.Charting;


namespace UI
{
    public partial class FRReporte1 : Form
    {
        public FRReporte1()
        {
            InitializeComponent();
        }

        private void FRReporte1_Load(object sender, EventArgs e)
        {
           
            this.reportViewer1.RefreshReport();
            CargaChart();
        }

       
        private void reportViewer1_Load(object sender, EventArgs e)
        {
            oBLLFormato = new BLLFormato();
            oBLLProp = new BLLPropiedadReporte();
            CargarReporte();
            CargaCombo();
            CargaComboFormato();
            LimpiarCombos();

        }
       

        BLLPropiedadReporte oBLLProp;
        BLLFormato oBLLFormato;
        private List<int> cantAmb = new List<int>{1,2,3,4 };
        

        #region Cargas Combos
        private void CargaCombo()
        {
            cmbCantAmb.DataSource = null;
            cmbCantAmb.DataSource = cantAmb;
        }
        private void CargaComboFormato()
        {
            cmbFormato.DataSource = null;
            cmbFormato.DataSource = oBLLFormato.TraerListaTodo();
            cmbFormato.DisplayMember = "tipoNombre";
            cmbFormato.ValueMember = "codigo";
        }

        private void LimpiarCombos()
        {
            cmbFormato.Text = string.Empty;
            cmbCantAmb.Text = string.Empty;
        }
        #endregion

        #region Filtros

        private void AplicarFiltro()
        {
            List<BEPropiedadReporte> resultadoDisponibles;
            List<BEPropiedadReporte> LProp = oBLLProp.TraerListaTodo().ToList();


            if (chCantAmb.Checked == true && chFormato.Checked == false)
            {
                int cantAmb = (int)cmbCantAmb.SelectedItem;
                resultadoDisponibles = (from prop in LProp where (prop.disponible == true && prop.cantidadAmbiente == cantAmb) select prop).ToList();
                CargaGenerica(resultadoDisponibles);
           

            }
            else if(chCantAmb.Checked == true && chFormato.Checked == true)
            {
                int cantAmb = (int)cmbCantAmb.SelectedItem;
                BEFormato formato = (BEFormato)cmbFormato.SelectedItem;
                resultadoDisponibles = (from prop in LProp where (prop.disponible == true && prop.cantidadAmbiente == cantAmb && prop.codForma == formato.codigo) select prop).ToList();
                CargaGenerica(resultadoDisponibles);

                       
            }else if(chCantAmb.Checked == false && chFormato.Checked == true)
            {
             
                BEFormato formato = (BEFormato)cmbFormato.SelectedItem;
                resultadoDisponibles = (from prop in LProp where (prop.disponible == true && prop.codForma == formato.codigo) select prop).ToList();
                CargaGenerica(resultadoDisponibles);
               
                            
           
            }else if(chCantAmb.Checked == false && chFormato.Checked == false)
            {
                CargarReporte();
            }

          

        }
        private void CargaGenerica(List<BEPropiedadReporte> listadoPropiedades)
        {
            this.reportViewer1.LocalReport.DataSources[0].Value = null;
            this.reportViewer1.LocalReport.DataSources[0].Value = listadoPropiedades;
            this.reportViewer1.RefreshReport();
        }
        private void CargarReporte()
        {
            List<BEPropiedadReporte> LProp = oBLLProp.TraerListaTodo().ToList();

            List<BEPropiedadReporte> resultadoDisponibles = (from prop in LProp where (prop.disponible == true) select prop).ToList();
           
            this.reportViewer1.LocalReport.DataSources[0].Value = null;
            this.reportViewer1.LocalReport.DataSources[0].Value = resultadoDisponibles;
            this.reportViewer1.RefreshReport();
        }

        #endregion

        #region Botones
        private void btnAplicar_Click(object sender, EventArgs e)
        {
            AplicarFiltro();
        }

       

      
        private void btnMostrarTodas_Click(object sender, EventArgs e)
        {
            CargarReporte();
        }


        #endregion

        #region Chart

        private void CargaChart()
        {
            List<BEPropiedadReporte> LProp = oBLLProp.TraerListaTodo().ToList();
            List<BEPropiedadReporte> resultadoDisponibles = (from prop in LProp where (prop.disponible == true) select prop).ToList();
            int ambMax = resultadoDisponibles.Max(x => x.cantidadAmbiente);

            Dictionary<int,int> dispoAmb = new Dictionary<int,int>();

           for(int i = 1; i <= ambMax; i++)
            {
                dispoAmb.Add(i, LProp.Count(x =>x.cantidadAmbiente == i));
            }


            
            chartPropDispo.Titles.Clear();
            chartPropDispo.ChartAreas.Clear();
            chartPropDispo.Series.Clear();

        
            Title Titulo = new Title("Porp. Disp. Por Cant. Amb.");
            Titulo.Font = new Font("Tahoma", 16, FontStyle.Bold);
            chartPropDispo.Titles.Add(Titulo);

            
            ChartArea Area = new ChartArea();
    
            chartPropDispo.ChartAreas.Add(Area);
           

      
            Series serie = new Series("Disponibles por Cantidad Ambientes");
            serie.ChartType = SeriesChartType.Column;
            serie.Points.DataBindXY(dispoAmb.Keys , dispoAmb.Values);

            

            chartPropDispo.Series.Add(serie);

            chartPropDispo.Series[0].XValueMember = "Cant. Amb.";
            chartPropDispo.Series[0].YValueMembers = "Cant Dispo.";



        }











        #endregion

    }

}
