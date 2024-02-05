using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstraccion;
using BE;
using Maper;
using System.Xml.Linq;
namespace BLL
{
    public class BLLOperacionCajaChica : IOperacionesABM<BEOperacionCajaChica>
    {
        MPOperacionCajaChica oMPOperacionCajaChica = new MPOperacionCajaChica();

        public bool Baja(BEOperacionCajaChica Objeto)
        {
           return oMPOperacionCajaChica.Baja(Objeto);
        }

        public bool Guardar(BEOperacionCajaChica Objeto)
        {
            if(Objeto.codigo == 0)
            {
                int ultimo = oMPOperacionCajaChica.ObtenerUltimo();
                Objeto.codigo = ultimo + 1;
            }


           return oMPOperacionCajaChica.Guardar(Objeto);

        }

        public List<BEOperacionCajaChica> TraerListaTodo()
        {
          return oMPOperacionCajaChica.TraerListaTodo();
        }
    }
}
