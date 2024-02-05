using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstraccion;
using BE;
using Maper;

namespace BLL
{
    public class BLLContrato : IOperacionesABM<BEContrato>
    {
        MPContrato oMPContrato = new MPContrato();

        public bool Baja(BEContrato contrato)
        {
           return oMPContrato.Baja(contrato);
        }

        public bool Guardar(BEContrato contrato)
        {
            return oMPContrato.Guardar(contrato);
        }

        public List<BEContrato> TraerListaTodo()
        {
           return oMPContrato.TraerListaTodo();
        }
    }
}
