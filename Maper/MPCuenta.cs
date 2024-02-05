using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstraccion;
using BE;
using System.Xml.Linq;

namespace Maper
{
    public class MPCuenta : IOperacionesABM<BeCuenta>
    {
        public bool Baja(BeCuenta Objeto)
        {
            throw new NotImplementedException();
        }

        public bool Guardar(BeCuenta Objeto)
        {
            try
            {
                XDocument documento = XDocument.Load("cuentas.XML");

                documento.Element("cuentas").Add(new XElement("cuenta",
                                                new XElement("numeroCuenta",Convert.ToString(Objeto.codigo)),
                                                new XElement("descripcion",Objeto.nombre)));


                documento.Save("cuentas.XML");
                return true;




            }catch(Exception ex)
            {
                return false;
            }
        }

        public List<BeCuenta> TraerListaTodo()
        {
            List<BeCuenta> listadCuentas;

            var consulta = from cuentasVarias in XElement.Load("cuentas.xml").Elements("cuenta")
                           select new BeCuenta
                           {
                               codigo = Convert.ToInt32(cuentasVarias.Element("numeroCuenta").Value),
                               nombre = Convert.ToString(cuentasVarias.Element("descripcion").Value)

                           };

            listadCuentas = consulta.ToList();

            return listadCuentas;   



        }
    }
}
