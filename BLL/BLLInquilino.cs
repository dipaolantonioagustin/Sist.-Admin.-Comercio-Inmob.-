using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maper;

namespace BLL
{
    public class BLLInquilino : BLLCliente
    {
        public BLLInquilino()
        {
             oMPInquilino = new MPInquilino();
        }

        MPInquilino oMPInquilino;

        public List<BEInquilino> TraerListarTodo()
        {
            return oMPInquilino.TraerListaTodo();
        }

        public bool Baja(BEInquilino inquilino)
        {
            return oMPInquilino.Baja(inquilino);
        }

        public bool Guardar(BEInquilino inquilino)
        {
            return oMPInquilino.Guardar(inquilino);
        }

        public override BEOperacion Operar(BEContrato contrato, float importe)
        {
            BEOperacion operacion = new BEOperacion();
            contrato.cuenta += importe;

            operacion.fechaOperacion = DateTime.Now;
            operacion.importe = importe;
            operacion.idContrato = contrato.codigo;

            return operacion;         
        }

        public BEOperacion CalcularMulta(BEContrato contrato, float importe, int dias)
        {
          
            double porcentajeMulta= dias * 0.05;

            BEOperacion operacion = new BEOperacion();

            float importeMulta = float.Parse((importe * porcentajeMulta).ToString());

            contrato.cuenta += importeMulta;

            operacion.fechaOperacion = DateTime.Now;
            operacion.importe = importeMulta;
            operacion.idContrato = contrato.codigo;
           
            return operacion;

        }


        //public  BEOperacion Operar(BEContrato contrato, float importe)
        //{
        //    return oMPInquilino.Operar(contrato, importe);
        //}




    }
}
