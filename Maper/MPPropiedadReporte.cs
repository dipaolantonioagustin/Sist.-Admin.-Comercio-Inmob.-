using Abstraccion;
using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Maper
{
    public  class MPPropiedadReporte : IOperacionesABM<BEPropiedadReporte>
    {
        Conexion conec = new Conexion();

        public bool Baja(BEPropiedadReporte Objeto)
        {
            throw new NotImplementedException();
        }

        public bool Guardar(BEPropiedadReporte Objeto)
        {
            throw new NotImplementedException();
        }

        public List<BEPropiedadReporte> TraerListaTodo()
        {
            conec = new Conexion();
            List<BEPropiedadReporte> ListaPropiedades = new List<BEPropiedadReporte>();

            string consulta = "propiedad_traer_todo_completo";

            DataSet resultado = new DataSet();

            resultado = conec.Lectura(consulta, null);

            if (resultado.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow registro in resultado.Tables[0].Rows)
                {
                    BEPropiedadReporte oBEPropiedadCarga = new BEPropiedadReporte();

                    oBEPropiedadCarga.codigo = Convert.ToInt32(registro["id_propiedad"]);
                    oBEPropiedadCarga.direccion = (registro["direccion"]).ToString();
                    oBEPropiedadCarga.disponible = Convert.ToBoolean(registro["disponible"]);
                    oBEPropiedadCarga.cantidadAmbiente = Convert.ToInt32(registro["cantidad_ambientes"]);

                    #region LocalidadCarga


                    oBEPropiedadCarga.codLoc = Convert.ToInt32(registro["id_localidad"]);
                    oBEPropiedadCarga.loc = (registro["Nombre_Localidad"]).ToString();


                    #endregion

                    #region PropietarioCarga

                    #endregion

                    #region TipoCarga

                    oBEPropiedadCarga.codForma = Convert.ToInt32(registro["id_formato"]);
                    oBEPropiedadCarga.forma = (registro["Nombre_formato"]).ToString();

                    #endregion



                    ListaPropiedades.Add(oBEPropiedadCarga);

                }


            }

            return ListaPropiedades;
        }
    }
}
