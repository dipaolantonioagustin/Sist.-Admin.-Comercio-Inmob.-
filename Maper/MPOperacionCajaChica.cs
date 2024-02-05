  using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstraccion;
using BE;
using System.Xml.Linq;
using System.Runtime.InteropServices;
using System.Linq.Expressions;

namespace Maper
{
    public class MPOperacionCajaChica : IOperacionesABM<BEOperacionCajaChica>
    {
        public bool Baja(BEOperacionCajaChica Objeto)
        {
            try
            {
                XDocument documento = XDocument.Load("cajaChica.XML");

                var consulta = from operacion in documento.Descendants("operacion")
                               where Convert.ToInt32(operacion.Attribute("numero").Value) == Objeto.codigo
                               select operacion;

                consulta.Remove();
                documento.Save("cajaChica.XML");
                return true;

            }catch(Exception ex)
            {
                
                return false;
            }
        }

        public bool Guardar(BEOperacionCajaChica operacionCajaChica)
        {
            XDocument documento = XDocument.Load("cajaChica.XML");

            var verificacion = from op in XElement.Load("cajaChica.XML").Elements("operacion") where op.Attribute("numero").Value == (operacionCajaChica.codigo).ToString() select op;
            int existe = verificacion.Count();
            
           
                try
                {

                if (existe == 0)
                {

                    documento.Element("cajaChica").Add(new XElement("operacion",
                                                new XAttribute("numero", Convert.ToString(operacionCajaChica.codigo)),
                                                new XElement("cuentaNumero",
                                                (from cuentaBusqueda in XElement.Load("cuentas.xml").Elements("cuenta")
                                                where cuentaBusqueda.Element("descripcion").Value == operacionCajaChica.cuenta
                                                select cuentaBusqueda.Element("numeroCuenta").Value).First().ToString()),
                                                
                                                new XElement("descripcion", Convert.ToString(operacionCajaChica.descripcion)),
                                                new XElement("importe", Convert.ToString(operacionCajaChica.importe)),
                                                new XElement("fecha", Convert.ToString(operacionCajaChica.fechaOperacion))));


                    documento.Save("cajaChica.XML");
                    return true;

                }
                else
                {

                    var operacion = from op in documento.Descendants("operacion")
                                    where op.Attribute("numero").Value == (operacionCajaChica.codigo).ToString()
                                    select op;

                    foreach (XElement ope in operacion)
                    {
                        ope.Element("cuentaNumero").Value = (from cuentaBusqueda in XElement.Load("cuentas.xml").Elements("cuenta")
                                                             where cuentaBusqueda.Element("descripcion").Value == operacionCajaChica.cuenta
                                                             select cuentaBusqueda.Element("numeroCuenta").Value).First().ToString();

                        ope.Element("descripcion").Value = operacionCajaChica.descripcion;
                        ope.Element("importe").Value = operacionCajaChica.importe.ToString();
                      //  ope.Element("fecha").Value = operacionCajaChica.fechaOperacion.ToString();

                    }

                    documento.Save("cajaChica.XML");
                    return true;

                }
                
                
            
            
                }
                catch( Exception ex)
                {
                    
                    return false;
                        

                }

                              



        }




        public List<BEOperacionCajaChica> TraerListaTodo()
        {
            List<BEOperacionCajaChica> resultadoCajaChica;

         

            var consulta = from operacion in XElement.Load("cajaChica.xml").Elements("operacion")
                           select new BEOperacionCajaChica
                           {
                               
                               codigo = Convert.ToInt32(Convert.ToString(operacion.Attribute("numero").Value).Trim()),
                               fechaOperacion = DateTime.Parse(Convert.ToString(operacion.Element("fecha").Value)), //Revisar aca como es que lo termina casteando
                               importe = float.Parse(Convert.ToString(operacion.Element("importe").Value).Trim()),
                               descripcion = Convert.ToString(operacion.Element("descripcion").Value),
                                                             
                               cuenta= (from cuentanombre in XElement.Load("cuentas.xml").Elements("cuenta")
                                        where (cuentanombre.Element("numeroCuenta").Value == operacion.Element("cuentaNumero").Value)
                                        select (cuentanombre.Element("descripcion").Value)).First().ToString()

                           };

            resultadoCajaChica = consulta.ToList();
            return resultadoCajaChica;
        }

    public int ObtenerUltimo()
        {
           

            XDocument documento = XDocument.Load("cajaChica.xml");

             int max = documento.Descendants("operacion").Max(x => (int)x.Attribute("numero"));

            return max;



        }





    }




}
