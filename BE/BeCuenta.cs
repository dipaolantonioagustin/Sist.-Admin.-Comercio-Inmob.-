using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstraccion;
namespace BE
{
    public class BeCuenta : IEntidad
    {
        public int codigo { get; set ; }

        public string nombre { get; set ; }

        


        public override string ToString()
        {
            return nombre;
        }



    }
}
