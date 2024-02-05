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
    public partial class FRReporte2 : Form
    {
        public FRReporte2()
        {
            InitializeComponent();
        }

        private void FRReporte2_Load(object sender, EventArgs e)
        {
            oBLLCaja = new BLLCaja();
            this.reportViewer1.RefreshReport();
            CargaGenerica(CargaReporte());
        }

        BLLCaja oBLLCaja;

        private List<BEOperacion> CargaReporte()
        {
            List<BEOperacion> lista = new List<BEOperacion>();
            lista = (oBLLCaja.TraerListaTodo()).OrderByDescending(x => x.fechaOperacion).ToList();
            return lista;
            
        }

        private void CargaGenerica(List<BEOperacion> listado)
        {
            reportViewer1.LocalReport.DataSources[0].Value = null;
            reportViewer1.LocalReport.DataSources[0].Value =listado;
            this.reportViewer1.RefreshReport();
        }
        private List<BEOperacion> FiltrarFecha()
        {
            List<BEOperacion> resultado;
            List<BEOperacion> lista = oBLLCaja.TraerListaTodo();
            DateTime fecha = dateTimePicker1.Value;
            resultado = (from op in lista where op.fechaOperacion.Date == fecha.Date select op).ToList();

           return resultado;


        }

        private List<BEOperacion> FiltrarFechaEntreDias()
        {
            List<BEOperacion> resultado;
            List<BEOperacion> lista = oBLLCaja.TraerListaTodo();
           
            DateTime fecha1 = dateTimePicker2.Value;
            DateTime fecha2 = dateTimePicker3.Value;

            resultado = (from op in lista where op.fechaOperacion.Date >= fecha1.Date && op.fechaOperacion.Date <= fecha2.Date select op).ToList();

            List<BEOperacion> listaOrdenada =  resultado.OrderByDescending(x => x.fechaOperacion).ToList();

            return listaOrdenada;

        }


        private void button1_Click(object sender, EventArgs e)
        {
            if(chDia.Checked == true && chED.Checked == false) 
            {
               CargaGenerica(FiltrarFecha());

            }else if(chDia.Checked == false && chED.Checked == true)
            {
                CargaGenerica(FiltrarFechaEntreDias());

            }else if((chDia.Checked == true && chED.Checked == true) ||(chDia.Checked == false && chED.Checked == false)) 
            {
                MessageBox.Show("Error de Selección de filtros, de elegir sólo una de opción ");
            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CargaGenerica(CargaReporte());
        }
    }
}
