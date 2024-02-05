using Abstraccion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEPropiedadReporte : IEntidad
    {

        public int codigo { get; set; }
        public string direccion { get; set; }
        public int cantidadAmbiente { get; set; }
        public bool disponible { get; set; }

        public int codLoc { get; set; }
        public string loc { get; set; }
        
        public int codForma { get; set; }
        public string forma { get; set; }

        public override string ToString()
        {
            return this.direccion + " " + this.loc + " " + this.forma;
        }


    }
}
