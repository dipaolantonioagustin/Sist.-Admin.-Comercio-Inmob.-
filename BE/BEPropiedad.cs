using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstraccion;

namespace BE
{
    public class BEPropiedad : IEntidad
    {
        public int codigo { get; set; }

        public string direccion { get; set; }

        public BEFormato formato { get; set; }

        public int cantidadAmbiente { get; set; }

        public BELocalidad localidad { get; set; }

        public bool disponible { get; set; }

      

        public override string ToString()
        {
            return this.direccion +" "+this.localidad+" "+this.formato;
        }

    }
}
