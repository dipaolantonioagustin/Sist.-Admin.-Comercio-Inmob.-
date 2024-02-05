using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstraccion;
namespace BE
{
    public class BEFormato : IEntidad
    {
        public int codigo { get; set; }

        public string tipoNombre { get; set; }


        public override string ToString()
        {
            return tipoNombre;
        }

    }
}
