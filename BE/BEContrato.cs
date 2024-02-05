using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstraccion;

namespace BE
{
    public class BEContrato : IEntidad
    {


        public BEContrato(float saldoCuenta)
        {
            cuenta = saldoCuenta;
        }

        public int codigo { get; set ; }

        public BEPropietario propietario { get; set ; }
        public BEPropiedad propiedad { get; set; }

        public BEInquilino inquilino { get; set; }

        public DateTime fechaInicio { get; set; }

        public int valor { get; set; }

        public bool activo { get; set; }

        public float cuenta { get; set; }


        public override string ToString()
        {
            return codigo +" "+propiedad;
        }

    }
}
