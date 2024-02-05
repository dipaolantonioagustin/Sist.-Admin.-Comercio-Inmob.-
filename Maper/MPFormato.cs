 using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using Abstraccion;
using BE;
using DAL;

namespace Maper
{
    public class MPFormato : IOperacionesABM<BEFormato>
    {
        Conexion conec = new Conexion();
        public bool Baja(BEFormato Objeto)
        {
            throw new NotImplementedException();
        }

        public bool Guardar(BEFormato Objeto)
        {
            throw new NotImplementedException();
        }

        public List<BEFormato> TraerListaTodo()
        {
          DataSet resultado = new DataSet();
          string consulta = "formato_traer_todo";
            List<BEFormato> ListadoTipo = new List<BEFormato>();


            resultado = conec.Lectura(consulta, null);
            if (resultado.Tables[0].Rows.Count > 0)
            {
                foreach  (DataRow registro in resultado.Tables[0].Rows)
                {
                    BEFormato oBETipoCarga = new BEFormato();

                    oBETipoCarga.codigo = Convert.ToInt32(registro["id_formato"]);
                    oBETipoCarga.tipoNombre = (registro["formato_nombre"]).ToString();

                    ListadoTipo.Add(oBETipoCarga);
                }

               
            }

            return ListadoTipo;


        }
    }
}
