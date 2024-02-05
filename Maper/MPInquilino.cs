using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstraccion;
using System.ComponentModel;
using System.Collections;
using System.Net;

namespace Maper
{
    public  class MPInquilino : MPClient , IOperacionesABM<BEInquilino>
    {
        Conexion conec;

        public  bool Baja(BEInquilino inquilino)
        {
            if(ExistenciaInquilino(inquilino) == true )
            {
                    conec = new Conexion();

                    Hashtable HDatos = new Hashtable();
                    HDatos.Add("@id_cliente", inquilino.codigo);

                    string consulta = $"cliente_borrar";
                    return conec.Escribir(consulta, HDatos);
                
            }
            else { return false; }
           
        }

        public bool ExistenciaInquilino(BEInquilino inquilino)
        {

            conec = new Conexion();
            Hashtable HDatos = new Hashtable();
            HDatos.Add("@id_cliente", inquilino.codigo);
            string consulta = $"cliente_seleccionar";
            return conec.LecturaEscalar(consulta, HDatos); 

        }

        public bool Guardar(BEInquilino inquilino)
        {
            
            conec = new Conexion();

            String consulta = null;
            Hashtable HDatos;

            if (inquilino.codigo > 0)

            {
                HDatos = new Hashtable();
                HDatos.Add("@id_cliente", inquilino.codigo);
                HDatos.Add("@nom", inquilino.nombre);
                HDatos.Add("@ape", inquilino.apellido);
                HDatos.Add("@fn", inquilino.fechaNac);
                HDatos.Add("@id_loc", inquilino.localidad.codigo);
                HDatos.Add("@activo", inquilino.activo);
                HDatos.Add("@dir", inquilino.direccion);
                HDatos.Add("@dni", inquilino.dni);
                HDatos.Add("@garan", inquilino.garantia.codigo);

                consulta = $"cliente_inquilino_modificar";

            }
            else
            {
                HDatos = new Hashtable();                
                HDatos.Add("@nom", inquilino.nombre);
                HDatos.Add("@ape", inquilino.apellido);
                HDatos.Add("@fn", inquilino.fechaNac);
                HDatos.Add("@id_loc", inquilino.localidad.codigo);
                HDatos.Add("@activo", inquilino.activo);
                HDatos.Add("@dir", inquilino.direccion);
                HDatos.Add("@dni", inquilino.dni);
                HDatos.Add("@garan", inquilino.garantia.codigo);

                consulta = $"cliente_inquilino_insertar";

               
            }

            return conec.Escribir(consulta, HDatos);

        }

