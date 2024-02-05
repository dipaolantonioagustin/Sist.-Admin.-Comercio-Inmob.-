using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using Abstraccion;
using BE;
using DAL;

namespace Maper
{
    public class MPContrato : IOperacionesABM<BEContrato>
    {


        Conexion conec  = new Conexion();

        public bool Baja(BEContrato contrato)
        {
            Hashtable HDatos1 = new Hashtable();
            HDatos1.Add("@id_contrato", contrato.codigo);
            Hashtable HDatos2 = new Hashtable();
            HDatos2.Add("@id_propiedad", contrato.propiedad.codigo);

            string consulta1 = $"contrato_borrar";
            string consulta2 = $"alquiler_borrar";

            return conec.Transaccion(consulta1,HDatos1, consulta2, HDatos2);

        }

        public bool Guardar(BEContrato contrato)
        {
            Hashtable HDatos;
            Hashtable HDatos2;
            if (contrato.codigo > 0)
            {
                HDatos = new Hashtable();
                HDatos.Add("@id_inq", contrato.inquilino.codigo);
                HDatos.Add("@id_propiedad", contrato.propiedad.codigo);
                HDatos.Add("@fn", contrato.fechaInicio);
                HDatos.Add("@activo", contrato.activo);
                HDatos.Add("@valor", contrato.valor);
                HDatos.Add("@id_contrato", contrato.codigo);
                HDatos.Add("@cuenta", contrato.cuenta);

                HDatos2 = new Hashtable();
                HDatos2.Add("@id_inq", contrato.inquilino.codigo);
                HDatos2.Add("@id_propiedad", contrato.propiedad.codigo);

                string consulta1 = $"contrato_modificar";
                string consulta2 = $"alquiler_modificar";

                return conec.Transaccion(consulta1,HDatos, consulta2, HDatos2);

            }
            else
            {
                if (VerificarExistenciaPropiedadAlquiler(contrato) == false)
                {
                   
                    HDatos = new Hashtable();
                    HDatos.Add("@id_inq", contrato.inquilino.codigo);
                    HDatos.Add("@id_propiedad", contrato.propiedad.codigo);
                    HDatos.Add("@fn", contrato.fechaInicio);
                    HDatos.Add("@activo", contrato.activo);
                    HDatos.Add("@valor", contrato.valor);
                    HDatos.Add("@cuenta", contrato.cuenta);

                HDatos2 = new Hashtable();
                    HDatos2.Add("@id_inq", contrato.inquilino.codigo);
                    HDatos2.Add("@id_propiedad", contrato.propiedad.codigo);

                    string consulta1 = $"contrato_insertar ";
                    string consulta2 = $"alquiler_insertar  ";

                    return conec.Transaccion(consulta1, HDatos, consulta2, HDatos2);

                }
                else
                {
                    return false;
                }

            }
        }


        private bool VerificarExistenciaPropiedadAlquiler(BEContrato contrato)
        {
           Hashtable HDatos = new Hashtable();
           HDatos.Add("@id_inq", contrato.inquilino.codigo);
           HDatos.Add("@id_prop", contrato.propiedad.codigo);
            string consulta = $"alquiler_seleccionar";

            return conec.LecturaEscalar(consulta, HDatos);
        }

        public List<BEContrato> TraerListaTodo()
        {
            List<BEContrato> listadoContratosResultado = new List<BEContrato>();

            DataSet resultado = new DataSet();
            string consulta = "contrato_traer_todo";
            resultado = conec.Lectura(consulta, null);

            if (resultado.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow registro in resultado.Tables[0].Rows)
                {
                    float saldoCuenta = (float)(Convert.ToDouble(registro["cuenta"]));
                    BEContrato oBEContratoCarga = new BEContrato(saldoCuenta);

                    oBEContratoCarga.codigo = Convert.ToInt32(registro["id_contrato"]);
                    oBEContratoCarga.fechaInicio = (DateTime)(registro["fecha_inicio"]);
                    oBEContratoCarga.valor = Convert.ToInt32(registro["valor"]);
                    oBEContratoCarga.activo = (bool)(registro["activo"]);
               
                    #region inquilinoCarga
                    BEInquilino oBEInquilinoCarga = new BEInquilino();

                    oBEInquilinoCarga.codigo = Convert.ToInt32(registro["id_cliente"]);
                    oBEInquilinoCarga.nombre = registro["inquilinoNombre"].ToString();
                    oBEInquilinoCarga.apellido = registro["inquilinoApellido"].ToString();

                    oBEContratoCarga.inquilino = oBEInquilinoCarga;
                    #endregion

                    #region PropietarioCarga

                    int IdProp =Convert.ToInt32(registro["propietarioId"]);

                    string consulta2 = "cliente_seleccionar";
                    Hashtable HDatos = new Hashtable();
                    HDatos.Add("@id_cliente",IdProp);
                    DataSet resultado2 = conec.Lectura(consulta2, HDatos);

                    foreach (DataRow registro2 in resultado2.Tables[0].Rows)
                    {
                        if (registro2["id_garantia"].ToString() == "")
                        {
                            BEPropietario oBEPropietarioCarga = new BEPropietario();

                            oBEPropietarioCarga.codigo = Convert.ToInt32(registro2["id_cliente"]);
                            oBEPropietarioCarga.nombre = registro2["nombre"].ToString();
                            oBEPropietarioCarga.apellido = registro2["apellido"].ToString();

                            oBEContratoCarga.propietario = oBEPropietarioCarga;
                        }
                    }
                    #endregion
                    
                    #region PropiedadCarga

                    BEPropiedad oBEPropiedadCarga = new BEPropiedad();

                    oBEPropiedadCarga.codigo = Convert.ToInt32(registro["id_propiedad"]);
                    oBEPropiedadCarga.direccion = (registro["direccion"]).ToString();
                    oBEPropiedadCarga.cantidadAmbiente = Convert.ToInt32(registro["cantidad_ambientes"]);
                   
                    #region FormatoCarga
                    BEFormato oBEtipoCarga = new BEFormato();

                    oBEtipoCarga.codigo = Convert.ToInt32(registro["id_formato"]);
                    oBEtipoCarga.tipoNombre = (registro["formato_nombre"]).ToString();

                    oBEPropiedadCarga.formato = oBEtipoCarga;

                    #endregion

                    oBEContratoCarga.propiedad = oBEPropiedadCarga;

                    #endregion

                    listadoContratosResultado.Add(oBEContratoCarga);
                }


            }
                return listadoContratosResultado;

        }
    }
}
