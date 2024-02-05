using BE;
using Maper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLPropietario : BLLCliente
    {

        public BLLPropietario()
        {
            oMPPropietario = new MPPropietario();
        }

        MPPropietario oMPPropietario;


        public List<BEPropietario> TraerListaTodo()
        {
            return oMPPropietario.TraerListaTodo();
        }

        public bool Guardar(BEPropietario propietario)
        {
            return oMPPropietario.Guardar(propietario);
        }

        public bool Baja(BEPropietario propietario)
        {
            return oMPPropietario.Baja(propietario);
        }

        public override BEOperacion Operar(BEContrato contrato, float importe)
        {

            BEOperacion operacion = new BEOperacion();

            if (contrato.cuenta > 0 && importe <= contrato.cuenta)
            {
                contrato.cuenta -= importe;

                operacion.fechaOperacion = DateTime.Now;
                operacion.importe = -importe;
                operacion.idContrato = contrato.codigo;

                return operacion;

            }
            else
            {
                throw new Exception("El importe que desea abonar supera al saldo de la cuenta");
            }


            
        }

        //public BEOperacion Operar(BEContrato contrato, float importe)
        //{
        //    return oMPPropietario.Operar(contrato, importe);
        //}

        public bool ExistenciaPropietarioDominio(BEPropietario propietario)
        {
            return oMPPropietario.ExistenciaPropietarioDominio(propietario);
        }

        public BEOperacion CalcularHonorariosAdministracion(float importe)
        {
            BEOperacion operacion = new BEOperacion();
            double honorarios = importe * 0.05;

            operacion.fechaOperacion = DateTime.Now;
            operacion.importe = importe;

            return operacion;

        }

    }
}
