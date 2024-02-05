using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstraccion;
using BE;
using DAL;

namespace Maper
{
    public class MPLocalidad : IOperacionesABM<BELocalidad>
    {
        public bool Baja(BELocalidad Objeto)
        {
            throw new NotImplementedException();
        }

        public bool Guardar(BELocalidad localidad)
        {
            string consulta;
            Conexion conec = new Conexion();
            Hashtable HDatos;
            if(localidad.codigo != 0)
            {
                HDatos = new Hashtable();
                HDatos.Add("@loc_nom", localidad.nombreLoc);
                HDatos.Add("@id_loc", localidad.codigo);
                consulta = $"localidades_modificar";
            }
            else
            {
                HDatos = new Hashtable();
                HDatos.Add("@loc_nom", localidad.nombreLoc);
                consulta = $"localidades_insertar";
            }

            return conec.Escribir(consulta, HDatos);
            
        }


        public List<BELocalidad> TraerListaTodo()
        {
            List<BELocalidad> ListadoLocalidadesResultado = new List<BELocalidad>();
            string consulta = "localidades_traer_todo";
            Conexion conec = new Conexion();
            DataSet resultado = conec.Lectura(consulta, null);

            if (resultado.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow registro in resultado.Tables[0].Rows)
                {
                    BELocalidad oBELocalidadCarga = new BELocalidad();

                    oBELocalidadCarga.codigo = Convert.ToInt32(registro["id_localidad"]);
                    oBELocalidadCarga.nombreLoc = registro["nombre"].ToString();

                    ListadoLocalidadesResultado.Add(oBELocalidadCarga);

                }

            }

            return ListadoLocalidadesResultado;


        }
    }
}
