using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstraccion;

namespace BE
{
    public class BEInquilino : BECliente
    {
        public List<BEPropiedad> listadoAlquileresInquilino = new List<BEPropiedad>();

        public BEGarantia garantia { get; set; }


        
    }
}
