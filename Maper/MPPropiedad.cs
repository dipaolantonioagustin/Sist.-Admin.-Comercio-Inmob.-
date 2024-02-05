using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Abstraccion;
using BE;
using DAL;


namespace Maper
{
    public class MPPropiedad : IOperacionesABM<BEPropiedad>
    {
        Conexion conec;

        public bool Baja(BEPropiedad propiedad)
        {   
            
                Hashtable HDatos1 = new Hashtable();
                HDatos1.Add("@id_propiedad", propiedad.codigo);

                
                conec = new Conexion();

                string consulta1 = $"dominio_borrado"; 
                string consulta2 = $"propiedad_borrado";

            return conec.Transaccion(consulta1, HDatos1,consulta2, HDatos1);
          
        }

        public bool Guardar1(BEPropiedad propiedad, BEPropietario propietario)
        {
            conec = new Conexion();

            Hashtable HDatos1 = new Hashtable();

            HDatos1.Add("@dir", propiedad.direccion);
            HDatos1.Add("@id_loc ", propiedad.localidad.codigo);
            HDatos1.Add("@id_for", propiedad.formato.codigo);
            HDatos1.Add("@cant_amb", propiedad.cantidadAmbiente);
            HDatos1.Add("@dispo", propiedad.disponible);
            //HDatos1.Add("@id_propietario", propiedad.propietario);
            HDatos1.Add("@id_propiedad", propiedad.codigo);


            Hashtable HDatos2 = new Hashtable();

            HDatos2.Add("@id_propietario", propietario.codigo);
            HDatos2.Add("@id_propiedad", propiedad.codigo);


            Hashtable HDatos3 = new Hashtable();

            HDatos3.Add("@dir", propiedad.direccion);
            HDatos3.Add("@id_loc ", propiedad.localidad.codigo);
            HDatos3.Add("@id_for", propiedad.formato.codigo);
            HDatos3.Add("@cant_amb", propiedad.cantidadAmbiente);
            HDatos3.Add("@dispo", propiedad.disponible);
           // HDatos3.Add("@id_propietario", propiedad.propietario);


            String consulta1 = null;
            String consulta2 = null;

            if (propiedad.codigo > 0) // guardar quiere decir modificar en este caso y esta seccion es para modificar
            {
                consulta1 = $"propiedad_guardar";
                consulta2 = $"dominio_guardar";

                return conec.Transaccion(consulta1, HDatos1, consulta2, HDatos2);
            }
            else
            {
                consulta1 = $"insertar_propiedad";
                
                conec.Escribir(consulta1, HDatos3);
              
                #region Obtener Codigo Nuevo

                DataSet resultado = conec.Lectura("propiedad_obtener_codigo", null);
                
                int codigoNuevo = 0;
                
                foreach (DataRow registro in resultado.Tables[0].Rows)
                {
                    codigoNuevo =Convert.ToInt32(registro[0]);
                }

                #endregion
                Hashtable HDatos4 = new Hashtable();

                HDatos4.Add("@id_propietario", propietario.codigo);
                HDatos4.Add("@id_propiedad", codigoNuevo);

                consulta2 = $"dominio_insertar";

                return conec.Escribir(consulta2,HDatos4);
            }

            
        }

         public bool Guardar(BEPropiedad Objeto)
        {
           throw new NotImplementedException();
        }

