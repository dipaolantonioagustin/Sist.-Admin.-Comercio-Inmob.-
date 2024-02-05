using Abstraccion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEOperacionCajaChica : BEOperacionBase, IEntidad
    {
        public int codigo { get ; set ; }

        public string cuenta { get; set ; }

        //public BeCuenta cuenta = new BeCuenta(); //{ get; set; }


        public string descripcion { get; set ; }



        public override string ToString()
        {
            return codigo + cuenta + base.importe;
        }
    }
}
