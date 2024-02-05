using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using Maper;


namespace BLL
{
    public class BLLPropiedad 
    {

        public BLLPropiedad()
        {
            oMPPropiedad = new MPPropiedad();

        }

        MPPropiedad oMPPropiedad;

        public  bool HabilitarDispo(BEPropiedad propiedad)
        {
            propiedad.disponible = true;
            return oMPPropiedad.CambiarDisponibilidad(propiedad);
        }

        public bool DeshabilitarDispo(BEPropiedad propiedad)
        {
            propiedad.disponible = false;
            return oMPPropiedad.CambiarDisponibilidad(propiedad);
        }


        public List<BEPropiedad> TraerListarTodo()
        {
            return oMPPropiedad.TraerListaTodo();
        }

        public bool Guardad(BEPropiedad propiedad, BEPropietario propietario)
        {
            return oMPPropiedad.Guardar1(propiedad, propietario);
        }

        public bool Baja(BEPropiedad propiedad)
        {
            return oMPPropiedad.Baja(propiedad);
        }


        public bool VerificarAsociadoInquilino(BEPropiedad propiedad)
        {
            return oMPPropiedad.VerificarAsociadoInquilino(propiedad);
        }

        public List<BEPropiedad> TraerListaSoloDisponibles()
        {
            return oMPPropiedad.TraerListaSoloDisponibles();
        }
    }
}
