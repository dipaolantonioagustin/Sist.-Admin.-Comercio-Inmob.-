using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstraccion;

namespace BE
{
    public class BEOperacion : BEOperacionBase, IEntidad
    {
        

        public int idContrato { get; set; }
      
        public int codigo { get ; set ; }

        public override string ToString()
        {
            return this.codigo +" "+ this.fechaOperacion +" "+this.importe+" "+this.idContrato;
        }

    }
}