        public  List<BEInquilino> TraerListaTodo()
        {
            List<BEInquilino> ListadoInquilinosResultado = new List<BEInquilino>();
            string consulta = "cliente_traer_todo";
            conec = new Conexion();
            DataSet resultado = conec.Lectura(consulta, null);  


            if (resultado.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow registro in resultado.Tables[0].Rows)
                {
                    if (registro["id_garantia"].ToString() != "")
                    {
                        BEInquilino oBEInquilinoCarga = new BEInquilino();


                        oBEInquilinoCarga.codigo = Convert.ToInt32(registro["id_cliente"]);
                        oBEInquilinoCarga.nombre = registro["nombre"].ToString();
                        oBEInquilinoCarga.apellido = registro["apellido"].ToString();
                        oBEInquilinoCarga.fechaNac = Convert.ToDateTime(registro["fecha_nacimiento"]);
                        oBEInquilinoCarga.activo = (bool)registro["activo"];
                        oBEInquilinoCarga.edad = oBEInquilinoCarga.CalcuEdad();
                        oBEInquilinoCarga.dni = Convert.ToInt32(registro["dni"]);
                        oBEInquilinoCarga.direccion = registro["direccion"].ToString();

                        #region GarantiaCarga
                        BEGarantia oBEGarantiaCarga = new BEGarantia();
                        oBEGarantiaCarga.codigo = Convert.ToInt32(registro["id_garantia"]);
                        oBEGarantiaCarga.nombreGarantia = registro["nombre_garantia"].ToString();

                        oBEInquilinoCarga.garantia = oBEGarantiaCarga;
                        #endregion

                        BELocalidad oBELocalidadCarga = new BELocalidad();
                        oBELocalidadCarga.codigo = Convert.ToInt32(registro["id_localidad"]);
                        oBELocalidadCarga.nombreLoc = registro["localidaDNombre"].ToString();

                        oBEInquilinoCarga.localidad = oBELocalidadCarga;

                        // string consulta2 = @"select propiedad.* from propiedad, alquiler where alquiler.id_propiedad = propiedad.id_propiedad and alquiler.id_inquilino = " + oBEInquilinoCarga.codigo.ToString() +" ";

                        string consulta2 = $"propiedad_asociada_cliente_traer_todo";
                        Hashtable HDato = new Hashtable();
                        HDato.Add("@id_cliente", oBEInquilinoCarga.codigo);
                        DataSet resultadoAlquileres = conec.Lectura(consulta2, HDato);

                        if (resultadoAlquileres.Tables[0].Rows.Count > 0)
                        {
                            List<BEPropiedad> listaPropiedades = new List<BEPropiedad>();


                            foreach (DataRow registroAlquiler in resultadoAlquileres.Tables[0].Rows)
                            {
                                BEPropiedad oBEpropAlq = new BEPropiedad();

                                oBEpropAlq.codigo = Convert.ToInt32(registroAlquiler["id_propiedad"]);
                                oBEpropAlq.direccion = (registroAlquiler["direccion"]).ToString();
                                oBEpropAlq.cantidadAmbiente = Convert.ToInt32(registroAlquiler["cantidad_ambientes"]);
                                oBEpropAlq.disponible = (bool)(registroAlquiler["disponible"]);

                                #region FormatoCarga
                                BEFormato oBETipoCarga = new BEFormato();
                                oBETipoCarga.codigo = Convert.ToInt32(registroAlquiler["id_formato"]);
                                oBETipoCarga.tipoNombre = (registroAlquiler["formato_nombre"]).ToString();

                                oBEpropAlq.formato = oBETipoCarga;
                                #endregion

                                #region LocalidadCarga

                                BELocalidad oBELocalidadCarga2 = new BELocalidad();

                                oBELocalidadCarga2.codigo = Convert.ToInt32(registroAlquiler["id_localidad"]);
                                oBELocalidadCarga2.nombreLoc = (registroAlquiler["nombre_localidad"]).ToString();

                                oBEpropAlq.localidad = oBELocalidadCarga2;
                                #endregion

                                #region PropietarioCarga

                                //BEPropietario oBEPropietarioCarga = new BEPropietario();

                                //oBEPropietarioCarga.apellido = (registroAlquiler["nombre_propietario"]).ToString();
                                //oBEPropietarioCarga.nombre = (registroAlquiler["apellido_propietario"]).ToString();

                                //oBEpropAlq.propietario = oBEPropietarioCarga;

                                #endregion

                                //Aca faltarian todo el resto de propiedades que tiene el objeto propiedad, pero con estas bastanta para saber cuantas y cuales tiene alquiladas el inquilino
                                listaPropiedades.Add(oBEpropAlq);

                            }

                            oBEInquilinoCarga.listadoAlquileresInquilino = listaPropiedades;


                        }

                        ListadoInquilinosResultado.Add(oBEInquilinoCarga);
                    }
                }

            }
           
            

            return ListadoInquilinosResultado;
      
        }


        //Esto hay que mandarlo a la BLL (si o si)
        public override BEOperacion Operar(BEContrato contrato, float importe)
        {
            BEOperacion operacion = new BEOperacion();
            
            contrato.cuenta += importe;

            operacion.fechaOperacion = DateTime.Now;
            operacion.importe = importe;
            operacion.idContrato = contrato.codigo;

            return operacion;
        }
    }
}
