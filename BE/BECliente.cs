using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstraccion;

namespace BE
{
    public  class BECliente : IEntidad

    {
        public int codigo { get; set; }
        public string nombre { set; get; }

        public string apellido { set; get; }

        public DateTime fechaNac { set; get; }

        public bool activo { set; get; }

        public int edad { set; get; }

        public int dni { set; get; }

        public string direccion { set; get; }

        public BELocalidad localidad { set; get; }

        public int CalcuEdad()
        {
            int edad = (DateTime.Now.Year - fechaNac.Year) - 1;

            if (fechaNac.Month >= DateTime.Now.Month && fechaNac.Day >= DateTime.Now.Day){

                edad = edad + 1;
            }
            
            return edad;
        }




        public override string ToString()
        {
            return this.nombre + " " + this.apellido;
        }


     
       



    }
}
