using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstraccion;
namespace BE
{
    public class BELocalidad : IEntidad
    {
        public int codigo { get; set; }

        public string nombreLoc { get; set; }

        public override string ToString()
        {
            return nombreLoc;
        }



    }
}
