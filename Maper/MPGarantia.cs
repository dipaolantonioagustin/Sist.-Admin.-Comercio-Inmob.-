using Abstraccion;
using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maper
{
    public class MPGarantia : IOperacionesABM<BEGarantia>
    {
        public bool Baja(BEGarantia Objeto)
        {
            throw new NotImplementedException();
        }

        public bool Guardar(BEGarantia Objeto)
        {
            throw new NotImplementedException();
        }

        public List<BEGarantia> TraerListaTodo()
        {
           
            List<BEGarantia> ListadoResultado = new List<BEGarantia>();
            
            string consulta = "garantia_traer_todo";
            Conexion conec = new Conexion();
            DataSet resultado = conec.Lectura(consulta, null);

            if (resultado.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow registro in resultado.Tables[0].Rows)
                {
                    BEGarantia oBEGarantiaCarga = new BEGarantia();

                    oBEGarantiaCarga.codigo = Convert.ToInt32(registro["id_garantia"]);
                    oBEGarantiaCarga.nombreGarantia = registro["nombre_garantia"].ToString();

                    ListadoResultado.Add(oBEGarantiaCarga);

                }

            }

            return ListadoResultado;
        }
    }
}
