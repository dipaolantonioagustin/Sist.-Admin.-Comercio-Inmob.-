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
    public class BLLCuenta : IOperacionesABM<BeCuenta>
    {

        MPCuenta oMPCuenta = new MPCuenta();
        public bool Baja(BeCuenta Objeto)
        {
            throw new NotImplementedException();
        }

        public bool Guardar(BeCuenta Objeto)
        {
            return oMPCuenta.Guardar(Objeto);
        }

        public List<BeCuenta> TraerListaTodo()
        {
            return oMPCuenta.TraerListaTodo();
        }
    }
}
