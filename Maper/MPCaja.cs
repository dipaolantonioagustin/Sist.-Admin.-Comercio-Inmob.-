using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstraccion;
using DAL;
using BE;
using System.Data;
using System.Reflection;
using System.ComponentModel.Design;
using System.Collections;

namespace Maper
{
    public class MPCaja : IOperacionesABM<BEOperacion>
    {
        Conexion conec = new Conexion();
       
        public bool Baja(BEOperacion operacion)
        {
            Hashtable HDatos = new Hashtable();
            HDatos.Add("@id_op", operacion.codigo);

            string consulta = $"caja_borrar_operacion";

            return conec.Escribir(consulta, HDatos);

        }

        public bool Anular(BEOperacion operacion)
        {
            Hashtable HDatos = new Hashtable();
            HDatos.Add("@id_contrato", operacion.idContrato);
            HDatos.Add("@importe", operacion.importe);
            HDatos.Add("@fn", operacion.fechaOperacion);


            string consulta = $"caja_anular_operacion";

            return conec.Escribir(consulta, HDatos);

        }

        public bool Guardar(BEOperacion operacion)
        {
            throw new NotImplementedException();
        }



        //Esto seria solo para ser usado en los honorarios por administracion

        public bool EscribirCajaHonorarios(BEOperacion operacion)
        {

            Conexion conec = new Conexion();

            Hashtable HDatos = new Hashtable();
            HDatos.Add("@id_contrato", operacion.idContrato);
            HDatos.Add("@importe", operacion.importe);
            HDatos.Add("@fn", operacion.fechaOperacion);

            string consulta1 = $"caja_insertar_operacion";

            return conec.Escribir(consulta1, HDatos);

        }



        public bool EscribirCaja(BEOperacion operacion, BEContrato contrato)
        {
            Conexion conec = new Conexion();

            Hashtable HDatos = new Hashtable();
            HDatos.Add("@id_contrato", operacion.idContrato);
            HDatos.Add("@importe", operacion.importe);
            HDatos.Add("@fn", operacion.fechaOperacion);

            Hashtable HDatos2 = new Hashtable();
            HDatos2.Add("@id_contrato", operacion.idContrato);
            HDatos2.Add("@cuenta", contrato.cuenta);
            


            string consulta1 = $"caja_insertar_operacion";
            string consulta2 = $"contrato_cuenta";

            return conec.Transaccion(consulta1, HDatos, consulta2, HDatos2);


        }


        public List<BEOperacion> TraerListaTodo()
        {
            List<BEOperacion> listadoCaja = new List<BEOperacion>();

            string consulta = "caja_traer_todo";
            DataSet resultado = new DataSet();

            resultado = conec.Lectura(consulta, null);


            if (resultado.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow registro in resultado.Tables[0].Rows)
                {
                    BEOperacion movimiento = new BEOperacion();

                    movimiento.idContrato = Convert.ToInt32(registro["id_contrato"]);
                    movimiento.fechaOperacion = (DateTime)(registro["fecha_movimiento"]);
                    movimiento.importe =float.Parse(registro["importe"].ToString());
                    movimiento.codigo = Convert.ToInt32(registro["id_movimiento"]);
                    
                    listadoCaja.Add(movimiento);
                }
            }

           return listadoCaja;

        }


        


    }
}
