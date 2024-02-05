using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using Maper;
namespace BLL
{
    public class BLLLocalidades
    {
        public BLLLocalidades()
        {
             oMPLoc = new MPLocalidad();
        }

        MPLocalidad oMPLoc;

        public List<BELocalidad> TraerListaTodo()
        {
            return oMPLoc.TraerListaTodo();
        }
        
        public bool Guardar(BELocalidad localidad)
        {
            return oMPLoc.Guardar(localidad);
        }
        
    
    
    }
}
