using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maper;

namespace BLL
{
    public class BLLCaja
    {
        MPCaja oMPCaja  = new MPCaja();



        public bool Baja(BEOperacion operacion)
        {
            return oMPCaja.Baja(operacion);
        }

        public virtual bool EscribirCaja(BEOperacion operacion, BEContrato contrato)
        {
            return oMPCaja.EscribirCaja(operacion,contrato);
        }
        public List<BEOperacion> TraerListaTodo()
        {
            return oMPCaja.TraerListaTodo();
        }

        public bool Anular(BEOperacion operacion)
        {
            return oMPCaja.Anular(operacion);
        }

        public float Balance(BEResumen resumen)
        {
            float movTotales = resumen.ResumenMovimiento.Sum(x => x.importe);
            float resultado = (resumen.saldoInicio + movTotales) - resumen.arqueo;
           
            return resultado;
        }

        public bool EscribiCajaHonorarios(BEOperacion operacion)
        {

            return oMPCaja.EscribirCajaHonorarios(operacion);
        }






    }
}
