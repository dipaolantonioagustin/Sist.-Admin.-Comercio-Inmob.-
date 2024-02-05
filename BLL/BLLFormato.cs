using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using Maper;


namespace BLL
{
    public class BLLFormato
    {

        public BLLFormato()
        {
            oMPTipo = new MPFormato();
        }

        MPFormato oMPTipo;

        public List<BEFormato> TraerListaTodo()
        {
            return oMPTipo.TraerListaTodo();
        }







    }
}
