using BE;
using Maper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public abstract class BLLCliente
    {
        public virtual BEOperacion Operar(BEContrato contrato, float importe)
        {
            BEOperacion oBEOperacion = new BEOperacion();

            return oBEOperacion;
        }



    }
}