        public List<BEPropiedad> TraerListaTodo()
        {
            conec = new Conexion();
            List<BEPropiedad> ListaPropiedades = new List<BEPropiedad>();

            string consulta = "propiedad_traer_todo_completo";

            DataSet resultado = new DataSet();

            resultado = conec.Lectura(consulta, null);

            if (resultado.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow registro in resultado.Tables[0].Rows)
                {
                    BEPropiedad oBEPropiedadCarga = new BEPropiedad();

                    oBEPropiedadCarga.codigo = Convert.ToInt32(registro["id_propiedad"]);
                    oBEPropiedadCarga.direccion = (registro["direccion"]).ToString();
                    oBEPropiedadCarga.disponible = Convert.ToBoolean(registro["disponible"]);
                    oBEPropiedadCarga.cantidadAmbiente = Convert.ToInt32(registro["cantidad_ambientes"]);

                    #region LocalidadCarga
                    BELocalidad oBELocalidadCarga = new BELocalidad();

                    oBELocalidadCarga.codigo = Convert.ToInt32(registro["id_localidad"]);
                    oBELocalidadCarga.nombreLoc = (registro["Nombre_Localidad"]).ToString();

                    oBEPropiedadCarga.localidad = oBELocalidadCarga;
                    #endregion

                    #region PropietarioCarga
                    
                    #endregion

                    #region TipoCarga
                    BEFormato oBETipoCarga = new BEFormato();

                    oBETipoCarga.codigo = Convert.ToInt32(registro["id_formato"]);
                    oBETipoCarga.tipoNombre = (registro["Nombre_formato"]).ToString();

                    oBEPropiedadCarga.formato = oBETipoCarga;
                    #endregion

                    

                    ListaPropiedades.Add(oBEPropiedadCarga);

                }

                
            }

            return ListaPropiedades;

        }

        public List<BEPropiedad> TraerListaSoloDisponibles()
        {
            conec = new Conexion();
            List<BEPropiedad> ListaPropiedades = new List<BEPropiedad>();

            string consulta = "traer_todo_completo_disponible";

            DataSet resultado = new DataSet();

            resultado = conec.Lectura(consulta, null);

            if (resultado.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow registro in resultado.Tables[0].Rows)
                {
                    BEPropiedad oBEPropiedadCarga = new BEPropiedad();

                    oBEPropiedadCarga.codigo = Convert.ToInt32(registro["id_propiedad"]);
                    oBEPropiedadCarga.direccion = (registro["direccion"]).ToString();
                    oBEPropiedadCarga.disponible = Convert.ToBoolean(registro["disponible"]);
                    oBEPropiedadCarga.cantidadAmbiente = Convert.ToInt32(registro["cantidad_ambientes"]);

                    #region LocalidadCarga
                    BELocalidad oBELocalidadCarga = new BELocalidad();

                    oBELocalidadCarga.codigo = Convert.ToInt32(registro["id_localidad"]);
                    oBELocalidadCarga.nombreLoc = (registro["Nombre_Localidad"]).ToString();

                    oBEPropiedadCarga.localidad = oBELocalidadCarga;
                    #endregion

                    #region PropietarioCarga

                    #endregion

                    #region TipoCarga
                    BEFormato oBETipoCarga = new BEFormato();

                    oBETipoCarga.codigo = Convert.ToInt32(registro["id_formato"]);
                    oBETipoCarga.tipoNombre = (registro["Nombre_formato"]).ToString();

                    oBEPropiedadCarga.formato = oBETipoCarga;
                    #endregion



                    ListaPropiedades.Add(oBEPropiedadCarga);

                }


            }

            return ListaPropiedades;

        }

        public bool CambiarDisponibilidad(BEPropiedad propiedad)
        {
            Conexion conec = new Conexion();

            Hashtable HDatos = new Hashtable();
            HDatos.Add("@dispo", propiedad.disponible);
            HDatos.Add("@id_prop", propiedad.codigo);

            string consulta = $"propiedad_cambio_habilitacion";

            return conec.Escribir(consulta, HDatos);

        }
        public bool VerificarAsociadoInquilino(BEPropiedad propiedad)
        {
            Conexion conec = new Conexion();

            Hashtable HDatos = new Hashtable();
            HDatos.Add("@id_propiedad", propiedad.codigo);
        
            string consulta = $"alquiler_inquilino_asociado_bool";

            return conec.LecturaEscalar(consulta, HDatos);

        }


    }
}
