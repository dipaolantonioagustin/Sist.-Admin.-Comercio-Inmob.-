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
    public class BLLGarantia : IOperacionesABM<BEGarantia>
    {
        MPGarantia oMPPGarantia = new MPGarantia();
        public bool Baja(BEGarantia Objeto)
        {
            throw new NotImplementedException();
        }

        public bool Guardar(BEGarantia Objeto)
        {
            throw new NotImplementedException();
        }

        public List<BEGarantia> TraerListaTodo()
        {
            return oMPPGarantia.TraerListaTodo();
        }
    }
}
