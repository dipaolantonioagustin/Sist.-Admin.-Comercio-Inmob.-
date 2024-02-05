using Abstraccion;
using BE;
using Maper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLPropiedadReporte : IOperacionesABM<BEPropiedadReporte>
    {
        MPPropiedadReporte oMPPropiedadReporte = new MPPropiedadReporte();

        public bool Baja(BEPropiedadReporte Objeto)
        {
            throw new NotImplementedException();
        }

        public bool Guardar(BEPropiedadReporte Objeto)
        {
            throw new NotImplementedException();
        }

        public List<BEPropiedadReporte> TraerListaTodo()
        {
            return oMPPropiedadReporte.TraerListaTodo();
        }
    }
}
