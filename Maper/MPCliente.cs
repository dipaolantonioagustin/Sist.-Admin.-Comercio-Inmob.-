using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Abstraccion;
using BE;
using DAL;

namespace Maper
{
    public abstract class MPClient 
    {
       
        public virtual BEOperacion Operar(BEContrato contrato, float importe)
        {
            contrato.cuenta = importe;

            BEOperacion operacion = new BEOperacion();

            operacion.fechaOperacion = DateTime.Now;
            operacion.importe = importe;
            operacion.idContrato = contrato.codigo;

            return operacion;
        }


     
    }
}
