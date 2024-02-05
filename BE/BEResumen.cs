using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEResumen
    {
        public List<BEOperacion> ResumenMovimiento = new List<BEOperacion>();

        public float saldoInicio { get; set; }

        public float arqueo { get; set; }


    }
}
