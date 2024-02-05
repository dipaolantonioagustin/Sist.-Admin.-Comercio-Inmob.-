using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using Abstraccion;
using DAL;
using System.Data;
using System.Net;
using System.Security.Policy;
using System.Net.Configuration;
using System.Collections;

namespace Maper
{
    public class MPPropietario : MPClient, IOperacionesABM<BEPropietario>
    {
        Conexion  conec;
        public bool Baja(BEPropietario propietario)
        {
            if (ExistenciaPropietarioDominio(propietario) == false)
            {
                Hashtable HDatos = new Hashtable();
                HDatos.Add("@id_cliente", propietario.codigo);
                conec = new Conexion();
                string consulta = $"cliente_propietario_borrar";
                return conec.Escribir(consulta, HDatos);
            }
            else { return false; }
        }

        public bool ExistenciaPropietarioDominio(BEPropietario propietario)
        {
            Hashtable HDatos = new Hashtable();
            HDatos.Add("@id_cliente", propietario.codigo);
            conec = new Conexion();
            string consulta = $"cliente_propietario_seleccionar_propiedades_dominio";
            return conec.LecturaEscalar(consulta,HDatos);

        }

        public bool Guardar(BEPropietario propietario)
        {
            conec = new Conexion();

            String consulta = null;
            Hashtable HDatos;
            if (propietario.codigo > 0)
            {
                HDatos = new Hashtable();
                HDatos.Add("@id_cliente",propietario.codigo);
                HDatos.Add("@nom", propietario.nombre);
                HDatos.Add("@ape", propietario.apellido);
                HDatos.Add("@fn", propietario.fechaNac);//Revisar si es que hay que adapter tema de formatos.
                HDatos.Add("@id_loc", propietario.localidad.codigo);
                HDatos.Add("@activo", propietario.activo);
                HDatos.Add("@dir", propietario.direccion);
                HDatos.Add("@dni", propietario.dni);

                consulta = $"cliente_propietario_modificar";
            }
            else
            {
                HDatos = new Hashtable();
                HDatos.Add("@nom", propietario.nombre);
                HDatos.Add("@ape", propietario.apellido);
                HDatos.Add("@fn", propietario.fechaNac);//Revisar si es que hay que adapter tema de formatos.
                HDatos.Add("@id_loc", propietario.localidad.codigo);
                HDatos.Add("@activo", propietario.activo);
                HDatos.Add("@dir", propietario.direccion);
                HDatos.Add("@dni", propietario.dni);

                consulta = $"cliente_propietario_insertar";
            }

            return conec.Escribir(consulta,HDatos);
        }

        public List<BEPropietario> TraerListaTodo()
        {
            List<BEPropietario> oBEListaPropietariosResultado = new List<BEPropietario>();  

            Conexion conec = new Conexion();
            string consulta = "propietario_traer_todo";

            DataSet resultado = new DataSet();

            resultado = conec.Lectura(consulta, null);

            foreach (DataRow registro in resultado.Tables[0].Rows)
            {
                if (registro["id_garantia"].ToString() == "")
                {
                    BEPropietario oBEPropietarioCarga = new BEPropietario();

                    oBEPropietarioCarga.codigo = Convert.ToInt32(registro["id_cliente"]);
                    oBEPropietarioCarga.nombre = (registro["nombre"]).ToString();
                    oBEPropietarioCarga.apellido = (registro["apellido"]).ToString();
                    oBEPropietarioCarga.dni = Convert.ToInt32(registro["dni"]);
                    oBEPropietarioCarga.fechaNac = (DateTime)(registro["fecha_nacimiento"]);
                    oBEPropietarioCarga.direccion = (registro["direccion"]).ToString();
                    oBEPropietarioCarga.edad = oBEPropietarioCarga.CalcuEdad();
                    oBEPropietarioCarga.activo = (bool)(registro["activo"]);

                    #region LocalidadCarga
                    BELocalidad oBELocalidadCarga = new BELocalidad();

                    oBELocalidadCarga.codigo = Convert.ToInt32(registro["id_localidad"]);
                    oBELocalidadCarga.nombreLoc = registro["LocalidadNombre"].ToString();

                    oBEPropietarioCarga.localidad = oBELocalidadCarga;

                    #endregion

                    #region PropiedadesCarga
                    // string consulta2 = $"select propiedad.* from propiedad, dominio where dominio.id_propiedad = propiedad.id_propiedad and dominio.id_propietario =  {oBEPropietarioCarga.codigo.ToString()} ";
                    string consulta2 = $"propietario_traer_todas_sus_propiedades ";
                    Hashtable HDatos = new Hashtable();
                    HDatos.Add("@id_cliente", oBEPropietarioCarga.codigo);

                    DataSet resultado2 = new DataSet();

                    resultado2 = conec.Lectura(consulta2,HDatos);

                    if (resultado2.Tables[0].Rows.Count > 0)
                    {
                        List<BEPropiedad> oBEListaPropiedadesCarga = new List<BEPropiedad>();

                        foreach (DataRow registro2 in resultado2.Tables[0].Rows)
                        {

                            BEPropiedad oBEPropiedadCarga = new BEPropiedad();

                            oBEPropiedadCarga.codigo = Convert.ToInt32(registro2["id_propiedad"]);
                            oBEPropiedadCarga.direccion = (registro2["direccion"]).ToString();
                            oBEPropiedadCarga.disponible = (bool)(registro2["disponible"]);
                            oBEPropiedadCarga.cantidadAmbiente = Convert.ToInt32(registro2["cantidad_ambientes"]);

                            BEFormato oBETipoCarga = new BEFormato();
                            oBETipoCarga.codigo = Convert.ToInt32(registro2["id_formato"]);
                            oBETipoCarga.tipoNombre = (registro2["formato_nombre"]).ToString();

                            oBEPropiedadCarga.formato = oBETipoCarga;

                            BELocalidad oBELocalidadCarga2 = new BELocalidad();
                            oBELocalidadCarga2.nombreLoc = (registro2["nom_loc"]).ToString();
                            oBELocalidadCarga2.codigo = Convert.ToInt32(registro2["id_localidad"]);

                            oBEPropiedadCarga.localidad = oBELocalidadCarga2;



                            oBEListaPropiedadesCarga.Add(oBEPropiedadCarga);

                        }

                        oBEPropietarioCarga.propiedadesPropietario = oBEListaPropiedadesCarga;



                    }
                    #endregion

                    oBEListaPropietariosResultado.Add(oBEPropietarioCarga);

                }
            }

            return oBEListaPropietariosResultado;
        }

        //Esto tambien se va a la BLL ( si o si )
        public override BEOperacion Operar(BEContrato contrato, float importe)
        {
            BEOperacion operacion = new BEOperacion();
            if (contrato.cuenta > 0 && importe <= contrato.cuenta)
            {
                contrato.cuenta -= importe;
                
                operacion.fechaOperacion = DateTime.Now;
                operacion.importe = -importe;
                operacion.idContrato = contrato.codigo;

                return operacion;
            }
            else
            {
                return null;
            }
        
        }

        


    }
    }

