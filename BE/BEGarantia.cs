using Abstraccion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEGarantia : IEntidad
    {
        public int codigo { get; set; }
        public string nombreGarantia { set; get; }



        public override string ToString()
        {
            return nombreGarantia;
        }
    }
}
