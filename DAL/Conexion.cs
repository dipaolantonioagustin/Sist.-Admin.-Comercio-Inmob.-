using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Collections;


namespace DAL
{
    public class Conexion
    {
        string BD = @"Data Source = DESKTOP-9JLD1SA\SQLEXPRESS; Initial Catalog = Tp1LUG; Integrated Security = True";
        private SqlConnection conec = new SqlConnection(@"Data Source = DESKTOP-9JLD1SA\SQLEXPRESS; Initial Catalog = Tp1LUG; Integrated Security = True");
        private SqlCommand comand;
        private SqlTransaction trans;

        public DataSet Lectura(string consulta, Hashtable parametros)
        {
            DataSet resultado = new DataSet();
            SqlDataAdapter DA;

            comand = new SqlCommand(consulta, conec);
            comand.CommandType = CommandType.StoredProcedure;
            try
            {
                DA = new SqlDataAdapter(comand);

                if (parametros != null)
                {
                    foreach (string dato in parametros.Keys)
                    {
                        comand.Parameters.AddWithValue(dato, parametros[dato]);
                    }

                }

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            DA.Fill(resultado);

            return resultado;


        }



        public bool Escribir(string consulta, Hashtable parametros)
        {

            if (conec.State == ConnectionState.Closed)
            {
                conec.Open();

            }

            try
            {

                comand = new SqlCommand(consulta, conec);
                comand.CommandType = CommandType.StoredProcedure;

                if (parametros.Count > 0)
                {
                    foreach (string dato in parametros.Keys)
                    {
                        comand.Parameters.AddWithValue(dato, parametros[dato]);
                    }
                }

                int cantidadRegistrosAfectado = comand.ExecuteNonQuery();

                return true;


            }
            catch (SqlException ex)
            {
                throw ex;
                return false;

            }
            catch (Exception ex)
            {
                throw ex;
                return false;
            }
            finally
            {
                conec.Close();
            }


        }



        public bool Transaccion(string consulta1, Hashtable parametros1, string consulta2, Hashtable parametros2)
        {
            SqlCommand comand1;
            SqlCommand comand2;


            if (conec.State == ConnectionState.Closed)
            {
                conec.Open();
            }
            try
            {
                trans = conec.BeginTransaction();
                comand1 = new SqlCommand(consulta1, conec);
                comand1.Transaction = trans;
                comand1.CommandType = CommandType.StoredProcedure;

                               

                    if (parametros1 != null)
                    {
                        foreach (string dato in parametros1.Keys)
                        {
                            comand1.Parameters.AddWithValue(dato, parametros1[dato]);
                        }

                    }

             
                var resultado1 = comand1.ExecuteNonQuery();

                comand2 = new SqlCommand(consulta2, conec);  

                comand2.Transaction = trans;
                comand2.CommandType = CommandType.StoredProcedure;

              

                if (parametros2 != null)
                {
                    foreach (string dato in parametros2.Keys)
                    {
                        comand2.Parameters.AddWithValue(dato, parametros2[dato]);
                    }

                }


                var resultado2 = comand2.ExecuteNonQuery();

                trans.Commit();
                return true;

            }
            catch (SqlException ex)
            {
                trans.Rollback();
                return false;
            }
            catch (Exception ex)
            {

                trans.Rollback();
                return false;
            }
            finally
            {
                conec.Close();
            }


        }



        public bool LecturaEscalar(string consulta, Hashtable parametros)
        {

            if (conec.State == ConnectionState.Closed)
            {
                conec.Open();

            }

            try
            {

                comand = new SqlCommand(consulta, conec);
                comand.CommandType = CommandType.StoredProcedure;

                if (parametros.Count > 0)
                {
                    foreach (string dato in parametros.Keys)
                    {
                        comand.Parameters.AddWithValue(dato, parametros[dato]);
                    }
                }

                var resultado = comand.ExecuteScalar();
                if (resultado != null) { return true; } else { return false; }



            }
            catch (SqlException ex)
            {
                throw ex;
                return false;

            }
            catch (Exception ex)
            {
                throw ex;
                return false;
            }
            finally
            {
                conec.Close();
            }

        }




















































    //    private SqlConnection conec = new SqlConnection(@"Data Source = DESKTOP-9JLD1SA\SQLEXPRESS; Initial Catalog = Tp1LUG; Integrated Security = True");



    //    public string TesteoConnection()
    //    {
    //        try
    //        {
    //            conec.Open();

    //            if (conec.State == ConnectionState.Open)
    //            {
    //                return "Conectado";
    //            }
    //            else
    //            {
    //                return "No Conectado";
    //            }
    //        }
    //        catch (SqlException ex)
    //        {
    //            throw ex;
    //        }
    //        finally
    //        {
    //            conec.Close();
    //        }


    //    }



    //    public DataSet Lectura(string consulta)
    //    {
    //        DataSet resultado = new DataSet();
    //        try
    //        {
    //            SqlDataAdapter busqueda = new SqlDataAdapter(consulta, conec);

    //            busqueda.Fill(resultado);


    //        }
    //        catch (SqlException ex)
    //        {
    //            throw ex;
    //        }
    //        catch (Exception ex)
    //        {
    //            throw ex;
    //        }
    //        finally
    //        {
    //            this.conec.Close();
    //        }


    //        return resultado;
    //    }

    //    public bool LecturaEscalar(string consulta)
    //    {
    //        conec.Open();

    //        SqlCommand busqueda = new SqlCommand(consulta, conec);
    //        busqueda.CommandType = CommandType.Text;
    //        try
    //        {
    //            int resultado = Convert.ToInt32(busqueda.ExecuteScalar());

    //            if (resultado != 0) return true;
    //            else return false;
    //        }
    //        catch (SqlException ex)
    //        {
    //            throw ex;
    //        }
    //        catch (Exception ex)
    //        {
    //            throw ex;
    //        }
    //        finally
    //        {
    //            conec.Close();
    //        }

    //    }

    //    public bool Escribir(string consulta)
    //    {
    //        conec.Open();
    //        try
    //        {
    //            SqlCommand comando = new SqlCommand();
    //            comando.CommandType = CommandType.Text;
    //            comando.CommandText = consulta;
    //            comando.Connection = conec;

    //            int resultado = comando.ExecuteNonQuery();
    //            if (resultado > 0) return true;
    //            else return false;
    //        }
    //        catch (SqlException ex)
    //        {
    //            throw ex;
    //        }
    //        catch (Exception ex)
    //        {
    //            throw ex;
    //        }
    //        finally
    //        {
    //            conec.Close();
    //        }




    //    }


    //    public bool Transaccion(string consulta1, string consulta2)
    //    {

           
    //        conec.Open();

    //        SqlTransaction transaccion;

    //        SqlCommand comando;

    //        transaccion = conec.BeginTransaction();

    //        try
    //        {
    //            comando = new SqlCommand(consulta1, conec);

    //            comando.Transaction = transaccion;

    //            comando.ExecuteNonQuery();


    //            comando = new SqlCommand(consulta2,conec);

    //            comando.Transaction = transaccion;

    //            comando.ExecuteNonQuery();



    //            transaccion.Commit();

    //            return true;

    //        }catch(SqlException ex)
    //        {
    //            transaccion.Rollback();
    //            return false;

    //        }
    //        catch (Exception ex)
    //        {
    //            transaccion.Rollback();
    //            return false;

    //        }
    //        finally
    //        {
    //            conec.Close();
    //        }

    //    }
    }
}