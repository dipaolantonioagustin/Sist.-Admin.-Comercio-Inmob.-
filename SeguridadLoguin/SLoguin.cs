using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;
using System.Security.Cryptography;
using System.Data;
using System.Collections;

namespace SeguridadLoguin
{
    public class SLoguin
    {
        Conexion conec = new Conexion();

        private byte[] conversorByte(string clave)
        {
            byte[] claveByte = System.Text.Encoding.UTF8.GetBytes(clave);
            return claveByte;
        }


        private string hashArmado(string clave)
        {
            conversorByte(clave);

            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {

                var hash = md5.ComputeHash(conversorByte(clave)); 

                return Convert.ToBase64String(hash);
            }
          
        }


        public bool CargarUsuario(BEUsuario usuario)
        {
            string clavehas = hashArmado(usuario.clave);
            Hashtable HDatos = new Hashtable();
            HDatos.Add("@nom_usu", usuario.nombre);
            HDatos.Add("@clave", clavehas);
            string consulta = $"usuario_insertar";

            return conec.Escribir(consulta, HDatos);

        }

        public bool Verificar(BEUsuario usuario)
        {
            string clavehas = hashArmado(usuario.clave);
            Hashtable HDatos = new Hashtable();
            HDatos.Add("@nom_usu", usuario.nombre);
            string consulta = $"usuario_seleccionar";

            BEUsuario oBEUsuarioBD = new BEUsuario();

            DataSet resultado = new DataSet();

            resultado = conec.Lectura(consulta, HDatos);

            if (resultado.Tables[0].Rows.Count > 0)
            {
                foreach(DataRow registro in resultado.Tables[0].Rows)
                {
                    oBEUsuarioBD.nombre = registro["usuario"].ToString();
                    oBEUsuarioBD.clave = registro["clave"].ToString();
                }
            }

            if(oBEUsuarioBD.clave == clavehas)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
